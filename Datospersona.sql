USE [Generacion23]
GO
/****** Object:  Table [dbo].[persona]    Script Date: 25/12/2023 06:05:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persona](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Paterno] [varchar](50) NOT NULL,
	[Materno] [varchar](50) NOT NULL,
	[FechaAlta] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_persona] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[persona] ON 

INSERT [dbo].[persona] ([id], [Nombre], [Paterno], [Materno], [FechaAlta]) VALUES (1, N'Oscar', N'Morales', N'Cruz', CAST(N'2023-12-04T11:44:00' AS SmallDateTime))
INSERT [dbo].[persona] ([id], [Nombre], [Paterno], [Materno], [FechaAlta]) VALUES (2, N'Oscar', N'Morales', N'Cruz', CAST(N'2023-12-04T11:51:00' AS SmallDateTime))
INSERT [dbo].[persona] ([id], [Nombre], [Paterno], [Materno], [FechaAlta]) VALUES (3, N'Omar', N'Morales', N'Cruz', CAST(N'2023-12-04T11:58:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[persona] OFF
GO
