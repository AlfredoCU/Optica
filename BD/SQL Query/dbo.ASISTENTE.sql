USE [Optica Industrial]
GO

/****** Object:  Table [dbo].[ASISTENTE]    Script Date: 16/04/2018 01:56:08 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ASISTENTE](
	[ID Asistente] [int] NOT NULL,
	[Nombre] [varchar](35) NOT NULL,
	[Apellido] [varchar](35) NOT NULL,
	[Tipo de Asistente] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Telefono] [int] NOT NULL,
	[Direccion] [varchar](55) NOT NULL,
	[Email] [varchar](35) NOT NULL,
	[Acceso] [varchar](50) NOT NULL,
	[Usuario] [varchar](25) NOT NULL,
	[Contrasena] [varchar](20) NOT NULL,
 CONSTRAINT [PK_ASISTENTE1] PRIMARY KEY CLUSTERED 
(
	[ID Asistente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


