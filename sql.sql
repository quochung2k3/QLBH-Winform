USE [master]
GO
/****** Object:  Database [Winform]    Script Date: 6/7/2023 4:17:14 PM ******/
CREATE DATABASE [Winform]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Winform', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Winform.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Winform_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Winform_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Winform] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Winform].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Winform] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Winform] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Winform] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Winform] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Winform] SET ARITHABORT OFF 
GO
ALTER DATABASE [Winform] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Winform] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Winform] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Winform] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Winform] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Winform] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Winform] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Winform] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Winform] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Winform] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Winform] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Winform] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Winform] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Winform] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Winform] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Winform] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Winform] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Winform] SET RECOVERY FULL 
GO
ALTER DATABASE [Winform] SET  MULTI_USER 
GO
ALTER DATABASE [Winform] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Winform] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Winform] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Winform] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Winform] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Winform] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Winform', N'ON'
GO
ALTER DATABASE [Winform] SET QUERY_STORE = ON
GO
ALTER DATABASE [Winform] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Winform]
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MAHD]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   FUNCTION [dbo].[AUTO_MAHD]()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @ID VARCHAR(4)
	IF (SELECT COUNT(*) FROM HOADON) = 0
		SET @ID = 'hd01'
	ELSE
		SELECT @ID = 'hd' + RIGHT('00' + CAST(CAST(RIGHT(MAX(MaHD), 2) AS INT) + 1 AS VARCHAR(2)), 2)
		FROM HOADON
	RETURN @ID
