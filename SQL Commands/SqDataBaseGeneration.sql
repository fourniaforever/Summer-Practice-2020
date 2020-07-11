USE [master]
GO

/****** Object:  Database [ShopsRates]    Script Date: 11.07.2020 18:31:54 ******/
CREATE DATABASE [ShopsRates]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopsRates', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ShopsRates.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ShopsRates_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ShopsRates_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopsRates].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ShopsRates] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ShopsRates] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ShopsRates] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ShopsRates] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ShopsRates] SET ARITHABORT OFF 
GO

ALTER DATABASE [ShopsRates] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ShopsRates] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ShopsRates] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ShopsRates] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ShopsRates] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ShopsRates] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ShopsRates] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ShopsRates] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ShopsRates] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ShopsRates] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ShopsRates] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ShopsRates] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ShopsRates] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ShopsRates] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ShopsRates] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ShopsRates] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ShopsRates] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ShopsRates] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [ShopsRates] SET  MULTI_USER 
GO

ALTER DATABASE [ShopsRates] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ShopsRates] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ShopsRates] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ShopsRates] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [ShopsRates] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ShopsRates] SET QUERY_STORE = OFF
GO

ALTER DATABASE [ShopsRates] SET  READ_WRITE 
GO

