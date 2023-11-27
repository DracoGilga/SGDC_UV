USE [master]
GO
/****** Object:  Database [DBConstancias]    Script Date: 27/11/2023 07:43:39 a. m. ******/
CREATE DATABASE [DBConstancias]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBConstancias', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLTBD\MSSQL\DATA\DBConstancias.ndf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBConstancias_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLTBD\MSSQL\DATA\DBConstancias_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DBConstancias] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBConstancias].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBConstancias] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBConstancias] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBConstancias] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBConstancias] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBConstancias] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBConstancias] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBConstancias] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBConstancias] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBConstancias] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBConstancias] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBConstancias] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBConstancias] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBConstancias] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBConstancias] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBConstancias] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBConstancias] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBConstancias] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBConstancias] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBConstancias] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBConstancias] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBConstancias] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBConstancias] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBConstancias] SET RECOVERY FULL 
GO
ALTER DATABASE [DBConstancias] SET  MULTI_USER 
GO
ALTER DATABASE [DBConstancias] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBConstancias] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBConstancias] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBConstancias] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBConstancias] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBConstancias] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBConstancias', N'ON'
GO
ALTER DATABASE [DBConstancias] SET QUERY_STORE = ON
GO
ALTER DATABASE [DBConstancias] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DBConstancias]
GO
/****** Object:  Table [dbo].[Constancia]    Script Date: 27/11/2023 07:43:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Constancia](
	[FK_Id_Firma] [int] NOT NULL,
	[fechaCreacionConstancia] [date] NOT NULL,
	[Id_Constancia] [int] NOT NULL,
	[FK_id_Profesor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Constancia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConstanciaImparticion]    Script Date: 27/11/2023 07:43:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConstanciaImparticion](
	[Id_constanciaImparticion] [int] NOT NULL,
	[bloque] [varchar](10) NOT NULL,
	[credito] [varchar](10) NOT NULL,
	[esperienciaEducativa] [varchar](100) NOT NULL,
	[hora] [time](7) NOT NULL,
	[mes] [date] NOT NULL,
	[prograamaEducativo] [varchar](255) NOT NULL,
	[seccion] [varchar](255) NOT NULL,
	[semana] [varchar](255) NOT NULL,
	[FK_Id_constancia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_constanciaImparticion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConstanciaJurado]    Script Date: 27/11/2023 07:43:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConstanciaJurado](
	[Id_constanciaJurado] [int] NOT NULL,
	[fechaPresentacion] [date] NOT NULL,
	[modalidad] [varchar](10) NOT NULL,
	[nombreAlumno] [varchar](100) NOT NULL,
	[nombreProyecto] [varchar](100) NOT NULL,
	[resultado] [varchar](100) NOT NULL,
	[FK_Id_constancia] [int] NOT NULL,
 CONSTRAINT [PK__Constanc__F3B1B976D6D87DD4] PRIMARY KEY CLUSTERED 
(
	[Id_constanciaJurado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConstanciaPLADEA]    Script Date: 27/11/2023 07:43:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConstanciaPLADEA](
	[Id_constanciaPLADEA] [int] NOT NULL,
	[acciones] [varchar](50) NOT NULL,
	[ejeEstrategico] [varchar](50) NOT NULL,
	[metas] [varchar](50) NOT NULL,
	[objetivosGenerales] [varchar](60) NOT NULL,
	[programaEstrategico] [varchar](50) NOT NULL,
	[FK_Id_constancia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_constanciaPLADEA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConstanciaProyecto]    Script Date: 27/11/2023 07:43:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConstanciaProyecto](
	[Id_constanciaProyecto] [int] NOT NULL,
	[duracion] [varchar](10) NOT NULL,
	[impactoObtenido] [varchar](255) NOT NULL,
	[lugarDesarrollo] [varchar](100) NOT NULL,
	[nombreAlumno] [varchar](100) NOT NULL,
	[proyectoRealizado] [varchar](100) NOT NULL,
	[FK_Id_constancia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_constanciaProyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FirmaElectronica]    Script Date: 27/11/2023 07:43:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FirmaElectronica](
	[Id_firma] [int] NOT NULL,
	[clave] [varchar](30) NOT NULL,
	[fechaCreacion] [date] NOT NULL,
	[fechaExpiracion] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_firma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonalAdministrativo]    Script Date: 27/11/2023 07:43:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalAdministrativo](
	[Id_personalAdministrativo] [int] NOT NULL,
	[nombreCompleto] [varchar](255) NOT NULL,
	[password] [varchar](60) NOT NULL,
	[usuario] [varchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_personalAdministrativo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 27/11/2023 07:43:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[Id_profesor] [int] NOT NULL,
	[nombreCompleto] [varchar](100) NOT NULL,
	[numeroPersonal] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [fk_firma]    Script Date: 27/11/2023 07:43:40 a. m. ******/
CREATE NONCLUSTERED INDEX [fk_firma] ON [dbo].[Constancia]
(
	[FK_Id_Firma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_profesor]    Script Date: 27/11/2023 07:43:40 a. m. ******/
CREATE NONCLUSTERED INDEX [fk_profesor] ON [dbo].[Constancia]
(
	[FK_id_Profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_constancia]    Script Date: 27/11/2023 07:43:40 a. m. ******/
CREATE NONCLUSTERED INDEX [fk_constancia] ON [dbo].[ConstanciaImparticion]
(
	[FK_Id_constancia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_constancia]    Script Date: 27/11/2023 07:43:40 a. m. ******/
CREATE NONCLUSTERED INDEX [fk_constancia] ON [dbo].[ConstanciaJurado]
(
	[FK_Id_constancia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_constancia]    Script Date: 27/11/2023 07:43:40 a. m. ******/
CREATE NONCLUSTERED INDEX [fk_constancia] ON [dbo].[ConstanciaPLADEA]
(
	[FK_Id_constancia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_constancia]    Script Date: 27/11/2023 07:43:40 a. m. ******/
CREATE NONCLUSTERED INDEX [fk_constancia] ON [dbo].[ConstanciaProyecto]
(
	[FK_Id_constancia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Constancia]  WITH CHECK ADD FOREIGN KEY([FK_id_Profesor])
REFERENCES [dbo].[Profesor] ([Id_profesor])
GO
ALTER TABLE [dbo].[Constancia]  WITH CHECK ADD FOREIGN KEY([FK_Id_Firma])
REFERENCES [dbo].[FirmaElectronica] ([Id_firma])
GO
ALTER TABLE [dbo].[ConstanciaImparticion]  WITH CHECK ADD FOREIGN KEY([FK_Id_constancia])
REFERENCES [dbo].[Constancia] ([Id_Constancia])
GO
ALTER TABLE [dbo].[ConstanciaJurado]  WITH CHECK ADD FOREIGN KEY([FK_Id_constancia])
REFERENCES [dbo].[Constancia] ([Id_Constancia])
GO
ALTER TABLE [dbo].[ConstanciaPLADEA]  WITH CHECK ADD FOREIGN KEY([FK_Id_constancia])
REFERENCES [dbo].[Constancia] ([Id_Constancia])
GO
ALTER TABLE [dbo].[ConstanciaProyecto]  WITH CHECK ADD FOREIGN KEY([FK_Id_constancia])
REFERENCES [dbo].[Constancia] ([Id_Constancia])
GO
USE [master]
GO
ALTER DATABASE [DBConstancias] SET  READ_WRITE 
GO
