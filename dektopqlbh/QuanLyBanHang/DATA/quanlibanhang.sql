USE [master]
GO
/****** Object:  Database [qanlibanhang]    Script Date: 6/1/2024 10:17:57 AM ******/
CREATE DATABASE [qanlibanhang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'qanlibanhang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\qanlibanhang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'qanlibanhang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\qanlibanhang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [qanlibanhang] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [qanlibanhang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [qanlibanhang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [qanlibanhang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [qanlibanhang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [qanlibanhang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [qanlibanhang] SET ARITHABORT OFF 
GO
ALTER DATABASE [qanlibanhang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [qanlibanhang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [qanlibanhang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [qanlibanhang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [qanlibanhang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [qanlibanhang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [qanlibanhang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [qanlibanhang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [qanlibanhang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [qanlibanhang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [qanlibanhang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [qanlibanhang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [qanlibanhang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [qanlibanhang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [qanlibanhang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [qanlibanhang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [qanlibanhang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [qanlibanhang] SET RECOVERY FULL 
GO
ALTER DATABASE [qanlibanhang] SET  MULTI_USER 
GO
ALTER DATABASE [qanlibanhang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [qanlibanhang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [qanlibanhang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [qanlibanhang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [qanlibanhang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [qanlibanhang] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'qanlibanhang', N'ON'
GO
ALTER DATABASE [qanlibanhang] SET QUERY_STORE = ON
GO
ALTER DATABASE [qanlibanhang] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [qanlibanhang]
GO
/****** Object:  Table [dbo].[tblChatLieu]    Script Date: 6/1/2024 10:17:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChatLieu](
	[MaChatLieu] [nvarchar](50) NOT NULL,
	[TenChatLieu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblChatLieu] PRIMARY KEY CLUSTERED 
(
	[MaChatLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietHD]    Script Date: 6/1/2024 10:17:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHD](
	[MaHDBan] [nvarchar](50) NOT NULL,
	[MaHang] [nvarchar](50) NOT NULL,
	[SoLuong] [float] NOT NULL,
 CONSTRAINT [PK_tblChiTietHD] PRIMARY KEY CLUSTERED 
(
	[MaHDBan] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHang]    Script Date: 6/1/2024 10:17:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHang](
	[MaHang] [nvarchar](50) NOT NULL,
	[TenHang] [nvarchar](50) NOT NULL,
	[MaChatLieu] [nvarchar](50) NOT NULL,
	[SoLuong] [float] NOT NULL,
 CONSTRAINT [PK_tblHang] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHDBan]    Script Date: 6/1/2024 10:17:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHDBan](
	[MaHDBan] [nvarchar](50) NOT NULL,
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[NgayBan] [datetime] NOT NULL,
	[MaKhach] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblHDBan] PRIMARY KEY CLUSTERED 
(
	[MaHDBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhach]    Script Date: 6/1/2024 10:17:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhach](
	[MaKhach] [nvarchar](10) NOT NULL,
	[TenKhach] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblKhach] PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 6/1/2024 10:17:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[DienThoai] [nvarchar](50) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'NC001', N'NHUA')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'NC002', N'GIAY')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'NC003', N'NILON')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'NC004', N'SAT')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'NC005', N'THUY TINH')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'NC006', N'CAO SU')
GO
INSERT [dbo].[tblChiTietHD] ([MaHDBan], [MaHang], [SoLuong]) VALUES (N'HD001', N'H001', 2)
INSERT [dbo].[tblChiTietHD] ([MaHDBan], [MaHang], [SoLuong]) VALUES (N'HD002', N'H002', 3)
INSERT [dbo].[tblChiTietHD] ([MaHDBan], [MaHang], [SoLuong]) VALUES (N'HD003', N'H001', 4)
GO
INSERT [dbo].[tblHang] ([MaHang], [TenHang], [MaChatLieu], [SoLuong]) VALUES (N'H001', N'CHAI 7UP ', N'NC001', 2)
INSERT [dbo].[tblHang] ([MaHang], [TenHang], [MaChatLieu], [SoLuong]) VALUES (N'H002', N'LON COCA', N'NC004', 1)
INSERT [dbo].[tblHang] ([MaHang], [TenHang], [MaChatLieu], [SoLuong]) VALUES (N'H003', N'CHAI NUOC LOC', N'NC001', 1)
INSERT [dbo].[tblHang] ([MaHang], [TenHang], [MaChatLieu], [SoLuong]) VALUES (N'H004', N'CHAI NUMBER 1', N'NC001', 5)
INSERT [dbo].[tblHang] ([MaHang], [TenHang], [MaChatLieu], [SoLuong]) VALUES (N'H005', N'LY CAFE', N'NC002', 2)
INSERT [dbo].[tblHang] ([MaHang], [TenHang], [MaChatLieu], [SoLuong]) VALUES (N'H006', N'LOAN BI DAO', N'NC003', 2)
GO
INSERT [dbo].[tblHDBan] ([MaHDBan], [MaNhanVien], [NgayBan], [MaKhach]) VALUES (N'HD001', N'NV001', CAST(N'2024-06-01T01:35:22.573' AS DateTime), N'KH001')
INSERT [dbo].[tblHDBan] ([MaHDBan], [MaNhanVien], [NgayBan], [MaKhach]) VALUES (N'HD002', N'NV002', CAST(N'2024-06-01T02:08:33.663' AS DateTime), N'KH003')
INSERT [dbo].[tblHDBan] ([MaHDBan], [MaNhanVien], [NgayBan], [MaKhach]) VALUES (N'HD003', N'NV001', CAST(N'2024-06-01T05:35:38.563' AS DateTime), N'KH001')
GO
INSERT [dbo].[tblKhach] ([MaKhach], [TenKhach], [DiaChi], [DienThoai]) VALUES (N'KH001', N'PHUNG GIA TUYET', N'QUY NHON', N'(  0) 237-8652')
INSERT [dbo].[tblKhach] ([MaKhach], [TenKhach], [DiaChi], [DienThoai]) VALUES (N'KH002', N'NGUYEN VAN B', N'BINH DINH', N'( 0 ) 087-6521')
INSERT [dbo].[tblKhach] ([MaKhach], [TenKhach], [DiaChi], [DienThoai]) VALUES (N'KH003', N'NGUYEN VAN C', N'PHU CAT', N'( 0 ) 087-6522')
INSERT [dbo].[tblKhach] ([MaKhach], [TenKhach], [DiaChi], [DienThoai]) VALUES (N'KH004', N'NGUYEN VAN D', N'PHU YEN', N'( 0 ) 087-6522')
INSERT [dbo].[tblKhach] ([MaKhach], [TenKhach], [DiaChi], [DienThoai]) VALUES (N'KH005', N'NGUYEN VAN F', N'AN NHON', N'( 0 ) 087-6522')
GO
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [DienThoai], [NgaySinh]) VALUES (N'NV001', N'LE HUU THIEN PHUC', N'(  0) 848-5888', CAST(N'2002-01-11T00:00:00.000' AS DateTime))
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [DienThoai], [NgaySinh]) VALUES (N'NV002', N'NGUYEN VAN A', N'( 02) 375-492', CAST(N'2003-02-11T00:00:00.000' AS DateTime))
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [DienThoai], [NgaySinh]) VALUES (N'NV003', N'NGUYEN VAN B', N'( 02) 375-492', CAST(N'2002-02-11T00:00:00.000' AS DateTime))
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [DienThoai], [NgaySinh]) VALUES (N'NV004', N'NGUYEN VAN C', N'( 02) 375-492', CAST(N'2000-02-11T00:00:00.000' AS DateTime))
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [DienThoai], [NgaySinh]) VALUES (N'NV005', N'NGUYEN VAN C', N'( 02) 375-492', CAST(N'1998-02-11T00:00:00.000' AS DateTime))
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [DienThoai], [NgaySinh]) VALUES (N'NV006', N'NVD', N'(032) 451-267', CAST(N'2003-12-11T00:00:00.000' AS DateTime))
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [DienThoai], [NgaySinh]) VALUES (N'NV008', N'NGUYEN VAN ABC', N'(012) 651-999', CAST(N'2222-11-11T00:00:00.000' AS DateTime))
GO
ALTER TABLE [dbo].[tblChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHD_tblHang] FOREIGN KEY([MaHang])
REFERENCES [dbo].[tblHang] ([MaHang])
GO
ALTER TABLE [dbo].[tblChiTietHD] CHECK CONSTRAINT [FK_tblChiTietHD_tblHang]
GO
ALTER TABLE [dbo].[tblChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHD_tblHDBan] FOREIGN KEY([MaHDBan])
REFERENCES [dbo].[tblHDBan] ([MaHDBan])
GO
ALTER TABLE [dbo].[tblChiTietHD] CHECK CONSTRAINT [FK_tblChiTietHD_tblHDBan]
GO
ALTER TABLE [dbo].[tblHang]  WITH CHECK ADD  CONSTRAINT [FK_tblHang_tblChatLieu] FOREIGN KEY([MaChatLieu])
REFERENCES [dbo].[tblChatLieu] ([MaChatLieu])
GO
ALTER TABLE [dbo].[tblHang] CHECK CONSTRAINT [FK_tblHang_tblChatLieu]
GO
ALTER TABLE [dbo].[tblHDBan]  WITH CHECK ADD  CONSTRAINT [FK_tblHDBan_tblKhach] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[tblKhach] ([MaKhach])
GO
ALTER TABLE [dbo].[tblHDBan] CHECK CONSTRAINT [FK_tblHDBan_tblKhach]
GO
ALTER TABLE [dbo].[tblHDBan]  WITH CHECK ADD  CONSTRAINT [FK_tblHDBan_tblNhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[tblNhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[tblHDBan] CHECK CONSTRAINT [FK_tblHDBan_tblNhanVien]
GO
USE [master]
GO
ALTER DATABASE [qanlibanhang] SET  READ_WRITE 
GO
