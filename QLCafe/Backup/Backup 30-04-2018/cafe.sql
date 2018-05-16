USE [gpm_codeCaFeMienPhi]
GO
/****** Object:  Table [dbo].[Setting]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Setting](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TieuDe] [nvarchar](250) NULL,
	[CongTy] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[SDT] [nvarchar](50) NULL,
	[TinhGio] [int] NULL,
	[TestDuLieu] [nvarchar](255) NULL,
	[ReportBill] [int] NULL,
	[MayIn] [nvarchar](255) NULL,
	[CauHinhServer] [int] NULL,
	[GiaoDienApDung] [int] NULL,
 CONSTRAINT [PK_Setting] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Setting] ON
INSERT [dbo].[Setting] ([ID], [TieuDe], [CongTy], [DiaChi], [SDT], [TinhGio], [TestDuLieu], [ReportBill], [MayIn], [CauHinhServer], [GiaoDienApDung]) VALUES (1, N'', N'Cửa Hàng 1', N'198B10 Hàm Nghi, Long Xuyên - AG', N'02966.275.595', 0, N'd9fd598e4ea9bc5deef68ae5fe1299871bebb033', 80, N'XP-80C', 1, 1)
SET IDENTITY_INSERT [dbo].[Setting] OFF
/****** Object:  Table [dbo].[CF_TongChi]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_TongChi](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LoaiChi] [nvarchar](250) NULL,
	[TienChi] [float] NULL,
	[NgayChi] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
	[IDChiNhanh] [int] NULL,
 CONSTRAINT [PK_CF_TongChi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CF_NhomNguoiDung]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_NhomNguoiDung](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNhom] [nvarchar](50) NULL,
	[TenNhom] [nvarchar](250) NULL,
	[NgayCapNhat] [datetime] NULL,
 CONSTRAINT [PK_CF_NhomNguoiDung] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CF_NhomNguoiDung] ON
INSERT [dbo].[CF_NhomNguoiDung] ([ID], [MaNhom], [TenNhom], [NgayCapNhat]) VALUES (1, N'0001', N'Nhóm Quản Trị', CAST(0x0000A7D000BBE141 AS DateTime))
INSERT [dbo].[CF_NhomNguoiDung] ([ID], [MaNhom], [TenNhom], [NgayCapNhat]) VALUES (2, N'0002', N'Nhóm Thu Ngân', CAST(0x0000A7D000BBEA6E AS DateTime))
SET IDENTITY_INSERT [dbo].[CF_NhomNguoiDung] OFF
/****** Object:  Table [dbo].[CF_NhomHangHoa]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_NhomHangHoa](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNhom] [nvarchar](50) NULL,
	[TenNhom] [nvarchar](250) NULL,
	[GhiChu] [nvarchar](250) NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
	[IDChiNhanh] [int] NULL,
 CONSTRAINT [PK_CF_NhomHangHoa] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CF_NhomHangHoa] ON
INSERT [dbo].[CF_NhomHangHoa] ([ID], [MaNhom], [TenNhom], [GhiChu], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (78, N'', N'Nước giải khát', N'', CAST(0x0000A8AA00C3F0EC AS DateTime), 0, 0)
INSERT [dbo].[CF_NhomHangHoa] ([ID], [MaNhom], [TenNhom], [GhiChu], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (79, N'', N'Điểm tâm', N'', CAST(0x0000A8AA00C3F897 AS DateTime), 0, 0)
INSERT [dbo].[CF_NhomHangHoa] ([ID], [MaNhom], [TenNhom], [GhiChu], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (90, N'', N'Thuốt hút', N'', CAST(0x0000A8AA00F5D1CF AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[CF_NhomHangHoa] OFF
/****** Object:  Table [dbo].[CF_NguoiDung]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_NguoiDung](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [nvarchar](50) NULL,
	[TenNguoiDung] [nvarchar](250) NULL,
	[TenDangNhap] [nvarchar](250) NULL,
	[SDT] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](255) NULL,
	[Email] [nvarchar](150) NULL,
	[IDNhomNguoiDung] [int] NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
	[IDChiNhanh] [int] NULL,
 CONSTRAINT [PK_CF_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CF_NguoiDung] ON
INSERT [dbo].[CF_NguoiDung] ([ID], [MaNhanVien], [TenNguoiDung], [TenDangNhap], [SDT], [MatKhau], [Email], [IDNhomNguoiDung], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (1, N'0000001', N'Hệ Thống', N'ADMIN', N'01674799994', N'601f1889667efaebb33b8c12572835da3f27f78', N'luanhv@gpm.vn', 1, CAST(0x0000A8C900C03582 AS DateTime), 0, 0)
INSERT [dbo].[CF_NguoiDung] ([ID], [MaNhanVien], [TenNguoiDung], [TenDangNhap], [SDT], [MatKhau], [Email], [IDNhomNguoiDung], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (7, N'0000007', N'Thu Ngân', N'THUNGAN1', N'1', N'cf7579954ba3792f6a4044c32f28fb62b10863f', N'', 2, CAST(0x0000A8AA01031DB7 AS DateTime), 0, 0)
INSERT [dbo].[CF_NguoiDung] ([ID], [MaNhanVien], [TenNguoiDung], [TenDangNhap], [SDT], [MatKhau], [Email], [IDNhomNguoiDung], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (8, N'0000003', N'Quản Trị', N'QUANTRI1', N'1', N'cf7579954ba3792f6a4044c32f28fb62b10863f', N'', 1, CAST(0x0000A8AA010325B1 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[CF_NguoiDung] OFF
/****** Object:  Table [dbo].[CF_LichSuThayDoiGia]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_LichSuThayDoiGia](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IDNguoiDung] [int] NULL,
	[MaHang] [nvarchar](50) NULL,
	[TenHang] [nvarchar](50) NULL,
	[IDDVT] [int] NULL,
	[GiaCu] [float] NULL,
	[GiaMoi] [float] NULL,
	[NgayThayDoi] [datetime] NULL,
	[IDChiNhanh] [int] NULL,
 CONSTRAINT [PK_GPM_LichSuThayDoiGia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CF_LichSuThayDoiGia] ON
INSERT [dbo].[CF_LichSuThayDoiGia] ([ID], [IDNguoiDung], [MaHang], [TenHang], [IDDVT], [GiaCu], [GiaMoi], [NgayThayDoi], [IDChiNhanh]) VALUES (1, 8, N'00007', N'7 Up', 40, 12000, 15000, CAST(0x0000A8C9009AC5B9 AS DateTime), NULL)
INSERT [dbo].[CF_LichSuThayDoiGia] ([ID], [IDNguoiDung], [MaHang], [TenHang], [IDDVT], [GiaCu], [GiaMoi], [NgayThayDoi], [IDChiNhanh]) VALUES (3, 8, N'00001', N'7 Up', 71, 10000, 10000, CAST(0x0000A8CF0089178F AS DateTime), 0)
INSERT [dbo].[CF_LichSuThayDoiGia] ([ID], [IDNguoiDung], [MaHang], [TenHang], [IDDVT], [GiaCu], [GiaMoi], [NgayThayDoi], [IDChiNhanh]) VALUES (4, 8, N'0', N'Cơm Tấm', 38, 20000, 20000, CAST(0x0000A8CF008931B4 AS DateTime), 0)
INSERT [dbo].[CF_LichSuThayDoiGia] ([ID], [IDNguoiDung], [MaHang], [TenHang], [IDDVT], [GiaCu], [GiaMoi], [NgayThayDoi], [IDChiNhanh]) VALUES (5, 8, N'3', N'Cafe', 36, 15000, 15000, CAST(0x0000A8CF008A1EDC AS DateTime), 0)
INSERT [dbo].[CF_LichSuThayDoiGia] ([ID], [IDNguoiDung], [MaHang], [TenHang], [IDDVT], [GiaCu], [GiaMoi], [NgayThayDoi], [IDChiNhanh]) VALUES (6, 8, N'4', N'Bánh Mì', 35, 15000, 15000, CAST(0x0000A8CF008BE050 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[CF_LichSuThayDoiGia] OFF
/****** Object:  Table [dbo].[CF_LichSuThaoTac]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_LichSuThaoTac](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[HoatDong] [nvarchar](max) NULL,
	[ThoiGian] [datetime] NULL,
	[ChiTiet] [nvarchar](max) NULL,
	[IDNhanVien] [bigint] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CF_LichSuThaoTac] ON
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (101, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010B6D8B AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (103, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010C4A3E AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (104, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D04BD AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (106, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D0A66 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (109, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D52D1 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (111, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D5399 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (115, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D5602 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (118, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D69E4 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (120, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D6DE4 AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (121, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D7047 AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: Bánh Mì ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (123, N'Cập Nhật Số Lượng', CAST(0x0000A8D001138CDF AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (124, N'Cập Nhật Số Lượng', CAST(0x0000A8D0011391DB AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (127, N'Cập Nhật Số Lượng', CAST(0x0000A8D0011393B4 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Bánh Mì ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (129, N'Cập Nhật Số Lượng', CAST(0x0000A8D00113948F AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (131, N'Cập Nhật Số Lượng', CAST(0x0000A8D0011397C3 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (133, N'Cập Nhật Số Lượng', CAST(0x0000A8D0011398AA AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (137, N'Cập Nhật Số Lượng', CAST(0x0000A8D001139B03 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (138, N'Cập Nhật Số Lượng', CAST(0x0000A8D001139C8E AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (140, N'Cập Nhật Số Lượng', CAST(0x0000A8D001139CEB AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (142, N'Cập Nhật Số Lượng', CAST(0x0000A8D001139DD1 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (144, N'Cập Nhật Số Lượng', CAST(0x0000A8D001139E67 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (184, N'Cập Nhật Số Lượng', CAST(0x0000A8D00189FA30 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (185, N'Cập Nhật Số Lượng', CAST(0x0000A8D00189FAA5 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (186, N'Cập Nhật Số Lượng', CAST(0x0000A8D00189FB15 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (197, N'Cập Nhật Số Lượng', CAST(0x0000A8D100091867 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (198, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000918DC AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (199, N'Cập Nhật Số Lượng', CAST(0x0000A8D100091D74 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (200, N'Cập Nhật Số Lượng', CAST(0x0000A8D100091DE7 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (201, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B5F11 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (202, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B6069 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (203, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B662B AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (204, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B66BF AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (205, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B6756 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (206, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B6812 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Bánh Mì ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (207, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B68EF AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (208, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B69C9 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (209, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B6C69 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (210, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B6CF5 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (211, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B6D6B AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (212, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B6DC3 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (213, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B7224 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Bánh Mì ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (214, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B72A5 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Bánh Mì ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (215, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B73C3 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (216, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B7428 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (217, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B749D AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (218, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B7752 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (219, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B77CA AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (220, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B7919 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (221, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B798F AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (222, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B7C30 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (105, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D09C7 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (108, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D51FA AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (113, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D54F3 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (114, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D557E AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (117, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D6113 AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: Bánh Mì ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (119, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D6D5E AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (125, N'Cập Nhật Số Lượng', CAST(0x0000A8D001139225 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (126, N'Cập Nhật Số Lượng', CAST(0x0000A8D00113935C AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (132, N'Cập Nhật Số Lượng', CAST(0x0000A8D0011397F3 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (135, N'Cập Nhật Số Lượng', CAST(0x0000A8D001139AB0 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (136, N'Cập Nhật Số Lượng', CAST(0x0000A8D001139AD9 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (139, N'Cập Nhật Số Lượng', CAST(0x0000A8D001139CC1 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (141, N'Cập Nhật Số Lượng', CAST(0x0000A8D001139D48 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (146, N'Cập Nhật Số Lượng', CAST(0x0000A8D001139EE8 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (147, N'Cập Nhật Số Lượng', CAST(0x0000A8D001139F37 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (148, N'Cập Nhật Số Lượng', CAST(0x0000A8D001157CA0 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (149, N'Cập Nhật Số Lượng', CAST(0x0000A8D001157D35 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (150, N'Cập Nhật Số Lượng', CAST(0x0000A8D001157DB8 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (151, N'Cập Nhật Số Lượng', CAST(0x0000A8D001157E2B AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (152, N'Cập Nhật Số Lượng', CAST(0x0000A8D0011581E7 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (153, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115828D AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (154, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115832B AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (155, N'Cập Nhật Số Lượng', CAST(0x0000A8D0011583C3 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (156, N'Cập Nhật Số Lượng', CAST(0x0000A8D0011584C3 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (157, N'Cập Nhật Số Lượng', CAST(0x0000A8D0011587CA AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (158, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115DE62 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (159, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E042 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (160, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E089 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (161, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E0E0 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (162, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E16A AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (163, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E31F AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (164, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E3B5 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (165, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E40A AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (166, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E45E AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (167, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E51B AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (168, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E573 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (169, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E5D4 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (170, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E64A AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (171, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E6A8 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (172, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E6F5 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (173, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E759 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (174, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E7CB AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (175, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E84F AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (176, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115E8FB AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (177, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115EA54 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (178, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115EAD7 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (179, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115EB3B AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (180, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115EB9D AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (181, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115EFB6 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 5', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (182, N'Cập Nhật Số Lượng', CAST(0x0000A8D00115F8E6 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
GO
print 'Processed 100 total records'
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (102, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010C4826 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (107, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D4CC1 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (110, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D5361 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (116, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D5671 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (128, N'Cập Nhật Số Lượng', CAST(0x0000A8D001139406 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (134, N'Cập Nhật Số Lượng', CAST(0x0000A8D0011398DA AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (143, N'Cập Nhật Số Lượng', CAST(0x0000A8D001139E20 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (183, N'Cập Nhật Số Lượng', CAST(0x0000A8D00116081B AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (187, N'Cập Nhật Số Lượng', CAST(0x0000A8D0018A7F53 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (188, N'Cập Nhật Số Lượng', CAST(0x0000A8D0018A8028 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (189, N'Cập Nhật Số Lượng', CAST(0x0000A8D0018B1171 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (190, N'Cập Nhật Số Lượng', CAST(0x0000A8D0018B5C20 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (191, N'Cập Nhật Số Lượng', CAST(0x0000A8D0018B5C9A AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (192, N'Cập Nhật Số Lượng', CAST(0x0000A8D0018B5D23 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (193, N'Cập Nhật Số Lượng', CAST(0x0000A8D0018B5D90 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (194, N'Cập Nhật Số Lượng', CAST(0x0000A8D0018B6040 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (195, N'Cập Nhật Số Lượng', CAST(0x0000A8D0018B6200 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (196, N'Cập Nhật Số Lượng', CAST(0x0000A8D0018B628C AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (243, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000F72E8 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (244, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000F735A AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (245, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000F7B60 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 2', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (246, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000F7B6A AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 2', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (247, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000F83B2 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (248, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000F840E AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (249, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000F8E65 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (250, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000F8E6F AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (251, N'Cập Nhật Số Lượng', CAST(0x0000A8D100A8EF33 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 5', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (252, N'Cập Nhật Số Lượng', CAST(0x0000A8D100A8EF33 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 5', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (278, N'Cập Nhật Số Lượng', CAST(0x0000A8D1012225B1 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (279, N'Cập Nhật Số Lượng', CAST(0x0000A8D10122272A AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (280, N'Cập Nhật Số Lượng', CAST(0x0000A8D1012227C2 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (281, N'Cập Nhật Số Lượng', CAST(0x0000A8D101222841 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (282, N'Cập Nhật Số Lượng', CAST(0x0000A8D1012228E6 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (283, N'Cập Nhật Số Lượng', CAST(0x0000A8D10122292C AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (284, N'Cập Nhật Số Lượng', CAST(0x0000A8D10180D670 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 0', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (285, N'Cập Nhật Số Lượng', CAST(0x0000A8D10180D68D AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 0', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (300, N'Cập Nhật Số Lượng', CAST(0x0000A8D10181A898 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 7', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (301, N'Cập Nhật Số Lượng', CAST(0x0000A8D10181BDD8 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: -4', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (302, N'Cập Nhật Số Lượng', CAST(0x0000A8D10181BDF8 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 6', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (303, N'Cập Nhật Số Lượng', CAST(0x0000A8D20006DFC5 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 8', -1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (304, N'Cập Nhật Số Lượng', CAST(0x0000A8D20006E079 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 8', -1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (305, N'Cập Nhật Số Lượng', CAST(0x0000A8D200077826 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (306, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000785E2 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (307, N'Cập Nhật Số Lượng', CAST(0x0000A8D200078BDF AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 5', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (308, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000791C3 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 8', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (309, N'Cập Nhật Số Lượng', CAST(0x0000A8D200079492 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 8', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (310, N'Cập Nhật Số Lượng', CAST(0x0000A8D200079547 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 8', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (311, N'Cập Nhật Số Lượng', CAST(0x0000A8D20007D256 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 5', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (312, N'Cập Nhật Số Lượng', CAST(0x0000A8D20007D58C AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 5', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (313, N'Cập Nhật Số Lượng', CAST(0x0000A8D20007D8ED AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (314, N'Cập Nhật Số Lượng', CAST(0x0000A8D20007DADF AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (112, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D5461 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (122, N'Cập Nhật Số Lượng', CAST(0x0000A8D0010D7096 AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: Bánh Mì ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (130, N'Cập Nhật Số Lượng', CAST(0x0000A8D00113950E AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (145, N'Cập Nhật Số Lượng', CAST(0x0000A8D001139EA4 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (334, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000A4FDE AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 8', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (335, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000A5163 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 8', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (336, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000A52ED AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (337, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000A53D3 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (338, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000A546B AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (339, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000A54DD AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (340, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000A5578 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (341, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000A560F AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (342, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000A569F AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (343, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000A5720 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (344, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000A57BA AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (345, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000A5C7E AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 5', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (346, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000A6189 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (347, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000AE25E AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 8', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (348, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000AFBE7 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 8', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (349, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B2301 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (350, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B2411 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (351, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B2490 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (352, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B24D3 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (353, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B2525 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (354, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B259D AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (355, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B262A AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (356, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B26C1 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (357, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B2B4A AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 5', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (358, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B2D89 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (359, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B2E46 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (360, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B3098 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (361, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B3111 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (362, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B31B2 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (363, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B323D AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (364, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B33B1 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (365, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B344C AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (366, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B4AA4 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (367, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B4AAD AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (368, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B56C7 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (369, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B575E AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (370, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B5B4B AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (371, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000B5B54 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (372, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000BD804 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 6', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (373, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000BDBB1 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 6', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (374, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000BECBD AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 6', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (375, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000BECC6 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 6', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (376, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000D6F7C AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 6', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (377, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000D6F92 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 6', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (378, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000D6F9B AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 6', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (379, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000D6FB0 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 6', 8)
GO
print 'Processed 200 total records'
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (223, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B7CA2 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (224, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B7D2E AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (225, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B800A AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (226, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B8062 AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (227, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B82BE AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (228, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B8350 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (229, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B85F4 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (230, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B8655 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (231, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B86B0 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (232, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B8759 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (233, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B8878 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Bánh Mì ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (234, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B8A1F AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (235, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B8AA4 AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (236, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B8B4A AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (237, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B8BD0 AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (238, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B8F5B AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (239, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B8FBA AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (240, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000B9139 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (241, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000CB9FA AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (242, N'Cập Nhật Số Lượng', CAST(0x0000A8D1000CBA65 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (253, N'Cập Nhật Số Lượng', CAST(0x0000A8D100D8F518 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (254, N'Cập Nhật Số Lượng', CAST(0x0000A8D100DD8BB1 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (255, N'Cập Nhật Số Lượng', CAST(0x0000A8D100DE661D AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (256, N'Cập Nhật Số Lượng', CAST(0x0000A8D100DE6FFB AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (257, N'Cập Nhật Số Lượng', CAST(0x0000A8D100DE74F5 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (258, N'Cập Nhật Số Lượng', CAST(0x0000A8D100DE758D AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (259, N'Cập Nhật Số Lượng', CAST(0x0000A8D100DF1E06 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (260, N'Cập Nhật Số Lượng', CAST(0x0000A8D100DF25BD AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (261, N'Cập Nhật Số Lượng', CAST(0x0000A8D100DF2C1D AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (262, N'Cập Nhật Số Lượng', CAST(0x0000A8D100DF2CBB AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (263, N'Cập Nhật Số Lượng', CAST(0x0000A8D100DF2D38 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (264, N'Cập Nhật Số Lượng', CAST(0x0000A8D100DF4142 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (265, N'Cập Nhật Số Lượng', CAST(0x0000A8D100DF42FC AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (266, N'Cập Nhật Số Lượng', CAST(0x0000A8D100DF4A99 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (267, N'Cập Nhật Số Lượng', CAST(0x0000A8D100DF4B92 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (268, N'Cập Nhật Số Lượng', CAST(0x0000A8D100DF4C0C AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (269, N'Cập Nhật Số Lượng', CAST(0x0000A8D100E31EE5 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (270, N'Cập Nhật Số Lượng', CAST(0x0000A8D100E75C1E AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (271, N'Cập Nhật Số Lượng', CAST(0x0000A8D100E75CF4 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (272, N'Cập Nhật Số Lượng', CAST(0x0000A8D100EB1D41 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (273, N'Cập Nhật Số Lượng', CAST(0x0000A8D100EB1DF9 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (274, N'Cập Nhật Số Lượng', CAST(0x0000A8D100EB2652 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 2', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (275, N'Cập Nhật Số Lượng', CAST(0x0000A8D100EB4103 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (276, N'Cập Nhật Số Lượng', CAST(0x0000A8D100EB4BD6 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 5', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (277, N'Cập Nhật Số Lượng', CAST(0x0000A8D100EB5063 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 4', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (286, N'Cập Nhật Số Lượng', CAST(0x0000A8D101814DDC AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 0', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (287, N'Cập Nhật Số Lượng', CAST(0x0000A8D101814DFB AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: -2', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (288, N'Cập Nhật Số Lượng', CAST(0x0000A8D1018156D5 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 5', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (289, N'Cập Nhật Số Lượng', CAST(0x0000A8D1018156EA AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: -3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (290, N'Cập Nhật Số Lượng', CAST(0x0000A8D1018156F3 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 4', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (291, N'Cập Nhật Số Lượng', CAST(0x0000A8D101815708 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 0', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (292, N'Cập Nhật Số Lượng', CAST(0x0000A8D101816825 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: -3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (293, N'Cập Nhật Số Lượng', CAST(0x0000A8D101816843 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 4', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (294, N'Cập Nhật Số Lượng', CAST(0x0000A8D101817A5E AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: -3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (295, N'Cập Nhật Số Lượng', CAST(0x0000A8D101817A68 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 4', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (296, N'Cập Nhật Số Lượng', CAST(0x0000A8D101817A7D AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 4', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (297, N'Cập Nhật Số Lượng', CAST(0x0000A8D1018184BE AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 8', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (298, N'Cập Nhật Số Lượng', CAST(0x0000A8D1018184D3 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: -6', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (299, N'Cập Nhật Số Lượng', CAST(0x0000A8D1018184F2 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 7', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (327, N'Cập Nhật Số Lượng', CAST(0x0000A8D200098487 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 8', -1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (328, N'Cập Nhật Số Lượng', CAST(0x0000A8D200099DCB AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 8', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (329, N'Cập Nhật Số Lượng', CAST(0x0000A8D20009A4BA AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 8', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (330, N'Cập Nhật Số Lượng', CAST(0x0000A8D20009A5BA AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 8', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (331, N'Cập Nhật Số Lượng', CAST(0x0000A8D20009A867 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 8', -1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (332, N'Cập Nhật Số Lượng', CAST(0x0000A8D20009A984 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 8', -1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (333, N'Cập Nhật Số Lượng', CAST(0x0000A8D20009B09A AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 8', 5)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (380, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000E674A AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (381, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000E675F AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (382, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000E6769 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (383, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000E677D AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (384, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000E7807 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: -3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (385, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000E7825 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: -3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (390, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000F3144 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (391, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000F3196 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (392, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000F358F AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (393, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000F35F7 AS DateTime), N' Bàn: Bàn 2 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (394, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000F3ACB AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 2', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (395, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000F3AD1 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 2', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (396, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000F4814 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (397, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000F60C0 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (398, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000F7B17 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: 2', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (399, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000F8626 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (400, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000F8672 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (401, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000FDEAF AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (402, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000FE4EF AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (403, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000FE7D0 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (404, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000FE846 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (405, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000FF14D AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (406, N'Cập Nhật Số Lượng', CAST(0x0000A8D200103A53 AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (407, N'Cập Nhật Số Lượng', CAST(0x0000A8D200110CCD AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 2', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (408, N'Cập Nhật Số Lượng', CAST(0x0000A8D200111AA4 AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (409, N'Cập Nhật Số Lượng', CAST(0x0000A8D200111B22 AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (410, N'Cập Nhật Số Lượng', CAST(0x0000A8D20011524D AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (411, N'Cập Nhật Số Lượng', CAST(0x0000A8D20011DF19 AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (412, N'Cập Nhật Số Lượng', CAST(0x0000A8D20011E7D3 AS DateTime), N' Bàn: Bàn 3 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (413, N'Cập Nhật Số Lượng', CAST(0x0000A8D2001A1931 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (414, N'Cập Nhật Số Lượng', CAST(0x0000A8D2001A5EB9 AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (415, N'Cập Nhật Số Lượng', CAST(0x0000A8D2001A652A AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (416, N'Cập Nhật Số Lượng', CAST(0x0000A8D2001A652B AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: 7 Up ;Số Lượng: 0', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (417, N'Cập Nhật Số Lượng', CAST(0x0000A8D2001A6CD6 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 0', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (418, N'Cập Nhật Số Lượng', CAST(0x0000A8D2001A7BE8 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
GO
print 'Processed 300 total records'
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (315, N'Cập Nhật Số Lượng', CAST(0x0000A8D20007DBB0 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (316, N'Cập Nhật Số Lượng', CAST(0x0000A8D20007DC6B AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (317, N'Cập Nhật Số Lượng', CAST(0x0000A8D20007DDFF AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 1', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (318, N'Cập Nhật Số Lượng', CAST(0x0000A8D20007DECE AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 1', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (319, N'Cập Nhật Số Lượng', CAST(0x0000A8D20007DF6C AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (320, N'Cập Nhật Số Lượng', CAST(0x0000A8D20007DFDB AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 1', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (321, N'Cập Nhật Số Lượng', CAST(0x0000A8D20007E06D AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (322, N'Cập Nhật Số Lượng', CAST(0x0000A8D20007E0DC AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 1', 1)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (323, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000865C8 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (324, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000866FF AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (325, N'Cập Nhật Số Lượng', CAST(0x0000A8D200086B39 AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: 7 Up ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (326, N'Cập Nhật Số Lượng', CAST(0x0000A8D200086DAF AS DateTime), N' Bàn: Bàn 5 ;Hàng Hóa: Cafe ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (386, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000EA5ED AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: 7 Up ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (387, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000EA6CE AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: Cafe ;Số Lượng: -1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (388, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000EA7C8 AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: 7 Up ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (389, N'Cập Nhật Số Lượng', CAST(0x0000A8D2000EA856 AS DateTime), N' Bàn: Bàn 6 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (419, N'Cập Nhật Số Lượng', CAST(0x0000A8D2001A7BE9 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 1', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (420, N'Cập Nhật Số Lượng', CAST(0x0000A8D2001A87CD AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (421, N'Cập Nhật Số Lượng', CAST(0x0000A8D2001A87D7 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 2', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (422, N'Cập Nhật Số Lượng', CAST(0x0000A8D2001A91A2 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: 7 Up ;Số Lượng: 3', 8)
INSERT [dbo].[CF_LichSuThaoTac] ([ID], [HoatDong], [ThoiGian], [ChiTiet], [IDNhanVien]) VALUES (423, N'Cập Nhật Số Lượng', CAST(0x0000A8D2001A91A2 AS DateTime), N' Bàn: Bàn 1 ;Hàng Hóa: Cafe ;Số Lượng: 2', 8)
SET IDENTITY_INSERT [dbo].[CF_LichSuThaoTac] OFF
/****** Object:  Table [dbo].[CF_KhuVuc]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_KhuVuc](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MaKhuVuc] [nvarchar](50) NULL,
	[KyHieu] [nvarchar](50) NULL,
	[TenKhuVuc] [nvarchar](250) NULL,
	[GiaKhuVuc] [float] NULL,
	[IDChiNhanh] [int] NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
	[GhiChu] [nvarchar](250) NULL,
	[IDBangGia] [int] NULL,
 CONSTRAINT [PK_CF_KhuVuc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CF_KhuVuc] ON
INSERT [dbo].[CF_KhuVuc] ([ID], [MaKhuVuc], [KyHieu], [TenKhuVuc], [GiaKhuVuc], [IDChiNhanh], [NgayCapNhat], [DaXoa], [GhiChu], [IDBangGia]) VALUES (1, N'KA', N'KA', N'Khu A', NULL, 0, CAST(0x0000A8CF008C0B50 AS DateTime), 0, N'', 2)
INSERT [dbo].[CF_KhuVuc] ([ID], [MaKhuVuc], [KyHieu], [TenKhuVuc], [GiaKhuVuc], [IDChiNhanh], [NgayCapNhat], [DaXoa], [GhiChu], [IDBangGia]) VALUES (2, N'KB', N'KB', N'Khu B', NULL, 0, CAST(0x0000A8CF0096497C AS DateTime), 0, N'', 2)
SET IDENTITY_INSERT [dbo].[CF_KhuVuc] OFF
/****** Object:  Table [dbo].[CF_KetCa]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_KetCa](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ThoiGianBatDau] [datetime] NULL,
	[ThoiGianKetThuc] [datetime] NULL,
	[TongTienSauCa] [float] NULL,
	[IDNhanVien] [int] NULL,
	[IDChiNhanh] [int] NULL,
	[TongTien] [float] NULL,
	[GiamGia] [float] NULL,
 CONSTRAINT [PK_CF_KetCa] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CF_KetCa] ON
INSERT [dbo].[CF_KetCa] ([ID], [ThoiGianBatDau], [ThoiGianKetThuc], [TongTienSauCa], [IDNhanVien], [IDChiNhanh], [TongTien], [GiamGia]) VALUES (9, CAST(0x0000A8AC00EB6B30 AS DateTime), CAST(0x0000A8AC00EBEF86 AS DateTime), 198000, 7, 0, 208000, 10000)
INSERT [dbo].[CF_KetCa] ([ID], [ThoiGianBatDau], [ThoiGianKetThuc], [TongTienSauCa], [IDNhanVien], [IDChiNhanh], [TongTien], [GiamGia]) VALUES (10, CAST(0x0000A8AC00ECC994 AS DateTime), CAST(0x0000A8AC00ED264C AS DateTime), 72000, 7, 0, 83000, 11000)
INSERT [dbo].[CF_KetCa] ([ID], [ThoiGianBatDau], [ThoiGianKetThuc], [TongTienSauCa], [IDNhanVien], [IDChiNhanh], [TongTien], [GiamGia]) VALUES (11, CAST(0x0000A8AC00EF3EE0 AS DateTime), CAST(0x0000A8AC00F31978 AS DateTime), 2458600, 7, 0, 2588000, 129400)
INSERT [dbo].[CF_KetCa] ([ID], [ThoiGianBatDau], [ThoiGianKetThuc], [TongTienSauCa], [IDNhanVien], [IDChiNhanh], [TongTien], [GiamGia]) VALUES (12, CAST(0x0000A8AC00F0549C AS DateTime), CAST(0x0000A8AC00FA05B8 AS DateTime), 262000, 7, 0, 272000, 10000)
INSERT [dbo].[CF_KetCa] ([ID], [ThoiGianBatDau], [ThoiGianKetThuc], [TongTienSauCa], [IDNhanVien], [IDChiNhanh], [TongTien], [GiamGia]) VALUES (13, CAST(0x0000A8AC00FEA2B8 AS DateTime), CAST(0x0000A8AF008AEBF2 AS DateTime), 64000, 7, 0, 64000, 0)
INSERT [dbo].[CF_KetCa] ([ID], [ThoiGianBatDau], [ThoiGianKetThuc], [TongTienSauCa], [IDNhanVien], [IDChiNhanh], [TongTien], [GiamGia]) VALUES (14, CAST(0x0000A8AF008B4520 AS DateTime), CAST(0x0000A8AF008B52C9 AS DateTime), 50000, 7, 0, 59000, 9000)
INSERT [dbo].[CF_KetCa] ([ID], [ThoiGianBatDau], [ThoiGianKetThuc], [TongTienSauCa], [IDNhanVien], [IDChiNhanh], [TongTien], [GiamGia]) VALUES (15, CAST(0x0000A8C001222170 AS DateTime), CAST(0x0000A8C600D73CA1 AS DateTime), 163000, 7, 0, 163000, 0)
SET IDENTITY_INSERT [dbo].[CF_KetCa] OFF
/****** Object:  Table [dbo].[CF_HangHoa]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_HangHoa](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHangHoa] [nvarchar](50) NULL,
	[TenHangHoa] [nvarchar](250) NULL,
	[GiaBan] [float] NULL,
	[IDDonViTinh] [int] NULL,
	[IDNhomHang] [int] NULL,
	[DaXoa] [int] NULL,
	[NgayCapNhat] [datetime] NULL,
	[GhiChu] [nvarchar](250) NULL,
	[IDChiNhanh] [int] NULL,
 CONSTRAINT [PK_CF_HangHoa] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CF_HangHoa] ON
INSERT [dbo].[CF_HangHoa] ([ID], [MaHangHoa], [TenHangHoa], [GiaBan], [IDDonViTinh], [IDNhomHang], [DaXoa], [NgayCapNhat], [GhiChu], [IDChiNhanh]) VALUES (1, N'1', N'7 Up', 10000, 71, 78, 0, CAST(0x0000A8CF0089178F AS DateTime), N'', 0)
INSERT [dbo].[CF_HangHoa] ([ID], [MaHangHoa], [TenHangHoa], [GiaBan], [IDDonViTinh], [IDNhomHang], [DaXoa], [NgayCapNhat], [GhiChu], [IDChiNhanh]) VALUES (2, N'2', N'Cơm Tấm', 20000, 38, 79, 0, CAST(0x0000A8CF008931B4 AS DateTime), N'', 0)
INSERT [dbo].[CF_HangHoa] ([ID], [MaHangHoa], [TenHangHoa], [GiaBan], [IDDonViTinh], [IDNhomHang], [DaXoa], [NgayCapNhat], [GhiChu], [IDChiNhanh]) VALUES (3, N'3', N'Cafe', 15000, 36, 78, 0, CAST(0x0000A8CF008A1EDC AS DateTime), N'', 0)
INSERT [dbo].[CF_HangHoa] ([ID], [MaHangHoa], [TenHangHoa], [GiaBan], [IDDonViTinh], [IDNhomHang], [DaXoa], [NgayCapNhat], [GhiChu], [IDChiNhanh]) VALUES (4, N'4', N'Bánh Mì', 15000, 35, 78, 0, CAST(0x0000A8CF008BE050 AS DateTime), N'', 0)
SET IDENTITY_INSERT [dbo].[CF_HangHoa] OFF
/****** Object:  Table [dbo].[CF_Gio]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_Gio](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaGio] [nvarchar](50) NULL,
	[TyLe] [int] NULL,
	[GioBatDau] [datetime] NULL,
	[GioKetThuc] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
 CONSTRAINT [PK_CF_Gio] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CF_DonViTinh]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_DonViTinh](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenDonViTinh] [nvarchar](255) NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
	[IDChiNhanh] [int] NULL,
 CONSTRAINT [PK_CF_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CF_DonViTinh] ON
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (35, N'CÁI', CAST(0x0000A8AA00C3868B AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (36, N'LY', CAST(0x0000A8AA00C38BAA AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (37, N'CHÉN', CAST(0x0000A8AA00C39090 AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (38, N'DĨA', CAST(0x0000A8AA00C3955A AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (39, N'TÔ', CAST(0x0000A8AA00C39A50 AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (40, N'LON', CAST(0x0000A8AA00C39F3C AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (71, N'CHAI', CAST(0x0000A8AA00F7031C AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (72, N'KG', CAST(0x0000A8AA00F710CA AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (73, N'BIT', CAST(0x0000A8AA00F7187A AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (74, N'GIO', CAST(0x0000A8AA00F72AAE AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (75, N'BAO', CAST(0x0000A8AA00F7355B AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (76, N'HỘP', CAST(0x0000A8AA00F74DED AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (77, N'GÓI', CAST(0x0000A8AA00F7711D AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (78, N'ĐIẾU', CAST(0x0000A8AA00F77F4E AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (79, N'TRÁI', CAST(0x0000A8AA00F7868B AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (80, N'GIỎ', CAST(0x0000A8AA00F7B01B AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (81, N'ML', CAST(0x0000A8AA00F7CD09 AS DateTime), 0, 0)
INSERT [dbo].[CF_DonViTinh] ([ID], [TenDonViTinh], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (82, N'CA', CAST(0x0000A8AA00F7D466 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[CF_DonViTinh] OFF
/****** Object:  Table [dbo].[CF_DatBan]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_DatBan](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenKhachHang] [nvarchar](150) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[GioDat] [nvarchar](150) NULL,
	[IDBan] [int] NULL,
	[IDChiNhanh] [int] NULL,
 CONSTRAINT [PK_CF_DatBan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CF_Ban]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_Ban](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenBan] [nvarchar](250) NULL,
	[IDKhuVuc] [int] NULL,
	[TrangThai] [int] NULL,
	[NgayCapNhat] [datetime] NULL,
	[IDChiNhanh] [int] NULL,
	[DaXoa] [int] NULL,
	[MaBan] [nvarchar](50) NULL,
 CONSTRAINT [PK_CF_Ban] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CF_Ban] ON
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (1, N'Bàn 1', 1, 2, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (2, N'Bàn 2', 1, 2, CAST(0x0000A8CF008A8ACA AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (3, N'Bàn 3', 1, 2, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (4, N'Bàn 4', 1, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (5, N'Bàn 5', 1, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (6, N'Bàn 6', 1, 2, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (7, N'Bàn 7', 1, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (8, N'Bàn 8', 1, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (9, N'Bàn 9', 1, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (10, N'Bàn 10', 1, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (11, N'Bàn 11', 1, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (12, N'Bàn 12', 2, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (13, N'Bàn 13', 2, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (14, N'Bàn 14', 2, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (15, N'Bàn 15', 2, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (16, N'Bàn 16', 2, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (17, N'Bàn 17', 2, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (18, N'Bàn 18', 2, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (19, N'Bàn 19', 2, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (20, N'Bàn 20', 2, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (21, N'Bàn 21', 2, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (22, N'Bàn 22', 2, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
INSERT [dbo].[CF_Ban] ([ID], [TenBan], [IDKhuVuc], [TrangThai], [NgayCapNhat], [IDChiNhanh], [DaXoa], [MaBan]) VALUES (23, N'Bàn 23', 2, 0, CAST(0x0000A8CF008A7DA9 AS DateTime), 0, 0, NULL)
SET IDENTITY_INSERT [dbo].[CF_Ban] OFF
/****** Object:  Table [dbo].[CF_ChiTietHoaDon]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_ChiTietHoaDon](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IDHoaDon] [int] NULL,
	[IDHangHoa] [int] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[ThanhTien] [float] NULL,
	[IDBan] [int] NULL,
	[MaHangHoa] [nvarchar](50) NULL,
	[IDDonViTinh] [int] NULL,
	[TrongLuong] [float] NULL,
	[IDChiNhanh] [int] NULL,
 CONSTRAINT [PK_CF_ChiTietHoaDon_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CF_ChiTietGio]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_ChiTietGio](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GioBatDau] [datetime] NULL,
	[GioKetThuc] [datetime] NULL,
	[TongGioChoi] [nvarchar](255) NULL,
	[DonGia] [float] NULL,
	[ThanhTien] [float] NULL,
	[IDBan] [int] NULL,
	[IDHoaDon] [int] NULL,
	[TrangThai] [int] NULL,
	[ThanhToan] [int] NULL,
 CONSTRAINT [PK_CF_ChiTietGio] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CF_ChiTietBangGia]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_ChiTietBangGia](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IDBangGia] [int] NULL,
	[IDHangHoa] [int] NULL,
	[GiaCu] [float] NULL,
	[GiaMoi] [float] NULL,
	[DaXoa] [int] NULL,
	[IDChiNhanh] [int] NULL,
 CONSTRAINT [PK_CF_ChiTietBangGia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CF_ChiTietBangGia] ON
INSERT [dbo].[CF_ChiTietBangGia] ([ID], [IDBangGia], [IDHangHoa], [GiaCu], [GiaMoi], [DaXoa], [IDChiNhanh]) VALUES (1, 1, 1, 10000, 10000, 0, 0)
INSERT [dbo].[CF_ChiTietBangGia] ([ID], [IDBangGia], [IDHangHoa], [GiaCu], [GiaMoi], [DaXoa], [IDChiNhanh]) VALUES (2, 1, 2, 20000, 20000, 0, 0)
INSERT [dbo].[CF_ChiTietBangGia] ([ID], [IDBangGia], [IDHangHoa], [GiaCu], [GiaMoi], [DaXoa], [IDChiNhanh]) VALUES (3, 1, 3, 15000, 15000, 0, 0)
INSERT [dbo].[CF_ChiTietBangGia] ([ID], [IDBangGia], [IDHangHoa], [GiaCu], [GiaMoi], [DaXoa], [IDChiNhanh]) VALUES (4, 2, 1, 10000, 10000, 0, 0)
INSERT [dbo].[CF_ChiTietBangGia] ([ID], [IDBangGia], [IDHangHoa], [GiaCu], [GiaMoi], [DaXoa], [IDChiNhanh]) VALUES (5, 2, 2, 20000, 20000, 0, 0)
INSERT [dbo].[CF_ChiTietBangGia] ([ID], [IDBangGia], [IDHangHoa], [GiaCu], [GiaMoi], [DaXoa], [IDChiNhanh]) VALUES (6, 2, 3, 15000, 15000, 0, 0)
INSERT [dbo].[CF_ChiTietBangGia] ([ID], [IDBangGia], [IDHangHoa], [GiaCu], [GiaMoi], [DaXoa], [IDChiNhanh]) VALUES (7, 2, 4, 15000, 15000, 0, 0)
SET IDENTITY_INSERT [dbo].[CF_ChiTietBangGia] OFF
/****** Object:  Table [dbo].[CF_ChiNhanh]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_ChiNhanh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaChiNhanh] [nvarchar](50) NULL,
	[TenChiNhanh] [nvarchar](250) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[NgayMo] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
	[ReportBill] [int] NULL,
	[MayIn] [nvarchar](255) NULL,
	[GiaoDienApDung] [int] NULL,
	[DuLieuMau] [int] NULL,
	[KeyCaiDat] [nvarchar](250) NULL,
	[Email] [nvarchar](250) NULL,
 CONSTRAINT [PK_CF_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CF_ChiNhanh] ON
INSERT [dbo].[CF_ChiNhanh] ([ID], [MaChiNhanh], [TenChiNhanh], [DienThoai], [DiaChi], [NgayMo], [NgayCapNhat], [DaXoa], [ReportBill], [MayIn], [GiaoDienApDung], [DuLieuMau], [KeyCaiDat], [Email]) VALUES (0, N'0', N'Caffe GPM', N'02966.275.595 - 0902.777.186', N'198B10, Hàm Nghi, Bình Khánh, Long Xuyên', CAST(0x0000A8C400000000 AS DateTime), CAST(0x0000A8CE0110D5F9 AS DateTime), 0, 80, N'', 0, 1, N'MW1BS-A0K3I-VA7W1-YJUWQ-M8GNK', N'vudt@gpm.vn')
SET IDENTITY_INSERT [dbo].[CF_ChiNhanh] OFF
/****** Object:  StoredProcedure [dbo].[pro_GetTemp]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_GetTemp]
AS
BEGIN
	IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='dbo' AND TABLE_NAME='temp')
	SELECT * FROM temp
END
GO
/****** Object:  StoredProcedure [dbo].[rp_ActiveBan]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[rp_ActiveBan]
@id bigint
as
BEGIN
	DECLARE @chechDaXoa int
	SELECT @chechDaXoa =DaXoa FROM dbo.CF_Ban WHERE ID=@id
	if(@chechDaXoa<=0)
	UPDATE dbo.CF_Ban SET DaXoa=1 WHERE ID=@id
	ELSE
	UPDATE dbo.CF_Ban SET DaXoa=0 WHERE ID=@id
END
GO
/****** Object:  StoredProcedure [dbo].[rp_UpInBan]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/**************************************************************************/
/*******************************BAN*********************************/
/**************************************************************************/
CREATE PROC [dbo].[rp_UpInBan]
			@id bigint
           ,@TenBan nvarchar(250)
           ,@IDKhuVuc bigint
