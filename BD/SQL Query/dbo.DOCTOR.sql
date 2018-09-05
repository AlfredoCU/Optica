USE [Optica Industrial]
GO

/****** Object:  Table [dbo].[DOCTOR]    Script Date: 16/04/2018 01:58:05 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DOCTOR](
	[Id Doctor] [int] NOT NULL,
	[Nombre] [varchar](35) NOT NULL,
	[Apellido] [varchar](35) NOT NULL,
	[Edad] [int] NOT NULL,
	[Direccion] [varchar](55) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Matricula] [int] NOT NULL,
	[Especialidad] [varchar](20) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[Acceso] [varchar](50) NOT NULL,
	[Usuario] [varchar](25) NOT NULL,
	[Contrasena] [varchar](20) NOT NULL,
 CONSTRAINT [PK_DOCTOR1] PRIMARY KEY CLUSTERED 
(
	[Id Doctor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


