USE [master]
GO
<<<<<<< HEAD:newScript.sql
/****** Object:  Database [dbVoltaire]    Script Date: 14/06/2024 10:59:02 ******/
=======
/****** Object:  Database [dbVoltaire]    Script Date: 17/06/2024 15:35:11 ******/
>>>>>>> 74ecd9090130c720c9f7297936ec2cc9d535d4e1:script.sql
CREATE DATABASE [dbVoltaire]
USE [dbVoltaire]
GO
<<<<<<< HEAD:newScript.sql
/****** Object:  Table [dbo].[Carros]    Script Date: 14/06/2024 10:59:02 ******/
=======
/****** Object:  Table [dbo].[Carros]    Script Date: 17/06/2024 15:35:11 ******/
>>>>>>> 74ecd9090130c720c9f7297936ec2cc9d535d4e1:script.sql
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carros](
	[idCarro] [uniqueidentifier] NOT NULL,
	[idUsuario] [uniqueidentifier] NULL,
	[idModelo] [uniqueidentifier] NULL,
	[placa] [varchar](255) NULL,
<<<<<<< HEAD:newScript.sql
	[BateriaAtual] [decimal](18, 15) NULL,
=======
	[BateriaAtual] [int] NULL,
>>>>>>> 74ecd9090130c720c9f7297936ec2cc9d535d4e1:script.sql
 CONSTRAINT [PK__Carros__3D09E20E3C025E74] PRIMARY KEY CLUSTERED 
(
	[idCarro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
<<<<<<< HEAD:newScript.sql
/****** Object:  Table [dbo].[Marca]    Script Date: 14/06/2024 10:59:03 ******/
=======
/****** Object:  Table [dbo].[Marca]    Script Date: 17/06/2024 15:35:11 ******/
>>>>>>> 74ecd9090130c720c9f7297936ec2cc9d535d4e1:script.sql
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
<<<<<<< HEAD:newScript.sql
/****** Object:  Table [dbo].[Modelos]    Script Date: 14/06/2024 10:59:03 ******/
=======
/****** Object:  Table [dbo].[Modelos]    Script Date: 17/06/2024 15:35:11 ******/
>>>>>>> 74ecd9090130c720c9f7297936ec2cc9d535d4e1:script.sql
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
<<<<<<< HEAD:newScript.sql
/****** Object:  Table [dbo].[Registros]    Script Date: 14/06/2024 10:59:03 ******/
=======
/****** Object:  Table [dbo].[Registros]    Script Date: 17/06/2024 15:35:11 ******/
>>>>>>> 74ecd9090130c720c9f7297936ec2cc9d535d4e1:script.sql
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registros](
	[idRegistro] [uniqueidentifier] NOT NULL,
	[idCarro] [uniqueidentifier] NULL,
	[UltimaRecarga] [datetime] NULL,
	[DuracaoRecarga] [datetime] NULL,
 CONSTRAINT [PK__Registro__62FC8F58FCF1BD8A] PRIMARY KEY CLUSTERED 
(
	[idRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
<<<<<<< HEAD:newScript.sql
/****** Object:  Table [dbo].[Usuarios]    Script Date: 14/06/2024 10:59:03 ******/
=======
/****** Object:  Table [dbo].[Usuarios]    Script Date: 17/06/2024 15:35:11 ******/
>>>>>>> 74ecd9090130c720c9f7297936ec2cc9d535d4e1:script.sql
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
<<<<<<< HEAD:newScript.sql
INSERT [dbo].[Carros] ([idCarro], [idUsuario], [idModelo], [placa], [BateriaAtual]) VALUES (N'6f0acdf3-3d48-418a-a466-2ab3976eb605', N'16b79f47-6d78-476b-a99c-102116efb799', N'169871f1-231f-4cf2-9f06-fbbda4d223d7', N'BABB222', CAST(0.500000000000000 AS Decimal(18, 15)))
GO
INSERT [dbo].[Carros] ([idCarro], [idUsuario], [idModelo], [placa], [BateriaAtual]) VALUES (N'3a35df83-d51d-49a4-ae6f-81b32f140f7e', NULL, NULL, NULL, CAST(0.000000000000000 AS Decimal(18, 15)))
GO
INSERT [dbo].[Carros] ([idCarro], [idUsuario], [idModelo], [placa], [BateriaAtual]) VALUES (N'6be9526c-4df4-406e-ad50-ca99c0f03a93', NULL, NULL, NULL, CAST(0.000000000000000 AS Decimal(18, 15)))
GO
INSERT [dbo].[Carros] ([idCarro], [idUsuario], [idModelo], [placa], [BateriaAtual]) VALUES (N'84bc400f-f2e1-45b3-a460-fd9afc6565e4', NULL, NULL, NULL, CAST(0.000000000000000 AS Decimal(18, 15)))
=======
INSERT [dbo].[Carros] ([idCarro], [idUsuario], [idRegistro], [idModelo], [placa], [BateriaAtual]) VALUES (N'fa279f6e-4a00-4df0-992f-1f72821a3c46', N'c5f74669-1277-4c1f-ae8c-e9390e82c534', NULL, N'169871f1-231f-4cf2-9f06-fbbda4d223d7', N'ABCD123', 1)
>>>>>>> 74ecd9090130c720c9f7297936ec2cc9d535d4e1:script.sql
GO
INSERT [dbo].[Marca] ([idMarca], [nomeMarca]) VALUES (N'86996daa-278f-4e47-b505-29e494c65e55', N'Volvo')
GO
INSERT [dbo].[Marca] ([idMarca], [nomeMarca]) VALUES (N'de419380-bab9-4029-a941-862ad932ed76', N'BMW')
GO
INSERT [dbo].[Marca] ([idMarca], [nomeMarca]) VALUES (N'3745e7a8-8df9-45bd-9652-df1a663a63be', N'Tesla')
GO
INSERT [dbo].[Marca] ([idMarca], [nomeMarca]) VALUES (N'be4ff398-de10-44e6-9dce-fb83d989a659', N'BYD')
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'd967b75d-ccf6-4f4f-a80b-07ceda8cb070', N'86996daa-278f-4e47-b505-29e494c65e55', N'EX90', 600, 111, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'2b674414-a5ec-4598-a606-15a883891f9e', N'3745e7a8-8df9-45bd-9652-df1a663a63be', N'Model S', 634, 103, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'73b37a8a-ad33-47d5-876f-44967c79a482', N'3745e7a8-8df9-45bd-9652-df1a663a63be', N'Model Y', 600, 78, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'4330cd8a-a63e-48c0-b93c-46594ab47731', N'be4ff398-de10-44e6-9dce-fb83d989a659', N'Dolphin', 291, 45, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'1b6a69a1-ffee-4201-a741-658c1f022fdd', N'de419380-bab9-4029-a941-862ad932ed76', N'i8', 51, 11, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'4fe3c974-b1a4-49d4-a719-767b16cc58de', N'3745e7a8-8df9-45bd-9652-df1a663a63be', N'Model X', 500, 100, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'3540f2d4-5c93-44c8-94d6-938b73867233', N'be4ff398-de10-44e6-9dce-fb83d989a659', N'Tan', 309, 88, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'fbed65f2-5085-48b7-ab7c-945dfdb6e4d7', N'3745e7a8-8df9-45bd-9652-df1a663a63be', N'Cybertruck', 547, 120, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'8e54697e-4136-408b-a5b5-b61cea427b66', N'be4ff398-de10-44e6-9dce-fb83d989a659', N'Han', 349, 86, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'6e08da1f-73e6-4db7-a342-c105b9d5453d', N'de419380-bab9-4029-a941-862ad932ed76', N'i3', 160, 42, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'16ef8910-4d9d-409d-8ebe-cab50a93dd98', N'de419380-bab9-4029-a941-862ad932ed76', N'iX', 528, 111, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'c4e6cdde-47ae-4739-95e7-d08184504451', N'be4ff398-de10-44e6-9dce-fb83d989a659', N'Seal', 372, 82, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'4d4a68ef-a659-4642-89fc-d2b159edc32f', N'86996daa-278f-4e47-b505-29e494c65e55', N'C40', 385, 78, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'93a7859a-ad28-4133-897d-f760432a52a9', N'86996daa-278f-4e47-b505-29e494c65e55', N'EX30', 338, 69, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
INSERT [dbo].[Modelos] ([idModelo], [idMarca], [nomeModelo], [Autonomia], [Capacidade], [DurBateria]) VALUES (N'169871f1-231f-4cf2-9f06-fbbda4d223d7', N'86996daa-278f-4e47-b505-29e494c65e55', N'XC40', 231, 69, CAST(N'1900-01-01T05:00:00.000' AS DateTime))
GO
<<<<<<< HEAD:newScript.sql
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'00000000-0000-0000-0000-000000000000', N'Artur Fiorentino', N'afiorentino1415@gmail.com', N'$2a$11$uTz0g4XSwYmrUXpeQlCJ2er4OVfzn5yW684W1cFcmHmJx.Nf6Nvee', NULL, NULL)
=======
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'00000000-0000-0000-0000-000000000000', N'Artur Fiorentino', N'afiorentino1415@gmail.com', N'$2a$11$2rH9TSbo2UgA0Msh2jbiyu7KetpOfYruoY.83i08AbCqjCEbQXswK', NULL, NULL)
>>>>>>> 74ecd9090130c720c9f7297936ec2cc9d535d4e1:script.sql
GO
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'16b79f47-6d78-476b-a99c-102116efb799', N'Richard', N'richardfpassarelli@gmail.com', N'$2a$11$UnfkYn9pXrtF.SmLin9km.cWU1ahbmEEEDSlu/t0dAAdhNlL3YAgi', NULL, N'string')
GO
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'e7575d92-c354-4dd0-9c17-1ab4ac024b44', N'SENAI', N'senai123', N'$2a$11$mmd00tlRwntO.ij4g4orX.HigwVMWTVBXAMx4QTItZP2aOGGsbJ6q', NULL, NULL)
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
<<<<<<< HEAD:newScript.sql
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'a2d8ca64-b81c-40ce-9e9e-c011994d2616', N'Anna ', N'annabbarbosa2712@gmail.com', N'$2a$11$uw.btbW44FQ3bxzY/CrmrOL1kCXMvITgcKkB9niu0n.fGRrbX5kz2', 5456, NULL)
=======
INSERT [dbo].[Usuarios] ([idUsuario], [nome], [email], [senha], [CodRecupSenha], [foto]) VALUES (N'c5f74669-1277-4c1f-ae8c-e9390e82c534', N'Teste01', N'teste01@gmail.com', N'$2a$11$pkAWcmk7L2ld7ulRPQsInecLSiRn6FzUFLDMh1UPmWRLrsivxsBha', NULL, NULL)
GO
ALTER TABLE [dbo].[Carros] ADD  CONSTRAINT [DF_Carros_idCarro]  DEFAULT (newid()) FOR [idCarro]
GO
ALTER TABLE [dbo].[Marca] ADD  CONSTRAINT [DF_Marca_idMarca]  DEFAULT (newid()) FOR [idMarca]
GO
ALTER TABLE [dbo].[Modelos] ADD  CONSTRAINT [DF_Modelos_idModelo]  DEFAULT (newid()) FOR [idModelo]
GO
ALTER TABLE [dbo].[Registros] ADD  CONSTRAINT [DF_Registros_idRegistro]  DEFAULT (newid()) FOR [idRegistro]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_idUsuario]  DEFAULT (newid()) FOR [idUsuario]
>>>>>>> 74ecd9090130c720c9f7297936ec2cc9d535d4e1:script.sql
GO
ALTER TABLE [dbo].[Carros]  WITH CHECK ADD  CONSTRAINT [FK_Carros_Modelos] FOREIGN KEY([idModelo])
REFERENCES [dbo].[Modelos] ([idModelo])
GO
ALTER TABLE [dbo].[Carros] CHECK CONSTRAINT [FK_Carros_Modelos]
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
ALTER TABLE [dbo].[Registros]  WITH CHECK ADD  CONSTRAINT [FK_Registros_Carros] FOREIGN KEY([idCarro])
REFERENCES [dbo].[Carros] ([idCarro])
GO
ALTER TABLE [dbo].[Registros] CHECK CONSTRAINT [FK_Registros_Carros]
GO
USE [master]
GO
ALTER DATABASE [dbVoltaire] SET  READ_WRITE 
GO