as
BEGIN
DECLARE @checkNull INT
DECLARE @checkDuplicate INT
DECLARE @NgayCapNhat DATETIME
	SET @NgayCapNhat = GETDATE()
	select @checkNull = COUNT(*) from dbo.CF_Ban where id=@id
	select @checkDuplicate = COUNT(*) from dbo.CF_Ban where TenBan=@TenBan and ID <> @id
 
  IF(@checkDuplicate>0)
 return -1
 ELSE
 IF(@checkNull>0)
 BEGIN
UPDATE [dbo].[CF_Ban]
   SET [TenBan] = @TenBan
      ,[IDKhuVuc] = @IDKhuVuc
      ,[NgayCapNhat] = @NgayCapNhat
	  WHERE id=@id
 END
 ELSE
 BEGIN
INSERT INTO [dbo].[CF_Ban]
           ([TenBan]
           ,[IDKhuVuc]
           ,[NgayCapNhat]
           )
     VALUES
           (@TenBan
           ,@IDKhuVuc
           ,@NgayCapNhat)
 END
END
GO
/****** Object:  Table [dbo].[CF_BangGia]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_BangGia](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenBangGia] [nvarchar](250) NULL,
	[NgayCapNhat] [datetime] NULL,
	[DaXoa] [int] NULL,
	[IDChiNhanh] [int] NULL,
 CONSTRAINT [PK_CF_BangGia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CF_BangGia] ON
INSERT [dbo].[CF_BangGia] ([ID], [TenBangGia], [NgayCapNhat], [DaXoa], [IDChiNhanh]) VALUES (2, N'Bảng Giá 1', CAST(0x0000A8CF008BFB27 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[CF_BangGia] OFF
/****** Object:  Table [dbo].[CF_HoaDon]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_HoaDon](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[GioVao] [datetime] NULL,
	[GioRa] [datetime] NULL,
	[IDBan] [int] NULL,
	[TrangThai] [int] NULL,
	[MaHoaDon] [nvarchar](50) NULL,
	[IDNhanVien] [int] NULL,
	[TongTien] [float] NULL,
	[GiamGia] [float] NULL,
	[KhachCanTra] [float] NULL,
	[KhachThanhToan] [float] NULL,
	[TienThua] [float] NULL,
	[TienGio] [float] NULL,
	[TrangThaiKetCa] [int] NULL,
	[LanIn] [int] NULL,
	[HinhThucGiamGia] [nvarchar](50) NULL,
	[TienGiamGia] [float] NULL,
	[TyLeGiamGia] [float] NULL,
	[NgayBan] [datetime] NULL,
	[IDChiNhanh] [int] NULL,
 CONSTRAINT [PK_CF_HoaDon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CF_HoaDon] ON
INSERT [dbo].[CF_HoaDon] ([ID], [GioVao], [GioRa], [IDBan], [TrangThai], [MaHoaDon], [IDNhanVien], [TongTien], [GiamGia], [KhachCanTra], [KhachThanhToan], [TienThua], [TienGio], [TrangThaiKetCa], [LanIn], [HinhThucGiamGia], [TienGiamGia], [TyLeGiamGia], [NgayBan], [IDChiNhanh]) VALUES (123, CAST(0x0000A8D2000F44D1 AS DateTime), NULL, 1, 0, NULL, 8, 60000, 0, 60000, 0, 0, 0, 0, 0, N'$', 0, 0, CAST(0x0000A8D2000F44D1 AS DateTime), 0)
INSERT [dbo].[CF_HoaDon] ([ID], [GioVao], [GioRa], [IDBan], [TrangThai], [MaHoaDon], [IDNhanVien], [TongTien], [GiamGia], [KhachCanTra], [KhachThanhToan], [TienThua], [TienGio], [TrangThaiKetCa], [LanIn], [HinhThucGiamGia], [TienGiamGia], [TyLeGiamGia], [NgayBan], [IDChiNhanh]) VALUES (124, CAST(0x0000A8D2000F47CE AS DateTime), NULL, 3, 0, NULL, 8, 10000, 0, 10000, 0, 0, 0, 0, 0, N'$', 0, 0, CAST(0x0000A8D2000F47CE AS DateTime), 0)
INSERT [dbo].[CF_HoaDon] ([ID], [GioVao], [GioRa], [IDBan], [TrangThai], [MaHoaDon], [IDNhanVien], [TongTien], [GiamGia], [KhachCanTra], [KhachThanhToan], [TienThua], [TienGio], [TrangThaiKetCa], [LanIn], [HinhThucGiamGia], [TienGiamGia], [TyLeGiamGia], [NgayBan], [IDChiNhanh]) VALUES (132, CAST(0x0000A8D2001A6CD5 AS DateTime), NULL, 2, 0, NULL, 8, 20000, 0, 20000, 0, 0, 0, 0, 0, N'$', 0, 0, CAST(0x0000A8D2001A6CD5 AS DateTime), 0)
INSERT [dbo].[CF_HoaDon] ([ID], [GioVao], [GioRa], [IDBan], [TrangThai], [MaHoaDon], [IDNhanVien], [TongTien], [GiamGia], [KhachCanTra], [KhachThanhToan], [TienThua], [TienGio], [TrangThaiKetCa], [LanIn], [HinhThucGiamGia], [TienGiamGia], [TyLeGiamGia], [NgayBan], [IDChiNhanh]) VALUES (134, CAST(0x0000A8D2001A91A1 AS DateTime), NULL, 6, 0, NULL, 8, 25000, 0, 25000, 0, 0, 0, 0, 0, N'$', 0, 0, CAST(0x0000A8D2001A91A1 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[CF_HoaDon] OFF
/****** Object:  StoredProcedure [dbo].[rp_ActiveTongChi]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[rp_ActiveTongChi]
@id bigint
as
BEGIN
	DECLARE @chechDaXoa int
	SELECT @chechDaXoa =DaXoa FROM dbo.CF_TongChi WHERE ID=@id
	if(@chechDaXoa<=0)
	UPDATE dbo.CF_TongChi SET DaXoa=1 WHERE ID=@id
	ELSE
	UPDATE dbo.CF_TongChi SET DaXoa=0 WHERE ID=@id
END
GO
/****** Object:  StoredProcedure [dbo].[rp_ActiveNhomHangHoa]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[rp_ActiveNhomHangHoa]
@id bigint
as
BEGIN
	DECLARE @chechDaXoa int
	SELECT @chechDaXoa =DaXoa FROM dbo.CF_NhomHangHoa WHERE ID=@id
	if(@chechDaXoa<=0)
	UPDATE dbo.CF_NhomHangHoa SET DaXoa=1 WHERE ID=@id
	ELSE
	UPDATE dbo.CF_NhomHangHoa SET DaXoa=0 WHERE ID=@id
END
GO
/****** Object:  StoredProcedure [dbo].[rp_ActiveNguoiDung]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[rp_ActiveNguoiDung]
@id bigint
as
BEGIN
	DECLARE @chechDaXoa int
	SELECT @chechDaXoa =DaXoa FROM dbo.CF_NguoiDung WHERE ID=@id
	if(@chechDaXoa<=0)
	UPDATE dbo.CF_NguoiDung SET DaXoa=1 WHERE ID=@id
	ELSE
	UPDATE dbo.CF_NguoiDung SET DaXoa=0 WHERE ID=@id
END
GO
/****** Object:  StoredProcedure [dbo].[rp_ActiveKhuVuc]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[rp_ActiveKhuVuc]
@id bigint
as
BEGIN
	DECLARE @chechDaXoa int
	SELECT @chechDaXoa =DaXoa FROM dbo.CF_KhuVuc WHERE ID=@id
	if(@chechDaXoa<=0)
	UPDATE dbo.CF_KhuVuc SET DaXoa=1 WHERE ID=@id
	ELSE
	UPDATE dbo.CF_KhuVuc SET DaXoa=0 WHERE ID=@id
END
GO
/****** Object:  StoredProcedure [dbo].[rp_ActiveHangHoa]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[rp_ActiveHangHoa]
@id bigint
as
BEGIN
	DECLARE @chechDaXoa int
	SELECT @chechDaXoa =DaXoa FROM dbo.CF_HangHoa WHERE ID=@id
	if(@chechDaXoa<=0)
	UPDATE dbo.CF_HangHoa SET DaXoa=1 WHERE ID=@id
	ELSE
	UPDATE dbo.CF_HangHoa SET DaXoa=0 WHERE ID=@id
END
GO
/****** Object:  StoredProcedure [dbo].[rp_ActiveDonViTinh]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[rp_ActiveDonViTinh]
@id bigint
as
BEGIN
	DECLARE @chechDaXoa int
	SELECT @chechDaXoa =DaXoa FROM dbo.CF_DonViTinh WHERE ID=@id
	if(@chechDaXoa<=0)
	UPDATE dbo.CF_DonViTinh SET DaXoa=1 WHERE ID=@id
	ELSE
	UPDATE dbo.CF_DonViTinh SET DaXoa=0 WHERE ID=@id
END
GO
/****** Object:  StoredProcedure [dbo].[rp_ActiveChiTietBangGia]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[rp_ActiveChiTietBangGia]
@id bigint
as
BEGIN
	DECLARE @chechDaXoa int
	SELECT @chechDaXoa =DaXoa FROM dbo.[CF_ChiTietBangGia] WHERE ID=@id
	if(@chechDaXoa<=0)
	UPDATE dbo.[CF_ChiTietBangGia] SET DaXoa=1 WHERE ID=@id
	ELSE
	UPDATE dbo.[CF_ChiTietBangGia] SET DaXoa=0 WHERE ID=@id
END
GO
/****** Object:  StoredProcedure [dbo].[rp_UpInTongChi]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/**************************************************************************/
/*******************************TONG CHI*********************************/
/**************************************************************************/
CREATE PROC [dbo].[rp_UpInTongChi]
			@id bigint
			,@LoaiChi nvarchar(250)
			,@TienChi float
			,@NgayChi datetime
