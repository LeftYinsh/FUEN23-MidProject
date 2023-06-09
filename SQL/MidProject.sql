USE [master]
GO
/****** Object:  Database [MidProject]    Script Date: 2022/12/19 08:21:21 ******/
CREATE DATABASE [MidProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MidProject', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MidProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MidProject_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MidProject_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MidProject] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MidProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MidProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MidProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MidProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MidProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MidProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [MidProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MidProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MidProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MidProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MidProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MidProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MidProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MidProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MidProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MidProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MidProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MidProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MidProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MidProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MidProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MidProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MidProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MidProject] SET RECOVERY FULL 
GO
ALTER DATABASE [MidProject] SET  MULTI_USER 
GO
ALTER DATABASE [MidProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MidProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MidProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MidProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MidProject] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MidProject] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MidProject', N'ON'
GO
ALTER DATABASE [MidProject] SET QUERY_STORE = OFF
GO
USE [MidProject]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 2022/12/19 08:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[ManagerID] [int] IDENTITY(1,1) NOT NULL,
	[ManagerName] [nvarchar](20) NOT NULL,
	[ManagerLevel] [tinyint] NOT NULL,
	[ManagerEmail] [nvarchar](50) NOT NULL,
	[ManagerPassword] [nvarchar](20) NOT NULL,
	[ManagerGender] [nvarchar](3) NOT NULL,
	[ManagerBirthday] [date] NOT NULL,
	[ManagerPhone] [nvarchar](10) NOT NULL,
	[ManagerAddress] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Manager] PRIMARY KEY CLUSTERED 
(
	[ManagerID] ASC,
	[ManagerEmail] ASC,
	[ManagerPhone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 2022/12/19 08:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[MemberName] [nvarchar](20) NOT NULL,
	[MemberLevel] [tinyint] NOT NULL,
	[MemberPoint] [int] NOT NULL,
	[MemberEmail] [nvarchar](50) NOT NULL,
	[MemberPassword] [nvarchar](20) NOT NULL,
	[MemberGender] [nvarchar](3) NOT NULL,
	[MemberBirthday] [date] NOT NULL,
	[MemberPhone] [nvarchar](10) NOT NULL,
	[MemberAddress] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC,
	[MemberEmail] ASC,
	[MemberPhone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderSheet]    Script Date: 2022/12/19 08:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderSheet](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrdererName] [nvarchar](50) NOT NULL,
	[OrdererEmail] [nvarchar](50) NOT NULL,
	[OrderPrice] [int] NOT NULL,
	[OrderTime] [datetime] NOT NULL,
	[OrderShipStatus] [bit] NOT NULL,
 CONSTRAINT [PK_OrderSheet] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2022/12/19 08:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[ProductPrice] [int] NOT NULL,
	[ProductDescribe] [nvarchar](50) NOT NULL,
	[ProductStocks] [int] NOT NULL,
	[ProductImage] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[ProductName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Manager] ON 

INSERT [dbo].[Manager] ([ManagerID], [ManagerName], [ManagerLevel], [ManagerEmail], [ManagerPassword], [ManagerGender], [ManagerBirthday], [ManagerPhone], [ManagerAddress]) VALUES (1, N'Admin', 3, N'Admin@manager.com', N'0911805195', N'不公開', CAST(N'1995-01-11' AS Date), N'0911805195', N'台南市北區')
INSERT [dbo].[Manager] ([ManagerID], [ManagerName], [ManagerLevel], [ManagerEmail], [ManagerPassword], [ManagerGender], [ManagerBirthday], [ManagerPhone], [ManagerAddress]) VALUES (2, N'Clerk', 0, N'Clerk@manager.com', N'0989746313', N'不公開', CAST(N'1999-07-10' AS Date), N'0989746313', N'台南市中西區')
INSERT [dbo].[Manager] ([ManagerID], [ManagerName], [ManagerLevel], [ManagerEmail], [ManagerPassword], [ManagerGender], [ManagerBirthday], [ManagerPhone], [ManagerAddress]) VALUES (4, N'Foreman', 1, N'Foreman@manager.com', N'0999887766', N'不公開', CAST(N'2000-12-12' AS Date), N'0999887766', N'基隆市中正區')
SET IDENTITY_INSERT [dbo].[Manager] OFF
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MemberID], [MemberName], [MemberLevel], [MemberPoint], [MemberEmail], [MemberPassword], [MemberGender], [MemberBirthday], [MemberPhone], [MemberAddress]) VALUES (1, N'HRW', 0, 1000, N'HRW@member.com', N'0911805195', N'男性', CAST(N'1995-01-11' AS Date), N'0911805195', N'台南市北區')
INSERT [dbo].[Member] ([MemberID], [MemberName], [MemberLevel], [MemberPoint], [MemberEmail], [MemberPassword], [MemberGender], [MemberBirthday], [MemberPhone], [MemberAddress]) VALUES (2, N'王小明', 0, 1000, N'WANG@member.com', N'0911223344', N'男性', CAST(N'1990-12-19' AS Date), N'0911223344', N'台南市中西區')
INSERT [dbo].[Member] ([MemberID], [MemberName], [MemberLevel], [MemberPoint], [MemberEmail], [MemberPassword], [MemberGender], [MemberBirthday], [MemberPhone], [MemberAddress]) VALUES (3, N'張小天', 0, 1000, N'SKY@member.com', N'0999999999', N'男性', CAST(N'2000-12-19' AS Date), N'0999999999', N'基隆市中正區')
INSERT [dbo].[Member] ([MemberID], [MemberName], [MemberLevel], [MemberPoint], [MemberEmail], [MemberPassword], [MemberGender], [MemberBirthday], [MemberPhone], [MemberAddress]) VALUES (4, N'陳小麗', 0, 1000, N'LI@member.com', N'0987654321', N'男性', CAST(N'2005-12-19' AS Date), N'0987654321', N'台南市安南區')
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderSheet] ON 

