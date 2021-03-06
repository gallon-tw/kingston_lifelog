USE [master]
GO
/****** Object:  Database [mydb]    Script Date: 2019/1/1 下午 02:21:14 ******/
CREATE DATABASE [mydb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mydb', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\mydb.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'mydb_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\mydb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [mydb] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mydb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mydb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mydb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mydb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mydb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mydb] SET ARITHABORT OFF 
GO
ALTER DATABASE [mydb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [mydb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mydb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mydb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mydb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mydb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mydb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mydb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mydb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mydb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [mydb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mydb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mydb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mydb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mydb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mydb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mydb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mydb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [mydb] SET  MULTI_USER 
GO
ALTER DATABASE [mydb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mydb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mydb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [mydb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [mydb]
GO
USE [mydb]
GO
/****** Object:  Sequence [dbo].[seq_lifelog]    Script Date: 2019/1/1 下午 02:21:14 ******/
CREATE SEQUENCE [dbo].[seq_lifelog] 
 AS [bigint]
 START WITH 10000
 INCREMENT BY 1
 MINVALUE 10000
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[lifelog]    Script Date: 2019/1/1 下午 02:21:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lifelog](
	[id] [int] NULL,
	[content] [nvarchar](4000) NULL,
	[user_id] [int] NULL,
	[title] [nvarchar](1000) NULL,
	[shift_date] [date] NULL,
	[weather_code] [nvarchar](10) NULL,
	[weather_text] [nvarchar](30) NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
	[location] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sheet1$]    Script Date: 2019/1/1 下午 02:21:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sheet1$](
	[F1] [float] NULL,
	[F2] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 2019/1/1 下午 02:21:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] NULL,
	[user_name] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[weather_file_map]    Script Date: 2019/1/1 下午 02:21:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[weather_file_map](
	[weather_code] [nvarchar](10) NULL,
	[file_name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [mydb] SET  READ_WRITE 
GO
