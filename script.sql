USE [master]
GO
USE [AnGiang]
GO

/****** Object:  StoredProcedure [dbo].[pr_bangLuongTongHop]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec [pr_bangLuongTongHop] 1,2,5,2018
--GO

CREATE PROC [dbo].[pr_bangLuongTongHop]
@IDDonVi INT, @IDNhanVien INT, @Thang INT, @Nam INT
AS
BEGIN
	DECLARE @DonGiaMD FLOAT =0 ,@LuongCobanMD FLOAT = 0,@LuongVungMD FLOAT = 0, @TienCuoiNamMD FLOAT = 0
	SELECT @luongCobanMD=LuongCoBan,@LuongVungMD=LuongVung,@TienCuoiNamMD=TienCuoiNam FROM lgLuong
	SELECT @DonGiaMD = DonGia FROM dvDonVi WHERE IDDonVi=@IDDonVi

	DECLARE @HeSoLuong FLOAt = 0 ,@HeSoChucDanh FLOAT = 0,@TGPCKK INT = 0, @DieuKienPCKK INT = 0,@IDPhong INT = 0,@LuongCoBan FLOAT = 0

	SELECT @HeSoChucDanh=HeSoChucDanh, @IDPhong=PhongBanID, @HeSoLuong=HeSoLuong,@TGPCKK=TGPCKK,@DieuKienPCKK=dieukienPCKK FROM nvNhanVien WHERE IDNhanVien = @IDNhanVien
	IF EXISTS (SELECT * FROM dvPhongBan WHERE IDPhongBan=@IDPhong and GhiChu=N'1')
		SET @LuongCoBan = @HeSoLuong*@LuongCobanMD
	ELSE
		SET @LuongCoBan = @HeSoLuong*@LuongVungMD

	DECLARE @NgayCong INT = 0 ,@NgayLamCuoiTuan INT = 0 ,@SoNgayNghiMaLam FLOAT = 0,@IDChamCong INT = 0

	SELECT @NgayCong=(HuongLuong),@IDChamCong=IDChamCong,@SoNgayNghiMaLam=NgayPhep FROM ccChamCong WHERE Thang=@Thang and Nam=@Nam and NhanVienID=@IDNhanVien
	
	DECLARE @TienLuongPhep FLOAT = 0,@PCKK INT = 0,@TienLuong FLOAT = 0,@TienPCKK FLOAT = 0,@TienLuong100 FLOAT = 0
			,@TienLuong80 FLOAT = 0,@BHXH8 FLOAT = 0,@BHYT1_5 FLOAT = 0,@BHTN1 FLOAT = 0,@CDPhi1LTN FLOAT = 0,@DangPhi1 FLOAT = 0,@ThucLanh FLOAT = 0
	
	IF(@LuongCoBan>0)
	SET @TienLuongPhep = (@LuongCoBan/24)*@SoNgayNghiMaLam

	IF(@TGPCKK>@DieuKienPCKK)
	SET @PCKK = @TGPCKK-@DieuKienPCKK

	SET @TienLuong = (@HeSoChucDanh*@NgayCong)*@DonGiaMD
	SET @TienPCKK = ((@HeSoChucDanh*@PCKK/100)*@NgayCong)*@DonGiaMD

	SET @TienLuong100=@TienLuong+@TienPCKK + @TienLuongPhep
	SET @TienLuong80 = @TienLuong100-(@TienLuong100 - (@TienLuong100*0.8))

	SET @BHXH8 = @TienLuong80-(@TienLuong80 - (@TienLuong80*0.08))
	SET @BHYT1_5 = @TienLuong80-(@TienLuong80 - (@TienLuong80*0.015))
	SET @BHTN1 = @TienLuong80-(@TienLuong80 - (@TienLuong80*0.01))
	SET @CDPhi1LTN = @TienLuong80-(@TienLuong80 - (@TienLuong80*0.01))
	SET @ThucLanh = @TienLuong80-(@BHXH8+@BHYT1_5+@BHTN1+@CDPhi1LTN)

	DECLARE @TenNV NVARCHAR(50),@TenPhongBan NVARCHAR(50),@TenChucDanh NVARCHAR(50)
	SELECT @TenPhongBan = dvPhongBan.TenPhongBan, @TenNV= nvNhanVien.HoTen, @TenChucDanh=nvChucDanh.TenChucDanh
	FROM    nvNhanVien INNER JOIN
            dvPhongBan ON nvNhanVien.PhongBanID = dvPhongBan.IDPhongBan INNER JOIN
            nvChucDanh ON nvNhanVien.ChucDanhID = nvChucDanh.IDChucDanh where IDNhanVien=@IDNhanVien

	IF EXISTS (SELECT * FROM [lgBangLuong] WHERE IDChamCong=@IDChamCong)
		DELETE FROM [lgBangLuong] WHERE IDChamCong=@IDChamCong

	INSERT INTO [lgBangLuong]
			([TGPCKK]
           ,[HESOLUONG]
           ,[NGAYNGHI]
           ,[TIENLUONGPHEP]
           ,[HESOCHUCDANH]
           ,[PCKK]
           ,[NGAYCONG]
           ,[TIENLUONG]
           ,[TIENPCKK]
           ,[TIENLUONG100]
           ,[TIENLUONG80]
           ,[BHXH]
           ,[BHYT]
           ,[BHTN]
           ,[CDPHI]
           ,[DANGPHI]
           ,[THUCLANH]
           ,[LUONGCOBAN]
		   ,[IDChamCong]
		   ,[Hoten]
		   ,[TenChucDanh]
		   ,[TenPhongBan]
		   ,[Thang]
		   ,[Nam]) SELECT @TGPCKK AS TGPCKK,@HeSoLuong AS HESOLUONG,@SoNgayNghiMaLam AS NGAYNGHI,@TienLuongPhep AS TIENLUONGPHEP,@HeSoChucDanh AS HESOCHUCDANH,@PCKK AS PCKK,@NgayCong AS NGAYCONG
			,@TienLuong AS TIENLUONG,@TienPCKK AS TIENPCKK,@TienLuong100 AS TIENLUONG100,@TienLuong80 AS TIENLUONG80,@BHXH8 AS BHXH,@BHYT1_5 AS BHYT,@BHTN1 AS BHTN,@CDPhi1LTN AS CDPHI
			,@DangPhi1 AS DANGPHI,@ThucLanh AS THUCLANH	,@LuongCoBan AS LUONGCOBAN ,@IDChamCong AS IDChamConginto,@TenNV AS Hoten, @TenChucDanh AS TenChucDanh, @TenPhongBan AS TenPhongBan, @Thang AS THANG ,@Nam AS Nam
		--exec sp_sqlexec @SQL
END

GO
/****** Object:  StoredProcedure [dbo].[pr_LayChiTietChamCong]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[pr_LayChiTietChamCong]
@Ngay INT,
@IDChamCong BIGINT
as
BEGIN
DECLARE @MaKyHieu NVARCHAR(50) = 0
 SELECT  @MaKyHieu= kh.MaKyHieu FROM ccChiTiet ct,ccKyHieu kh WHERE ct.KyHieuID=kh.IDKyHieu and ChamCongID=@IDChamCong and [Ngay]=@Ngay
 SELECT @MaKyHieu
END


GO
/****** Object:  StoredProcedure [dbo].[pr_LoadChamCong]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pr_LoadChamCong]
@IDChamCong BIGINT
as
BEGIN
DECLARE @cols AS NVARCHAR(MAX),
    @query  AS NVARCHAR(MAX)

select @cols = STUFF((SELECT ',' + QUOTENAME(Ngay) 
                    from ccChiTiet INNER JOIN
                         ccChamCong ON ccChiTiet.ChamCongID = ccChamCong.IDChamCong INNER JOIN
                         nvNhanVien ON ccChamCong.NhanVienID = nvNhanVien.IDNhanVien INNER JOIN
						 dvPhongBan ON dvPhongBan.IDPhongBan = nvNhanVien.PhongBanID INNER JOIN
                         ccKyHieu ON ccChiTiet.KyHieuID = ccKyHieu.IDKyHieu
					WHERE IDChamCong=@IDChamCong
                    group by Ngay, IDChiTiet
                    order by IDChiTiet
            FOR XML PATH(''), TYPE
            ).value('.', 'NVARCHAR(MAX)') 
        ,1,1,'')
	IF(EXISTS (SELECT * FROM ccXemChamCong WHERE IDChamCong=@IDChamCong))
		DELETE FROM ccXemChamCong WHERE IDChamCong=@IDChamCong
set @query = N'INSERT ccXemChamCong(IDChamCong,IDNhanVien,TenPhongBan, HoTen, MaNhanVien,' + @cols + N' , AnTrua, HuongLuong, PhepNam, NgayPhep, Thang ,Nam) SELECT IDChamCong,IDNhanVien,TenPhongBan, HoTen, MaNhanVien,' + @cols + N' , AnTrua, HuongLuong, PhepNam, NgayPhep,Thang, Nam from
             (
                select [MaKyHieu], [Ngay] ,dvPhongBan.TenPhongBan,ccChamCong.IDChamCong,nvNhanVien.IDNhanVien, nvNhanVien.HoTen, nvNhanVien.MaNhanVien, ccChamCong.AnTrua, ccChamCong.HuongLuong, ccChamCong.PhepNam, ccChamCong.NgayPhep,ccChamCong.Thang,ccChamCong.Nam
                 from ccChiTiet INNER JOIN
                         ccChamCong ON ccChiTiet.ChamCongID = ccChamCong.IDChamCong INNER JOIN
                         nvNhanVien ON ccChamCong.NhanVienID = nvNhanVien.IDNhanVien INNER JOIN
						 dvPhongBan ON dvPhongBan.IDPhongBan = nvNhanVien.PhongBanID INNER JOIN
                         ccKyHieu ON ccChiTiet.KyHieuID = ccKyHieu.IDKyHieu				  
				WHERE IDChamCong='+CONVERT(varchar(10), @IDChamCong)+'
            ) x
            pivot 
            (
                max([MaKyHieu])
                for [Ngay] in (' + @cols + N')
            ) p '
exec sp_executesql @query 
END


GO
/****** Object:  StoredProcedure [dbo].[pr_ThemChamCong]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[pr_ThemChamCong]
@IDNhanVien BIGINT,
@Thang INT,
@Nam INT,
@SoNgay INT,
@SoNgayNghi FLOAT,
@HuongLuong FLOAT
AS
BEGIN
			INSERT INTO [ccChamCong]
           ([NguoiChamID]
           ,[NhanVienID]
           ,[Thang]
           ,[Nam]
           ,[SoNgay]
           ,[AnTrua]
           ,[HuongLuong]
           ,[PhepNam]
		   ,[SoNgayNghi])
     VALUES
           (1
           ,@IDNhanVien
           ,@Thang
           ,@Nam
           ,@SoNgay
           ,0
           ,@HuongLuong
           ,0
		   ,@SoNgayNghi)
END


GO
/****** Object:  StoredProcedure [dbo].[pr_ThemChiTiet]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[pr_ThemChiTiet]
@IDKyHieu BIGINT,
@IDChamCong BIGINT,
@Ngay INT,
@NgayNghi INT
AS
BEGIN
	DECLARE @KiemTraIDhiTiet BIGINT = 0
	DECLARE @HuongLuong FLOAT = 0
	DECLARE @AnTrua FLOAT = 0
	DECLARE @PhepNam FLOAT = 0
	DECLARE @SoNgayNghi INT =0
	DECLARE @NgayNghiMaLam FLOAT = 0
	SELECT @KiemTraIDhiTiet=IDChiTiet FROM ccChiTiet WHERE ChamCongID=@IDChamCong and Ngay = @Ngay
	SELECT @HuongLuong=HuongLuong,@AnTrua=AnTrua,@PhepNam=PhepNam FROM ccKyHieu WHERE IDKyHieu=@IDKyHieu
	IF(@NgayNghi=3)
		IF(@HuongLuong>0.5 or @HuongLuong<-0.5)
		BEGIN
		SET @HuongLuong = @HuongLuong/2
		SET @NgayNghiMaLam = @HuongLuong
		END
		IF((@PhepNam>0.5))
		BEGIN
			SET @PhepNam=@PhepNam/2
		END
	IF(@NgayNghi=2 and (@HuongLuong>0))
		SET @NgayNghiMaLam = @HuongLuong
		IF (@KiemTraIDhiTiet>0)
		BEGIN
			IF(@IDKyHieu=-1)
			BEGIN
				DELETE ccChiTiet WHERE IDChiTiet=@KiemTraIDhiTiet
			END
			ELSE
			BEGIN			
				UPDATE ccChiTiet SET KyHieuID=@IDKyHieu,HuongLuong=@HuongLuong,AnTrua=@AnTrua,PhepNam=@PhepNam,NgayPhep=@NgayNghiMaLam WHERE IDChiTiet=@KiemTraIDhiTiet
			END
		END
		ELSE
		IF(@IDKyHieu<>-1)
			BEGIN
			INSERT INTO [dbo].[ccChiTiet]
				   ([KyHieuID]
				   ,[ChamCongID]
				   ,[Ngay]
				   ,[HuongLuong]
				   ,[AnTrua]
				   ,[PhepNam]
				   ,[NgayNghi])
			 VALUES
				   (@IDKyHieu
				   ,@IDChamCong
				   ,@Ngay
				   ,@HuongLuong
				   ,@AnTrua
				   ,@PhepNam
				   ,@NgayNghi)
			END

		DECLARE @SUMHuongLuong FLOAT = 0
		DECLARE @SUMAnTrua FLOAT = 0
		DECLARE @SUMPhepNam FLOAT = 0
		DECLARE @SUMNgayNghiMaLam FLOAT = 0
		SELECT @SUMHuongLuong=SUM(HuongLuong),@SUMAnTrua=SUM(AnTrua),@SUMNgayNghiMaLam=SUM(NgayPhep)
		FROM ccChiTiet 
		WHERE ChamCongID=@IDChamCong and HuongLuong>-0.5 and AnTrua>-0.5
		SELECT @SUMPhepNam=SUM(PhepNam)
		FROM ccChiTiet 
		WHERE ChamCongID=@IDChamCong and PhepNam>-0.5
		--2: Ngày Nghĩ 3: thứ bảy
		IF EXISTS (SELECT * FROM ccChiTiet where NgayNghi=2 and HuongLuong>0 and ChamCongID=@IDChamCong)
		SET @SUMHuongLuong = @SUMHuongLuong - (SELECT SUM(HuongLuong) FROM ccChiTiet where NgayNghi=2 and ChamCongID=@IDChamCong and HuongLuong>0)
		UPDATE ccChamCong SET HuongLuong=@SUMHuongLuong,AnTrua=@SUMAnTrua,PhepNam=@SUMPhepNam,NgayPhep=@SUMNgayNghiMaLam WHERE IDChamCong=@IDChamCong
END


GO
/****** Object:  Table [dbo].[ccChamCong]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccChamCong](
	[IDChamCong] [bigint] IDENTITY(1,1) NOT NULL,
	[NguoiChamID] [bigint] NULL,
	[NhanVienID] [bigint] NULL,
	[Thang] [int] NULL,
	[Nam] [int] NULL,
	[SoNgay] [int] NULL,
	[SoNgayNghi] [float] NULL,
	[AnTrua] [float] NULL,
	[HuongLuong] [float] NULL,
	[PhepNam] [float] NULL,
	[BHXH_DuongSuc] [float] NULL,
	[BHXH_KhamThai] [float] NULL,
	[BHXH_ChamConBenh] [float] NULL,
	[BHXH_NghiBenh] [float] NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[TrangThai] [int] NULL,
	[DaXoa] [int] NOT NULL,
	[NgayPhep] [float] NULL,
 CONSTRAINT [PK_ccChamCong_1] PRIMARY KEY CLUSTERED 
(
	[IDChamCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ccChiTiet]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccChiTiet](
	[IDChiTiet] [bigint] IDENTITY(1,1) NOT NULL,
	[KyHieuID] [bigint] NULL,
	[ChamCongID] [bigint] NULL,
	[Ngay] [int] NULL,
	[HuongLuong] [float] NULL,
	[AnTrua] [float] NULL,
	[PhepNam] [float] NULL,
	[NgayNghi] [int] NULL,
	[GhiChu] [nvarchar](250) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
	[NgayPhep] [float] NULL,
 CONSTRAINT [PK_ccChamCong] PRIMARY KEY CLUSTERED 
(
	[IDChiTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ccKyHieu]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccKyHieu](
	[IDKyHieu] [bigint] IDENTITY(1,1) NOT NULL,
	[MaKyHieu] [nvarchar](50) NULL,
	[TenKyHieu] [nvarchar](250) NULL,
	[HuongLuong] [float] NULL,
	[AnTrua] [float] NULL,
	[PhepNam] [float] NULL,
	[DienGiai] [nvarchar](250) NULL,
	[GhiChu] [nvarchar](250) NULL,
	[MacDinh] [int] NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
 CONSTRAINT [PK_ccKyHieu] PRIMARY KEY CLUSTERED 
(
	[IDKyHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ccXemChamCong]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ccXemChamCong](
	[IDChamCong] [bigint] NOT NULL,
	[IDNhanVien] [bigint] NULL,
	[TenPhongBan] [nvarchar](50) NULL,
	[HoTen] [nvarchar](50) NULL,
	[MaNhanVien] [nvarchar](50) NULL,
	[1] [nvarchar](50) NULL,
	[2] [nvarchar](50) NULL,
	[3] [nvarchar](50) NULL,
	[4] [nvarchar](50) NULL,
	[5] [nvarchar](50) NULL,
	[6] [nvarchar](50) NULL,
	[7] [nvarchar](50) NULL,
	[8] [nvarchar](50) NULL,
	[9] [nvarchar](50) NULL,
	[10] [nvarchar](50) NULL,
	[11] [nvarchar](50) NULL,
	[12] [nvarchar](50) NULL,
	[13] [nvarchar](50) NULL,
	[14] [nvarchar](50) NULL,
	[15] [nvarchar](50) NULL,
	[16] [nvarchar](50) NULL,
	[17] [nvarchar](50) NULL,
	[18] [nvarchar](50) NULL,
	[19] [nvarchar](50) NULL,
	[20] [nvarchar](50) NULL,
	[21] [nvarchar](50) NULL,
	[22] [nvarchar](50) NULL,
	[23] [nvarchar](50) NULL,
	[24] [nvarchar](50) NULL,
	[25] [nvarchar](50) NULL,
	[26] [nvarchar](50) NULL,
	[27] [nvarchar](50) NULL,
	[28] [nvarchar](50) NULL,
	[29] [nvarchar](50) NULL,
	[30] [nvarchar](50) NULL,
	[31] [nvarchar](50) NULL,
	[AnTrua] [float] NULL,
	[HuongLuong] [float] NULL,
	[PhepNam] [float] NULL,
	[NgayPhep] [float] NULL,
	[Thang] [int] NULL,
	[Nam] [int] NULL,
 CONSTRAINT [PK_ccXemChamCong] PRIMARY KEY CLUSTERED 
(
	[IDChamCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dvChuyenMon]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dvChuyenMon](
	[IDChuyenMon] [bigint] IDENTITY(1,1) NOT NULL,
	[MaChuyenMon] [nvarchar](50) NULL,
	[TenChuyenMon] [nvarchar](50) NULL,
	[NgayTao] [smalldatetime] NULL,
	[NgayCapNhat] [smalldatetime] NULL,
	[DaXoa] [int] NULL,
	[DonViID] [bigint] NULL,
 CONSTRAINT [PK_dvChuyenMon] PRIMARY KEY CLUSTERED 
(
	[IDChuyenMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dvDonVi]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dvDonVi](
	[IDDonVi] [bigint] IDENTITY(1,1) NOT NULL,
	[MaDonVi] [nvarchar](50) NULL,
	[TenDonVi] [nvarchar](250) NULL,
	[DonGia] [float] NULL,
	[MST] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[Logo] [text] NULL,
	[NgayDangKy] [datetime] NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
 CONSTRAINT [PK_dvDonVi] PRIMARY KEY CLUSTERED 
(
	[IDDonVi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dvPhongBan]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dvPhongBan](
	[IDPhongBan] [bigint] IDENTITY(1,1) NOT NULL,
	[MaPhongBan] [nvarchar](50) NULL,
	[TenPhongBan] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](250) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
	[DonViID] [bigint] NULL,
 CONSTRAINT [PK_dvPhongBan] PRIMARY KEY CLUSTERED 
(
	[IDPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[lgBangLuong]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lgBangLuong](
	[IDChamCong] [bigint] NOT NULL,
	[TGPCKK] [int] NULL,
	[HESOLUONG] [float] NULL,
	[NGAYNGHI] [float] NULL,
	[TIENLUONGPHEP] [float] NULL,
	[HESOCHUCDANH] [float] NULL,
	[PCKK] [int] NULL,
	[NGAYCONG] [int] NULL,
	[TIENLUONG] [float] NULL,
	[TIENPCKK] [float] NULL,
	[TIENLUONG100] [float] NULL,
	[TIENLUONG80] [float] NULL,
	[BHXH] [float] NULL,
	[BHYT] [float] NULL,
	[BHTN] [float] NULL,
	[CDPHI] [float] NULL,
	[DANGPHI] [float] NULL,
	[THUCLANH] [float] NULL,
	[LUONGCOBAN] [float] NULL,
	[HOTEN] [nvarchar](50) NULL,
	[TENCHUCDANH] [nvarchar](50) NULL,
	[TENPHONGBAN] [nvarchar](50) NULL,
	[THANG] [int] NULL,
	[NAM] [int] NULL,
 CONSTRAINT [PK_lgBangLuong] PRIMARY KEY CLUSTERED 
(
	[IDChamCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[lgLuong]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lgLuong](
	[IDLgLuong] [bigint] IDENTITY(1,1) NOT NULL,
	[LuongVung] [float] NULL,
	[LuongCoBan] [float] NULL,
	[TienCuoiNam] [float] NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
 CONSTRAINT [PK_BacLuong] PRIMARY KEY CLUSTERED 
(
	[IDLgLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[lskLoaiSuKien]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lskLoaiSuKien](
	[IDLoaiSuKien] [bigint] IDENTITY(1,1) NOT NULL,
	[MaLoaiSuKien] [nvarchar](50) NULL,
	[TenLoaiSuKien] [nvarchar](50) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
 CONSTRAINT [PK_lskLoaiSuKien] PRIMARY KEY CLUSTERED 
(
	[IDLoaiSuKien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[lskSuKien]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lskSuKien](
	[IDSuKien] [bigint] IDENTITY(1,1) NOT NULL,
	[TenSuKien] [nvarchar](50) NULL,
	[TuNgay] [datetime] NULL,
	[DenNgay] [datetime] NULL,
	[Buoi] [float] NULL,
	[HuongLuong] [float] NULL,
	[AnTrua] [float] NULL,
	[GhiChu] [nvarchar](250) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
	[LoaiSuKienID] [bigint] NULL,
 CONSTRAINT [PK_lskSuKien] PRIMARY KEY CLUSTERED 
(
	[IDSuKien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nvChucDanh]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nvChucDanh](
	[IDChucDanh] [bigint] IDENTITY(1,1) NOT NULL,
	[DanhMucCDID] [bigint] NULL,
	[MaChucDanh] [nvarchar](50) NULL,
	[TenChucDanh] [nvarchar](50) NULL,
	[HeSoChucDanh] [float] NULL,
	[GhiChu] [nvarchar](250) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
 CONSTRAINT [PK_nvChucDanh] PRIMARY KEY CLUSTERED 
(
	[IDChucDanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nvDanhMucCD]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nvDanhMucCD](
	[IDDanhMucCD] [bigint] IDENTITY(1,1) NOT NULL,
	[TenChucDanh] [nvarchar](50) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
 CONSTRAINT [PK_nvChucVu] PRIMARY KEY CLUSTERED 
(
	[IDDanhMucCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nvNhanVien]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nvNhanVien](
	[IDNhanVien] [bigint] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [nvarchar](50) NULL,
	[HoTen] [nvarchar](50) NULL,
	[GioiTinh] [int] NULL,
	[NgaySinh] [datetime] NULL,
	[DienThoai] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[CMND] [nvarchar](20) NULL,
	[HeSoLuong] [float] NULL,
	[HeSoChucDanh] [float] NULL,
	[TGPCKK] [int] NULL,
	[DieuKienPCKK] [int] NULL,
	[GhiChu] [nvarchar](250) NULL,
	[NgayLamViec] [datetime] NULL,
	[NgayNghiViec] [datetime] NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
	[PhongBanID] [bigint] NULL,
	[DonViID] [bigint] NULL,
	[TrinhDoID] [bigint] NULL,
	[ChucDanhID] [bigint] NULL,
 CONSTRAINT [PK_nvNhanVien_1] PRIMARY KEY CLUSTERED 
(
	[IDNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tlDinhMuc]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tlDinhMuc](
	[IDDinhMuc] [bigint] IDENTITY(1,1) NOT NULL,
	[MaDinhMuc] [nvarchar](50) NULL,
	[TenDinhMuc] [nvarchar](50) NULL,
	[HeSoDinhMuc] [float] NULL,
	[GhiChu] [nvarchar](250) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
 CONSTRAINT [PK_tlDinhMuc] PRIMARY KEY CLUSTERED 
(
	[IDDinhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrinhDo]    Script Date: 25/05/2018 2:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrinhDo](
	[IDTrinhDo] [bigint] IDENTITY(1,1) NOT NULL,
	[MaTrinhDo] [nvarchar](50) NULL,
	[TenTrinhDo] [nvarchar](50) NULL,
 CONSTRAINT [PK_TrinhDo] PRIMARY KEY CLUSTERED 
(
	[IDTrinhDo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ccChamCong] ON 

INSERT [dbo].[ccChamCong] ([IDChamCong], [NguoiChamID], [NhanVienID], [Thang], [Nam], [SoNgay], [SoNgayNghi], [AnTrua], [HuongLuong], [PhepNam], [BHXH_DuongSuc], [BHXH_KhamThai], [BHXH_ChamConBenh], [BHXH_NghiBenh], [NgayTao], [NgayCapNhat], [TrangThai], [DaXoa], [NgayPhep]) VALUES (1, 1, 1, 5, 2018, 31, 6, 27, 25, 0, NULL, 0, 0, 0, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0, 0)
INSERT [dbo].[ccChamCong] ([IDChamCong], [NguoiChamID], [NhanVienID], [Thang], [Nam], [SoNgay], [SoNgayNghi], [AnTrua], [HuongLuong], [PhepNam], [BHXH_DuongSuc], [BHXH_KhamThai], [BHXH_ChamConBenh], [BHXH_NghiBenh], [NgayTao], [NgayCapNhat], [TrangThai], [DaXoa], [NgayPhep]) VALUES (2, 1, 2, 5, 2018, 31, 6, 27, 25, 0, NULL, 0, 0, 0, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0, 0)
INSERT [dbo].[ccChamCong] ([IDChamCong], [NguoiChamID], [NhanVienID], [Thang], [Nam], [SoNgay], [SoNgayNghi], [AnTrua], [HuongLuong], [PhepNam], [BHXH_DuongSuc], [BHXH_KhamThai], [BHXH_ChamConBenh], [BHXH_NghiBenh], [NgayTao], [NgayCapNhat], [TrangThai], [DaXoa], [NgayPhep]) VALUES (3, 1, 10002, 5, 2018, 31, 6, 27, 25, 0, NULL, 0, 0, 0, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0, 0)
SET IDENTITY_INSERT [dbo].[ccChamCong] OFF
SET IDENTITY_INSERT [dbo].[ccChiTiet] ON 

INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (1, 1, 1, 1, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (2, 1, 1, 2, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (3, 1, 1, 3, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (4, 1, 1, 4, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (5, 4, 1, 5, 0.5, 1, 0, 3, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (6, 5, 1, 6, -1, -1, 0, 2, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (7, 1, 1, 7, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (8, 1, 1, 8, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (9, 1, 1, 9, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (10, 1, 1, 10, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (11, 1, 1, 11, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (12, 4, 1, 12, 0.5, 1, 0, 3, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (13, 5, 1, 13, -1, -1, 0, 2, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (14, 1, 1, 14, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (15, 1, 1, 15, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (16, 1, 1, 16, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (17, 1, 1, 17, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (18, 1, 1, 18, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (19, 4, 1, 19, 0.5, 1, 0, 3, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (20, 5, 1, 20, -1, -1, 0, 2, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (21, 1, 1, 21, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (22, 1, 1, 22, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (23, 1, 1, 23, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (24, 1, 1, 24, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (25, 1, 1, 25, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (26, 4, 1, 26, 0.5, 1, 0, 3, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (27, 5, 1, 27, -1, -1, 0, 2, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (28, 1, 1, 28, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (29, 1, 1, 29, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (30, 1, 1, 30, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (31, 1, 1, 31, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (32, 1, 2, 1, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (33, 1, 2, 2, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (34, 1, 2, 3, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (35, 1, 2, 4, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (36, 4, 2, 5, 0.5, 1, 0, 3, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (37, 5, 2, 6, -1, -1, 0, 2, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (38, 1, 2, 7, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (39, 1, 2, 8, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (40, 1, 2, 9, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (41, 1, 2, 10, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (42, 1, 2, 11, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (43, 4, 2, 12, 0.5, 1, 0, 3, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (44, 5, 2, 13, -1, -1, 0, 2, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (45, 1, 2, 14, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (46, 1, 2, 15, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (47, 1, 2, 16, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (48, 1, 2, 17, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (49, 1, 2, 18, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (50, 4, 2, 19, 0.5, 1, 0, 3, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (51, 5, 2, 20, -1, -1, 0, 2, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (52, 1, 2, 21, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (53, 1, 2, 22, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (54, 1, 2, 23, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (55, 1, 2, 24, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (56, 1, 2, 25, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (57, 4, 2, 26, 0.5, 1, 0, 3, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (58, 5, 2, 27, -1, -1, 0, 2, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (59, 1, 2, 28, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (60, 1, 2, 29, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (61, 1, 2, 30, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (62, 1, 2, 31, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (63, 1, 3, 1, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (64, 1, 3, 2, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (65, 1, 3, 3, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (66, 1, 3, 4, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (67, 4, 3, 5, 0.5, 1, 0, 3, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (68, 5, 3, 6, -1, -1, 0, 2, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (69, 1, 3, 7, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (70, 1, 3, 8, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (71, 1, 3, 9, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (72, 1, 3, 10, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (73, 1, 3, 11, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (74, 4, 3, 12, 0.5, 1, 0, 3, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (75, 5, 3, 13, -1, -1, 0, 2, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (76, 1, 3, 14, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (77, 1, 3, 15, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (78, 1, 3, 16, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (79, 1, 3, 17, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (80, 1, 3, 18, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (81, 4, 3, 19, 0.5, 1, 0, 3, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (82, 5, 3, 20, -1, -1, 0, 2, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (83, 1, 3, 21, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (84, 1, 3, 22, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (85, 1, 3, 23, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (86, 1, 3, 24, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (87, 1, 3, 25, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (88, 4, 3, 26, 0.5, 1, 0, 3, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (89, 5, 3, 27, -1, -1, 0, 2, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (90, 1, 3, 28, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (91, 1, 3, 29, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (92, 1, 3, 30, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
INSERT [dbo].[ccChiTiet] ([IDChiTiet], [KyHieuID], [ChamCongID], [Ngay], [HuongLuong], [AnTrua], [PhepNam], [NgayNghi], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [NgayPhep]) VALUES (93, 1, 3, 31, 1, 1, 0, 0, NULL, CAST(0x0000A8EA01133520 AS DateTime), CAST(0x0000A8EA01133520 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[ccChiTiet] OFF
SET IDENTITY_INSERT [dbo].[ccKyHieu] ON 

INSERT [dbo].[ccKyHieu] ([IDKyHieu], [MaKyHieu], [TenKyHieu], [HuongLuong], [AnTrua], [PhepNam], [DienGiai], [GhiChu], [MacDinh], [NgayTao], [NgayCapNhat], [DaXoa]) VALUES (1, N'8', N'Làm việc 8 giờ/ngày', 1, 1, 0, N'Hưởng lương, ăn trưa 1 ngày', NULL, 0, CAST(0x0000A8E4010ED020 AS DateTime), CAST(0x0000A8E4010ED020 AS DateTime), 0)
INSERT [dbo].[ccKyHieu] ([IDKyHieu], [MaKyHieu], [TenKyHieu], [HuongLuong], [AnTrua], [PhepNam], [DienGiai], [GhiChu], [MacDinh], [NgayTao], [NgayCapNhat], [DaXoa]) VALUES (2, N'P', N'Nghỉ phép 1 ngày', 0, 0, 1, N'Nghĩ phép 1 ngày', NULL, 0, CAST(0x0000A8E4010F1670 AS DateTime), CAST(0x0000A8E4010F1670 AS DateTime), 0)
INSERT [dbo].[ccKyHieu] ([IDKyHieu], [MaKyHieu], [TenKyHieu], [HuongLuong], [AnTrua], [PhepNam], [DienGiai], [GhiChu], [MacDinh], [NgayTao], [NgayCapNhat], [DaXoa]) VALUES (3, N'K', N'Nghỉ không phép 1 ngày', -1, -1, 1, N'Nghỉ không phép 1 ngày', NULL, 0, CAST(0x0000A8E4010F5CC0 AS DateTime), CAST(0x0000A8E4010F5CC0 AS DateTime), 0)
INSERT [dbo].[ccKyHieu] ([IDKyHieu], [MaKyHieu], [TenKyHieu], [HuongLuong], [AnTrua], [PhepNam], [DienGiai], [GhiChu], [MacDinh], [NgayTao], [NgayCapNhat], [DaXoa]) VALUES (4, N'4', N'Làm việc 4 giờ/ngày', 0.5, 1, 0, N'Làm việc 4 giờ/ngày', NULL, 0, CAST(0x0000A8E4010FA310 AS DateTime), CAST(0x0000A8E4010FA310 AS DateTime), 0)
INSERT [dbo].[ccKyHieu] ([IDKyHieu], [MaKyHieu], [TenKyHieu], [HuongLuong], [AnTrua], [PhepNam], [DienGiai], [GhiChu], [MacDinh], [NgayTao], [NgayCapNhat], [DaXoa]) VALUES (5, N' ', N'Nghĩ phép cuối tuần', -1, -1, 0, N'Nghĩ phép cuối tuần', NULL, 1, CAST(0x0000A8E601499700 AS DateTime), CAST(0x0000A8E601499700 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[ccKyHieu] OFF
INSERT [dbo].[ccXemChamCong] ([IDChamCong], [IDNhanVien], [TenPhongBan], [HoTen], [MaNhanVien], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [24], [25], [26], [27], [28], [29], [30], [31], [AnTrua], [HuongLuong], [PhepNam], [NgayPhep], [Thang], [Nam]) VALUES (1, 1, N'Phòng Kế toán', N'Nguyễn Văn Tèo', N'NV0001', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', 27, 25, 0, 0, 5, 2018)
INSERT [dbo].[ccXemChamCong] ([IDChamCong], [IDNhanVien], [TenPhongBan], [HoTen], [MaNhanVien], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [24], [25], [26], [27], [28], [29], [30], [31], [AnTrua], [HuongLuong], [PhepNam], [NgayPhep], [Thang], [Nam]) VALUES (2, 2, N'Phòng Giám Đốc', N'Nguyễn Thị Leo', N'NV0002', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', 27, 25, 0, 0, 5, 2018)
INSERT [dbo].[ccXemChamCong] ([IDChamCong], [IDNhanVien], [TenPhongBan], [HoTen], [MaNhanVien], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [24], [25], [26], [27], [28], [29], [30], [31], [AnTrua], [HuongLuong], [PhepNam], [NgayPhep], [Thang], [Nam]) VALUES (3, 10002, N'Phòng nhân viên', N'Lê Văn Tê', N'NV0003', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', 27, 25, 0, 0, 5, 2018)
INSERT [dbo].[ccXemChamCong] ([IDChamCong], [IDNhanVien], [TenPhongBan], [HoTen], [MaNhanVien], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [24], [25], [26], [27], [28], [29], [30], [31], [AnTrua], [HuongLuong], [PhepNam], [NgayPhep], [Thang], [Nam]) VALUES (4, 1, N'Phòng Kế toán', N'Nguyễn Văn Tèo', N'NV0001', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', NULL, 25, 23, 0, 0, 4, 2018)
INSERT [dbo].[ccXemChamCong] ([IDChamCong], [IDNhanVien], [TenPhongBan], [HoTen], [MaNhanVien], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [24], [25], [26], [27], [28], [29], [30], [31], [AnTrua], [HuongLuong], [PhepNam], [NgayPhep], [Thang], [Nam]) VALUES (5, 2, N'Phòng Giám Đốc', N'Nguyễn Thị Leo', N'NV0002', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', NULL, 25, 23, 0, 0, 4, 2018)
INSERT [dbo].[ccXemChamCong] ([IDChamCong], [IDNhanVien], [TenPhongBan], [HoTen], [MaNhanVien], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [24], [25], [26], [27], [28], [29], [30], [31], [AnTrua], [HuongLuong], [PhepNam], [NgayPhep], [Thang], [Nam]) VALUES (6, 1, N'Phòng Kế toán', N'Nguyễn Văn Tèo', N'NV0001', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', 27, 24.5, 0, 0, 3, 2018)
INSERT [dbo].[ccXemChamCong] ([IDChamCong], [IDNhanVien], [TenPhongBan], [HoTen], [MaNhanVien], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [24], [25], [26], [27], [28], [29], [30], [31], [AnTrua], [HuongLuong], [PhepNam], [NgayPhep], [Thang], [Nam]) VALUES (7, 2, N'Phòng Giám Đốc', N'Nguyễn Thị Leo', N'NV0002', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', 27, 24.5, 0, 0, 3, 2018)
INSERT [dbo].[ccXemChamCong] ([IDChamCong], [IDNhanVien], [TenPhongBan], [HoTen], [MaNhanVien], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [24], [25], [26], [27], [28], [29], [30], [31], [AnTrua], [HuongLuong], [PhepNam], [NgayPhep], [Thang], [Nam]) VALUES (8, 1, N'Phòng Kế toán', N'Nguyễn Văn Tèo', N'NV0001', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', NULL, NULL, NULL, 24, 22, 0, 0, 2, 2018)
INSERT [dbo].[ccXemChamCong] ([IDChamCong], [IDNhanVien], [TenPhongBan], [HoTen], [MaNhanVien], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [24], [25], [26], [27], [28], [29], [30], [31], [AnTrua], [HuongLuong], [PhepNam], [NgayPhep], [Thang], [Nam]) VALUES (9, 2, N'Phòng Giám Đốc', N'Nguyễn Thị Leo', N'NV0002', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', NULL, NULL, NULL, 24, 22, 0, 0, 2, 2018)
INSERT [dbo].[ccXemChamCong] ([IDChamCong], [IDNhanVien], [TenPhongBan], [HoTen], [MaNhanVien], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [24], [25], [26], [27], [28], [29], [30], [31], [AnTrua], [HuongLuong], [PhepNam], [NgayPhep], [Thang], [Nam]) VALUES (10, 1, N'Phòng Kế toán', N'Nguyễn Văn Tèo', N'NV0001', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', 27, 25, 0, 0, 1, 2018)
INSERT [dbo].[ccXemChamCong] ([IDChamCong], [IDNhanVien], [TenPhongBan], [HoTen], [MaNhanVien], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [24], [25], [26], [27], [28], [29], [30], [31], [AnTrua], [HuongLuong], [PhepNam], [NgayPhep], [Thang], [Nam]) VALUES (11, 2, N'Phòng Giám Đốc', N'Nguyễn Thị Leo', N'NV0002', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', N'8', N'8', N'4', N' ', N'8', N'8', N'8', 27, 25, 0, 0, 1, 2018)
SET IDENTITY_INSERT [dbo].[dvDonVi] ON 

INSERT [dbo].[dvDonVi] ([IDDonVi], [MaDonVi], [TenDonVi], [DonGia], [MST], [DiaChi], [DienThoai], [Logo], [NgayDangKy], [NgayTao], [NgayCapNhat], [DaXoa]) VALUES (1, N'XNPAG', N'Xí nghiệp Phà An Giang', 140000, N'123456789', N'TP. Long Xuyên, tỉnh An Giang', N'0296111222', NULL, CAST(0x00009A9F00000000 AS DateTime), CAST(0x0000A8E30107AC00 AS DateTime), CAST(0x0000A8E30107AC00 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[dvDonVi] OFF
SET IDENTITY_INSERT [dbo].[dvPhongBan] ON 

INSERT [dbo].[dvPhongBan] ([IDPhongBan], [MaPhongBan], [TenPhongBan], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [DonViID]) VALUES (1, N'PGD', N'Phòng Giám Đốc', N'1', CAST(0x0000A8E3010838A0 AS DateTime), CAST(0x0000A8E3010838A0 AS DateTime), 0, 1)
INSERT [dbo].[dvPhongBan] ([IDPhongBan], [MaPhongBan], [TenPhongBan], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [DonViID]) VALUES (2, N'PKT', N'Phòng Kế toán', N'0', CAST(0x0000A8E400AEAEC0 AS DateTime), CAST(0x0000A8E400AEAEC0 AS DateTime), 0, 1)
INSERT [dbo].[dvPhongBan] ([IDPhongBan], [MaPhongBan], [TenPhongBan], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [DonViID]) VALUES (3, N'PNV', N'Phòng nhân viên', NULL, CAST(0x0000A8EA0112A880 AS DateTime), CAST(0x0000A8EA0112A880 AS DateTime), 0, 1)
SET IDENTITY_INSERT [dbo].[dvPhongBan] OFF
INSERT [dbo].[lgBangLuong] ([IDChamCong], [TGPCKK], [HESOLUONG], [NGAYNGHI], [TIENLUONGPHEP], [HESOCHUCDANH], [PCKK], [NGAYCONG], [TIENLUONG], [TIENPCKK], [TIENLUONG100], [TIENLUONG80], [BHXH], [BHYT], [BHTN], [CDPHI], [DANGPHI], [THUCLANH], [LUONGCOBAN], [HOTEN], [TENCHUCDANH], [TENPHONGBAN], [THANG], [NAM]) VALUES (1, 2, 2.35, 0, 0, 2.35, 0, 25, 8225000, 0, 8225000, 6580000, 526400, 98700, 65800, 65800, 0, 5823300, 8295500, N'Nguyễn Văn Tèo', N'Phụ Phà', N'Phòng Kế toán', 5, 2018)
INSERT [dbo].[lgBangLuong] ([IDChamCong], [TGPCKK], [HESOLUONG], [NGAYNGHI], [TIENLUONGPHEP], [HESOCHUCDANH], [PCKK], [NGAYCONG], [TIENLUONG], [TIENPCKK], [TIENLUONG100], [TIENLUONG80], [BHXH], [BHYT], [BHTN], [CDPHI], [DANGPHI], [THUCLANH], [LUONGCOBAN], [HOTEN], [TENCHUCDANH], [TENPHONGBAN], [THANG], [NAM]) VALUES (2, 5, 2.67, 0, 0, 1.5, 0, 25, 5250000, 0, 5250000, 4200000, 336000, 63000, 42000, 42000, 0, 3717000, 3471000, N'Nguyễn Thị Leo', N'Phụ Phà', N'Phòng Giám Đốc', 5, 2018)
INSERT [dbo].[lgBangLuong] ([IDChamCong], [TGPCKK], [HESOLUONG], [NGAYNGHI], [TIENLUONGPHEP], [HESOCHUCDANH], [PCKK], [NGAYCONG], [TIENLUONG], [TIENPCKK], [TIENLUONG100], [TIENLUONG80], [BHXH], [BHYT], [BHTN], [CDPHI], [DANGPHI], [THUCLANH], [LUONGCOBAN], [HOTEN], [TENCHUCDANH], [TENPHONGBAN], [THANG], [NAM]) VALUES (3, 2, 3, 0, 0, 1.7, 0, 25, 5950000, 0, 5950000, 4760000, 380800, 71400, 47600, 47600, 0, 4212600, 10590000, N'Lê Văn Tê', N'Phụ Phà', N'Phòng nhân viên', 5, 2018)
SET IDENTITY_INSERT [dbo].[lgLuong] ON 

INSERT [dbo].[lgLuong] ([IDLgLuong], [LuongVung], [LuongCoBan], [TienCuoiNam], [NgayTao], [NgayCapNhat], [DaXoa]) VALUES (1, 3530000, 1300000, 1200000, CAST(0x0000A8E800A9BD20 AS DateTime), CAST(0x0000A8E800A9BD20 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[lgLuong] OFF
SET IDENTITY_INSERT [dbo].[lskLoaiSuKien] ON 

INSERT [dbo].[lskLoaiSuKien] ([IDLoaiSuKien], [MaLoaiSuKien], [TenLoaiSuKien], [NgayTao], [NgayCapNhat], [DaXoa]) VALUES (1, N'TND', N'Tết nguyên đán', CAST(0x0000A8E4010FE960 AS DateTime), CAST(0x0000A8E4010FE960 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[lskLoaiSuKien] OFF
SET IDENTITY_INSERT [dbo].[lskSuKien] ON 

INSERT [dbo].[lskSuKien] ([IDSuKien], [TenSuKien], [TuNgay], [DenNgay], [Buoi], [HuongLuong], [AnTrua], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa], [LoaiSuKienID]) VALUES (1, N'Nghĩ Tết Nguyên Đán', CAST(0x0000A8E300000000 AS DateTime), CAST(0x0000A8E400000000 AS DateTime), 4, 0, 0, NULL, CAST(0x0000A8E4010FE960 AS DateTime), CAST(0x0000A8E4010FE960 AS DateTime), 0, 1)
SET IDENTITY_INSERT [dbo].[lskSuKien] OFF
SET IDENTITY_INSERT [dbo].[nvChucDanh] ON 

INSERT [dbo].[nvChucDanh] ([IDChucDanh], [DanhMucCDID], [MaChucDanh], [TenChucDanh], [HeSoChucDanh], [GhiChu], [NgayTao], [NgayCapNhat], [DaXoa]) VALUES (1, 1, N'CD000001', N'Phụ Phà', 3.55, NULL, CAST(0x0000A8EA00970FE0 AS DateTime), CAST(0x0000A8EA00970FE0 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[nvChucDanh] OFF
SET IDENTITY_INSERT [dbo].[nvDanhMucCD] ON 

INSERT [dbo].[nvDanhMucCD] ([IDDanhMucCD], [TenChucDanh], [NgayTao], [NgayCapNhat], [DaXoa]) VALUES (1, N'Nhân Viên', CAST(0x0000A8EA0096C990 AS DateTime), CAST(0x0000A8EA0096C990 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[nvDanhMucCD] OFF
SET IDENTITY_INSERT [dbo].[nvNhanVien] ON 

INSERT [dbo].[nvNhanVien] ([IDNhanVien], [MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [CMND], [HeSoLuong], [HeSoChucDanh], [TGPCKK], [DieuKienPCKK], [GhiChu], [NgayLamViec], [NgayNghiViec], [NgayTao], [NgayCapNhat], [DaXoa], [PhongBanID], [DonViID], [TrinhDoID], [ChucDanhID]) VALUES (1, N'NV0001', N'Nguyễn Văn Tèo', 1, CAST(0x000081B600000000 AS DateTime), N'01234567890', N'An Giang', N'123123123', 2.35, 2.35, 2, 5, NULL, CAST(0x0000A60F00000000 AS DateTime), NULL, CAST(0x0000A8E3010B8460 AS DateTime), CAST(0x0000A8E3010B8460 AS DateTime), 0, 2, 1, 3, 1)
INSERT [dbo].[nvNhanVien] ([IDNhanVien], [MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [CMND], [HeSoLuong], [HeSoChucDanh], [TGPCKK], [DieuKienPCKK], [GhiChu], [NgayLamViec], [NgayNghiViec], [NgayTao], [NgayCapNhat], [DaXoa], [PhongBanID], [DonViID], [TrinhDoID], [ChucDanhID]) VALUES (2, N'NV0002', N'Nguyễn Thị Leo', 0, CAST(0x0000723B00000000 AS DateTime), N'01234567891', N'Cần Thơ', N'456456456', 2.67, 1.5, 5, 5, NULL, CAST(0x0000A74800000000 AS DateTime), NULL, CAST(0x0000A8E3010BCAB0 AS DateTime), CAST(0x0000A8E3010BCAB0 AS DateTime), 0, 1, 1, 4, 1)
INSERT [dbo].[nvNhanVien] ([IDNhanVien], [MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [CMND], [HeSoLuong], [HeSoChucDanh], [TGPCKK], [DieuKienPCKK], [GhiChu], [NgayLamViec], [NgayNghiViec], [NgayTao], [NgayCapNhat], [DaXoa], [PhongBanID], [DonViID], [TrinhDoID], [ChucDanhID]) VALUES (10002, N'NV0003', N'Lê Văn Tê', 1, CAST(0x00007DF700000000 AS DateTime), N'01234567892', N'Đồng Tháp', N'789789789', 3, 1.7, 2, 5, NULL, CAST(0x0000A8DC00000000 AS DateTime), NULL, CAST(0x0000A8E400B054A0 AS DateTime), CAST(0x0000A8E400B054A0 AS DateTime), 0, 3, 1, 5, 1)
INSERT [dbo].[nvNhanVien] ([IDNhanVien], [MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [CMND], [HeSoLuong], [HeSoChucDanh], [TGPCKK], [DieuKienPCKK], [GhiChu], [NgayLamViec], [NgayNghiViec], [NgayTao], [NgayCapNhat], [DaXoa], [PhongBanID], [DonViID], [TrinhDoID], [ChucDanhID]) VALUES (10003, N'NV0004', N'Nguyên Văn Tâm', 1, NULL, NULL, NULL, NULL, 2, 1.5, 2, 4, NULL, NULL, NULL, CAST(0x0000A8E900B54640 AS DateTime), CAST(0x0000A8E900B54640 AS DateTime), 0, 3, 4, 5, 1)
SET IDENTITY_INSERT [dbo].[nvNhanVien] OFF
SET IDENTITY_INSERT [dbo].[TrinhDo] ON 

INSERT [dbo].[TrinhDo] ([IDTrinhDo], [MaTrinhDo], [TenTrinhDo]) VALUES (1, N'TS', N'Tiến sĩ')
INSERT [dbo].[TrinhDo] ([IDTrinhDo], [MaTrinhDo], [TenTrinhDo]) VALUES (2, N'ThS', N'Thạc sĩ')
INSERT [dbo].[TrinhDo] ([IDTrinhDo], [MaTrinhDo], [TenTrinhDo]) VALUES (3, N'CH', N'Cao học')
INSERT [dbo].[TrinhDo] ([IDTrinhDo], [MaTrinhDo], [TenTrinhDo]) VALUES (4, N'DH', N'Đại học')
INSERT [dbo].[TrinhDo] ([IDTrinhDo], [MaTrinhDo], [TenTrinhDo]) VALUES (5, N'CD', N'Cao đẳng')
INSERT [dbo].[TrinhDo] ([IDTrinhDo], [MaTrinhDo], [TenTrinhDo]) VALUES (6, N'TC', N'Trung cấp')
INSERT [dbo].[TrinhDo] ([IDTrinhDo], [MaTrinhDo], [TenTrinhDo]) VALUES (7, N'THPT', N'Tốt nghiệp 12')
SET IDENTITY_INSERT [dbo].[TrinhDo] OFF
ALTER TABLE [dbo].[ccChamCong] ADD  CONSTRAINT [DF_ccChamCong_AnTrua]  DEFAULT ((0)) FOR [AnTrua]
GO
ALTER TABLE [dbo].[ccChamCong] ADD  CONSTRAINT [DF_ccChamCong_HuongLuong]  DEFAULT ((0)) FOR [HuongLuong]
GO
ALTER TABLE [dbo].[ccChamCong] ADD  CONSTRAINT [DF_ccChamCong_PhepNam]  DEFAULT ((0)) FOR [PhepNam]
GO
ALTER TABLE [dbo].[ccChamCong] ADD  CONSTRAINT [DF_ccChamCong_BHXH_KhamThai]  DEFAULT ((0)) FOR [BHXH_KhamThai]
GO
ALTER TABLE [dbo].[ccChamCong] ADD  CONSTRAINT [DF_ccChamCong_BHXH_ChamConBenh]  DEFAULT ((0)) FOR [BHXH_ChamConBenh]
GO
ALTER TABLE [dbo].[ccChamCong] ADD  CONSTRAINT [DF_ccChamCong_BHXH_NghiBenh]  DEFAULT ((0)) FOR [BHXH_NghiBenh]
GO
ALTER TABLE [dbo].[ccChamCong] ADD  CONSTRAINT [DF_ccChamCong_NgayTao_1]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[ccChamCong] ADD  CONSTRAINT [DF_ccChamCong_NgayCapNhat_1]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[ccChamCong] ADD  CONSTRAINT [DF_ccChamCong_TrangThai]  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[ccChamCong] ADD  CONSTRAINT [DF_ccChamCong_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[ccChamCong] ADD  CONSTRAINT [DF_ccChamCong_NgayPhep]  DEFAULT ((0)) FOR [NgayPhep]
GO
ALTER TABLE [dbo].[ccChiTiet] ADD  CONSTRAINT [DF_ccChiTiet_HuongLuong]  DEFAULT ((0)) FOR [HuongLuong]
GO
ALTER TABLE [dbo].[ccChiTiet] ADD  CONSTRAINT [DF_ccChiTiet_AnTrua]  DEFAULT ((0)) FOR [AnTrua]
GO
ALTER TABLE [dbo].[ccChiTiet] ADD  CONSTRAINT [DF_ccChiTiet_PhepNam]  DEFAULT ((0)) FOR [PhepNam]
GO
ALTER TABLE [dbo].[ccChiTiet] ADD  CONSTRAINT [DF_ccChiTiet_NgayNghi]  DEFAULT ((0)) FOR [NgayNghi]
GO
ALTER TABLE [dbo].[ccChiTiet] ADD  CONSTRAINT [DF_ccChamCong_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[ccChiTiet] ADD  CONSTRAINT [DF_ccChamCong_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[ccChiTiet] ADD  CONSTRAINT [DF_ccChiTiet_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[ccChiTiet] ADD  CONSTRAINT [DF_ccChiTiet_NgayPhep]  DEFAULT ((0)) FOR [NgayPhep]
GO
ALTER TABLE [dbo].[ccKyHieu] ADD  CONSTRAINT [DF_ccKyHieu_MacDinh]  DEFAULT ((0)) FOR [MacDinh]
GO
ALTER TABLE [dbo].[ccKyHieu] ADD  CONSTRAINT [DF_ccKyHieu_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[ccKyHieu] ADD  CONSTRAINT [DF_ccKyHieu_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[ccKyHieu] ADD  CONSTRAINT [DF_ccKyHieu_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[dvChuyenMon] ADD  CONSTRAINT [DF_dvChuyenMon_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[dvChuyenMon] ADD  CONSTRAINT [DF_dvChuyenMon_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[dvChuyenMon] ADD  CONSTRAINT [DF_dvChuyenMon_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[dvDonVi] ADD  CONSTRAINT [DF_dvDonVi_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[dvDonVi] ADD  CONSTRAINT [DF_dvDonVi_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[dvDonVi] ADD  CONSTRAINT [DF_dvDonVi_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[dvPhongBan] ADD  CONSTRAINT [DF_dvPhongBan_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[dvPhongBan] ADD  CONSTRAINT [DF_dvPhongBan_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[dvPhongBan] ADD  CONSTRAINT [DF_dvPhongBan_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[lgLuong] ADD  CONSTRAINT [DF_BacLuong_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[lgLuong] ADD  CONSTRAINT [DF_BacLuong_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[lgLuong] ADD  CONSTRAINT [DF_BacLuong_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[lskLoaiSuKien] ADD  CONSTRAINT [DF_lskLoaiSuKien_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[lskLoaiSuKien] ADD  CONSTRAINT [DF_lskLoaiSuKien_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[lskLoaiSuKien] ADD  CONSTRAINT [DF_lskLoaiSuKien_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[lskSuKien] ADD  CONSTRAINT [DF_lskSuKien_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[lskSuKien] ADD  CONSTRAINT [DF_lskSuKien_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[lskSuKien] ADD  CONSTRAINT [DF_lskSuKien_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[nvChucDanh] ADD  CONSTRAINT [DF_nvChucDanh_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[nvChucDanh] ADD  CONSTRAINT [DF_nvChucDanh_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[nvChucDanh] ADD  CONSTRAINT [DF_nvChucDanh_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[nvDanhMucCD] ADD  CONSTRAINT [DF_nvChucVu_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[nvDanhMucCD] ADD  CONSTRAINT [DF_nvChucVu_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[nvDanhMucCD] ADD  CONSTRAINT [DF_nvChucVu_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[nvNhanVien] ADD  CONSTRAINT [DF_nvNhanVien_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[nvNhanVien] ADD  CONSTRAINT [DF_nvNhanVien_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[nvNhanVien] ADD  CONSTRAINT [DF_nvNhanVien_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
ALTER TABLE [dbo].[tlDinhMuc] ADD  CONSTRAINT [DF_tlDinhMuc_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[tlDinhMuc] ADD  CONSTRAINT [DF_tlDinhMuc_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
USE [master]
GO
ALTER DATABASE [AnGiang] SET  READ_WRITE 
GO
