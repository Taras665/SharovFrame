USE [master]
GO
/****** Object:  Database [SharovFrame]    Script Date: 14.03.2022 7:02:02 ******/
CREATE DATABASE [SharovFrame] ON  PRIMARY 
( NAME = N'SharovFrame', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\SharovFrame.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SharovFrame_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\SharovFrame_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SharovFrame] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SharovFrame].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SharovFrame] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SharovFrame] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SharovFrame] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SharovFrame] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SharovFrame] SET ARITHABORT OFF 
GO
ALTER DATABASE [SharovFrame] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SharovFrame] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SharovFrame] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SharovFrame] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SharovFrame] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SharovFrame] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SharovFrame] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SharovFrame] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SharovFrame] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SharovFrame] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SharovFrame] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SharovFrame] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SharovFrame] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SharovFrame] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SharovFrame] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SharovFrame] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SharovFrame] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SharovFrame] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SharovFrame] SET  MULTI_USER 
GO
ALTER DATABASE [SharovFrame] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SharovFrame] SET DB_CHAINING OFF 
GO
USE [SharovFrame]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 14.03.2022 7:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nchar](10) NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginHistory]    Script Date: 14.03.2022 7:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginHistory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NULL,
	[TimeLogin] [time](7) NULL,
	[Result] [bit] NULL,
 CONSTRAINT [PK_LoginHistory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 14.03.2022 7:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 14.03.2022 7:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nchar](10) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 14.03.2022 7:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[IdRole] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Worker]    Script Date: 14.03.2022 7:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Worker](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[MiddleName] [nvarchar](50) NULL,
	[Gender] [int] NULL,
	[DateBirth] [date] NULL,
	[Phone] [nvarchar](50) NULL,
	[Fired] [bit] NULL,
 CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkerOrder]    Script Date: 14.03.2022 7:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkerOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdWorker] [int] NULL,
	[IdOrder] [int] NULL,
	[Title] [nvarchar](50) NULL,
	[DateCreate] [date] NULL,
	[Invalid] [bit] NULL,
 CONSTRAINT [PK_WorkerOrder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Gender] ON 

INSERT [dbo].[Gender] ([Id], [Title]) VALUES (1, N'Мужской   ')
INSERT [dbo].[Gender] ([Id], [Title]) VALUES (2, N'Женский   ')
SET IDENTITY_INSERT [dbo].[Gender] OFF
GO
SET IDENTITY_INSERT [dbo].[LoginHistory] ON 

INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (1, N'admin', CAST(N'03:42:57' AS Time), 0)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (2, N'admin', CAST(N'03:53:04' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (3, N'admin', CAST(N'03:53:29' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (4, N'admin', CAST(N'04:19:50' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (5, N'admin', CAST(N'04:23:50' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (6, N'admin', CAST(N'04:29:22' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (7, N'admin', CAST(N'04:30:06' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (8, N'admin', CAST(N'04:30:46' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (9, N'admin', CAST(N'04:34:58' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (10, N'admin', CAST(N'04:35:21' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (11, N'admin', CAST(N'04:41:38' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (12, N'admin', CAST(N'04:42:08' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (13, N'admin', CAST(N'04:44:33' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (14, N'admin', CAST(N'04:45:00' AS Time), 0)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (15, N'admin', CAST(N'04:45:05' AS Time), 0)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (16, N'admin', CAST(N'04:45:14' AS Time), 0)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (17, N'admin', CAST(N'04:45:21' AS Time), 0)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (18, N'admin', CAST(N'04:45:44' AS Time), 0)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (19, N'user125', CAST(N'04:47:17' AS Time), 0)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (20, N'user125', CAST(N'04:47:36' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (21, N'user125', CAST(N'04:48:54' AS Time), 0)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (22, N'user129', CAST(N'04:50:00' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (23, N'admin', CAST(N'04:50:16' AS Time), 0)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (24, N'admin', CAST(N'04:52:57' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (25, N'admin', CAST(N'04:54:04' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (26, N'admin', CAST(N'04:56:19' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (27, N'admin', CAST(N'05:03:34' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (28, N'user', CAST(N'05:31:41' AS Time), 0)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (29, N'user123', CAST(N'05:31:49' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (30, N'user', CAST(N'05:34:03' AS Time), 0)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (31, N'user123', CAST(N'05:34:12' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (32, N'user123', CAST(N'05:35:13' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (33, N'user123', CAST(N'05:36:44' AS Time), 1)
INSERT [dbo].[LoginHistory] ([id], [Login], [TimeLogin], [Result]) VALUES (34, N'user123', CAST(N'05:37:21' AS Time), 1)
SET IDENTITY_INSERT [dbo].[LoginHistory] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([Id], [Title]) VALUES (1, N'Admin     ')
INSERT [dbo].[Role] ([Id], [Title]) VALUES (2, N'HR        ')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([id], [Login], [Password], [IdRole]) VALUES (1, N'admin', N'123', 1)
INSERT [dbo].[User] ([id], [Login], [Password], [IdRole]) VALUES (2, N'user', N'124', 2)
INSERT [dbo].[User] ([id], [Login], [Password], [IdRole]) VALUES (3, N'user123', N'123', 2)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[Worker] ON 

INSERT [dbo].[Worker] ([id], [FirstName], [LastName], [MiddleName], [Gender], [DateBirth], [Phone], [Fired]) VALUES (1, N'Ivan', N'Ivanov', N'Ivanovich', 1, CAST(N'1999-02-02' AS Date), N'+79114445566', 0)
INSERT [dbo].[Worker] ([id], [FirstName], [LastName], [MiddleName], [Gender], [DateBirth], [Phone], [Fired]) VALUES (2, N'Ivanova', N'Anna', N'Ivanovna', 1, CAST(N'1975-01-01' AS Date), N'+791234445566', 0)
SET IDENTITY_INSERT [dbo].[Worker] OFF
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
ALTER TABLE [dbo].[Worker]  WITH CHECK ADD  CONSTRAINT [FK_Worker_Gender] FOREIGN KEY([Gender])
REFERENCES [dbo].[Gender] ([Id])
GO
ALTER TABLE [dbo].[Worker] CHECK CONSTRAINT [FK_Worker_Gender]
GO
ALTER TABLE [dbo].[WorkerOrder]  WITH CHECK ADD  CONSTRAINT [FK_WorkerOrder_Order] FOREIGN KEY([IdOrder])
REFERENCES [dbo].[Order] ([id])
GO
ALTER TABLE [dbo].[WorkerOrder] CHECK CONSTRAINT [FK_WorkerOrder_Order]
GO
ALTER TABLE [dbo].[WorkerOrder]  WITH CHECK ADD  CONSTRAINT [FK_WorkerOrder_Worker] FOREIGN KEY([IdWorker])
REFERENCES [dbo].[Worker] ([id])
GO
ALTER TABLE [dbo].[WorkerOrder] CHECK CONSTRAINT [FK_WorkerOrder_Worker]
GO
USE [master]
GO
ALTER DATABASE [SharovFrame] SET  READ_WRITE 
GO