END
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[Username] [varchar](255) NOT NULL,
	[Pass] [varchar](255) NOT NULL,
	[Type] [int] NULL,
	[MaNV] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BAN]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAN](
	[MaBan] [varchar](20) NOT NULL,
	[TenBan] [varchar](255) NOT NULL,
	[MaKV] [varchar](255) NOT NULL,
	[TrangThai] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHINHANH]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHINHANH](
	[MaChiNhanh] [varchar](255) NOT NULL,
	[DiaChi] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiNhanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIET_HD]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIET_HD](
	[MaHD] [varchar](255) NOT NULL,
	[MaDoDung] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaDoDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DODUNG]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DODUNG](
	[MaDoDung] [varchar](255) NOT NULL,
	[TenDoDung] [varchar](255) NOT NULL,
	[MaLoaiDoDung] [varchar](255) NOT NULL,
	[Gia] [float] NOT NULL,
	[TrangThai] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDoDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [varchar](255) NOT NULL,
	[NgayIn] [datetime] NOT NULL,
	[MaBan] [varchar](20) NOT NULL,
	[TongTien] [float] NOT NULL,
	[TienDaNhan] [float] NOT NULL,
	[TienThoi]  AS ([TienDaNhan]-[TongTien]),
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [varchar](255) NOT NULL,
	[Ten] [varchar](255) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[SDT] [varchar](255) NOT NULL,
	[TongTienDaMua] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHUVUC]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHUVUC](
	[MaKV] [varchar](255) NOT NULL,
	[TenKV] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIDODUNG]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIDODUNG](
	[MaLoaiDoDung] [varchar](255) NOT NULL,
	[TenLoaiDoDung] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiDoDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](255) NOT NULL,
	[Ten] [varchar](255) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [varchar](255) NOT NULL,
	[SDT] [varchar](255) NOT NULL,
	[MaChiNhanh] [varchar](255) NOT NULL,
	[LoaiNhanVien] [varchar](255) NOT NULL,
	[LuongCoBan] [float] NULL,
	[LuongTheoGio] [float] NULL,
	[SoGioLam] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THANHTOAN]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THANHTOAN](
	[MaNV] [varchar](255) NOT NULL,
	[MaKH] [varchar](255) NULL,
	[MaVoucher] [varchar](255) NULL,
	[MaHD] [varchar](255) NOT NULL,
	[TrangThai] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VOUCHER]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VOUCHER](
	[MaVoucher] [varchar](255) NOT NULL,
	[TenVoucher] [varchar](255) NOT NULL,
	[PhanTramGiam] [float] NOT NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
	[SoLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVoucher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ACCOUNT] ([Username], [Pass], [Type], [MaNV]) VALUES (N'UserADMIN1', N'29052003', 2, N'NV01')
INSERT [dbo].[ACCOUNT] ([Username], [Pass], [Type], [MaNV]) VALUES (N'UserADMIN2', N'123456', 2, N'NV14')
INSERT [dbo].[ACCOUNT] ([Username], [Pass], [Type], [MaNV]) VALUES (N'Usernhanvien1', N'29052003', 0, N'NV07')
INSERT [dbo].[ACCOUNT] ([Username], [Pass], [Type], [MaNV]) VALUES (N'Usernhanvien2', N'123456', 0, N'NV12')
INSERT [dbo].[ACCOUNT] ([Username], [Pass], [Type], [MaNV]) VALUES (N'Userquanly1', N'123456', 1, N'NV05')
INSERT [dbo].[ACCOUNT] ([Username], [Pass], [Type], [MaNV]) VALUES (N'Userquanly2', N'123456', 1, N'NV15')
GO
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B01', N'Ban 1', N'KV01', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B02', N'Ban 2', N'KV01', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B03', N'Ban 3', N'KV01', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B04', N'Ban 4', N'KV01', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B05', N'Ban 5', N'KV01', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B06', N'Ban 6', N'KV01', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B07', N'Ban 7', N'KV01', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B08', N'Ban 8', N'KV01', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B09', N'Ban 9', N'KV01', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B10', N'Ban 10', N'KV01', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B11', N'Ban 11', N'KV02', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B12', N'Ban 12', N'KV02', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B13', N'Ban 13', N'KV02', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B14', N'Ban 14', N'KV02', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B15', N'Ban 15', N'KV02', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B16', N'Ban 16', N'KV02', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B17', N'Ban 17', N'KV02', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B18', N'Ban 18', N'KV03', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B19', N'Ban 19', N'KV03', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B20', N'Ban 20', N'KV03', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B21', N'Ban 21', N'KV01', N'Tr?ng')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [MaKV], [TrangThai]) VALUES (N'B22', N'Ban 22', N'KV01', N'Tr?ng')
GO
INSERT [dbo].[CHINHANH] ([MaChiNhanh], [DiaChi]) VALUES (N'CN01', N'159 Nguyen Duc Canh, Khu Grand View, Tan Phong, Quan 7, Thanh pho Ho Chi Minh')
INSERT [dbo].[CHINHANH] ([MaChiNhanh], [DiaChi]) VALUES (N'CN02', N'71 Hoang Van Thai, Tan Phu, Quan 7, Thanh pho Ho Chi Minh')
GO
INSERT [dbo].[CHITIET_HD] ([MaHD], [MaDoDung]) VALUES (N'hd01', N'CF03')
INSERT [dbo].[CHITIET_HD] ([MaHD], [MaDoDung]) VALUES (N'hd01', N'CK01')
INSERT [dbo].[CHITIET_HD] ([MaHD], [MaDoDung]) VALUES (N'hd02', N'CF03')
INSERT [dbo].[CHITIET_HD] ([MaHD], [MaDoDung]) VALUES (N'hd02', N'CK02')
GO
INSERT [dbo].[DODUNG] ([MaDoDung], [TenDoDung], [MaLoaiDoDung], [Gia], [TrangThai]) VALUES (N'CF01', N'Ca phe sua da', N'COFFEE', 35000, N'Con')
INSERT [dbo].[DODUNG] ([MaDoDung], [TenDoDung], [MaLoaiDoDung], [Gia], [TrangThai]) VALUES (N'CF02', N'Ca phe muoi', N'COFFEE', 35000, N'Het')
INSERT [dbo].[DODUNG] ([MaDoDung], [TenDoDung], [MaLoaiDoDung], [Gia], [TrangThai]) VALUES (N'CF03', N'Espresso', N'COFFEE', 40000, N'Het')
INSERT [dbo].[DODUNG] ([MaDoDung], [TenDoDung], [MaLoaiDoDung], [Gia], [TrangThai]) VALUES (N'CF04', N'Ca phe den', N'COFFEE', 30000, N'Con')
INSERT [dbo].[DODUNG] ([MaDoDung], [TenDoDung], [MaLoaiDoDung], [Gia], [TrangThai]) VALUES (N'CF05', N'Ca phe cot dua', N'COFFEE', 45000, N'Con')
INSERT [dbo].[DODUNG] ([MaDoDung], [TenDoDung], [MaLoaiDoDung], [Gia], [TrangThai]) VALUES (N'CK01', N'Bong lan trung muoi', N'CAKE', 60000, N'Con')
INSERT [dbo].[DODUNG] ([MaDoDung], [TenDoDung], [MaLoaiDoDung], [Gia], [TrangThai]) VALUES (N'CK02', N'Banh quy hanh nhan', N'CAKE', 40000, N'Het')
INSERT [dbo].[DODUNG] ([MaDoDung], [TenDoDung], [MaLoaiDoDung], [Gia], [TrangThai]) VALUES (N'CK03', N'Banh quy tra xanh', N'CAKE', 35000, N'Con')
INSERT [dbo].[DODUNG] ([MaDoDung], [TenDoDung], [MaLoaiDoDung], [Gia], [TrangThai]) VALUES (N'CK04', N'Banh kem dau', N'CAKE', 50000, N'Con')
INSERT [dbo].[DODUNG] ([MaDoDung], [TenDoDung], [MaLoaiDoDung], [Gia], [TrangThai]) VALUES (N'CK05', N'Banh donut', N'CAKE', 20000, N'Con')
INSERT [dbo].[DODUNG] ([MaDoDung], [TenDoDung], [MaLoaiDoDung], [Gia], [TrangThai]) VALUES (N'T01', N'Tra xanh hoa nhai', N'TEA', 45000, N'Con')
INSERT [dbo].[DODUNG] ([MaDoDung], [TenDoDung], [MaLoaiDoDung], [Gia], [TrangThai]) VALUES (N'T02', N'Tra hoa cuc', N'TEA', 40000, N'Het')
INSERT [dbo].[DODUNG] ([MaDoDung], [TenDoDung], [MaLoaiDoDung], [Gia], [TrangThai]) VALUES (N'T03', N'Tra gung nong', N'TEA', 40000, N'Con')
INSERT [dbo].[DODUNG] ([MaDoDung], [TenDoDung], [MaLoaiDoDung], [Gia], [TrangThai]) VALUES (N'T04', N'Tra trai cay nhiet doi', N'TEA', 45000, N'Het')
INSERT [dbo].[DODUNG] ([MaDoDung], [TenDoDung], [MaLoaiDoDung], [Gia], [TrangThai]) VALUES (N'T05', N'Tra chanh ', N'TEA', 35000, N'Con')
GO
INSERT [dbo].[HOADON] ([MaHD], [NgayIn], [MaBan], [TongTien], [TienDaNhan]) VALUES (N'hd01', CAST(N'2023-06-06T23:37:22.000' AS DateTime), N'B02', 80000, 100000)
INSERT [dbo].[HOADON] ([MaHD], [NgayIn], [MaBan], [TongTien], [TienDaNhan]) VALUES (N'hd02', CAST(N'2023-06-06T23:50:15.000' AS DateTime), N'B05', 64000, 65000)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [Ten], [NgaySinh], [SDT], [TongTienDaMua]) VALUES (N'KH01', N'Nguyen Phung Bao Han', CAST(N'1999-02-02' AS Date), N'0986735243', 0)
INSERT [dbo].[KHACHHANG] ([MaKH], [Ten], [NgaySinh], [SDT], [TongTienDaMua]) VALUES (N'KH02', N'Nguyen Van Anh', CAST(N'1997-12-02' AS Date), N'0892678753', 0)
INSERT [dbo].[KHACHHANG] ([MaKH], [Ten], [NgaySinh], [SDT], [TongTienDaMua]) VALUES (N'KH03', N'Le Thien An', CAST(N'2000-05-14' AS Date), N'0987890253', 0)
INSERT [dbo].[KHACHHANG] ([MaKH], [Ten], [NgaySinh], [SDT], [TongTienDaMua]) VALUES (N'KH04', N'Tran Ngoc Tuong', CAST(N'2003-06-06' AS Date), N'0945632123', 0)
INSERT [dbo].[KHACHHANG] ([MaKH], [Ten], [NgaySinh], [SDT], [TongTienDaMua]) VALUES (N'KH05', N'Le Duc Phu', CAST(N'2001-07-17' AS Date), N'0989023145', 0)
INSERT [dbo].[KHACHHANG] ([MaKH], [Ten], [NgaySinh], [SDT], [TongTienDaMua]) VALUES (N'KH06', N'Pham Van Binh', CAST(N'2000-08-15' AS Date), N'0980146743', 0)
INSERT [dbo].[KHACHHANG] ([MaKH], [Ten], [NgaySinh], [SDT], [TongTienDaMua]) VALUES (N'KH07', N'Nguyen Vi ', CAST(N'1999-09-24' AS Date), N'0909897098', 0)
INSERT [dbo].[KHACHHANG] ([MaKH], [Ten], [NgaySinh], [SDT], [TongTienDaMua]) VALUES (N'KH08', N'Nguyen Duc Anh', CAST(N'2002-12-23' AS Date), N'0909898067', 0)
INSERT [dbo].[KHACHHANG] ([MaKH], [Ten], [NgaySinh], [SDT], [TongTienDaMua]) VALUES (N'KH09', N'Tran Bao Tin', CAST(N'1994-01-02' AS Date), N'0678565498', 0)
INSERT [dbo].[KHACHHANG] ([MaKH], [Ten], [NgaySinh], [SDT], [TongTienDaMua]) VALUES (N'KH10', N'Hoang Van Canh', CAST(N'2000-11-11' AS Date), N'0909235461', 0)
INSERT [dbo].[KHACHHANG] ([MaKH], [Ten], [NgaySinh], [SDT], [TongTienDaMua]) VALUES (N'KH11', N'Ph?m Qu?c Hung', CAST(N'1997-12-02' AS Date), N'02374923789', 0)
INSERT [dbo].[KHACHHANG] ([MaKH], [Ten], [NgaySinh], [SDT], [TongTienDaMua]) VALUES (N'KH12', N'AAA2', CAST(N'1999-02-02' AS Date), N'0986735222', 0)
INSERT [dbo].[KHACHHANG] ([MaKH], [Ten], [NgaySinh], [SDT], [TongTienDaMua]) VALUES (N'KH13', N'Kiet', CAST(N'2003-01-02' AS Date), N'0907555888', 0)
GO
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV]) VALUES (N'KV01', N' Tang 1')
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV]) VALUES (N'KV02', N' Tang 2')
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV]) VALUES (N'KV03', N' Ban cong')
GO
INSERT [dbo].[LOAIDODUNG] ([MaLoaiDoDung], [TenLoaiDoDung]) VALUES (N'CAKE', N'Banh')
INSERT [dbo].[LOAIDODUNG] ([MaLoaiDoDung], [TenLoaiDoDung]) VALUES (N'COFFEE', N'Ca phe')
INSERT [dbo].[LOAIDODUNG] ([MaLoaiDoDung], [TenLoaiDoDung]) VALUES (N'TEA', N'Tra')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV01', N'Nguyen Thanh An', CAST(N'1999-02-02' AS Date), N'Binh Dinh', N'0978456382', N'CN01', N'Ban Hang', 8000000, 25000, 2)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV02', N'Nguyen Phuong Anh', CAST(N'2000-02-10' AS Date), N'Khanh Hoa', N'0978456356', N'CN02', N'Ban Hang', 6000000, 25000, 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV03', N'Le Nguyen Minh Chau', CAST(N'2000-01-21' AS Date), N'Quang Ngai', N'0978434356', N'CN01', N'Ban Hang', 6000000, 25000, 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV04', N'Pham Tri Cong', CAST(N'2001-01-25' AS Date), N'Dong Nai', N'0978456784', N'CN01', N'Ban Hang', 6000000, 25000, 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV05', N'Le Th? Quynh Giao', CAST(N'1992-01-03' AS Date), N'An Giang', N'0976356123', N'CN02', N'Quan ly', 10000000, 30000, 2)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV06', N'Pham Quoc Hung', CAST(N'1998-05-07' AS Date), N'Khanh Hoa', N'09767825342', N'CN01', N'Ban Hang', 7000000, 25000, 2)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV07', N'Ho Thi Hue', CAST(N'2003-08-09' AS Date), N'Quan 9', N'0978635245', N'CN01', N'Ban Hang', 6000000, 25000, 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV08', N'Nguyen Thi Thuy Trang', CAST(N'2002-09-01' AS Date), N'Tp HCM', N'0987092341', N'CN01', N'Ban Hang', 7000000, 25000, 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV09', N'Vu Ngoc Tram', CAST(N'2003-10-12' AS Date), N'Binh Dinh', N'0978352673', N'CN01', N'Ban Hang', 6000000, 25000, 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV10', N'Ho Kieu Oanh', CAST(N'1998-06-14' AS Date), N'Tien Giang', N'0967352432', N'CN01', N'Ban Hang', 6000000, 25000, 2)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV11', N'Le Ngoc Yen Nhi', CAST(N'2000-09-06' AS Date), N'Tien Giang', N'0912847423', N'CN02', N'Ban Hang', 6000000, 25000, 2)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV12', N'Le Duc Phat', CAST(N'2000-05-04' AS Date), N'Dong Thap', N'0978231174', N'CN01', N'Ban Hang', 7000000, 25000, 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV13', N'Nguyen Minh Phong', CAST(N'1999-03-04' AS Date), N'Vinh Long', N'0987674562', N'CN01', N'Ban Hang', 6000000, 25000, 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV14', N'Le Quoc Phu', CAST(N'2001-04-07' AS Date), N'Tien Giang', N'0967283542', N'CN02', N'Ban Hang', 6000000, 25000, 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV15', N'Ha Nam Phuong', CAST(N'1993-01-09' AS Date), N'Can Tho', N'0928763521', N'CN02', N'Quan ly', 10000000, 30000, 2)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV16', N'Pham Nhat Phuong Quynh', CAST(N'2002-02-12' AS Date), N'Tp HCM', N'0967911232', N'CN02', N'Ban Hang', 7000000, 25000, 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV17', N'Ngo Phuong Thao', CAST(N'2001-01-09' AS Date), N'An Giang', N'09889273212', N'CN02', N'Ban Hang', 6000000, 25000, 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV18', N'Nguyen Minh Thu', CAST(N'1998-03-15' AS Date), N'Quang Nam', N'0978782321', N'CN02', N'Ban Hang', 6000000, 25000, 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV19', N'Nguyen Thi Huyen Tran', CAST(N'1999-11-15' AS Date), N'Quang Nam', N'0564327162', N'CN02', N'Ban Hang', 7000000, 25000, 2)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV20', N'Nguyen Huong Tuyen', CAST(N'2000-04-11' AS Date), N'Vung Tau', N'08734672936', N'CN02', N'Ban Hang', 6000000, 25000, 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV22', N'Nguyen Huong Tuyen Hung', CAST(N'2000-04-11' AS Date), N'Can Tho', N'0907693555', N'CN02', N'Ban Hang', 6000000, 25000, 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV23', N'AAA', CAST(N'2000-10-02' AS Date), N'Khanh Hoa', N'023791874', N'CN02', N'Ban Hang', 0, 0, 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV24', N'BBB', CAST(N'2003-02-02' AS Date), N'Cam Lam', N'089284739', N'CN02', N'Quan ly', 0, 0, 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV25', N'CCCCC', CAST(N'2003-01-01' AS Date), N'Can Tho', N'0123456789', N'CN02', N'Ban Hang', 0, 0, 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV26', N'DDD', CAST(N'2003-01-01' AS Date), N'Can Tho', N'03259285', N'CN01', N'Ban Hang', 0, 0, 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV27', N'EEEE', CAST(N'2003-01-01' AS Date), N'Can Tho', N'032487592', N'CN01', N'Ban Hang', 0, 0, 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [Ten], [NgaySinh], [DiaChi], [SDT], [MaChiNhanh], [LoaiNhanVien], [LuongCoBan], [LuongTheoGio], [SoGioLam]) VALUES (N'NV28', N'H? Gia Ki?t', CAST(N'2003-01-01' AS Date), N'Quan 9', N'0907693888', N'CN02', N'Ban Hang', 0, 0, 0)
GO
INSERT [dbo].[THANHTOAN] ([MaNV], [MaKH], [MaVoucher], [MaHD], [TrangThai]) VALUES (N'NV12', N'KH05', N'VC05', N'hd01', N'Da thanh toan')
INSERT [dbo].[THANHTOAN] ([MaNV], [MaKH], [MaVoucher], [MaHD], [TrangThai]) VALUES (N'NV07', N'KH05', N'VC02', N'hd02', N'Da thanh toan')
GO
INSERT [dbo].[VOUCHER] ([MaVoucher], [TenVoucher], [PhanTramGiam], [NgayBatDau], [NgayKetThuc], [SoLuong]) VALUES (N'None', N'Khong co Voucher', 0, CAST(N'2001-01-01' AS Date), CAST(N'2001-02-01' AS Date), 0)
INSERT [dbo].[VOUCHER] ([MaVoucher], [TenVoucher], [PhanTramGiam], [NgayBatDau], [NgayKetThuc], [SoLuong]) VALUES (N'VC01', N'Voucher giam 10% tong bill', 10, CAST(N'2023-02-02' AS Date), CAST(N'2023-03-12' AS Date), 30)
INSERT [dbo].[VOUCHER] ([MaVoucher], [TenVoucher], [PhanTramGiam], [NgayBatDau], [NgayKetThuc], [SoLuong]) VALUES (N'VC02', N'Voucher giam 20% tong bill', 20, CAST(N'2023-05-12' AS Date), CAST(N'2023-05-20' AS Date), 20)
INSERT [dbo].[VOUCHER] ([MaVoucher], [TenVoucher], [PhanTramGiam], [NgayBatDau], [NgayKetThuc], [SoLuong]) VALUES (N'VC04', N'Voucher giam 10% cho moi ly mua ve', 10, CAST(N'2023-03-08' AS Date), CAST(N'2023-03-09' AS Date), 30)
INSERT [dbo].[VOUCHER] ([MaVoucher], [TenVoucher], [PhanTramGiam], [NgayBatDau], [NgayKetThuc], [SoLuong]) VALUES (N'VC05', N'Voucher giam 20% cho cac dong banh ngot', 20, CAST(N'2023-09-10' AS Date), CAST(N'2023-09-20' AS Date), 50)
INSERT [dbo].[VOUCHER] ([MaVoucher], [TenVoucher], [PhanTramGiam], [NgayBatDau], [NgayKetThuc], [SoLuong]) VALUES (N'VC06', N'Voucher giam 50% cho cac dong banh ngot', 50, CAST(N'2023-09-10' AS Date), CAST(N'2023-10-09' AS Date), 5)
INSERT [dbo].[VOUCHER] ([MaVoucher], [TenVoucher], [PhanTramGiam], [NgayBatDau], [NgayKetThuc], [SoLuong]) VALUES (N'VC07', N'Voucher giam 35% cho cac dong banh ngot', 35, CAST(N'2023-09-10' AS Date), CAST(N'2023-09-10' AS Date), 15)
INSERT [dbo].[VOUCHER] ([MaVoucher], [TenVoucher], [PhanTramGiam], [NgayBatDau], [NgayKetThuc], [SoLuong]) VALUES (N'VC08', N'Voucher giam 25% cho cac dong banh ngot', 25, CAST(N'2023-10-09' AS Date), CAST(N'2023-10-09' AS Date), 15)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__ACCOUNT__2725D70BBB1941B6]    Script Date: 6/7/2023 4:17:15 PM ******/
ALTER TABLE [dbo].[ACCOUNT] ADD UNIQUE NONCLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__KHACHHAN__CA1930A5D4D6E12B]    Script Date: 6/7/2023 4:17:15 PM ******/
ALTER TABLE [dbo].[KHACHHANG] ADD UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NHANVIEN__CA1930A588761A98]    Script Date: 6/7/2023 4:17:15 PM ******/
ALTER TABLE [dbo].[NHANVIEN] ADD UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HOADON] ADD  DEFAULT ((0)) FOR [TongTien]
GO
ALTER TABLE [dbo].[KHACHHANG] ADD  DEFAULT ((0)) FOR [TongTienDaMua]
GO
ALTER TABLE [dbo].[THANHTOAN] ADD  DEFAULT ('Chua Thanh Toan') FOR [TrangThai]
GO
ALTER TABLE [dbo].[ACCOUNT]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[BAN]  WITH CHECK ADD FOREIGN KEY([MaKV])
REFERENCES [dbo].[KHUVUC] ([MaKV])
GO
ALTER TABLE [dbo].[CHITIET_HD]  WITH CHECK ADD FOREIGN KEY([MaDoDung])
REFERENCES [dbo].[DODUNG] ([MaDoDung])
GO
ALTER TABLE [dbo].[CHITIET_HD]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[DODUNG]  WITH CHECK ADD FOREIGN KEY([MaLoaiDoDung])
REFERENCES [dbo].[LOAIDODUNG] ([MaLoaiDoDung])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[BAN] ([MaBan])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([MaChiNhanh])
REFERENCES [dbo].[CHINHANH] ([MaChiNhanh])
GO
ALTER TABLE [dbo].[THANHTOAN]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[THANHTOAN]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[THANHTOAN]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[THANHTOAN]  WITH CHECK ADD FOREIGN KEY([MaVoucher])
REFERENCES [dbo].[VOUCHER] ([MaVoucher])
GO
ALTER TABLE [dbo].[ACCOUNT]  WITH CHECK ADD CHECK  (([Type]>=(0) AND [Type]<=(2)))
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD CHECK  (([LoaiNhanVien]='Quan ly' OR [LoaiNhanVien]='Ban hang'))
GO
ALTER TABLE [dbo].[VOUCHER]  WITH CHECK ADD CHECK  (([NgayKetThuc]>=[NgayBatDau]))
GO
ALTER TABLE [dbo].[VOUCHER]  WITH CHECK ADD CHECK  (([SoLuong]>=(0)))
GO
/****** Object:  StoredProcedure [dbo].[CapnhatBan]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CapnhatBan]
	(@MaBan varchar(20),
	@TenBan varchar (255),
	@MaKV varchar (255))
AS
BEGIN 
	UPDATE BAN
	set 
		TenBan =@TenBan,
		MaKV = @MaKV
	where MaBan = @MaBan
end
GO
/****** Object:  StoredProcedure [dbo].[CapNhatBangThanhToan]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[CapNhatBangThanhToan]
	@MaVoucher VARCHAR(255),
	@MaHD VARCHAR(255)
AS
BEGIN
	UPDATE THANHTOAN
	SET MaVoucher=@MaVoucher, TrangThai='Da thanh toan'
	WHERE MaHD=@MaHD
END
GO
/****** Object:  StoredProcedure [dbo].[CapNhatTrangThaiBanKhiThanhToan]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CapNhatTrangThaiBanKhiThanhToan]
	@MaBan VARCHAR(255)
AS
BEGIN
	UPDATE BAN
	SET TrangThai='Trống'
	WHERE MaBan=@MaBan
END
GO
/****** Object:  StoredProcedure [dbo].[spThemVoucher]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spThemVoucher]
(
	@MaVoucher VARCHAR(255),
	@TenVoucher VARCHAR(255),
	@PhanTramGiam FLOAT,
	@NgayBatDau DATE,
	@NgayKetThuc DATE,
	@SoLuong INT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO VOUCHER (MaVoucher, TenVoucher, PhanTramGiam, NgayBatDau, NgayKetThuc,SoLuong)
        VALUES (@MaVoucher, @TenVoucher, @PhanTramGiam, @NgayBatDau, @NgayKetThuc,@SoLuong);

        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRAN
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState); -- Phát sinh thông báo lỗi
    END CATCH;
END
GO
/****** Object:  StoredProcedure [dbo].[SuaAccount]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaAccount]
	@Username varchar(255),
	@Pass varchar(255),
	@Type int,
	@MaNV varchar(255)
AS
BEGIN
---kiem tra co ton tai khoa chinh de update khong
	IF NOT EXISTS (SELECT * FROM ACCOUNT WHERE Username= @Username)
	BEGIN
		RAISERROR('Error',16,1)
	END
	ELSE
	BEGIN
		UPDATE ACCOUNT
		SET Username = @Username, Pass=@Pass, Type= @Type, MaNV=@MaNV
		WHERE Username= @Username;
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SuaNhanVien]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaNhanVien]
	@MaNV varchar (255),
	@Ten VARCHAR(255),
	@NgaySinh DATE , 
	@DiaChi VARCHAR(255),
	@SDT VARCHAR(255),
	@LoaiNhanVien varchar(255)
AS
BEGIN
---kiem tra co ton tai khoa chinh de update khong
	IF NOT EXISTS (SELECT * FROM NHANVIEN WHERE MaNV= @MaNV)
	BEGIN
		RAISERROR('Error',16,1)
	END
	ELSE
	BEGIN
		UPDATE NHANVIEN
		SET MaNV= @MaNV, Ten=@Ten,NgaySinh= @NgaySinh, DiaChi=@DiaChi, SDT = @SDT, LoaiNhanVien=@LoaiNhanVien
		WHERE MaNV= @MaNV;
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SuaVoucher]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaVoucher]
	@MaVoucher VARCHAR(255),
	@TenVoucher VARCHAR(255),
	@PhanTramGiam FLOAT,
	@NgayBatDau DATE,
	@NgayKetThuc DATE,
	@SoLuong INT
AS
BEGIN
---kiem tra co ton tai khoa chinh de update khong
	IF NOT EXISTS (SELECT * FROM VOUCHER WHERE MaVoucher= @MaVoucher)
	BEGIN
		RAISERROR('Error',16,1)
	END
	ELSE
	BEGIN
		UPDATE VOUCHER
		SET MaVoucher=@MaVoucher,TenVoucher=@TenVoucher,PhanTramGiam= @PhanTramGiam,NgayBatDau =@NgayBatDau,@NgayKetThuc=@NgayKetThuc, SoLuong=@SoLuong
		WHERE MaVoucher=@MaVoucher;
	END
END
GO
/****** Object:  StoredProcedure [dbo].[ThemBan]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[ThemBan]
(@MaBan varchar(20),
@TenBan varchar (255),
@MaKV varchar (255),
@TrangThai varchar(255))
AS 
BEGIN 
		SET NOCOUNT ON;
        INSERT INTO BAN VALUES (@MaBan, @TenBan, @MaKV, @TrangThai);
END
GO
/****** Object:  StoredProcedure [dbo].[ThemChiTietHD]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemChiTietHD]
	@MaHD VARCHAR(255),
	@MaDoDung VARCHAR(255)
AS
BEGIN
	
	INSERT INTO CHITIET_HD(MaHD, MaDoDung)
	VALUES (@MaHD, @MaDoDung);
END
GO
/****** Object:  StoredProcedure [dbo].[ThemHoaDon]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[ThemHoaDon]
	@MaHD VARCHAR(255),
	@NgayIn DATETIME,
	@MaBan VARCHAR(255),
	@TongTien FLOAT,
	@TienDaNhan FLOAT,
	@TienThoi FLOAT
AS
BEGIN
	
	INSERT INTO HOADON(MaHD, NgayIn, MaBan, TongTien, TienDaNhan)
	VALUES (@MaHD, @NgayIn, @MaBan, @TongTien, @TienDaNhan);
END
GO
/****** Object:  StoredProcedure [dbo].[ThemKhachHang]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[ThemKhachHang]
	@MaKH VARCHAR(255),
	@Ten VARCHAR(255),
	@NgaySinh DATE,
	@SDT VARCHAR(255)
AS
BEGIN
	INSERT INTO KHACHHANG(MaKH, Ten, NgaySinh, SDT)
	VALUES(@MaKH, @Ten, @NgaySinh, @SDT)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemmAccount]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--EXEC SuaVoucher 'VC06','Voucher giam 5% cho cac dong banh ngot',5,'2023-09-10','2023-09-20', 15

-------------------------------------------------------------------------------------

CREATE PROC [dbo].[ThemmAccount]
(
	@Username varchar(255),
	@Pass varchar(255),
	@Type int,
	@MaNV varchar(255)
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO ACCOUNT (Username, Pass, Type, MaNV)
        VALUES (@Username, @Pass, @Type, @MaNV);

        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRAN
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState); -- Phát sinh thông báo lỗi
    END CATCH;
END
--EXEC ThemmAccount 'Usernhanvien5','777777',0,'NV010'
GO
/****** Object:  StoredProcedure [dbo].[ThemNhanVien]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[ThemNhanVien]
(
	@MaNV varchar (255),
	@Ten VARCHAR(255),
	@NgaySinh DATE, 
	@DiaChi VARCHAR(255),
	@SDT VARCHAR(255),
	@MaChiNhanh VARCHAR(255),
	@LoaiNhanVien varchar(255),
	@LuongCoBan float,
	@LuongTheoGio float,
	@SoGioLam float	
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN;
        INSERT INTO NHANVIEN(MaNV, Ten, NgaySinh, DiaChi, SDT,MaChiNhanh,LoaiNhanVien,LuongCoBan,LuongTheoGio,SoGioLam  )
        VALUES (@MaNV, @Ten, @NgaySinh, @DiaChi, @SDT,@MaChiNhanh,@LoaiNhanVien,@LuongCoBan,@LuongTheoGio,@SoGioLam );

        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRAN
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState); -- Phát sinh thông báo lỗi
    END CATCH;
END
GO
/****** Object:  StoredProcedure [dbo].[ThemVaoBangThanhToan]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[ThemVaoBangThanhToan]
	@MaNV VARCHAR(255),
	@MaKH VARCHAR(255),
	@MaHD VARCHAR(255)
AS
BEGIN
	INSERT INTO THANHTOAN(MaNV, MaKH, MaVoucher, MaHD, TrangThai)
	VALUES (@MaNV, @MaKH, 'None', @MaHD, 'Chua Thanh Toan');
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateAccount]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[UpdateAccount]
	@Username VARCHAR(255),
	@Pass VARCHAR(255)
AS
BEGIN
	UPDATE ACCOUNT
	SET Username=@Username, Pass=@Pass
	WHERE Username=@Username
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateBangHoaDon]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[UpdateBangHoaDon]
	@MaHD VARCHAR(255),
	@TongTien Float,
	@TienDaNhan Float
AS
BEGIN
	UPDATE HOADON
	SET TongTien=@TongTien, TienDaNhan=@TienDaNhan
	WHERE MaHD=@MaHD
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateKhachHang]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[UpdateKhachHang]
	@MaKH VARCHAR(255),
	@Ten VARCHAR(255),
	@NgaySinh DATE,
	@SDT VARCHAR(255)
AS
BEGIN
	UPDATE KHACHHANG
	SET Ten=@Ten, NgaySinh=@NgaySinh, SDT=@SDT
	WHERE MaKH=@MaKH
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateNhanVien]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateNhanVien]
(
	@MaNV varchar (255),
	@Ten VARCHAR(255),
	@NgaySinh DATE, 
	@DiaChi VARCHAR(255),
	@SDT VARCHAR(255),
	@MaChiNhanh VARCHAR(255),
	@LoaiNhanVien varchar(255)
)
AS
BEGIN
	UPDATE NHANVIEN
	SET MaNV=@MaNV, Ten=@Ten, NgaySinh=@NgaySinh, DiaChi=@DiaChi, SDT=@SDT,
		MaChiNhanh=@MaChiNhanh, LoaiNhanVien=@LoaiNhanVien
	WHERE MaNV=@MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateTrangThaiBan]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[UpdateTrangThaiBan]
	@MaBan VARCHAR(255),
	@TrangThai VARCHAR(255)
AS
BEGIN
	UPDATE BAN
	SET TrangThai=@TrangThai
	WHERE MaBan=@MaBan
END
GO
/****** Object:  StoredProcedure [dbo].[XoaAccount]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaAccount]
@Username varchar(255)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN;
        DELETE FROM ACCOUNT WHERE Username = @Username;
        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK TRAN;
        DECLARE @ErrorMessage NVARCHAR(4000);
        SET @ErrorMessage = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[XoaBan]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaBan]
(@MaBan varchar(20))
AS
BEGIN 
	SET NOCOUNT ON ;
	DELETE FROM BAN
	WHERE MaBan = @MaBan
end
GO
/****** Object:  StoredProcedure [dbo].[XoaVoucher]    Script Date: 6/7/2023 4:17:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaVoucher]
@MaVoucher CHAR(6)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN;
        DELETE FROM VOUCHER WHERE MaVoucher = @MaVoucher;
        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK TRAN;
        DECLARE @ErrorMessage NVARCHAR(4000);
        SET @ErrorMessage = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
    END CATCH;
END;
GO
USE [master]
GO
ALTER DATABASE [Winform] SET  READ_WRITE 
GO
