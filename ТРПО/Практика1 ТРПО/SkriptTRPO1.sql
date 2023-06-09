USE [master]
GO
/****** Object:  Database [Warehoyse1]    Script Date: 23.04.2023 20:55:53 ******/
CREATE DATABASE [Warehoyse1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Warehoyse1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Warehoyse1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Warehoyse1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Warehoyse1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Warehoyse1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Warehoyse1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Warehoyse1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Warehoyse1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Warehoyse1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Warehoyse1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Warehoyse1] SET ARITHABORT OFF 
GO
ALTER DATABASE [Warehoyse1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Warehoyse1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Warehoyse1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Warehoyse1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Warehoyse1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Warehoyse1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Warehoyse1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Warehoyse1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Warehoyse1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Warehoyse1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Warehoyse1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Warehoyse1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Warehoyse1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Warehoyse1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Warehoyse1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Warehoyse1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Warehoyse1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Warehoyse1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Warehoyse1] SET  MULTI_USER 
GO
ALTER DATABASE [Warehoyse1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Warehoyse1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Warehoyse1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Warehoyse1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Warehoyse1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Warehoyse1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Warehoyse1] SET QUERY_STORE = OFF
GO
USE [Warehoyse1]
GO
/****** Object:  Table [dbo].[Byers]    Script Date: 23.04.2023 20:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Byers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[Address] [nchar](150) NOT NULL,
	[Phone] [int] NOT NULL,
 CONSTRAINT [PK_Byers] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deals]    Script Date: 23.04.2023 20:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deals](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nchar](150) NOT NULL,
	[ByersName] [nchar](50) NOT NULL,
	[Count] [int] NOT NULL,
	[Summa] [money] NOT NULL,
 CONSTRAINT [PK_Deals] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Measurnament]    Script Date: 23.04.2023 20:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Measurnament](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Measurnament_1] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 23.04.2023 20:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](150) NOT NULL,
	[Count] [int] NOT NULL,
	[MeasurnamentName] [nchar](10) NOT NULL,
	[ProviderName] [nchar](50) NOT NULL,
	[PurchasePprice] [int] NOT NULL,
	[SellingPrice] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 23.04.2023 20:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[Address] [nchar](150) NOT NULL,
	[Phone] [int] NOT NULL,
 CONSTRAINT [PK_Provider] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 23.04.2023 20:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nchar](50) NOT NULL,
	[Password] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Byers] ON 

INSERT [dbo].[Byers] ([id], [Name], [Address], [Phone]) VALUES (3, N'Spar                                              ', N'Богдана Хмельницкого                                                                                                                                  ', 7778493)
INSERT [dbo].[Byers] ([id], [Name], [Address], [Phone]) VALUES (2, N'Магнит                                            ', N'Ш. Металлургов                                                                                                                                        ', 88888888)
SET IDENTITY_INSERT [dbo].[Byers] OFF
GO
SET IDENTITY_INSERT [dbo].[Measurnament] ON 

INSERT [dbo].[Measurnament] ([id], [Name]) VALUES (1, N'кг        ')
INSERT [dbo].[Measurnament] ([id], [Name]) VALUES (2, N'шт        ')
SET IDENTITY_INSERT [dbo].[Measurnament] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([id], [Name], [Count], [MeasurnamentName], [ProviderName], [PurchasePprice], [SellingPrice]) VALUES (3, N'Молоко                                                                                                                                                ', 22, N'шт        ', N'Upiter                                            ', 40, 65)
INSERT [dbo].[Products] ([id], [Name], [Count], [MeasurnamentName], [ProviderName], [PurchasePprice], [SellingPrice]) VALUES (4, N'Хлеб                                                                                                                                                  ', 100, N'шт        ', N'Челяб                                             ', 10, 25)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Provider] ON 

INSERT [dbo].[Provider] ([id], [Name], [Address], [Phone]) VALUES (2, N'MoskowCity                                        ', N'Москва                                                                                                                                                ', 7777777)
INSERT [dbo].[Provider] ([id], [Name], [Address], [Phone]) VALUES (3, N'Upiter                                            ', N'Краснодар                                                                                                                                             ', 2897403)
INSERT [dbo].[Provider] ([id], [Name], [Address], [Phone]) VALUES (1, N'Челяб                                             ', N'Челябинск                                                                                                                                             ', 8922201)
SET IDENTITY_INSERT [dbo].[Provider] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [Login], [Password]) VALUES (1, N'admin                                             ', N'admin                                             ')
INSERT [dbo].[Users] ([id], [Login], [Password]) VALUES (2, N'kamilla                                           ', N'kamilla                                           ')
INSERT [dbo].[Users] ([id], [Login], [Password]) VALUES (3, N'admin                                             ', N'kamilla                                           ')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Deals]  WITH CHECK ADD  CONSTRAINT [FK_Deals_Byers] FOREIGN KEY([ByersName])
REFERENCES [dbo].[Byers] ([Name])
GO
ALTER TABLE [dbo].[Deals] CHECK CONSTRAINT [FK_Deals_Byers]
GO
ALTER TABLE [dbo].[Deals]  WITH CHECK ADD  CONSTRAINT [FK_Deals_Products] FOREIGN KEY([ProductName])
REFERENCES [dbo].[Products] ([Name])
GO
ALTER TABLE [dbo].[Deals] CHECK CONSTRAINT [FK_Deals_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Measurnament1] FOREIGN KEY([MeasurnamentName])
REFERENCES [dbo].[Measurnament] ([Name])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Measurnament1]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Provider1] FOREIGN KEY([ProviderName])
REFERENCES [dbo].[Provider] ([Name])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Provider1]
GO
USE [master]
GO
ALTER DATABASE [Warehoyse1] SET  READ_WRITE 
GO
