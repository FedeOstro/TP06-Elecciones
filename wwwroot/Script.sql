USE [Elecciones2023]
GO
/****** Object:  User [alumno]    Script Date: 12/7/2023 08:10:21 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Candidato]    Script Date: 12/7/2023 08:10:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidato](
	[IdCandidato] [int] IDENTITY(1,1) NOT NULL,
	[IdPartido] [int] NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Foto] [nvarchar](50) NULL,
	[Postulacion] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partido]    Script Date: 12/7/2023 08:10:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partido](
	[IdPartido] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Logo] [nvarchar](50) NULL,
	[SitioWeb] [nvarchar](50) NULL,
	[FechaFundacion] [date] NOT NULL,
	[CantidadDiputados] [int] NOT NULL,
	[CantidadSenadores] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Partido] ON 

INSERT [dbo].[Partido] ([IdPartido], [Nombre], [Logo], [SitioWeb], [FechaFundacion], [CantidadDiputados], [CantidadSenadores]) VALUES (2, N'Unión por la Patria', N'Union_por_la_Patria_logo.png', NULL, CAST(N'2023-06-14' AS Date), 118, 31)
INSERT [dbo].[Partido] ([IdPartido], [Nombre], [Logo], [SitioWeb], [FechaFundacion], [CantidadDiputados], [CantidadSenadores]) VALUES (4, N'Juntos por el Cambio', N'Juntos-Por-El-Cambio-Logo.png', N'https://jxc.com.ar/', CAST(N'2023-06-12' AS Date), 116, 33)
INSERT [dbo].[Partido] ([IdPartido], [Nombre], [Logo], [SitioWeb], [FechaFundacion], [CantidadDiputados], [CantidadSenadores]) VALUES (7, N'La Libertad Avanza', N'Logo_La_Libertad_Avanza.png', N'https://lalibertadavanza.com.ar/', CAST(N'2023-07-14' AS Date), 3, 0)
SET IDENTITY_INSERT [dbo].[Partido] OFF
GO
