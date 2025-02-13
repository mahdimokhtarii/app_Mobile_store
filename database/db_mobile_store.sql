USE [master]
GO
/****** Object:  Database [DB_Mobile_Store]    Script Date: 2/13/2025 11:43:32 PM ******/
CREATE DATABASE [DB_Mobile_Store]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_Mobile_Store', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DB_Mobile_Store.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_Mobile_Store_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DB_Mobile_Store_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DB_Mobile_Store] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Mobile_Store].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_Mobile_Store] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_Mobile_Store] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_Mobile_Store] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_Mobile_Store] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_Mobile_Store] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET RECOVERY FULL 
GO
ALTER DATABASE [DB_Mobile_Store] SET  MULTI_USER 
GO
ALTER DATABASE [DB_Mobile_Store] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_Mobile_Store] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_Mobile_Store] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_Mobile_Store] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_Mobile_Store] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_Mobile_Store] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DB_Mobile_Store', N'ON'
GO
ALTER DATABASE [DB_Mobile_Store] SET QUERY_STORE = ON
GO
ALTER DATABASE [DB_Mobile_Store] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DB_Mobile_Store]
GO
/****** Object:  Table [dbo].[tbl_Category]    Script Date: 2/13/2025 11:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Category](
	[Category_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Category] PRIMARY KEY CLUSTERED 
(
	[Category_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Customer]    Script Date: 2/13/2025 11:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Customer](
	[Customer_id] [nvarchar](50) NOT NULL,
	[Customer_first_name] [nvarchar](50) NOT NULL,
	[Customer_last_name] [nvarchar](50) NOT NULL,
	[Customer_address] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_Customer] PRIMARY KEY CLUSTERED 
(
	[Customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Device]    Script Date: 2/13/2025 11:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Device](
	[Device_id] [int] IDENTITY(1,1) NOT NULL,
	[Device_model] [nvarchar](50) NOT NULL,
	[Device_display_type] [nvarchar](50) NULL,
	[Device_dim] [nvarchar](50) NULL,
	[Device_memory] [nvarchar](50) NULL,
	[Device_ram] [nvarchar](50) NULL,
	[Device_coment] [nvarchar](max) NULL,
	[Category_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Device] PRIMARY KEY CLUSTERED 
(
	[Device_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Factor_buy]    Script Date: 2/13/2025 11:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Factor_buy](
	[Factor_buy_id] [int] NOT NULL,
	[personnel_id] [int] NOT NULL,
	[Customer_id] [nvarchar](50) NOT NULL,
	[Factor_buy_date] [date] NOT NULL,
	[Factor_buy_cost] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Factor_buy] PRIMARY KEY CLUSTERED 
(
	[Factor_buy_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Factor_device_buy]    Script Date: 2/13/2025 11:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Factor_device_buy](
	[Factor_device_buy_number] [int] NOT NULL,
	[Mydevice_id] [int] NOT NULL,
	[Factor_buy_id] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Factor_device_buy] PRIMARY KEY CLUSTERED 
(
	[Mydevice_id] ASC,
	[Factor_buy_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Factor_repair]    Script Date: 2/13/2025 11:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Factor_repair](
	[Factor_repair_id] [int] NOT NULL,
	[Factor_repair_date] [date] NOT NULL,
	[Personnel_id] [int] NOT NULL,
	[Customer_id] [nvarchar](50) NOT NULL,
	[Factor_repair_cost] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Factor_repair] PRIMARY KEY CLUSTERED 
(
	[Factor_repair_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Factor_repair_device]    Script Date: 2/13/2025 11:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Factor_repair_device](
	[Factor_repair_device] [nvarchar](50) NOT NULL,
	[Factor_repair_id] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Factor_repair_device] PRIMARY KEY CLUSTERED 
(
	[Factor_repair_device] ASC,
	[Factor_repair_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Mydevice]    Script Date: 2/13/2025 11:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Mydevice](
	[Mydevice_id] [int] IDENTITY(1,1) NOT NULL,
	[Mydevice_number] [int] NULL,
	[Mydevice_cost] [money] NULL,
	[Device_id] [int] NULL,
 CONSTRAINT [PK_tbl_Mydevice] PRIMARY KEY CLUSTERED 
(
	[Mydevice_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Personnel]    Script Date: 2/13/2025 11:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Personnel](
	[Personnel_id] [int] IDENTITY(201,1) NOT NULL,
	[Personnel_first_name] [nvarchar](50) NOT NULL,
	[personnel_last_name] [nvarchar](50) NOT NULL,
	[Personnel_national_code] [nvarchar](50) NOT NULL,
	[Personnel_city] [nchar](10) NOT NULL,
	[Personnel_address] [nvarchar](max) NOT NULL,
	[Personnel_mobile] [nvarchar](50) NOT NULL,
	[Personnel_account_number] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Personel] PRIMARY KEY CLUSTERED 
(
	[Personnel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tbl_Customer_1]    Script Date: 2/13/2025 11:43:32 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tbl_Customer_1] ON [dbo].[tbl_Customer]
(
	[Customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_tbl_Mydevice]    Script Date: 2/13/2025 11:43:32 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tbl_Mydevice] ON [dbo].[tbl_Mydevice]
(
	[Device_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_Device]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Device_tbl_Category] FOREIGN KEY([Category_name])
REFERENCES [dbo].[tbl_Category] ([Category_name])
GO
ALTER TABLE [dbo].[tbl_Device] CHECK CONSTRAINT [FK_tbl_Device_tbl_Category]
GO
ALTER TABLE [dbo].[tbl_Factor_buy]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Factor_buy_tbl_Customer] FOREIGN KEY([Customer_id])
REFERENCES [dbo].[tbl_Customer] ([Customer_id])
GO
ALTER TABLE [dbo].[tbl_Factor_buy] CHECK CONSTRAINT [FK_tbl_Factor_buy_tbl_Customer]
GO
ALTER TABLE [dbo].[tbl_Factor_buy]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Factor_buy_tbl_Personel] FOREIGN KEY([personnel_id])
REFERENCES [dbo].[tbl_Personnel] ([Personnel_id])
GO
ALTER TABLE [dbo].[tbl_Factor_buy] CHECK CONSTRAINT [FK_tbl_Factor_buy_tbl_Personel]
GO
ALTER TABLE [dbo].[tbl_Factor_device_buy]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Factor_device_buy_tbl_Factor_buy] FOREIGN KEY([Factor_buy_id])
REFERENCES [dbo].[tbl_Factor_buy] ([Factor_buy_id])
GO
ALTER TABLE [dbo].[tbl_Factor_device_buy] CHECK CONSTRAINT [FK_tbl_Factor_device_buy_tbl_Factor_buy]
GO
ALTER TABLE [dbo].[tbl_Factor_device_buy]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Factor_device_buy_tbl_Mydevice1] FOREIGN KEY([Mydevice_id])
REFERENCES [dbo].[tbl_Mydevice] ([Mydevice_id])
GO
ALTER TABLE [dbo].[tbl_Factor_device_buy] CHECK CONSTRAINT [FK_tbl_Factor_device_buy_tbl_Mydevice1]
GO
ALTER TABLE [dbo].[tbl_Factor_repair]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Factor_repair_tbl_Customer] FOREIGN KEY([Customer_id])
REFERENCES [dbo].[tbl_Customer] ([Customer_id])
GO
ALTER TABLE [dbo].[tbl_Factor_repair] CHECK CONSTRAINT [FK_tbl_Factor_repair_tbl_Customer]
GO
ALTER TABLE [dbo].[tbl_Factor_repair]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Factor_repair_tbl_Personel] FOREIGN KEY([Personnel_id])
REFERENCES [dbo].[tbl_Personnel] ([Personnel_id])
GO
ALTER TABLE [dbo].[tbl_Factor_repair] CHECK CONSTRAINT [FK_tbl_Factor_repair_tbl_Personel]
GO
ALTER TABLE [dbo].[tbl_Factor_repair_device]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Factor_repair_device_tbl_Factor_repair1] FOREIGN KEY([Factor_repair_id])
REFERENCES [dbo].[tbl_Factor_repair] ([Factor_repair_id])
GO
ALTER TABLE [dbo].[tbl_Factor_repair_device] CHECK CONSTRAINT [FK_tbl_Factor_repair_device_tbl_Factor_repair1]
GO
ALTER TABLE [dbo].[tbl_Mydevice]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Mydevice_tbl_Device] FOREIGN KEY([Device_id])
REFERENCES [dbo].[tbl_Device] ([Device_id])
GO
ALTER TABLE [dbo].[tbl_Mydevice] CHECK CONSTRAINT [FK_tbl_Mydevice_tbl_Device]
GO
USE [master]
GO
ALTER DATABASE [DB_Mobile_Store] SET  READ_WRITE 
GO