as
BEGIN
DECLARE @checkNull INT
DECLARE @checkDuplicate INT
DECLARE @NgayCapNhat DATETIME
	SET @NgayCapNhat = GETDATE()
	select @checkNull = COUNT(*) from dbo.CF_TongChi where id=@id
	/*select @checkDuplicate = COUNT(*) from dbo.CF_TongChi where LoaiChi=@LoaiChi and ID <> @id
 
  IF(@checkDuplicate>0)
 return -1
 ELSE*/
 IF(@checkNull>0)
 BEGIN
UPDATE [dbo].[CF_TongChi]
   SET [LoaiChi] = @LoaiChi
      ,[TienChi] = @TienChi
      ,[NgayChi] = @NgayChi
      ,[NgayCapNhat] = @NgayCapNhat
	  WHERE id=@id
 END
 ELSE
 BEGIN
	INSERT INTO [gpm_codeCaFeMienPhi].[dbo].[CF_TongChi]
           ([LoaiChi]
           ,[TienChi]
           ,[NgayChi]
           ,[NgayCapNhat])
     VALUES
           (@LoaiChi
           ,@TienChi
           ,@NgayChi
           ,@NgayCapNhat)
  END
END
GO
/****** Object:  StoredProcedure [dbo].[rp_UpInNhomHangHoa]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/**************************************************************************/
/*******************************NHOM HANG HOA*********************************/
/**************************************************************************/
CREATE PROC [dbo].[rp_UpInNhomHangHoa]
			@id bigint
           ,@TenNhom nvarchar(250)
           ,@GhiChu nvarchar(250)
