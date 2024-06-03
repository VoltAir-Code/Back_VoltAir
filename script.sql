USE [master]
GO
/****** Object:  Database [dbVoltaire]    Script Date: 03/06/2024 09:51:42 ******/
CREATE DATABASE [dbVoltaire]
GO
USE [dbVoltaire]
GO
/****** Object:  Table [dbo].[Carros]    Script Date: 03/06/2024 09:51:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carros](
	[idCarro] [uniqueidentifier] NOT NULL,
	[idMarca] [uniqueidentifier] NULL,
	[idRegistro] [uniqueidentifier] NULL,
	[modelo] [varchar](255) NULL,
	[placa] [varchar](255) NULL,
	[DurBateria] [datetime] NULL,
 CONSTRAINT [PK__Carros__3D09E20E3C025E74] PRIMARY KEY CLUSTERED 
(
	[idCarro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 03/06/2024 09:51:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[idMarca] [uniqueidentifier] NOT NULL,
	[nomeMarca] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registros]    Script Date: 03/06/2024 09:51:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registros](
	[idRegistro] [uniqueidentifier] NOT NULL,
	[UltimaRecarga] [datetime] NULL,
	[DuracaoRecarga] [datetime] NULL,
 CONSTRAINT [PK__Registro__62FC8F58E4144EE4] PRIMARY KEY CLUSTERED 
(
	[idRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 03/06/2024 09:51:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [uniqueidentifier] NOT NULL,
	[idCarro] [uniqueidentifier] NULL,
	[nome] [varchar](255) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[senha] [varchar](255) NOT NULL,
	[CodRecupSenha] [int] NULL,
	[foto] [varchar](255) NULL,
 CONSTRAINT [PK__Usuarios__645723A69BF397A7] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Carros] ([idCarro], [idMarca], [idRegistro], [modelo], [placa], [DurBateria]) VALUES (N'6f0acdf3-3d48-418a-a466-2ab3976eb605', N'86996daa-278f-4e47-b505-29e494c65e55', NULL, N'XC60', N'ABC456', CAST(N'1900-01-01T00:05:00.000' AS DateTime))
GO
INSERT [dbo].[Carros] ([idCarro], [idMarca], [idRegistro], [modelo], [placa], [DurBateria]) VALUES (N'3a35df83-d51d-49a4-ae6f-81b32f140f7e', N'be4ff398-de10-44e6-9dce-fb83d989a659', NULL, N'Dolphin', NULL, CAST(N'1900-01-01T00:05:00.000' AS DateTime))
GO
INSERT [dbo].[Carros] ([idCarro], [idMarca], [idRegistro], [modelo], [placa], [DurBateria]) VALUES (N'6be9526c-4df4-406e-ad50-ca99c0f03a93', N'86996daa-278f-4e47-b505-29e494c65e55', NULL, N'XC40', NULL, CAST(N'1900-01-01T00:05:00.000' AS DateTime))
GO
INSERT [dbo].[Carros] ([idCarro], [idMarca], [idRegistro], [modelo], [placa], [DurBateria]) VALUES (N'84bc400f-f2e1-45b3-a460-fd9afc6565e4', N'3745e7a8-8df9-45bd-9652-df1a663a63be', NULL, N'Model X', NULL, CAST(N'1900-01-01T00:05:00.000' AS DateTime))
GO
INSERT [dbo].[Marca] ([idMarca], [nomeMarca]) VALUES (N'86996daa-278f-4e47-b505-29e494c65e55', N'Volvo')
GO
INSERT [dbo].[Marca] ([idMarca], [nomeMarca]) VALUES (N'de419380-bab9-4029-a941-862ad932ed76', N'BMW')
GO
INSERT [dbo].[Marca] ([idMarca], [nomeMarca]) VALUES (N'3745e7a8-8df9-45bd-9652-df1a663a63be', N'Tesla')
GO
INSERT [dbo].[Marca] ([idMarca], [nomeMarca]) VALUES (N'be4ff398-de10-44e6-9dce-fb83d989a659', N'BYD')
GO
INSERT [dbo].[Usuarios] ([idUsuario], [idCarro], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'3091531b-84f4-484d-a664-300ea967fc68', N'6f0acdf3-3d48-418a-a466-2ab3976eb605', N'Artur Fiorentino', N'artur@senai.com', N'$2a$11$gng1eY6Hwr7iDN4MFIif5ekoFHnmbUU7POTr0B8kP2B5HXzUHRxR6', NULL, NULL)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [idCarro], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'9850ab98-3c8c-4ba3-8acc-3300a7dbaf43', N'84bc400f-f2e1-45b3-a460-fd9afc6565e4', N'Richard', N'rikzinho@gmail.com', N'$2a$11$YV9NfG8uu2NC4HNk6RB8muGwpf9VFL8/R/lNCqRzP7kLJJmeWyVF2', NULL, N'string')
GO
INSERT [dbo].[Usuarios] ([idUsuario], [idCarro], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'79b5dc78-f0a0-42f9-ab59-725602a8a571', N'84bc400f-f2e1-45b3-a460-fd9afc6565e4', N'Ribamar', N'ribamar@gmail.com', N'$2a$11$9UgVuP4G1GzCoxQOcZLsy.hLPUn2GfNjQwkUmq4QagdQs/O3Yk/xC', NULL, N'https://voltairestorage.blob.core.windows.net/blobvoltaire/a0a2e6bf7af84d2b9ad45285e9073487.jpg')
GO
ALTER TABLE [dbo].[Carros]  WITH CHECK ADD  CONSTRAINT [FK_Carros_Marca] FOREIGN KEY([idMarca])
REFERENCES [dbo].[Marca] ([idMarca])
GO
ALTER TABLE [dbo].[Carros] CHECK CONSTRAINT [FK_Carros_Marca]
GO
ALTER TABLE [dbo].[Carros]  WITH CHECK ADD  CONSTRAINT [FK_Carros_Registros] FOREIGN KEY([idRegistro])
REFERENCES [dbo].[Registros] ([idRegistro])
GO
ALTER TABLE [dbo].[Carros] CHECK CONSTRAINT [FK_Carros_Registros]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Carros] FOREIGN KEY([idCarro])
REFERENCES [dbo].[Carros] ([idCarro])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Carros]
GO
USE [master]
GO
ALTER DATABASE [dbVoltaire] SET  READ_WRITE 
GO
