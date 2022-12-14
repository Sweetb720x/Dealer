USE [DBautos]
GO
/****** Object:  Table [dbo].[Tadmin]    Script Date: 13/11/2022 22:48:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tadmin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](70) NULL,
	[Clave] [varchar](70) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tautos]    Script Date: 13/11/2022 22:48:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tautos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](50) NULL,
	[Modelo] [varchar](50) NULL,
	[Color] [varchar](50) NULL,
	[Año] [int] NULL,
	[Tipo] [varchar](30) NULL,
	[Transmicion] [varchar](30) NULL,
	[Costo] [money] NULL,
	[Descripcion] [text] NULL,
	[Foto] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tpropietario]    Script Date: 13/11/2022 22:48:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tpropietario](
	[Propietario] [varchar](70) NULL,
	[Telefono] [varchar](15) NULL,
	[Direccion] [varchar](70) NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