as
BEGIN
DECLARE @checkNull INT
DECLARE @checkDuplicate INT
DECLARE @NgayCapNhat DATETIME
	SET @NgayCapNhat = GETDATE()
	select @checkNull = COUNT(*) from dbo.CF_NhomHangHoa where id=@id
	select @checkDuplicate = COUNT(*) from dbo.CF_NhomHangHoa where TenNhom=@TenNhom and ID <> @id
 
  IF(@checkDuplicate>0)
 return -1
 ELSE
 IF(@checkNull>0)
 BEGIN
UPDATE [dbo].[CF_NhomHangHoa]
   SET [TenNhom] = @TenNhom
      ,[GhiChu] = @GhiChu
      ,[NgayCapNhat] = @NgayCapNhat
	  WHERE id=@id
 END
 ELSE
 BEGIN
	INSERT INTO [dbo].[CF_NhomHangHoa]
           ([TenNhom]
           ,[GhiChu]
           ,[NgayCapNhat])
     VALUES
           (@TenNhom
           ,@GhiChu
           ,@NgayCapNhat)
  END
END
GO
/****** Object:  StoredProcedure [dbo].[rp_UpInNguoiDung]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/**************************************************************************/
/*******************************NHOM HANG HOA*********************************/
/**************************************************************************/
CREATE PROC [dbo].[rp_UpInNguoiDung]
			@id bigint
          ,@MaNhanVien nvarchar(50)
		  ,@TenNguoiDung nvarchar(250)
		  ,@TenDangNhap nvarchar(250)
		  ,@SDT nvarchar(50)
		  ,@MatKhau nvarchar(255)
		  ,@IDNhomNguoiDung int
