CREATE PROC pr_ThemChamCong
@IDNhanVien BIGINT,
@Thang INT,
@Nam INT,
@SoNgay FLOAT
AS
BEGIN
	DECLARE @TruHuongLuong FLOAT = 0
	DECLARE @TruAnTrua FLOAT = 0
	DECLARE @TruPhepNam FLOAT =0
	DECLARE @IDChamCong BIGINT = 0
	SELECT @IDChamCong=[IDChamCong] FROM ccChamCong WHERE Thang=@Thang and Nam=@Nam
	IF (@IDChamCong>0)
		BEGIN			
			SELECT @TruHuongLuong=SUM(HuongLuong),@TruAnTrua=SUM(AnTrua),@TruPhepNam=SUM(PhepNam) FROM ccChiTiet WHERE ChamCongID=@IDChamCong
			UPDATE ccChamCong SET HuongLuong=(@SoNgay-@TruHuongLuong),AnTrua=(@SoNgay-@TruAnTrua),PhepNam=@TruPhepNam WHERE IDChamCong=@IDChamCong
		END
	ELSE
		BEGIN
			INSERT INTO [ccChamCong]
           ([NguoiChamID]
           ,[NhanVienID]
           ,[Thang]
           ,[Nam]
           ,[SoNgay]
           ,[AnTrua]
           ,[HuongLuong]
           ,[PhepNam])
     VALUES
           (1
           ,@IDNhanVien
           ,@Thang
           ,@Nam
           ,@SoNgay
           ,0
           ,0
           ,0)
		END
END
GO

CREATE PROC pr_ThemChiTiet
@IDKyHieu BIGINT,
@IDChamCong BIGINT,
@Ngay INT
AS
BEGIN
	DECLARE @KiemTraIDhiTiet BIGINT = 0
	DECLARE @TruHuongLuong FLOAT = 0
	DECLARE @TruAnTrua FLOAT = 0
	DECLARE @TruPhepNam FLOAT = 0
	SELECT @KiemTraIDhiTiet=IDChiTiet FROM ccChiTiet WHERE @IDKyHieu=@IDKyHieu and ChamCongID=@IDChamCong	
	SELECT @TruHuongLuong=HuongLuong,@TruAnTrua=AnTrua,@TruPhepNam=PhepNam FROM ccKyHieu WHERE IDKyHieu=@IDKyHieu

		IF (@KiemTraIDhiTiet>0)
		BEGIN			
			UPDATE ccChiTiet SET KyHieuID=@IDKyHieu,HuongLuong=@TruHuongLuong,AnTrua=@TruAnTrua,PhepNam=@TruPhepNam WHERE IDChiTiet=@KiemTraIDhiTiet
		END
		ELSE
		BEGIN
			INSERT INTO [dbo].[ccChiTiet]
           ([KyHieuID]
           ,[ChamCongID]
           ,[Ngay]
           ,[HuongLuong]
           ,[AnTrua]
           ,[PhepNam])
     VALUES
           (@IDKyHieu
           ,@IDChamCong
           ,@Ngay
           ,@TruHuongLuong
           ,@TruAnTrua
           ,@TruPhepNam
           )
		END
END
GO
