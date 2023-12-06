/*
 Navicat Premium Data Transfer

 Source Server         : Administracion de Base de datos
 Source Server Type    : SQL Server
 Source Server Version : 16001105 (16.00.1105)
 Source Host           : localhost:1433
 Source Catalog        : DBConstancias
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001105 (16.00.1105)
 File Encoding         : 65001

 Date: 05/12/2023 21:58:44
*/


-- ----------------------------
-- Table structure for Constancia
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Constancia]') AND type IN ('U'))
	DROP TABLE [dbo].[Constancia]
GO

CREATE TABLE [dbo].[Constancia] (
  [Id_Constancia] int  IDENTITY(1,1) NOT NULL,
  [fechaCreacionConstancia] date  NOT NULL,
  [FK_id_Profesor] int  NOT NULL,
  [FK_Id_Firma] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Constancia] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for ConstanciaImparticion
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ConstanciaImparticion]') AND type IN ('U'))
	DROP TABLE [dbo].[ConstanciaImparticion]
GO

CREATE TABLE [dbo].[ConstanciaImparticion] (
  [Id_constanciaImparticion] int  IDENTITY(1,1) NOT NULL,
  [bloque] varchar(10) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [credito] varchar(10) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [esperienciaEducativa] varchar(100) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [hora] nvarchar(10) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [mes] nvarchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [prograamaEducativo] varchar(255) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [seccion] varchar(255) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [semana] varchar(255) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [FK_Id_constancia] int  NOT NULL
)
GO

ALTER TABLE [dbo].[ConstanciaImparticion] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for ConstanciaJurado
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ConstanciaJurado]') AND type IN ('U'))
	DROP TABLE [dbo].[ConstanciaJurado]
GO

CREATE TABLE [dbo].[ConstanciaJurado] (
  [Id_constanciaJurado] int  IDENTITY(1,1) NOT NULL,
  [fechaPresentacion] date  NOT NULL,
  [modalidad] varchar(10) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [nombreAlumno] varchar(100) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [nombreProyecto] varchar(100) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [resultado] varchar(100) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Cargo] varchar(255) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Licenciatura] varchar(255) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [FK_Id_constancia] int  NOT NULL
)
GO

ALTER TABLE [dbo].[ConstanciaJurado] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for ConstanciaPLADEA
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ConstanciaPLADEA]') AND type IN ('U'))
	DROP TABLE [dbo].[ConstanciaPLADEA]
GO

CREATE TABLE [dbo].[ConstanciaPLADEA] (
  [Id_constanciaPLADEA] int  IDENTITY(1,1) NOT NULL,
  [acciones] varchar(50) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [ejeEstrategico] varchar(50) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [metas] varchar(50) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [objetivosGenerales] varchar(60) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [programaEstrategico] varchar(50) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [FK_Id_constancia] int  NOT NULL
)
GO

ALTER TABLE [dbo].[ConstanciaPLADEA] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for ConstanciaProyecto
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ConstanciaProyecto]') AND type IN ('U'))
	DROP TABLE [dbo].[ConstanciaProyecto]
GO

CREATE TABLE [dbo].[ConstanciaProyecto] (
  [Id_constanciaProyecto] int  IDENTITY(1,1) NOT NULL,
  [duracion] varchar(10) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [impactoObtenido] varchar(255) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [lugarDesarrollo] varchar(100) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [nombreAlumno] varchar(100) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [proyectoRealizado] varchar(100) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [FK_Id_constancia] int  NOT NULL
)
GO

ALTER TABLE [dbo].[ConstanciaProyecto] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for FirmaElectronica
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[FirmaElectronica]') AND type IN ('U'))
	DROP TABLE [dbo].[FirmaElectronica]
GO

CREATE TABLE [dbo].[FirmaElectronica] (
  [Id_firma] int  IDENTITY(1,1) NOT NULL,
  [clave] varchar(30) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [fechaCreacion] date  NOT NULL,
  [fechaExpiracion] date  NOT NULL
)
GO

ALTER TABLE [dbo].[FirmaElectronica] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for PersonalAdministrativo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonalAdministrativo]') AND type IN ('U'))
	DROP TABLE [dbo].[PersonalAdministrativo]
GO

CREATE TABLE [dbo].[PersonalAdministrativo] (
  [Id_personalAdministrativo] int  IDENTITY(1,1) NOT NULL,
  [nombreCompleto] varchar(255) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [password] varchar(60) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [usuario] varchar(60) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[PersonalAdministrativo] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Profesor
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Profesor]') AND type IN ('U'))
	DROP TABLE [dbo].[Profesor]
GO

CREATE TABLE [dbo].[Profesor] (
  [Id_profesor] int  IDENTITY(1,1) NOT NULL,
  [nombreCompleto] varchar(100) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [numeroPersonal] varchar(50) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Profesor] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Auto increment value for Constancia
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Constancia]', RESEED, 1060)
GO


-- ----------------------------
-- Indexes structure for table Constancia
-- ----------------------------
CREATE NONCLUSTERED INDEX [fk_firma]
ON [dbo].[Constancia] (
  [FK_Id_Firma] ASC
)
GO