as
BEGIN
DECLARE @checkNull INT
DECLARE @checkDuplicate INT
DECLARE @NgayCapNhat DATETIME
	SET @NgayCapNhat = GETDATE()
	select @checkNull = COUNT(*) from dbo.CF_NguoiDung where id=@id
	select @checkDuplicate = COUNT(*) from dbo.CF_NguoiDung where (TenDangNhap=@TenDangNhap or MaNhanVien=@MaNhanVien) and ID <> @id
 
  IF(@checkDuplicate>0)
 return -1
 ELSE
 IF(@checkNull>0)
 BEGIN
 IF(@MatKhau!='null')
 BEGIN
 UPDATE [gpm_codeCaFeMienPhi].[dbo].[CF_NguoiDung]
			   SET [MaNhanVien] = @MaNhanVien
				  ,[TenNguoiDung] = @TenNguoiDung
				  ,[TenDangNhap] = @TenDangNhap
				  ,[SDT] = @SDT
				  ,[MatKhau] = @MatKhau
				  ,[IDNhomNguoiDung] = @IDNhomNguoiDung
				  ,[NgayCapNhat] = @NgayCapNhat
				  WHERE id=@id
 END
 ELSE
 BEGIN
  UPDATE [gpm_codeCaFeMienPhi].[dbo].[CF_NguoiDung]
			   SET [MaNhanVien] = @MaNhanVien
				  ,[TenNguoiDung] = @TenNguoiDung
				  ,[TenDangNhap] = @TenDangNhap
				  ,[SDT] = @SDT
				  ,[IDNhomNguoiDung] = @IDNhomNguoiDung
				  ,[NgayCapNhat] = @NgayCapNhat
				  WHERE id=@id
 END
			
 END
 ELSE
 BEGIN
	INSERT INTO [gpm_codeCaFeMienPhi].[dbo].[CF_NguoiDung]
           ([MaNhanVien]
           ,[TenNguoiDung]
           ,[TenDangNhap]
           ,[SDT]
           ,[MatKhau]
           ,[IDNhomNguoiDung]
           ,[NgayCapNhat])
     VALUES
           (@MaNhanVien
           ,@TenNguoiDung
           ,@TenDangNhap
           ,@SDT
           ,@MatKhau
           ,@IDNhomNguoiDung
           ,@NgayCapNhat)
  END
END
GO
/****** Object:  StoredProcedure [dbo].[rp_UpInKhuVuc]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/**************************************************************************/
/*******************************KHU VUC*********************************/
/**************************************************************************/
CREATE PROC [dbo].[rp_UpInKhuVuc]
			 @id bigint
			,@MaKhuVuc nvarchar(50)
			,@KyHieu nvarchar(50)
			,@TenKhuVuc nvarchar(250)
			,@GhiChu nvarchar(250)
			,@IDBangGia int
