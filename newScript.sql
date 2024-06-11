USE [master]
GO
/****** Object:  Database [dbVoltaire]    Script Date: 11/06/2024 10:42:33 ******/
CREATE DATABASE [dbVoltaire]
GO
USE [dbVoltaire]
GO
/****** Object:  Table [dbo].[Carros]    Script Date: 11/06/2024 10:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carros](
	[idCarro] [uniqueidentifier] NOT NULL,
	[idUsuario] [uniqueidentifier] NULL,
	[idRegistro] [uniqueidentifier] NULL,
	[idModelo] [uniqueidentifier] NULL,
	[placa] [varchar](255) NULL,
	[BateriaAtual] [datetime] NULL,
 CONSTRAINT [PK__Carros__3D09E20E3C025E74] PRIMARY KEY CLUSTERED 
(
	[idCarro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 11/06/2024 10:42:33 ******/
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
/****** Object:  Table [dbo].[Modelos]    Script Date: 11/06/2024 10:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modelos](
	[idModelo] [uniqueidentifier] NOT NULL,
	[idMarca] [uniqueidentifier] NULL,
	[nomeModelo] [nvarchar](255) NULL,
	[Autonomia] [int] NULL,
	[Capacidade] [int] NULL,
	[DurBateria] [datetime] NULL,
 CONSTRAINT [PK_Modelos] PRIMARY KEY CLUSTERED 
(
	[idModelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registros]    Script Date: 11/06/2024 10:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registros](
	[idRegistro] [uniqueidentifier] NOT NULL,
	[UltimaRecarga] [datetime] NULL,
	[DuracaoRecarga] [datetime] NULL,
 CONSTRAINT [PK__Registro__62FC8F58FCF1BD8A] PRIMARY KEY CLUSTERED 
(
	[idRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/06/2024 10:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [uniqueidentifier] NOT NULL,
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
INSERT [dbo].[Carros] ([idCarro], [idUsuario], [idRegistro], [idModelo], [placa], [BateriaAtual]) VALUES (N'6f0acdf3-3d48-418a-a466-2ab3976eb605', NULL, NULL, NULL, NULL, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Carros] ([idCarro], [idUsuario], [idRegistro], [idModelo], [placa], [BateriaAtual]) VALUES (N'3a35df83-d51d-49a4-ae6f-81b32f140f7e', NULL, NULL, NULL, NULL, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Carros] ([idCarro], [idUsuario], [idRegistro], [idModelo], [placa], [BateriaAtual]) VALUES (N'6be9526c-4df4-406e-ad50-ca99c0f03a93', NULL, NULL, NULL, NULL, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Carros] ([idCarro], [idUsuario], [idRegistro], [idModelo], [placa], [BateriaAtual]) VALUES (N'84bc400f-f2e1-45b3-a460-fd9afc6565e4', NULL, NULL, NULL, NULL, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Marca] ([idMarca], [nomeMarca]) VALUES (N'86996daa-278f-4e47-b505-29e494c65e55', N'Volvo')
GO
INSERT [dbo].[Marca] ([idMarca], [nomeMarca]) VALUES (N'de419380-bab9-4029-a941-862ad932ed76', N'BMW')
GO
INSERT [dbo].[Marca] ([idMarca], [nomeMarca]) VALUES (N'3745e7a8-8df9-45bd-9652-df1a663a63be', N'Tesla')
GO
INSERT [dbo].[Marca] ([idMarca], [nomeMarca]) VALUES (N'be4ff398-de10-44e6-9dce-fb83d989a659', N'BYD')
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'4330cd8a-a63e-48c0-b93c-46594ab47731', N'be4ff398-de10-44e6-9dce-fb83d989a659', N'Dolphin', 291, 45, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'1b6a69a1-ffee-4201-a741-658c1f022fdd', N'de419380-bab9-4029-a941-862ad932ed76', N'i8', 51, 11, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'4fe3c974-b1a4-49d4-a719-767b16cc58de', N'3745e7a8-8df9-45bd-9652-df1a663a63be', N'Model X', 500, 100, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'169871f1-231f-4cf2-9f06-fbbda4d223d7', N'86996daa-278f-4e47-b505-29e494c65e55', N'XC40', 231, 69, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'00000000-0000-0000-0000-000000000000', N'Artur Fiorentino', N'afiorentino1415@gmail.com', N'$2a$11$VnRwd9cehqPDdNAjlaEeDuS8PaoloGGiBSiaPxb7KGP9dU1taP9Uu', NULL, NULL)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'16b79f47-6d78-476b-a99c-102116efb799', N'Richard', N'richardfpassarelli@gmail.com', N'$2a$11$UnfkYn9pXrtF.SmLin9km.cWU1ahbmEEEDSlu/t0dAAdhNlL3YAgi', NULL, N'string')
GO
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'9850ab98-3c8c-4ba3-8acc-3300a7dbaf43', N'Richard', N'rikzinho@gmail.com', N'$2a$11$YV9NfG8uu2NC4HNk6RB8muGwpf9VFL8/R/lNCqRzP7kLJJmeWyVF2', NULL, N'string')
GO
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'65fba607-17f1-4fbb-89eb-41cfa46b586d', N'Anna Senai', N'anna@senai.com', N'$2a$11$IrTcKp3.SbUyFLST0sfoxOQ5UBFaKyasa.B82Ae3CRvJaJWotwZtC', NULL, NULL)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'8bd1cdd2-557e-40c4-94d2-573127824f0c', N'Gabriela', N'gabriela@gmail.com', N'$2a$11$LE7Vh6qQBuppRFPiDw6jFeyI3ySsKppMkqT6r6cGBt3VYkmlYcmsG', NULL, NULL)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'79b5dc78-f0a0-42f9-ab59-725602a8a571', N'Ribamar', N'ribamar@gmail.com', N'$2a$11$9UgVuP4G1GzCoxQOcZLsy.hLPUn2GfNjQwkUmq4QagdQs/O3Yk/xC', NULL, N'string')
GO
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'8bf92770-afe9-488d-90b3-7cf978ff2a67', N'der', N'senai134dev@gmail.com', N'$2a$11$Cc3/eZGM5Tsv4jTJIJnBzeGwYh5HMP47DLEviQyA4/JphOJ.n2dei', NULL, NULL)
GO
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'cfb52ef5-fdbc-411a-b785-8cadedd0ae45', N'Gabriel', N'bielgvsa@gmail.com', N'$2a$11$EyL9QhnDEtM7wqcMxQyz3OyEQ1cyN97ZZmQf9WmLWZYkO/2rtyWRW', NULL, NULL)
GO
ALTER TABLE [dbo].[Carros]  WITH CHECK ADD  CONSTRAINT [FK_Carros_Modelos] FOREIGN KEY([idModelo])
REFERENCES [dbo].[Modelos] ([idModelo])
GO
ALTER TABLE [dbo].[Carros] CHECK CONSTRAINT [FK_Carros_Modelos]
GO
ALTER TABLE [dbo].[Carros]  WITH CHECK ADD  CONSTRAINT [FK_Carros_Registros] FOREIGN KEY([idRegistro])
REFERENCES [dbo].[Registros] ([idRegistro])
GO
ALTER TABLE [dbo].[Carros] CHECK CONSTRAINT [FK_Carros_Registros]
GO
ALTER TABLE [dbo].[Carros]  WITH CHECK ADD  CONSTRAINT [FK_Carros_Usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[Carros] CHECK CONSTRAINT [FK_Carros_Usuarios]
GO
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [FK_Modelos_Marca] FOREIGN KEY([idMarca])
REFERENCES [dbo].[Marca] ([idMarca])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [FK_Modelos_Marca]
GO
USE [master]
GO
ALTER DATABASE [dbVoltaire] SET  READ_WRITE 
GO
