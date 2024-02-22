USE [master]
GO
/****** Object:  Database [FahritdinovDb]    Script Date: 14.02.2024 9:43:13 ******/
CREATE DATABASE [FahritdinovDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FahritdinovDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FahritdinovDb.mdf' , SIZE = 13248KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'FahritdinovDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FahritdinovDb_log.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FahritdinovDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FahritdinovDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FahritdinovDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FahritdinovDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FahritdinovDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FahritdinovDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FahritdinovDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [FahritdinovDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FahritdinovDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FahritdinovDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FahritdinovDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FahritdinovDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FahritdinovDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FahritdinovDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FahritdinovDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FahritdinovDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FahritdinovDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FahritdinovDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FahritdinovDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FahritdinovDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FahritdinovDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FahritdinovDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FahritdinovDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FahritdinovDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FahritdinovDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FahritdinovDb] SET  MULTI_USER 
GO
ALTER DATABASE [FahritdinovDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FahritdinovDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FahritdinovDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FahritdinovDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [FahritdinovDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FahritdinovDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [FahritdinovDb] SET QUERY_STORE = OFF
GO
USE [FahritdinovDb]
GO
/****** Object:  Table [dbo].[(инв)Должность-подстановка]    Script Date: 14.02.2024 9:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[(инв)Должность-подстановка](
	[Должность] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[в непригодном состоянии]    Script Date: 14.02.2024 9:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[в непригодном состоянии](
	[Инвентарный номер] [int] NOT NULL,
	[Вид] [nvarchar](60) NULL,
	[Кол-во(фактическое)] [int] NULL,
	[Состояние] [nvarchar](255) NULL,
	[ФИО(ИНВ)] [nvarchar](255) NULL,
	[ФИО(ОТВ)] [nvarchar](255) NULL,
	[Зона ответсвености] [nvarchar](255) NULL,
 CONSTRAINT [PK_в непригодном состоянии] PRIMARY KEY CLUSTERED 
(
	[Инвентарный номер] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Вид_подстановвка]    Script Date: 14.02.2024 9:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Вид_подстановвка](
	[Вид] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Группа инвентаризации]    Script Date: 14.02.2024 9:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Группа инвентаризации](
	[ID-G] [smallint] NOT NULL,
	[ФИО] [nvarchar](255) NULL,
	[Должность в группе] [nvarchar](255) NULL,
	[Область ответсвености] [nvarchar](255) NULL,
 CONSTRAINT [PK_Группа инвентаризации] PRIMARY KEY CLUSTERED 
(
	[ID-G] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Данные об имуществе( по документации)]    Script Date: 14.02.2024 9:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Данные об имуществе( по документации)](
	[Инвентарный номер] [int] NOT NULL,
	[Вид] [nvarchar](100) NULL,
	[Ответсвеные лица] [smallint] NULL,
	[Кол-во] [int] NULL,
	[Состояние] [nvarchar](60) NULL,
	[Наименование] [nvarchar](255) NULL,
 CONSTRAINT [PK_Данные об имуществе( по документации)] PRIMARY KEY CLUSTERED 
(
	[Инвентарный номер] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Данные об имущетсве( фактически)]    Script Date: 14.02.2024 9:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Данные об имущетсве( фактически)](
	[Инвентарный номер] [int] NOT NULL,
	[Вид] [nvarchar](60) NULL,
	[Кол-во(фактическое)] [int] NULL,
	[Состояние] [nvarchar](255) NULL,
	[ФИО(ИНВ)] [nvarchar](255) NULL,
	[ФИО(ОТВ)] [nvarchar](255) NULL,
	[Зона ответсвености] [nvarchar](255) NULL,
 CONSTRAINT [PK_Данные об имущетсве( фактически)] PRIMARY KEY CLUSTERED 
(
	[Инвентарный номер] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Область ответсвености подстановка]    Script Date: 14.02.2024 9:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Область ответсвености подстановка](
	[Область ответвсености] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ОЛ]    Script Date: 14.02.2024 9:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ОЛ](
	[ID] [smallint] NOT NULL,
	[ФИО] [nvarchar](100) NULL,
	[Зона отв-и] [nvarchar](100) NULL,
	[Должность] [nvarchar](100) NULL,
 CONSTRAINT [PK_ОЛ] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Расхождение]    Script Date: 14.02.2024 9:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Расхождение](
	[Инвентарный номер] [int] NOT NULL,
	[Вид] [nvarchar](60) NULL,
	[Кол-во(фактическое)] [int] NULL,
	[Состояние] [nvarchar](255) NULL,
	[ФИО(ИНВ)] [nvarchar](255) NULL,
	[ФИО(ОТВ)] [nvarchar](255) NULL,
	[Зона ответсвености] [nvarchar](255) NULL,
	[Расхождение] [int] NULL,
 CONSTRAINT [PK_Расхождение] PRIMARY KEY CLUSTERED 
(
	[Инвентарный номер] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Расхождения в состоянии имущества]    Script Date: 14.02.2024 9:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Расхождения в состоянии имущества](
	[Инвентарный номер] [int] NOT NULL,
	[Вид] [nvarchar](60) NULL,
	[Кол-во(фактическое)] [int] NULL,
	[Данные об имущетсве( фактически).Состояние] [nvarchar](255) NULL,
	[ФИО(ИНВ)] [nvarchar](255) NULL,
	[ФИО(ОТВ)] [nvarchar](255) NULL,
	[Зона ответсвености] [nvarchar](255) NULL,
	[Данные об имуществе( по документации).Состояние] [nvarchar](60) NULL,
 CONSTRAINT [PK_Расхождения в состоянии имущества] PRIMARY KEY CLUSTERED 
(
	[Инвентарный номер] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Состояние-подстановка]    Script Date: 14.02.2024 9:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Состояние-подстановка](
	[Состояние] [nvarchar](255) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Данные об имуществе( по документации)]  WITH CHECK ADD  CONSTRAINT [FK_Данные об имуществе( по документации)_ОЛ] FOREIGN KEY([Ответсвеные лица])
REFERENCES [dbo].[ОЛ] ([ID])
GO
ALTER TABLE [dbo].[Данные об имуществе( по документации)] CHECK CONSTRAINT [FK_Данные об имуществе( по документации)_ОЛ]
GO
ALTER TABLE [dbo].[Данные об имущетсве( фактически)]  WITH CHECK ADD  CONSTRAINT [FK_Данные об имущетсве( фактически)_Данные об имуществе( по документации)] FOREIGN KEY([Инвентарный номер])
REFERENCES [dbo].[Данные об имуществе( по документации)] ([Инвентарный номер])
GO
ALTER TABLE [dbo].[Данные об имущетсве( фактически)] CHECK CONSTRAINT [FK_Данные об имущетсве( фактически)_Данные об имуществе( по документации)]
GO
USE [master]
GO
ALTER DATABASE [FahritdinovDb] SET  READ_WRITE 
GO