as
BEGIN
DECLARE @checkNull INT
DECLARE @checkDuplicate INT
DECLARE @NgayCapNhat DATETIME
	SET @NgayCapNhat = GETDATE()
	select @checkNull = COUNT(*) from dbo.CF_KhuVuc where id=@id
	select @checkDuplicate = COUNT(*) from dbo.CF_KhuVuc where TenKhuVuc=@TenKhuVuc and ID <> @id
 
  IF(@checkDuplicate>0)
 return -1
 ELSE
 IF(@checkNull>0)
 BEGIN
	UPDATE [dbo].[CF_KhuVuc]
   SET [MaKhuVuc] = @MaKhuVuc
      ,[KyHieu] = @KyHieu
      ,[TenKhuVuc] = @TenKhuVuc
      ,[NgayCapNhat] = @NgayCapNhat
      ,[GhiChu] = @GhiChu
      ,[IDBangGia] = @IDBangGia
	  WHERE id=@id
 END
 ELSE
 BEGIN

 INSERT INTO [dbo].[CF_KhuVuc]
           ([MaKhuVuc]
           ,[KyHieu]
           ,[TenKhuVuc]
           ,[NgayCapNhat]
           ,[GhiChu]
           ,[IDBangGia])
     VALUES
           (@MaKhuVuc
           ,@KyHieu
           ,@TenKhuVuc         
           ,@NgayCapNhat
           ,@GhiChu
           ,@IDBangGia)
 END
END
GO
/****** Object:  StoredProcedure [dbo].[rp_UpInHangHoa]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[rp_UpInHangHoa]
			 @id bigint
			,@MaHangHoa nvarchar(50)
			,@TenHangHoa nvarchar(250)
			,@GiaBan float
			,@IDDonViTinh  bigint
			,@IDNhomHang  bigint
			,@GhiChu nvarchar(250)
			,@IDNguoiDung BIGINT
as
BEGIN
DECLARE @checkNull INT
DECLARE @checkDuplicate INT
DECLARE @NgayCapNhat DATETIME
DECLARE @GiaCu FLOAT
	SET @NgayCapNhat = GETDATE()
	select @checkNull = ID,@GiaCu=GiaBan from dbo.CF_HangHoa where id=@id
	select @checkDuplicate = COUNT(*) from dbo.CF_HangHoa where MaHangHoa=@MaHangHoa and IDNhomHang=@IDNhomHang and ID <> @id
 
  IF(@checkDuplicate>0)
 return -1
 ELSE
 IF(@checkNull>0)
 BEGIN
UPDATE [gpm_codeCaFeMienPhi].[dbo].[CF_HangHoa]
   SET [MaHangHoa] = @MaHangHoa
	  ,[TenHangHoa] = @TenHangHoa
      ,[GiaBan] = @GiaBan
      ,[IDDonViTinh] = @IDDonViTinh
      ,[IDNhomHang] = @IDNhomHang
      ,[GhiChu] = @GhiChu
      ,[NgayCapNhat] = @NgayCapNhat
	  WHERE id=@id
	--Them vao bang chi tiet hang hoa
	INSERT INTO [dbo].[CF_LichSuThayDoiGia]
           ([IDNguoiDung]
           ,[MaHang]
           ,[TenHang]
           ,[IDDVT]
           ,[GiaCu]
           ,[GiaMoi]
           ,[NgayThayDoi])
     VALUES
           (@IDNguoiDung
           ,@MaHangHoa
           ,@TenHangHoa
           ,@IDDonViTinh
           ,@GiaCu
           ,@GiaBan
           ,@NgayCapNhat)
	  
 END
 ELSE
 BEGIN
	INSERT INTO [gpm_codeCaFeMienPhi].[dbo].[CF_HangHoa]
           ([MaHangHoa]
		   ,[TenHangHoa]
           ,[GiaBan]
           ,[IDDonViTinh]
           ,[IDNhomHang]
           ,[NgayCapNhat]
           ,[GhiChu]
           )
     VALUES
           (@MaHangHoa
           ,@TenHangHoa
           ,@GiaBan
           ,@IDDonViTinh
           ,@IDNhomHang          
           ,@NgayCapNhat
           ,@GhiChu)
   --Them vao bang chi tiet hang hoa
	INSERT INTO [dbo].[CF_LichSuThayDoiGia]
           ([IDNguoiDung]
           ,[MaHang]
           ,[TenHang]
           ,[IDDVT]
           ,[GiaCu]
           ,[GiaMoi]
           ,[NgayThayDoi])
     VALUES
           (@IDNguoiDung
           ,@MaHangHoa
           ,@TenHangHoa
           ,@IDDonViTinh
           ,@GiaBan
           ,@GiaBan
           ,@NgayCapNhat)
  END
END
GO
/****** Object:  StoredProcedure [dbo].[rp_UpInDonViTinh]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/********************PROCEDUE**************************/
/**************************************************************************/
/******************************* DONVITINH*********************************/
/**************************************************************************/
CREATE PROC [dbo].[rp_UpInDonViTinh]
@id bigint,
@TenDonViTinh nvarchar(255)
as
BEGIN
DECLARE @checkNull INT
DECLARE @checkDuplicate INT
DECLARE @NgayCapNhat DATETIME
	SET @NgayCapNhat = GETDATE()
	select @checkNull = COUNT(*) from dbo.CF_DonViTinh where id=@id
	select @checkDuplicate = COUNT(*) from dbo.CF_DonViTinh where TenDonViTinh=@TenDonViTinh and ID <> @id
 IF(@checkNull>0)
 BEGIN
	UPDATE [dbo].[CF_DonViTinh]
   SET [TenDonViTinh] =@TenDonViTinh
      ,[NgayCapNhat] = @NgayCapNhat
	  WHERE id=@id
 END
 ELSE
 BEGIN
 IF(@checkDuplicate>0)
 return -1
 ELSE
 INSERT INTO [dbo].[CF_DonViTinh]
           ([TenDonViTinh]
           ,[NgayCapNhat])
     VALUES
           (@TenDonViTinh
           ,@NgayCapNhat)
 END
 
END
GO
/****** Object:  StoredProcedure [dbo].[rp_UpInChiTietBangGia]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/**************************************************************************/
/*******************************Chi Tiet Bang Gia*********************************/
/**************************************************************************/
CREATE PROC [dbo].[rp_UpInChiTietBangGia]
			 @ID bigint
			,@GiaMoi float
			,@IDBangGia bigint
			,@IDHangHoa bigint
			,@IDNguoiDung bigint
as
BEGIN
DECLARE @TenHang nvarchar(50)
DECLARE @IDDVT INT
DECLARE @GiaCu FLOAT
DECLARE @NgayCapNhat DATETIME
	SET @NgayCapNhat = GETDATE()
	SELECT @TenHang=TenHangHoa,@IDDVT=IDDonViTinh FROM CF_HangHoa WHERE ID=@IDHangHoa
	SELECT @GiaCu=GiaMoi FROM [dbo].[CF_ChiTietBangGia] WHERE ID=@ID

UPDATE [dbo].[CF_ChiTietBangGia]
   SET [GiaMoi] = @GiaMoi
	  WHERE id=@ID
	  	  
	  INSERT INTO [dbo].[CF_LichSuThayDoiGia]
           ([IDNguoiDung]
           ,[MaHang]
           ,[TenHang]
           ,[IDDVT]
           ,[GiaCu]
           ,[GiaMoi]
           ,[NgayThayDoi])
     VALUES
           (@IDNguoiDung
           ,@IDHangHoa
           ,@TenHang
           ,@IDDVT
           ,@GiaCu
           ,@GiaMoi
           ,@NgayCapNhat)
END
GO
/****** Object:  StoredProcedure [dbo].[rp_UpInBangGia]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/**************************************************************************/
/*******************************BANG GIA*********************************/
/**************************************************************************/
CREATE PROC [dbo].[rp_UpInBangGia]
@id bigint,
@TenBangGia nvarchar(255)
as
BEGIN
DECLARE @checkNull INT
DECLARE @checkDuplicate INT
DECLARE @NgayCapNhat DATETIME
	SET @NgayCapNhat = GETDATE()
	select @checkNull = COUNT(*) from dbo.CF_BangGia where id=@id
	select @checkDuplicate = COUNT(*) from dbo.CF_BangGia where TenBangGia=@TenBangGia and ID <> @id
  IF(@checkDuplicate>0)
 return -1
 ELSE
 IF(@checkNull>0)
 BEGIN
 
 
	UPDATE [dbo].[CF_BangGia]
   SET [TenBangGia] =@TenBangGia
      ,[NgayCapNhat] = @NgayCapNhat
	  WHERE id=@id
	  
	  
 END
 ELSE
 BEGIN
 INSERT INTO [dbo].[CF_BangGia]
           ([TenBangGia]
           ,[NgayCapNhat])
     VALUES
           (@TenBangGia
           ,@NgayCapNhat)
 END
 
