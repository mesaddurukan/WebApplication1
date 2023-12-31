USE [corepersonel]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7.07.2023 21:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departmanlars]    Script Date: 7.07.2023 21:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departmanlars](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[departmanad] [nvarchar](max) NULL,
 CONSTRAINT [PK_Departmanlars] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personels]    Script Date: 7.07.2023 21:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personels](
	[perid] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](max) NULL,
	[soyad] [nvarchar](max) NULL,
	[sehir] [nvarchar](max) NULL,
	[departid] [int] NULL,
 CONSTRAINT [PK_Personels] PRIMARY KEY CLUSTERED 
(
	[perid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Personels]  WITH CHECK ADD  CONSTRAINT [FK_Personels_Departmanlars_departid] FOREIGN KEY([departid])
REFERENCES [dbo].[Departmanlars] ([id])
GO
ALTER TABLE [dbo].[Personels] CHECK CONSTRAINT [FK_Personels_Departmanlars_departid]
GO
