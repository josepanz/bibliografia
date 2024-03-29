USE [master]
GO
/****** Object:  Database [bibliografia]    Script Date: 20/11/2019 13:35:35 ******/
CREATE DATABASE [bibliografia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bibliografia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVER\MSSQL\DATA\bibliografia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bibliografia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVER\MSSQL\DATA\bibliografia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [bibliografia] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bibliografia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bibliografia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bibliografia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bibliografia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bibliografia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bibliografia] SET ARITHABORT OFF 
GO
ALTER DATABASE [bibliografia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bibliografia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bibliografia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bibliografia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bibliografia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bibliografia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bibliografia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bibliografia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bibliografia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bibliografia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bibliografia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bibliografia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bibliografia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bibliografia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bibliografia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bibliografia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bibliografia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bibliografia] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bibliografia] SET  MULTI_USER 
GO
ALTER DATABASE [bibliografia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bibliografia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bibliografia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bibliografia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bibliografia] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bibliografia] SET QUERY_STORE = OFF
GO
USE [bibliografia]
GO
/****** Object:  Table [dbo].[autor]    Script Date: 20/11/2019 13:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[autor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_autor] [varchar](50) NULL,
 CONSTRAINT [PK_autor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bibliografia]    Script Date: 20/11/2019 13:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bibliografia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[materia_id] [int] NOT NULL,
	[promocion_id] [int] NOT NULL,
	[ano] [int] NOT NULL,
 CONSTRAINT [PK_bibliografia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_bibliografia]    Script Date: 20/11/2019 13:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_bibliografia](
	[id] [int] NULL,
	[libro_id] [int] NULL,
	[descripcion_detalle] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[edicion]    Script Date: 20/11/2019 13:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[edicion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_edicion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[editorial]    Script Date: 20/11/2019 13:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[editorial](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_editorial] [varchar](50) NULL,
 CONSTRAINT [PK_editorial] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[facultad]    Script Date: 20/11/2019 13:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[facultad](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_facultad] [varchar](50) NULL,
	[codigo_facultad] [varchar](50) NULL,
 CONSTRAINT [PK_facultad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[libro]    Script Date: 20/11/2019 13:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[libro](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[isbn] [varchar](50) NOT NULL,
	[titulo] [varchar](50) NULL,
	[edicion_id] [int] NULL,
	[editorial_id] [int] NULL,
	[autor_id] [int] NULL,
	[ano_publicacion] [int] NULL,
 CONSTRAINT [PK_libro_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materia]    Script Date: 20/11/2019 13:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo_materia] [varchar](50) NULL,
	[descripcion_materia] [varchar](50) NULL,
	[facultad_id] [int] NULL,
 CONSTRAINT [PK_materia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[promocion]    Script Date: 20/11/2019 13:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[promocion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_promocion] [varchar](50) NULL,
	[ano_promocion] [nchar](10) NULL,
	[nro_promocion] [int] NULL,
 CONSTRAINT [PK_promocion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[bibliografia]  WITH CHECK ADD  CONSTRAINT [materia_id] FOREIGN KEY([materia_id])
REFERENCES [dbo].[materia] ([id])
GO
ALTER TABLE [dbo].[bibliografia] CHECK CONSTRAINT [materia_id]
GO
ALTER TABLE [dbo].[bibliografia]  WITH CHECK ADD  CONSTRAINT [promocion_id] FOREIGN KEY([promocion_id])
REFERENCES [dbo].[promocion] ([id])
GO
ALTER TABLE [dbo].[bibliografia] CHECK CONSTRAINT [promocion_id]
GO
ALTER TABLE [dbo].[detalle_bibliografia]  WITH CHECK ADD  CONSTRAINT [libro_id] FOREIGN KEY([libro_id])
REFERENCES [dbo].[libro] ([id])
GO
ALTER TABLE [dbo].[detalle_bibliografia] CHECK CONSTRAINT [libro_id]
GO
ALTER TABLE [dbo].[materia]  WITH CHECK ADD  CONSTRAINT [FK_materia_facultad] FOREIGN KEY([facultad_id])
REFERENCES [dbo].[facultad] ([id])
GO
ALTER TABLE [dbo].[materia] CHECK CONSTRAINT [FK_materia_facultad]
GO
USE [master]
GO
ALTER DATABASE [bibliografia] SET  READ_WRITE 
GO