END
GO
/****** Object:  StoredProcedure [dbo].[rp_ActiveBangGia]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[rp_ActiveBangGia]
@id bigint
as
BEGIN
	DECLARE @chechDaXoa int
	SELECT @chechDaXoa =DaXoa FROM dbo.CF_BangGia WHERE ID=@id
	if(@chechDaXoa<=0)
	UPDATE dbo.CF_BangGia SET DaXoa=1 WHERE ID=@id
	ELSE
	UPDATE dbo.CF_BangGia SET DaXoa=0 WHERE ID=@id
END
GO
/****** Object:  Table [dbo].[CF_ChiTietHoaDon_Temp]    Script Date: 04/30/2018 08:06:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CF_ChiTietHoaDon_Temp](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IDHoaDon] [int] NULL,
	[IDHangHoa] [int] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[ThanhTien] [float] NULL,
	[IDBan] [int] NULL,
	[TrongLuong] [float] NULL,
	[IDChiNhanh] [int] NULL,
 CONSTRAINT [PK_CF_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CF_ChiTietHoaDon_Temp] ON
INSERT [dbo].[CF_ChiTietHoaDon_Temp] ([ID], [IDHoaDon], [IDHangHoa], [SoLuong], [DonGia], [ThanhTien], [IDBan], [TrongLuong], [IDChiNhanh]) VALUES (163, 123, 1, 3, 10000, 30000, 1, 0, NULL)
INSERT [dbo].[CF_ChiTietHoaDon_Temp] ([ID], [IDHoaDon], [IDHangHoa], [SoLuong], [DonGia], [ThanhTien], [IDBan], [TrongLuong], [IDChiNhanh]) VALUES (164, 123, 3, 2, 15000, 30000, 1, 0, NULL)
INSERT [dbo].[CF_ChiTietHoaDon_Temp] ([ID], [IDHoaDon], [IDHangHoa], [SoLuong], [DonGia], [ThanhTien], [IDBan], [TrongLuong], [IDChiNhanh]) VALUES (170, 124, 1, 1, 10000, 10000, 3, 0, NULL)
INSERT [dbo].[CF_ChiTietHoaDon_Temp] ([ID], [IDHoaDon], [IDHangHoa], [SoLuong], [DonGia], [ThanhTien], [IDBan], [TrongLuong], [IDChiNhanh]) VALUES (176, 132, 1, 2, 10000, 20000, 2, 0, NULL)
INSERT [dbo].[CF_ChiTietHoaDon_Temp] ([ID], [IDHoaDon], [IDHangHoa], [SoLuong], [DonGia], [ThanhTien], [IDBan], [TrongLuong], [IDChiNhanh]) VALUES (179, 134, 1, 1, 10000, 10000, 6, 0, NULL)
INSERT [dbo].[CF_ChiTietHoaDon_Temp] ([ID], [IDHoaDon], [IDHangHoa], [SoLuong], [DonGia], [ThanhTien], [IDBan], [TrongLuong], [IDChiNhanh]) VALUES (180, 134, 3, 1, 15000, 15000, 6, 0, NULL)
SET IDENTITY_INSERT [dbo].[CF_ChiTietHoaDon_Temp] OFF
/****** Object:  StoredProcedure [dbo].[pr_updateSL]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pr_updateSL]
@KiemTra INT,
@IDHoaDon BIGINT,
@IDHangHoa BIGINT,
@IDNhanVien BIGINT,
@SoLuong INT
AS
BEGIN
	DECLARE @KiemTraSoLuong INT
	DECLARE @TongTien FLOAT
	DECLARE @KiemTraHoaDon INT
	DECLARE @IDBan BIGINT
	DECLARE @TenHangHoa NVARCHAR(250)
	DECLARE @ChiTiet NVARCHAR(MAX)
	DECLARE @HoatDong NVARCHAR(MAX)
	DECLARE @ID BIGINT
	DECLARE @TenBan NVARCHAR(250)
	DECLARE @KiemTraHangHoaTonTai INT
	SELECT @KiemTraHangHoaTonTai=COUNT(*) FROM CF_ChiTietHoaDon_Temp WHERE IDHoaDon=@IDHoaDon and IDHangHoa=@IDHangHoa	
	SELECT @ID = ID , @IDBan=IDBan FROM CF_ChiTietHoaDon_Temp WHERE IDHoaDon=@IDHoaDon and IDHangHoa=@IDHangHoa
	SELECT @TenHangHoa=TenHangHoa FROm CF_HangHoa WHERE ID = @IDHangHoa
	SELECT @TenBan=TenBan FROM CF_Ban WHERE ID=@IDBan
	
	--1:cong them so luong ,0: gan so luong bang
	if(@KiemTra=1)
	SELECT @KiemTraSoLuong = (SoLuong+@SoLuong) FROM CF_ChiTietHoaDon_Temp WHERE ID=@ID
	ELSE
	SET @KiemTraSoLuong = @SoLuong
	
	SELECT @KiemTraHoaDon = COUNT(*) FROM CF_ChiTietHoaDon_Temp WHERE IDHoaDon=@IDHoaDon
	SET @ChiTiet = N' Bàn: '+@TenBan +N' ;Hàng Hóa: '+@TenHangHoa+N' ;Số Lượng: '+CAST(@SoLuong as NVARCHAR(50))
	SET @HoatDong = N'Cập Nhật Số Lượng'
	--Khi so luong lon hon 0
	IF(@KiemTraHangHoaTonTai>0)
	BEGIN
	IF(@KiemTraSoLuong>0)
	BEGIN
		UPDATE CF_ChiTietHoaDon_Temp SET SoLuong=@KiemTraSoLuong,ThanhTien=(DonGia*@KiemTraSoLuong) WHERE ID=@ID
	END
	ELSE
	BEGIN
			DELETE CF_ChiTietHoaDon_Temp WHERE ID=@ID
			IF(@KiemTraHoaDon=1)
			BEGIN
			 DELETE CF_HoaDon WHERE ID=@IDHoaDon
			 UPDATE CF_Ban SET TrangThai=0 WHERE ID=@IDBan
			END
	END
	INSERT INTO [CF_LichSuThaoTac]
			   ([HoatDong]
			   ,[ThoiGian]
			   ,[ChiTiet]
			   ,[IDNhanVien])
		 VALUES
			   (@HoatDong
			   ,GETDATE()
			   ,@ChiTiet
			   ,@IDNhanVien)
		END	
	SELECT @TongTien = SUM(ThanhTien) FROM CF_ChiTietHoaDon_Temp WHERE IDHoaDon=@IDHoaDon
	UPDATE CF_HoaDon SET TongTien = @TongTien, KhachCanTra=@TongTien WHERE ID=@IDHoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[pr_GopBan]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pr_GopBan]
@IDBan1 INT ,@IDBan2 INT ,@IDNhanVien BIGINT 
AS
BEGIN

	DECLARE @IDHoaDon1 int
	DECLARE @IDHoaDon2 int 
	
	DECLARE @KiemTraIDBan1 int =1
	DECLARE @KiemTraIDBan2 int =1
	
	 SELECT @IDHoaDon2 = id FROM dbo.CF_HoaDon WHERE IDBan= @IDBan2 AND TrangThai=0 -- int
	 SELECT @IDHoaDon1 = id FROM dbo.CF_HoaDon WHERE IDBan= @IDBan1 AND TrangThai=0 -- int
	
	IF(@IDHoaDon1 IS NULL)
	BEGIN
		INSERT INTO CF_HoaDon
		([GioVao]
           ,[IDBan]
           ,[IDNhanVien]
           ,[NgayBan])
           VALUES
           (GETDATE()
           ,@IDBan1
           ,@IDNhanVien
           ,GETDATE())
		SELECT @IDHoaDon1 = MAX(id) FROM dbo.CF_HoaDon WHERE IDBan=@IDBan1 AND TrangThai=0					
	END	
	SELECT @KiemTraIDBan1 = COUNT(*) FROM CF_ChiTietHoaDon_Temp WHERE IDHoaDon=@IDHoaDon1
	IF(@IDHoaDon2 IS NULL)
	BEGIN
		INSERT INTO CF_HoaDon
		([GioVao]
           ,[IDBan]
           ,[IDNhanVien]
           ,[NgayBan])
           VALUES
           (GETDATE()
           ,@IDBan2
           ,@IDNhanVien
           ,GETDATE())
		    SELECT @IDHoaDon2 = MAX(id) FROM dbo.CF_HoaDon WHERE IDBan=@IDBan2 AND TrangThai=0			
		END
	SELECT @KiemTraIDBan2 = COUNT(*) FROM CF_ChiTietHoaDon_Temp WHERE IDHoaDon=@IDHoaDon2
		
	IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='dbo' AND TABLE_NAME='temp')
	DROP TABLE temp
	
	SELECT * INTO temp FROM dbo.CF_ChiTietHoaDon_Temp WHERE IDHoaDon=@IDHoaDon1 AND IDHangHoa in(SELECT IDHangHoa FROM dbo.CF_ChiTietHoaDon_Temp WHERE IDHoaDon=@IDHoaDon2)
	UPDATE temp SET IDHoaDon= @IDHoaDon2
	
	DELETE dbo.CF_ChiTietHoaDon_Temp WHERE IDHangHoa in(SELECT IDHangHoa FROM dbo.CF_ChiTietHoaDon_Temp WHERE IDHoaDon=@IDHoaDon2) AND IDHoaDon=@IDHoaDon1
	UPDATE dbo.CF_ChiTietHoaDon_Temp SET IDHoaDon = @IDHoaDon2 WHERE IDHoaDon = @IDHoaDon1
	
	DELETE dbo.CF_HoaDon WHERE id =@IDHoaDon1
	 
	UPDATE dbo.CF_Ban SET TrangThai=0 WHERE id = @IDBan1

END
GO
/****** Object:  StoredProcedure [dbo].[pr_ChuyenBan]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROC [dbo].[pr_ChuyenBan]
@IDBan1 INT ,@IDBan2 INT, @IDNhanVien BIGINT
AS
BEGIN

	DECLARE @IDHoaDon1 int
	DECLARE @IDHoaDon2 int 
	
	DECLARE @KiemTraIDBan1 int =1
	DECLARE @KiemTraIDBan2 int =1
	
	 SELECT @IDHoaDon2 = id FROM dbo.CF_HoaDon WHERE IDBan= @IDBan2 AND TrangThai=0
	 SELECT @IDHoaDon1 = id FROM dbo.CF_HoaDon WHERE IDBan= @IDBan1 AND TrangThai=0
	
	IF(@IDHoaDon1 IS NULL)
	BEGIN
		INSERT INTO CF_HoaDon
		([GioVao]
           ,[IDBan]
           ,[IDNhanVien]
           ,[NgayBan])
           VALUES
           (GETDATE()
           ,@IDBan1
           ,@IDNhanVien
           ,GETDATE())
		SELECT @IDHoaDon1 = MAX(id) FROM dbo.CF_HoaDon WHERE IDBan=@IDBan1 AND TrangThai=0					
	END
	
	SELECT @KiemTraIDBan1 = COUNT(*) FROM CF_ChiTietHoaDon_Temp WHERE IDHoaDon=@IDHoaDon1
	
		
	IF(@IDHoaDon2 IS NULL)
	BEGIN
		INSERT INTO CF_HoaDon
		([GioVao]
           ,[IDBan]
           ,[IDNhanVien]
           ,[NgayBan])
           VALUES
           (GETDATE()
           ,@IDBan2
           ,@IDNhanVien
           ,GETDATE())
		    SELECT @IDHoaDon2 = MAX(id) FROM dbo.CF_HoaDon WHERE IDBan=@IDBan2 AND TrangThai=0				
		END
	SELECT @KiemTraIDBan2 = COUNT(*) FROM CF_ChiTietHoaDon_Temp WHERE IDHoaDon=@IDHoaDon2
		
	SELECT id INTO TempTable1 FROM dbo.CF_ChiTietHoaDon_Temp WHERE IDHoaDon=@IDHoaDon2
	
	UPDATE dbo.CF_ChiTietHoaDon_Temp SET IDHoaDon = @IDHoaDon2 WHERE IDHoaDon = @IDHoaDon1
	
	UPDATE dbo.CF_ChiTietHoaDon_Temp SET IDHoaDon = @IDHoaDon1 WHERE id IN (SELECT * FROM TempTable1)
	
	DROP TABLE TempTable1
	
	IF(@KiemTraIDBan1=0)
	BEGIN
		DELETE dbo.CF_HoaDon WHERE id =@IDHoaDon2
		UPDATE dbo.CF_Ban SET TrangThai= 0 WHERE id = @IDBan2
	END
	
	IF(@KiemTraIDBan2=0)
	BEGIN
		DELETE dbo.CF_HoaDon WHERE id =@IDHoaDon1
		UPDATE dbo.CF_Ban SET TrangThai=0 WHERE id = @IDBan1
	END
	END
GO
/****** Object:  StoredProcedure [dbo].[rp_GoiMon]    Script Date: 04/30/2018 08:06:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[rp_GoiMon]
@IDBan BIGINT,
@IDHangHoa BIGINT,
@SoLuong INT,
@IDNhanVien BIGINT
AS
BEGIN
	DECLARE @IDHoaDon BIGINT
	DECLARE @IDKhuVuc BIGINT
	DECLARE @IDBangGia BIGINT
	DECLARE @TrangThaiBan BIGINT
	DECLARE @KiemTraHangTonTai INT
	DECLARE @DonGia FLOAT
	DECLARE @TongTien FLOAT
	SELECT @TrangThaiBan = TrangThai FROM CF_Ban WHERE ID=@IDBan
	SELECT @IDKhuVuc = IDKhuVuc FROM CF_Ban WHERE ID=@IDBan
	SELECT @IDBangGia = IDBangGia FROM CF_KhuVuc WHERE ID=@IDKhuVuc
	--kiem tra hang hoa co nam trong ban chi tiet hang hoa hay khong va lay gia ban
	IF(@IDBangGia!=0)
	SELECT @DonGia = GiaMoi FROM CF_ChiTietBangGia WHERE IDBangGia=@IDBangGia and IDHangHoa=@IDHangHoa
	ELSE
	SELECT @DonGia = GiaBan FROM CF_HangHoa WHERE ID=@IDHangHoa
	--ban da co nguoi
	IF(@TrangThaiBan=2)
	BEGIN
		SELECT @IDHoaDon=ID FROM CF_HoaDon WHERE IDBan=@IDBan and TrangThai=0
		SELECT @KiemTraHangTonTai=COUNT(*) FROM CF_ChiTietHoaDon_Temp WHERE IDHangHoa = @IDHangHoa and IDHoaDon=@IDHoaDon
		IF(@KiemTraHangTonTai>0)
		BEGIN
			EXEC pr_updateSL 1,@IDHoaDon,@IDHangHoa,@IDNhanVien,@SoLuong
		END
		ELSE
		BEGIN
			INSERT INTO [gpm_codeCaFeMienPhi].[dbo].[CF_ChiTietHoaDon_Temp]
           ([IDHoaDon]
           ,[IDHangHoa]
           ,[SoLuong]
           ,[DonGia]
           ,[ThanhTien]
           ,[IDBan])
           VALUES
           (@IDHoaDon
           ,@IDHangHoa
           ,@SoLuong
           ,@DonGia
           ,(@DonGia*@SoLuong)
           ,@IDBan)
		END	
	END
	--ban chua co nguoi
	ELSE
	BEGIN
		INSERT INTO CF_HoaDon
		([GioVao]
           ,[IDBan]
           ,[IDNhanVien]
           ,[NgayBan])
           VALUES
           (GETDATE()
           ,@IDBan
           ,@IDNhanVien
           ,GETDATE())
           --Update CF_Ban SET TrangThai=2 WHERE ID=@IDBan
           SELECT @IDHoaDon = MAX(id) FROM CF_HoaDon WHERE IDBan=@IDBan and TrangThai=0  
           INSERT INTO [gpm_codeCaFeMienPhi].[dbo].[CF_ChiTietHoaDon_Temp]
           ([IDHoaDon]
           ,[IDHangHoa]
           ,[SoLuong]
           ,[DonGia]
           ,[ThanhTien]
           ,[IDBan])
           VALUES
           (@IDHoaDon
           ,@IDHangHoa
           ,@SoLuong
           ,@DonGia
           ,(@DonGia*@SoLuong)
           ,@IDBan)
           SELECT @TongTien = SUM(ThanhTien) FROM CF_ChiTietHoaDon_Temp WHERE IDHoaDon=@IDHoaDon 
	END
	SELECT @TongTien = SUM(ThanhTien) FROM CF_ChiTietHoaDon_Temp WHERE IDHoaDon=@IDHoaDon
	UPDATE CF_HoaDon SET TongTien = @TongTien, KhachCanTra=@TongTien WHERE ID=@IDHoaDon
END
GO
/****** Object:  Default [DF_CF_Ban_TrangThai]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_Ban] ADD  CONSTRAINT [DF_CF_Ban_TrangThai]  DEFAULT ((0)) FOR [TrangThai]
GO
/****** Object:  Default [DF_CF_Ban_IDChiNhanh]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_Ban] ADD  CONSTRAINT [DF_CF_Ban_IDChiNhanh]  DEFAULT ((0)) FOR [IDChiNhanh]
GO
/****** Object:  Default [DF_CF_Ban_DaXoa]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_Ban] ADD  CONSTRAINT [DF_CF_Ban_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
/****** Object:  Default [DF_CF_BangGia_DaXoa]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_BangGia] ADD  CONSTRAINT [DF_CF_BangGia_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
/****** Object:  Default [DF_CF_BangGia_IDChiNhanh]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_BangGia] ADD  CONSTRAINT [DF_CF_BangGia_IDChiNhanh]  DEFAULT ((0)) FOR [IDChiNhanh]
GO
/****** Object:  Default [DF_CF_ChiNhanh_DaXoa]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_ChiNhanh] ADD  CONSTRAINT [DF_CF_ChiNhanh_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
/****** Object:  Default [DF_CF_ChiNhanh_ReportBill]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_ChiNhanh] ADD  CONSTRAINT [DF_CF_ChiNhanh_ReportBill]  DEFAULT ((80)) FOR [ReportBill]
GO
/****** Object:  Default [DF_CF_ChiNhanh_GiaoDienApDung]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_ChiNhanh] ADD  CONSTRAINT [DF_CF_ChiNhanh_GiaoDienApDung]  DEFAULT ((0)) FOR [GiaoDienApDung]
GO
/****** Object:  Default [DF_CF_ChiNhanh_TaoDaTaMau]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_ChiNhanh] ADD  CONSTRAINT [DF_CF_ChiNhanh_TaoDaTaMau]  DEFAULT ((0)) FOR [DuLieuMau]
GO
/****** Object:  Default [DF_CF_ChiTietBangGia_DaXoa]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_ChiTietBangGia] ADD  CONSTRAINT [DF_CF_ChiTietBangGia_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
/****** Object:  Default [DF_CF_ChiTietBangGia_IDChiNhanh]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_ChiTietBangGia] ADD  CONSTRAINT [DF_CF_ChiTietBangGia_IDChiNhanh]  DEFAULT ((0)) FOR [IDChiNhanh]
GO
/****** Object:  Default [DF_CF_ChiTietGio_DonGia]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_ChiTietGio] ADD  CONSTRAINT [DF_CF_ChiTietGio_DonGia]  DEFAULT ((0)) FOR [DonGia]
GO
/****** Object:  Default [DF_CF_ChiTietGio_ThanhTien]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_ChiTietGio] ADD  CONSTRAINT [DF_CF_ChiTietGio_ThanhTien]  DEFAULT ((0)) FOR [ThanhTien]
GO
/****** Object:  Default [DF_CF_ChiTietGio_TrangThai]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_ChiTietGio] ADD  CONSTRAINT [DF_CF_ChiTietGio_TrangThai]  DEFAULT ((0)) FOR [TrangThai]
GO
/****** Object:  Default [DF_CF_ChiTietGio_ThanhToan]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_ChiTietGio] ADD  CONSTRAINT [DF_CF_ChiTietGio_ThanhToan]  DEFAULT ((0)) FOR [ThanhToan]
GO
/****** Object:  Default [DF_CF_ChiTietHoaDon_SoLuong]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_ChiTietHoaDon] ADD  CONSTRAINT [DF_CF_ChiTietHoaDon_SoLuong]  DEFAULT ((0)) FOR [SoLuong]
GO
/****** Object:  Default [DF_CF_ChiTietHoaDon_DonGia]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_ChiTietHoaDon] ADD  CONSTRAINT [DF_CF_ChiTietHoaDon_DonGia]  DEFAULT ((0)) FOR [DonGia]
GO
/****** Object:  Default [DF_CF_ChiTietHoaDon_ThanhTien]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_ChiTietHoaDon] ADD  CONSTRAINT [DF_CF_ChiTietHoaDon_ThanhTien]  DEFAULT ((0)) FOR [ThanhTien]
GO
/****** Object:  Default [DF_CF_ChiTietHoaDon_TrongLuong]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_ChiTietHoaDon] ADD  CONSTRAINT [DF_CF_ChiTietHoaDon_TrongLuong]  DEFAULT ((0)) FOR [TrongLuong]
GO
/****** Object:  Default [DF_CF_ChiTietHoaDon_Temp_TrongLuong]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_ChiTietHoaDon_Temp] ADD  CONSTRAINT [DF_CF_ChiTietHoaDon_Temp_TrongLuong]  DEFAULT ((0)) FOR [TrongLuong]
GO
/****** Object:  Default [DF_CF_DonViTinh_DaXoa]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_DonViTinh] ADD  CONSTRAINT [DF_CF_DonViTinh_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
/****** Object:  Default [DF_CF_DonViTinh_IDChiNhanh]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_DonViTinh] ADD  CONSTRAINT [DF_CF_DonViTinh_IDChiNhanh]  DEFAULT ((0)) FOR [IDChiNhanh]
GO
/****** Object:  Default [DF_CF_Gio_TyLe]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_Gio] ADD  CONSTRAINT [DF_CF_Gio_TyLe]  DEFAULT ((0)) FOR [TyLe]
GO
/****** Object:  Default [DF_CF_HangHoa_DaXoa]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_HangHoa] ADD  CONSTRAINT [DF_CF_HangHoa_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
/****** Object:  Default [DF_CF_HangHoa_IDChiNhanh]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_HangHoa] ADD  CONSTRAINT [DF_CF_HangHoa_IDChiNhanh]  DEFAULT ((0)) FOR [IDChiNhanh]
GO
/****** Object:  Default [DF_CF_HoaDon_TrangThai]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_HoaDon] ADD  CONSTRAINT [DF_CF_HoaDon_TrangThai]  DEFAULT ((0)) FOR [TrangThai]
GO
/****** Object:  Default [DF_CF_HoaDon_TongTien]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_HoaDon] ADD  CONSTRAINT [DF_CF_HoaDon_TongTien]  DEFAULT ((0)) FOR [TongTien]
GO
/****** Object:  Default [DF_CF_HoaDon_GiamGia]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_HoaDon] ADD  CONSTRAINT [DF_CF_HoaDon_GiamGia]  DEFAULT ((0)) FOR [GiamGia]
GO
/****** Object:  Default [DF_CF_HoaDon_KhachCanTra]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_HoaDon] ADD  CONSTRAINT [DF_CF_HoaDon_KhachCanTra]  DEFAULT ((0)) FOR [KhachCanTra]
GO
/****** Object:  Default [DF_CF_HoaDon_KhachThanhToan]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_HoaDon] ADD  CONSTRAINT [DF_CF_HoaDon_KhachThanhToan]  DEFAULT ((0)) FOR [KhachThanhToan]
GO
/****** Object:  Default [DF_CF_HoaDon_TienThua]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_HoaDon] ADD  CONSTRAINT [DF_CF_HoaDon_TienThua]  DEFAULT ((0)) FOR [TienThua]
GO
/****** Object:  Default [DF_CF_HoaDon_TienGio]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_HoaDon] ADD  CONSTRAINT [DF_CF_HoaDon_TienGio]  DEFAULT ((0)) FOR [TienGio]
GO
/****** Object:  Default [DF_CF_HoaDon_TrangThaiKetCa]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_HoaDon] ADD  CONSTRAINT [DF_CF_HoaDon_TrangThaiKetCa]  DEFAULT ((0)) FOR [TrangThaiKetCa]
GO
/****** Object:  Default [DF_CF_HoaDon_LanIn]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_HoaDon] ADD  CONSTRAINT [DF_CF_HoaDon_LanIn]  DEFAULT ((0)) FOR [LanIn]
GO
/****** Object:  Default [DF_CF_HoaDon_HinhThucGiamGia]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_HoaDon] ADD  CONSTRAINT [DF_CF_HoaDon_HinhThucGiamGia]  DEFAULT ('$') FOR [HinhThucGiamGia]
GO
/****** Object:  Default [DF_CF_HoaDon_TienGiamGia]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_HoaDon] ADD  CONSTRAINT [DF_CF_HoaDon_TienGiamGia]  DEFAULT ((0)) FOR [TienGiamGia]
GO
/****** Object:  Default [DF_CF_HoaDon_TyLeGiamGia]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_HoaDon] ADD  CONSTRAINT [DF_CF_HoaDon_TyLeGiamGia]  DEFAULT ((0)) FOR [TyLeGiamGia]
GO
/****** Object:  Default [DF_CF_HoaDon_IDChiNhanh]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_HoaDon] ADD  CONSTRAINT [DF_CF_HoaDon_IDChiNhanh]  DEFAULT ((0)) FOR [IDChiNhanh]
GO
/****** Object:  Default [DF_CF_KetCa_TongTienSauCa]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_KetCa] ADD  CONSTRAINT [DF_CF_KetCa_TongTienSauCa]  DEFAULT ((0)) FOR [TongTienSauCa]
GO
/****** Object:  Default [DF_CF_KetCa_TienGio]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_KetCa] ADD  CONSTRAINT [DF_CF_KetCa_TienGio]  DEFAULT ((0)) FOR [TongTien]
GO
/****** Object:  Default [DF_CF_KetCa_TienNuoc]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_KetCa] ADD  CONSTRAINT [DF_CF_KetCa_TienNuoc]  DEFAULT ((0)) FOR [GiamGia]
GO
/****** Object:  Default [DF_CF_KhuVuc_IDChiNhanh]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_KhuVuc] ADD  CONSTRAINT [DF_CF_KhuVuc_IDChiNhanh]  DEFAULT ((0)) FOR [IDChiNhanh]
GO
/****** Object:  Default [DF_CF_KhuVuc_DaXoa]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_KhuVuc] ADD  CONSTRAINT [DF_CF_KhuVuc_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
/****** Object:  Default [DF_CF_KhuVuc_IDBangGia]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_KhuVuc] ADD  CONSTRAINT [DF_CF_KhuVuc_IDBangGia]  DEFAULT ((0)) FOR [IDBangGia]
GO
/****** Object:  Default [DF_CF_LichSuThayDoiGia_IDChiNhanh]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_LichSuThayDoiGia] ADD  CONSTRAINT [DF_CF_LichSuThayDoiGia_IDChiNhanh]  DEFAULT ((0)) FOR [IDChiNhanh]
GO
/****** Object:  Default [DF_CF_NguoiDung_DaXoa]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_NguoiDung] ADD  CONSTRAINT [DF_CF_NguoiDung_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
/****** Object:  Default [DF_CF_NguoiDung_IDChiNhanh]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_NguoiDung] ADD  CONSTRAINT [DF_CF_NguoiDung_IDChiNhanh]  DEFAULT ((0)) FOR [IDChiNhanh]
GO
/****** Object:  Default [DF_CF_NhomHangHoa_DaXoa]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_NhomHangHoa] ADD  CONSTRAINT [DF_CF_NhomHangHoa_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
/****** Object:  Default [DF_CF_NhomHangHoa_IDChiNhanh]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_NhomHangHoa] ADD  CONSTRAINT [DF_CF_NhomHangHoa_IDChiNhanh]  DEFAULT ((0)) FOR [IDChiNhanh]
GO
/****** Object:  Default [DF_CF_TongChi_DaXoa]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[CF_TongChi] ADD  CONSTRAINT [DF_CF_TongChi_DaXoa]  DEFAULT ((0)) FOR [DaXoa]
GO
/****** Object:  Default [DF_Setting_TinhGio]    Script Date: 04/30/2018 08:06:02 ******/
ALTER TABLE [dbo].[Setting] ADD  CONSTRAINT [DF_Setting_TinhGio]  DEFAULT ((0)) FOR [TinhGio]
GO
