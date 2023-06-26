USE [Elecciones2023]
GO
/****** Object:  User [alumno]    Script Date: 26/6/2023 09:47:02 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Candidato]    Script Date: 26/6/2023 09:47:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidato](
	[IdCandidato] [int] NOT NULL,
	[IdPartido] [int] NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Foto] [nvarchar](50) NULL,
	[Postulacion] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partido]    Script Date: 26/6/2023 09:47:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partido](
	[IdPartido] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Logo] [nvarchar](50) NULL,
	[SitioWeb] [nvarchar](50) NULL,
	[FechaFundacion] [date] NOT NULL,
	[CantidadDiputados] [int] NOT NULL,
	[CantidadSenadores] [int] NOT NULL
) ON [PRIMARY]
GO