CREATE NONCLUSTERED INDEX [fk_profesor]
ON [dbo].[Constancia] (
  [FK_id_Profesor] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table Constancia
-- ----------------------------
ALTER TABLE [dbo].[Constancia] ADD CONSTRAINT [PK__Constanc__B3DD462DA14458D3] PRIMARY KEY CLUSTERED ([Id_Constancia])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for ConstanciaImparticion
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[ConstanciaImparticion]', RESEED, 16)
GO


-- ----------------------------
-- Indexes structure for table ConstanciaImparticion
-- ----------------------------
CREATE NONCLUSTERED INDEX [fk_constancia]
ON [dbo].[ConstanciaImparticion] (
  [FK_Id_constancia] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table ConstanciaImparticion
-- ----------------------------
ALTER TABLE [dbo].[ConstanciaImparticion] ADD CONSTRAINT [PK__Constanc__C79AF49851F80E28] PRIMARY KEY CLUSTERED ([Id_constanciaImparticion])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for ConstanciaJurado
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[ConstanciaJurado]', RESEED, 11)
GO


-- ----------------------------
-- Indexes structure for table ConstanciaJurado
-- ----------------------------
CREATE NONCLUSTERED INDEX [fk_constancia]
ON [dbo].[ConstanciaJurado] (
  [FK_Id_constancia] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table ConstanciaJurado
-- ----------------------------
ALTER TABLE [dbo].[ConstanciaJurado] ADD CONSTRAINT [PK__Constanc__F3B1B976D6D87DD4] PRIMARY KEY CLUSTERED ([Id_constanciaJurado])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for ConstanciaPLADEA
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[ConstanciaPLADEA]', RESEED, 11)
GO


-- ----------------------------
-- Indexes structure for table ConstanciaPLADEA
-- ----------------------------
CREATE NONCLUSTERED INDEX [fk_constancia]
ON [dbo].[ConstanciaPLADEA] (
  [FK_Id_constancia] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table ConstanciaPLADEA
-- ----------------------------
ALTER TABLE [dbo].[ConstanciaPLADEA] ADD CONSTRAINT [PK__Constanc__7BA0623B90A45171] PRIMARY KEY CLUSTERED ([Id_constanciaPLADEA])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for ConstanciaProyecto
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[ConstanciaProyecto]', RESEED, 11)
GO


-- ----------------------------
-- Indexes structure for table ConstanciaProyecto
-- ----------------------------
CREATE NONCLUSTERED INDEX [fk_constancia]
ON [dbo].[ConstanciaProyecto] (
  [FK_Id_constancia] ASC
)
GO


-- ----------------------------
-- Primary Key structure for table ConstanciaProyecto
-- ----------------------------
ALTER TABLE [dbo].[ConstanciaProyecto] ADD CONSTRAINT [PK__Constanc__F3B1B976F4654CF7] PRIMARY KEY CLUSTERED ([Id_constanciaProyecto])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for FirmaElectronica
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[FirmaElectronica]', RESEED, 2007)
GO


-- ----------------------------
-- Primary Key structure for table FirmaElectronica
-- ----------------------------
ALTER TABLE [dbo].[FirmaElectronica] ADD CONSTRAINT [PK__Firma__D573DABEBE36ADEF] PRIMARY KEY CLUSTERED ([Id_firma])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for PersonalAdministrativo
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[PersonalAdministrativo]', RESEED, 10)
GO


-- ----------------------------
-- Primary Key structure for table PersonalAdministrativo
-- ----------------------------
ALTER TABLE [dbo].[PersonalAdministrativo] ADD CONSTRAINT [PK__Personal__2619A382289344F0] PRIMARY KEY CLUSTERED ([Id_personalAdministrativo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Profesor
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Profesor]', RESEED, 1003)
GO


-- ----------------------------
-- Primary Key structure for table Profesor
-- ----------------------------
ALTER TABLE [dbo].[Profesor] ADD CONSTRAINT [PK__Profesor__9298F53A4CFD12AA] PRIMARY KEY CLUSTERED ([Id_profesor])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Constancia
-- ----------------------------
ALTER TABLE [dbo].[Constancia] ADD CONSTRAINT [FK__Constanci__FK_Id__4CA06362] FOREIGN KEY ([FK_Id_Firma]) REFERENCES [dbo].[FirmaElectronica] ([Id_firma]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Constancia] ADD CONSTRAINT [FK__Constanci__FK_id__4BAC3F29] FOREIGN KEY ([FK_id_Profesor]) REFERENCES [dbo].[Profesor] ([Id_profesor]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table ConstanciaImparticion
-- ----------------------------
ALTER TABLE [dbo].[ConstanciaImparticion] ADD CONSTRAINT [FK__Constanci__FK_Id__47DBAE45] FOREIGN KEY ([FK_Id_constancia]) REFERENCES [dbo].[Constancia] ([Id_Constancia]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table ConstanciaJurado
-- ----------------------------
ALTER TABLE [dbo].[ConstanciaJurado] ADD CONSTRAINT [FK__Constanci__FK_Id__48CFD27E] FOREIGN KEY ([FK_Id_constancia]) REFERENCES [dbo].[Constancia] ([Id_Constancia]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table ConstanciaPLADEA
-- ----------------------------
ALTER TABLE [dbo].[ConstanciaPLADEA] ADD CONSTRAINT [FK__Constanci__FK_Id__49C3F6B7] FOREIGN KEY ([FK_Id_constancia]) REFERENCES [dbo].[Constancia] ([Id_Constancia]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table ConstanciaProyecto
-- ----------------------------
ALTER TABLE [dbo].[ConstanciaProyecto] ADD CONSTRAINT [FK__Constanci__FK_Id__4AB81AF0] FOREIGN KEY ([FK_Id_constancia]) REFERENCES [dbo].[Constancia] ([Id_Constancia]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

