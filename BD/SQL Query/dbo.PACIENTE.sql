USE [Optica Industrial]
GO

/****** Object:  Table [dbo].[PACIENTE]    Script Date: 16/04/2018 01:59:04 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PACIENTE](
	[Id Paciente] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Tipo de Paciente] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Telefono] [int] NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PACIENTE1_1] PRIMARY KEY CLUSTERED 
(
	[Id Paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