INSERT [dbo].[OrderSheet] ([OrderID], [OrdererName], [OrdererEmail], [OrderPrice], [OrderTime], [OrderShipStatus]) VALUES (1, N'HRW', N'HRW@member.com', 21000, CAST(N'2022-12-19T08:17:30.000' AS DateTime), 0)
INSERT [dbo].[OrderSheet] ([OrderID], [OrdererName], [OrdererEmail], [OrderPrice], [OrderTime], [OrderShipStatus]) VALUES (2, N'陳小麗', N'LI@member.com', 5000, CAST(N'2022-12-19T08:18:50.000' AS DateTime), 0)
INSERT [dbo].[OrderSheet] ([OrderID], [OrdererName], [OrdererEmail], [OrderPrice], [OrderTime], [OrderShipStatus]) VALUES (3, N'王小明', N'WANG@member.com', 8500, CAST(N'2022-12-19T08:19:13.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[OrderSheet] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductDescribe], [ProductStocks], [ProductImage]) VALUES (1, N'CPU', 2000, N'電腦處理器', 10, N'2022-12-19@081154#2233.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductDescribe], [ProductStocks], [ProductImage]) VALUES (2, N'MB', 1500, N'電腦主機板', 10, N'2022-12-19@081218#6359.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductDescribe], [ProductStocks], [ProductImage]) VALUES (3, N'GPU', 5000, N'電腦顯示卡', 5, N'2022-12-19@081235#1532.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductDescribe], [ProductStocks], [ProductImage]) VALUES (4, N'RAM', 1000, N'電腦記憶體', 20, N'2022-12-19@081331#5661.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductDescribe], [ProductStocks], [ProductImage]) VALUES (5, N'HDD', 500, N'電腦HDD硬碟', 50, N'2022-12-19@081349#1434.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductDescribe], [ProductStocks], [ProductImage]) VALUES (6, N'SSD', 1500, N'電腦SSD硬碟', 25, N'2022-12-19@081421#4509.png')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductDescribe], [ProductStocks], [ProductImage]) VALUES (7, N'CASE', 1000, N'電腦機殼', 20, N'2022-12-19@081437#9841.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductDescribe], [ProductStocks], [ProductImage]) VALUES (8, N'PSU', 1500, N'電腦電源供應器', 15, N'2022-12-19@081453#1658.jpg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice], [ProductDescribe], [ProductStocks], [ProductImage]) VALUES (9, N'OS', 4000, N'電腦作業系統', 30, N'2022-12-19@081507#8334.jpg')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Member]    Script Date: 2022/12/19 08:21:22 ******/
ALTER TABLE [dbo].[Member] ADD  CONSTRAINT [IX_Member] UNIQUE NONCLUSTERED 
(
	[MemberEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [MidProject] SET  READ_WRITE 
GO
