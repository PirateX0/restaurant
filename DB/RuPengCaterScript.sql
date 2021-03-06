USE [master]
GO
/****** Object:  Database [RuPengCater]    Script Date: 04/20/2017 08:28:57 ******/
CREATE DATABASE [RuPengCater] ON  PRIMARY 
( NAME = N'RuPengCater', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RuPengCater.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RuPengCater_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RuPengCater_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RuPengCater] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RuPengCater].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RuPengCater] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [RuPengCater] SET ANSI_NULLS OFF
GO
ALTER DATABASE [RuPengCater] SET ANSI_PADDING OFF
GO
ALTER DATABASE [RuPengCater] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [RuPengCater] SET ARITHABORT OFF
GO
ALTER DATABASE [RuPengCater] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [RuPengCater] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [RuPengCater] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [RuPengCater] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [RuPengCater] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [RuPengCater] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [RuPengCater] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [RuPengCater] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [RuPengCater] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [RuPengCater] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [RuPengCater] SET  DISABLE_BROKER
GO
ALTER DATABASE [RuPengCater] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [RuPengCater] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [RuPengCater] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [RuPengCater] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [RuPengCater] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [RuPengCater] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [RuPengCater] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [RuPengCater] SET  READ_WRITE
GO
ALTER DATABASE [RuPengCater] SET RECOVERY FULL
GO
ALTER DATABASE [RuPengCater] SET  MULTI_USER
GO
ALTER DATABASE [RuPengCater] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [RuPengCater] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'RuPengCater', N'ON'
GO
USE [RuPengCater]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 04/20/2017 08:28:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[LoginUserName] [nvarchar](50) NULL,
	[Pwd] [nvarchar](50) NULL,
	[LastLoginTime] [datetime] NULL,
	[LastLoginIP] [varchar](50) NULL,
	[DelFlag] [int] NULL,
	[SubTime] [datetime] NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[UserInfo] ON
INSERT [dbo].[UserInfo] ([UserId], [UserName], [LoginUserName], [Pwd], [LastLoginTime], [LastLoginIP], [DelFlag], [SubTime]) VALUES (1, N'地主', N'admin', N'21232f297a57a5a743894a0e4a801fc3', CAST(0x0000A29900000000 AS DateTime), N'192.168.3.100', 0, CAST(0x0000A29A00000000 AS DateTime))
INSERT [dbo].[UserInfo] ([UserId], [UserName], [LoginUserName], [Pwd], [LastLoginTime], [LastLoginIP], [DelFlag], [SubTime]) VALUES (2, N'二手科学家', N'ershoukexuejia', N'12345', CAST(0x0000A29800000000 AS DateTime), N'192.168.1.101', 0, CAST(0x0000A29A00000000 AS DateTime))
INSERT [dbo].[UserInfo] ([UserId], [UserName], [LoginUserName], [Pwd], [LastLoginTime], [LastLoginIP], [DelFlag], [SubTime]) VALUES (3, N'乐乐', N'lele', N'69bfc4ef467b367e3515cdcf693e65db', CAST(0x0000A29A00000000 AS DateTime), N'192.168.3.123', 0, CAST(0x0000A29A00000000 AS DateTime))
INSERT [dbo].[UserInfo] ([UserId], [UserName], [LoginUserName], [Pwd], [LastLoginTime], [LastLoginIP], [DelFlag], [SubTime]) VALUES (4, N'', N'mingren', N'mingren', NULL, NULL, 0, CAST(0x0000000100000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[UserInfo] OFF
/****** Object:  Table [dbo].[RoomInfo]    Script Date: 04/20/2017 08:28:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RoomInfo](
	[RoomId] [int] IDENTITY(1,1) NOT NULL,
	[RoomName] [varchar](50) NULL,
	[RoomType] [int] NULL,
	[RoomMinMoney] [float] NULL,
	[RoomMaxNum] [int] NULL,
	[IsDefault] [nvarchar](20) NULL,
	[DelFlag] [int] NULL,
	[SubTime] [datetime] NULL,
	[SubBy] [int] NULL,
 CONSTRAINT [PK_RoomInfo] PRIMARY KEY CLUSTERED 
(
	[RoomId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[RoomInfo] ON
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (1, N'豪华包间', 1, 1000, 10, N'100', 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (2, N'普通包间', 2, 500, 10, N'101', 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (3, N'普通大厅', 3, 0, 100, N'103', 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (4, N'土豪包间', 4, 10000, 12, N'808', 0, CAST(0x0000A48700B42222 AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (5, N'贵族包间', 5, 88888, 10, N'8888', 0, CAST(0x0000A48800D4D6A8 AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (6, N'神秘包间', 6, 999, 20, N'9991', 0, CAST(0x0000A48800D594EE AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (7, N'惊讶的房间', 7, 10, 1, N'8776', 1, CAST(0x0000A48A01026464 AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (8, N'313123', 321, 3213, 312, N'313211', 1, CAST(0x0000A48A016B3E70 AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (9, N'测试的房间', 6, 12, 12, N'8998', 0, CAST(0x0000A48B016FDF30 AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (10, N'哈哈哈', 7, 323, 323, N'131231', 1, CAST(0x0000A48B0170628C AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (11, N'真6', 666, 666, 666, N'666', 1, CAST(0x0000A54E0110A2C0 AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (12, N'6', 6, 6, 6, N'6', 1, CAST(0x0000A54E013C4FCF AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (13, N'小亚老师的房间', 7, 999, 2, N'1111', 0, CAST(0x0000A54E013FDE75 AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (14, N'110', 110, 110, 110, N'110', 0, CAST(0x0000A56201203052 AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (15, N'120', 120, 120, 120, N'120', 1, CAST(0x0000A562012781D5 AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (16, N'119', 119, 119, 119, N'119', 1, CAST(0x0000A5620128E429 AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (17, N'120', 120, 120, 120, N'120', 1, CAST(0x0000A562012BC830 AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (18, N'12', 12, 12, 12, N'12', 1, CAST(0x0000A562012F0068 AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (19, N'13', 1, 1, 1, N'1', 1, CAST(0x0000A562012F824C AS DateTime), 1)
INSERT [dbo].[RoomInfo] ([RoomId], [RoomName], [RoomType], [RoomMinMoney], [RoomMaxNum], [IsDefault], [DelFlag], [SubTime], [SubBy]) VALUES (20, N'131', 1, 1, 1, N'1', 1, CAST(0x0000A5620131E195 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[RoomInfo] OFF
/****** Object:  Table [dbo].[R_Order_Product]    Script Date: 04/20/2017 08:28:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[R_Order_Product](
	[ROrderProId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ProId] [int] NULL,
	[DelFlag] [int] NULL,
	[SubTime] [datetime] NULL,
	[UnitCount] [int] NULL,
 CONSTRAINT [PK_R_Order_Product] PRIMARY KEY CLUSTERED 
(
	[ROrderProId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[R_Order_Product] ON
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (1, 5, 4, 1, CAST(0x0000A487010BD0C1 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (2, 5, 6, 1, CAST(0x0000A487010C099F AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (3, 5, 10, 1, CAST(0x0000A487010D7161 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (4, 1, 9, 0, CAST(0x0000A487010DBFB3 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (5, 1, 13, 0, CAST(0x0000A487010DC108 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (6, 3, 7, 1, CAST(0x0000A487010DC856 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (7, 3, 2, 1, CAST(0x0000A487010DD5AD AS DateTime), 5)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (8, 6, 21, 1, CAST(0x0000A487010E4A2E AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (9, 6, 8, 1, CAST(0x0000A487010E4F9B AS DateTime), 2)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (10, 6, 9, 0, CAST(0x0000A487011E4881 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (11, 6, 13, 0, CAST(0x0000A487011E4A41 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (12, 6, 15, 1, CAST(0x0000A487011E4B50 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (13, 7, 4, 1, CAST(0x0000A4870121ED94 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (14, 7, 12, 1, CAST(0x0000A4870121EEA4 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (15, 7, 18, 1, CAST(0x0000A4870121F040 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (16, 7, 21, 1, CAST(0x0000A4870121F16F AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (17, 7, 5, 1, CAST(0x0000A4870122C068 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (18, 7, 8, 1, CAST(0x0000A4870122C1D4 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (19, 5, 8, 1, CAST(0x0000A4870168974E AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (20, 5, 12, 1, CAST(0x0000A48701689880 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (21, 3, 13, 1, CAST(0x0000A48800C59B5F AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (22, 3, 20, 1, CAST(0x0000A48800C59D18 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (23, 8, 4, 1, CAST(0x0000A488014C0B2A AS DateTime), 10)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (24, 8, 6, 1, CAST(0x0000A488014C21CE AS DateTime), 10)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (25, 8, 21, 1, CAST(0x0000A488014C280C AS DateTime), 10)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (26, 8, 20, 1, CAST(0x0000A488014C3964 AS DateTime), 10)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (27, 9, 4, 1, CAST(0x0000A488015C0314 AS DateTime), 10)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (28, 9, 20, 1, CAST(0x0000A488015C2451 AS DateTime), 2)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (29, 9, 21, 1, CAST(0x0000A488015C3645 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (30, 9, 18, 1, CAST(0x0000A488015C5164 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (31, 11, 12, 1, CAST(0x0000A48B001D67F6 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (32, 11, 8, 1, CAST(0x0000A48B00274BCE AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (33, 11, 11, 1, CAST(0x0000A48B00274CF7 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (34, 11, 4, 1, CAST(0x0000A48B0027C083 AS DateTime), 2)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (35, 10, 5, 1, CAST(0x0000A48B003E777E AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (36, 12, 11, 0, CAST(0x0000A48B0046D884 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (37, 12, 7, 0, CAST(0x0000A48B0046DC90 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (38, 5, 12, 1, CAST(0x0000A48B009D5218 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (39, 10, 8, 1, CAST(0x0000A48B00A09FC5 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (40, 11, 11, 1, CAST(0x0000A48B00A1287E AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (41, 1, 10, 0, CAST(0x0000A48B00A1BD27 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (42, 6, 14, 0, CAST(0x0000A48B00A1F55E AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (43, 6, 18, 0, CAST(0x0000A48B00A24043 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (44, 6, 19, 0, CAST(0x0000A48B00A249FD AS DateTime), 9)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (45, 5, 11, 1, CAST(0x0000A48B00A285E1 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (46, 5, 15, 1, CAST(0x0000A48B00A28E66 AS DateTime), 5)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (47, 5, 20, 1, CAST(0x0000A48B00A58703 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (48, 6, 3, 0, CAST(0x0000A48B00A5BAE2 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (49, 6, 3, 0, CAST(0x0000A48B00A99271 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (50, 0, 6, 1, CAST(0x0000A55101743155 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (51, 0, 7, 1, CAST(0x0000A551017436FD AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (52, 13, 6, 1, CAST(0x0000A5510174770C AS DateTime), 2)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (53, 13, 7, 1, CAST(0x0000A55101747D5E AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (56, 22, 6, 1, CAST(0x0000A552016EA2FC AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (57, 22, 18, 1, CAST(0x0000A55300971E75 AS DateTime), 2)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (58, 22, 19, 1, CAST(0x0000A5530097639E AS DateTime), 3)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (59, 22, 6, 1, CAST(0x0000A5530098DEF7 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (60, 22, 7, 1, CAST(0x0000A55300994D6D AS DateTime), 2)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (61, 22, 16, 1, CAST(0x0000A55300A85C11 AS DateTime), 7)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (63, 22, 16, 1, CAST(0x0000A55400A46125 AS DateTime), 6)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (64, 15, 11, 1, CAST(0x0000A55900FA9486 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (65, 15, 16, 1, CAST(0x0000A55900FA9DBF AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (66, 23, 6, 1, CAST(0x0000A55900FAF655 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (67, 23, 19, 1, CAST(0x0000A55900FB084D AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (68, 24, 6, 1, CAST(0x0000A55900FC62F7 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (69, 24, 7, 1, CAST(0x0000A55900FC64C0 AS DateTime), 2)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (70, 24, 8, 1, CAST(0x0000A55900FCB0DE AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (71, 25, 6, 1, CAST(0x0000A55900FD9527 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (72, 25, 7, 1, CAST(0x0000A55900FD992B AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (73, 25, 8, 1, CAST(0x0000A55900FDAB45 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (74, 26, 7, 1, CAST(0x0000A55900FF45B4 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (75, 26, 6, 1, CAST(0x0000A55900FF5193 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (76, 26, 7, 1, CAST(0x0000A55900FF5449 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (77, 27, 6, 1, CAST(0x0000A5590100595F AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (78, 27, 7, 1, CAST(0x0000A55901005B54 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (79, 27, 8, 1, CAST(0x0000A559010072F6 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (80, 27, 6, 1, CAST(0x0000A55901010462 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (81, 27, 7, 1, CAST(0x0000A5590101073C AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (82, 27, 6, 1, CAST(0x0000A5590105DDD9 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (83, 27, 7, 1, CAST(0x0000A5590105F6E7 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (84, 27, 8, 1, CAST(0x0000A5590106002F AS DateTime), 2)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (85, 27, 7, 1, CAST(0x0000A55901060636 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (86, 14, 7, 1, CAST(0x0000A559010FF0AF AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (87, 14, 8, 1, CAST(0x0000A559010FF268 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (88, 13, 8, 1, CAST(0x0000A559010FFF0F AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (89, 13, 11, 1, CAST(0x0000A55901100009 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (90, 28, 6, 1, CAST(0x0000A5590163DB81 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (91, 28, 7, 1, CAST(0x0000A5590163DCD7 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (92, 21, 8, 1, CAST(0x0000A5590163F0BC AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (93, 21, 11, 1, CAST(0x0000A5590163F16E AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (94, 29, 7, 1, CAST(0x0000A5590173C0BC AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (95, 29, 9, 1, CAST(0x0000A5590173C266 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (96, 20, 7, 1, CAST(0x0000A55901791CD7 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (97, 20, 10, 1, CAST(0x0000A55901791EA7 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (98, 30, 7, 1, CAST(0x0000A559017930E1 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (99, 30, 9, 1, CAST(0x0000A5590179317A AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (100, 35, 6, 1, CAST(0x0000A56201724A35 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (101, 39, 6, 1, CAST(0x0000A56300F116EC AS DateTime), 2)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (102, 39, 7, 1, CAST(0x0000A56300F11FC6 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (103, 39, 14, 1, CAST(0x0000A56300F12785 AS DateTime), 1)
GO
print 'Processed 100 total records'
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (104, 40, 6, 1, CAST(0x0000A56301104853 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (105, 41, 6, 1, CAST(0x0000A56301136119 AS DateTime), 2)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (106, 41, 7, 1, CAST(0x0000A56301136960 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (107, 41, 8, 1, CAST(0x0000A56301137D45 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (108, 41, 13, 1, CAST(0x0000A5630113817C AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (109, 42, 6, 1, CAST(0x0000A5640149B2C6 AS DateTime), 1)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (110, 43, 6, 0, CAST(0x0000A56D00A9B295 AS DateTime), 2)
INSERT [dbo].[R_Order_Product] ([ROrderProId], [OrderId], [ProId], [DelFlag], [SubTime], [UnitCount]) VALUES (111, 43, 17, 0, CAST(0x0000A56D00A9C2DD AS DateTime), 3)
SET IDENTITY_INSERT [dbo].[R_Order_Product] OFF
/****** Object:  Table [dbo].[R_Order_Desk]    Script Date: 04/20/2017 08:28:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[R_Order_Desk](
	[RID] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[DeskId] [int] NULL,
 CONSTRAINT [PK_R_Order_Desk] PRIMARY KEY CLUSTERED 
(
	[RID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[R_Order_Desk] ON
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (1, 1, 1)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (2, 3, 2)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (3, 5, 11)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (4, 6, 35)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (5, 7, 26)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (6, 8, 37)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (7, 9, 34)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (8, 10, 43)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (9, 11, 41)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (10, 12, 28)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (11, 13, 41)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (12, 14, 40)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (13, 15, 47)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (15, 17, 24)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (16, 18, 25)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (18, 20, 30)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (19, 21, 31)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (20, 22, 52)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (21, 23, 47)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (22, 24, 52)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (23, 25, 52)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (24, 26, 52)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (25, 27, 52)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (26, 28, 52)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (27, 29, 52)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (28, 30, 30)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (29, 31, 52)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (30, 32, 52)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (31, 33, 52)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (32, 34, 54)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (33, 35, 54)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (34, 36, 54)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (35, 37, 54)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (36, 38, 54)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (37, 39, 54)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (38, 40, 54)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (39, 41, 54)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (40, 42, 54)
INSERT [dbo].[R_Order_Desk] ([RID], [OrderId], [DeskId]) VALUES (41, 43, 54)
SET IDENTITY_INSERT [dbo].[R_Order_Desk] OFF
/****** Object:  Table [dbo].[ProductInfo]    Script Date: 04/20/2017 08:28:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductInfo](
	[ProId] [int] IDENTITY(1,1) NOT NULL,
	[CId] [int] NULL,
	[ProName] [nvarchar](50) NULL,
	[ProCost] [float] NULL,
	[ProSpell] [nvarchar](50) NULL,
	[ProPrice] [float] NULL,
	[ProUnit] [nvarchar](50) NULL,
	[Remark] [nvarchar](50) NULL,
	[DelFlag] [int] NULL,
	[SubTime] [datetime] NULL,
	[ProStock] [int] NULL,
	[ProNum] [nvarchar](50) NULL,
	[SubBy] [int] NULL,
 CONSTRAINT [PK_ProductInfo] PRIMARY KEY CLUSTERED 
(
	[ProId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ProductInfo] ON
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (1, 1, N'中华烟', 100, N'ZHY', 120, N'包', N'装逼利器', 1, CAST(0x00009E4A00000000 AS DateTime), 10, N'1001', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (2, 1, N'玉溪烟', 23, N'YXY', 35, N'包', N'好烟', 1, CAST(0x00009E4A00000000 AS DateTime), 10, N'1002', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (3, 1, N'长白山烟', 10, N'CBSY', 20, N'包', N'好烟', 1, CAST(0x00009E4A00000000 AS DateTime), 10, N'1003', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (4, 2, N'茅台酒', 1000, N'MTJ', 1500, N'瓶', N'好酒', 1, CAST(0x00009E4A00000000 AS DateTime), 10, N'1004', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (5, 2, N'红星二锅头酒', 100, N'HXEGTJ', 120, N'瓶', N'好酒', 1, CAST(0x00009E4A00000000 AS DateTime), 10, N'1005', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (6, 3, N'长城红酒', 200, N'CCHJ', 300, N'瓶', N'好酒', 0, CAST(0x00009E4A00000000 AS DateTime), 10, N'1006', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (7, 3, N'张裕红酒', 150, N'ZYHJ', 280, N'瓶', N'好酒', 0, CAST(0x00009E4A00000000 AS DateTime), 10, N'1007', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (8, 4, N'金士百啤酒', 5, N'JSBPJ', 10, N'瓶', N'好酒', 0, CAST(0x00009E4A00000000 AS DateTime), 10, N'1008', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (9, 4, N'雪花啤酒', 5, N'XHPJ', 10, N'瓶', N'好酒', 0, CAST(0x00009E4A00000000 AS DateTime), 10, N'1009', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (10, 5, N'梅花鹿糖', 2, N'MHLT', 3, N'个', N'好糖', 0, CAST(0x00009E4A00000000 AS DateTime), 10, N'1010', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (11, 5, N'奶糖', 1, N'NT', 2, N'个', N'好糖', 0, CAST(0x00009E4A00000000 AS DateTime), 10, N'1011', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (12, 6, N'龙井', 50, N'LJ', 55, N'壶', N'好茶', 0, CAST(0x00009E4A00000000 AS DateTime), 10, N'1012', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (13, 6, N'碧螺春', 50, N'BLC', 55, N'壶', N'好茶', 0, CAST(0x00009E4A00000000 AS DateTime), 10, N'1013', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (14, 7, N'可口可乐', 2, N'KKKL', 5, N'瓶', N'好饮料', 0, CAST(0x00009E4A00000000 AS DateTime), 10, N'1014', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (15, 7, N'美年达', 2, N'MND', 5, N'瓶', N'好饮料', 0, CAST(0x00009E4A00000000 AS DateTime), 10, N'1015', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (16, 7, N'百事可乐', 2, N'BSKL', 5, N'瓶', N'好饮料', 0, CAST(0x00009E4A00000000 AS DateTime), 10, N'1016', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (17, 8, N'香蕉', 3, N'XJ', 5, N'份', N'好水果', 0, CAST(0x00009E4A00000000 AS DateTime), 10, N'1017', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (18, 8, N'苹果', 3, N'PG', 5, N'份', N'好水果', 0, CAST(0x00009E4A00000000 AS DateTime), 10, N'1018', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (19, 8, N'橙子', 3, N'CZ', 5, N'份', N'好水果', 0, CAST(0x00009E4A00000000 AS DateTime), 10, N'1019', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (20, 8, N'榴莲', 100, N'LL', 200, N'份', N'好水果', 1, CAST(0x00009E4A00000000 AS DateTime), 10, N'1020', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (21, 9, N'东北乱炖', 50, N'DBLD', 50, N'份', N'好菜', 1, CAST(0x00009E4A00000000 AS DateTime), 10, N'1021', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (22, 12, N'测试啊', 12, N'ce shi a', 323, N'1', N'223', 1, CAST(0x0000A48801549FF8 AS DateTime), 21, N'1022', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (23, 13, N'测试数据', 31231, N'313', 3123, N'321', N'31', 1, CAST(0x0000A488015522C4 AS DateTime), 31, N'1023', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (24, 14, N'饭后一条龙', 10, N'fan hou yu le', 1000, N'次', N'很强大的体验', 1, CAST(0x0000A488015DD43C AS DateTime), 100, N'1024', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (25, 15, N'揉揉的', 10, N'rou rou de', 50, N'次', N'很好玩的', 1, CAST(0x0000A48A00C96622 AS DateTime), 10, N'1025', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (26, 17, N'仗剑走天涯', 1, N'1', 1, N'1', N'帅', 1, CAST(0x0000A54D00F65FC9 AS DateTime), 1, N'1', 1)
INSERT [dbo].[ProductInfo] ([ProId], [CId], [ProName], [ProCost], [ProSpell], [ProPrice], [ProUnit], [Remark], [DelFlag], [SubTime], [ProStock], [ProNum], [SubBy]) VALUES (27, 20, N'66', 66, N'66', 66, N'66', N'66', 1, CAST(0x0000A54E01344D14 AS DateTime), 66, N'66', 1)
SET IDENTITY_INSERT [dbo].[ProductInfo] OFF
/****** Object:  Table [dbo].[OrderInfo]    Script Date: 04/20/2017 08:28:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderInfo](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[SubTime] [datetime] NULL,
	[Remark] [nvarchar](50) NULL,
	[OrderState] [int] NULL,
	[OrderMemberId] [int] NULL,
	[DelFlag] [int] NULL,
	[SubBy] [int] NULL,
	[BeginTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
	[OrderMoney] [float] NULL,
	[DisCount] [float] NOT NULL,
 CONSTRAINT [PK_OrderInfo] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OrderInfo] ON
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (1, CAST(0x0000A41300000000 AS DateTime), N'此订单是单位报销的', 1, 1, 0, 1, CAST(0x0000A48B00FBF0D4 AS DateTime), CAST(0x0000A41400000000 AS DateTime), 998, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (3, CAST(0x0000A48700F09500 AS DateTime), N'4个人,一起吃喝玩乐', 2, 0, 0, 1, CAST(0x0000A48800C59F17 AS DateTime), CAST(0x0000A48800C5B0EE AS DateTime), 530, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (5, CAST(0x0000A48700F3B5CE AS DateTime), N'4个人,大家聚会', 2, 0, 0, 1, CAST(0x0000A48B010E3329 AS DateTime), CAST(0x0000A48B010E3991 AS DateTime), 2095, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (6, CAST(0x0000A487010E3B39 AS DateTime), N'5个人,随便吃点', 1, NULL, 0, 1, CAST(0x0000A48B00FBE414 AS DateTime), NULL, 160, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (7, CAST(0x0000A4870121DE43 AS DateTime), N'2个人吃饭', 2, 1, 0, 1, CAST(0x0000A48800A10148 AS DateTime), CAST(0x0000A48800C457E0 AS DateTime), 65, 5)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (8, CAST(0x0000A488014BC720 AS DateTime), N'2个人一起吃喝玩乐', 2, 3, 0, 1, CAST(0x0000A488014C5F3A AS DateTime), CAST(0x0000A488014CB383 AS DateTime), 14130, 9)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (9, CAST(0x0000A488015BA69E AS DateTime), N'2个人吃喝玩乐', 2, 5, 0, 1, CAST(0x0000A488015C5BF5 AS DateTime), CAST(0x0000A488015CA434 AS DateTime), 1504.5, 1)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (10, CAST(0x0000A48B0017C1D2 AS DateTime), N'10个一起吃饭', 2, NULL, 0, 1, CAST(0x0000A48B010D7EE4 AS DateTime), NULL, 130, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (11, CAST(0x0000A48B001890BE AS DateTime), N'10个吃饭', 2, NULL, 0, 1, CAST(0x0000A48B010D4925 AS DateTime), NULL, 0, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (12, CAST(0x0000A48B001C81F4 AS DateTime), N'2个吃饭', 1, NULL, 0, 1, CAST(0x0000A48B00FBE806 AS DateTime), NULL, 282, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (13, CAST(0x0000A551012E8354 AS DateTime), N'11个11', 2, 1, 0, 1, CAST(0x0000A55101748461 AS DateTime), CAST(0x0000A559011017A3 AS DateTime), 6, 5)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (14, CAST(0x0000A5510135E7FF AS DateTime), N'111个111', 2, NULL, 0, 1, CAST(0x0000A5510135E7FF AS DateTime), CAST(0x0000A559010FF95F AS DateTime), 290, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (15, CAST(0x0000A55101752C71 AS DateTime), N'12个12', 2, NULL, 0, 1, CAST(0x0000A55101752C71 AS DateTime), CAST(0x0000A55900FAB261 AS DateTime), 7, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (17, CAST(0x0000A55200C6B1BB AS DateTime), N'16个16', 1, NULL, 0, 1, CAST(0x0000A55200C6B1BA AS DateTime), NULL, 0, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (18, CAST(0x0000A55200C6E479 AS DateTime), N'207个207', 1, NULL, 0, 1, CAST(0x0000A55200C71AE7 AS DateTime), NULL, 0, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (20, CAST(0x0000A552011B255C AS DateTime), N'1个1116.1710', 2, NULL, 0, 1, CAST(0x0000A552011B255B AS DateTime), CAST(0x0000A55901792458 AS DateTime), 283, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (21, CAST(0x0000A552011B7153 AS DateTime), N'1个1116.1711', 2, 1, 0, 1, CAST(0x0000A552011B7153 AS DateTime), CAST(0x0000A55901640607 AS DateTime), 6, 5)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (22, CAST(0x0000A552012FC9F9 AS DateTime), N'11161825个11161825', 2, NULL, 0, 1, CAST(0x0000A552012FC9F9 AS DateTime), CAST(0x0000A55900F95A5E AS DateTime), 345, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (23, CAST(0x0000A55900FAF219 AS DateTime), N'1个1', 2, NULL, 0, 1, CAST(0x0000A55900FAF219 AS DateTime), CAST(0x0000A55900FB131E AS DateTime), 305, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (24, CAST(0x0000A55900FC5F8C AS DateTime), N'1个1', 2, 1, 0, 1, CAST(0x0000A55900FC5F8C AS DateTime), CAST(0x0000A55900FD3A7B AS DateTime), 285, 5)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (25, CAST(0x0000A55900FD921D AS DateTime), N'1个1', 2, 2, 0, 1, CAST(0x0000A55900FD921C AS DateTime), CAST(0x0000A55900FDDC3F AS DateTime), 59, 1)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (26, CAST(0x0000A55900FF426E AS DateTime), N'1个1', 2, NULL, 0, 1, CAST(0x0000A55900FF426E AS DateTime), CAST(0x0000A55900FF6DEE AS DateTime), 580, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (27, CAST(0x0000A55901005658 AS DateTime), N'1个1', 2, NULL, 0, 1, CAST(0x0000A5590101172F AS DateTime), CAST(0x0000A559010FE003 AS DateTime), 0, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (28, CAST(0x0000A5590163D8DF AS DateTime), N'1个1', 2, NULL, 0, 1, CAST(0x0000A5590163D8DF AS DateTime), CAST(0x0000A5590163E44E AS DateTime), 580, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (29, CAST(0x0000A5590173BDF5 AS DateTime), N'1个1', 2, 12, 0, 1, CAST(0x0000A5590173BDF4 AS DateTime), CAST(0x0000A5590173E59F AS DateTime), 29, 1)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (30, CAST(0x0000A55901792DEE AS DateTime), N'1个1', 2, 2, 0, 1, CAST(0x0000A55901792DEE AS DateTime), CAST(0x0000A55901793BE5 AS DateTime), 29, 1)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (31, CAST(0x0000A562011D36DD AS DateTime), N'1个1', 2, 1, 0, 1, CAST(0x0000A562011D36DD AS DateTime), CAST(0x0000A562011D8053 AS DateTime), 0, 5)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (32, CAST(0x0000A562011DA070 AS DateTime), N'1个1', 2, NULL, 0, 1, CAST(0x0000A562011DA070 AS DateTime), CAST(0x0000A562011DA9C0 AS DateTime), 0, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (33, CAST(0x0000A562011DC852 AS DateTime), N'1个1', 2, 0, 0, 1, CAST(0x0000A562011DC852 AS DateTime), CAST(0x0000A562011DD25C AS DateTime), 0, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (34, CAST(0x0000A56201723171 AS DateTime), N'1个1', 2, NULL, 0, 1, CAST(0x0000A56201723171 AS DateTime), CAST(0x0000A562017236C7 AS DateTime), 0, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (35, CAST(0x0000A562017241DB AS DateTime), N'1个1', 2, NULL, 0, 1, CAST(0x0000A562017241DB AS DateTime), CAST(0x0000A56201725319 AS DateTime), 300, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (36, CAST(0x0000A56201739F79 AS DateTime), N'1个1', 2, NULL, 0, 1, CAST(0x0000A56201739F79 AS DateTime), CAST(0x0000A5620173A4FC AS DateTime), 0, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (37, CAST(0x0000A56300D9C3B2 AS DateTime), N'1个1', 2, NULL, 0, 1, CAST(0x0000A56300D9C3B2 AS DateTime), CAST(0x0000A56300DA7E17 AS DateTime), 0, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (38, CAST(0x0000A56300DD3F93 AS DateTime), N'1个1', 2, NULL, 0, 1, CAST(0x0000A56300DD3F93 AS DateTime), CAST(0x0000A56300DD4704 AS DateTime), 0, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (39, CAST(0x0000A56300F10FAF AS DateTime), N'11个1', 2, 1, 0, 1, CAST(0x0000A56300F10FAF AS DateTime), CAST(0x0000A56300F14332 AS DateTime), 302.5, 5)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (40, CAST(0x0000A56301103E00 AS DateTime), N'1个1', 2, NULL, 0, 1, CAST(0x0000A56301103E00 AS DateTime), CAST(0x0000A56301106618 AS DateTime), 300, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (41, CAST(0x0000A56301135485 AS DateTime), N'1个1', 2, NULL, 0, 1, CAST(0x0000A56301135485 AS DateTime), CAST(0x0000A56301154F3D AS DateTime), 0, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (42, CAST(0x0000A5640149AF43 AS DateTime), N'1个1', 2, NULL, 0, 1, CAST(0x0000A5640149AF43 AS DateTime), CAST(0x0000A5640149C203 AS DateTime), 300, 0)
INSERT [dbo].[OrderInfo] ([OrderId], [SubTime], [Remark], [OrderState], [OrderMemberId], [DelFlag], [SubBy], [BeginTime], [EndTime], [OrderMoney], [DisCount]) VALUES (43, CAST(0x0000A56D00A8C83C AS DateTime), N'1个1', 1, NULL, 0, 1, CAST(0x0000A56D00A8C83C AS DateTime), NULL, 615, 0)
SET IDENTITY_INSERT [dbo].[OrderInfo] OFF
/****** Object:  Table [dbo].[MemberType]    Script Date: 04/20/2017 08:28:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberType](
	[MemType] [int] IDENTITY(1,1) NOT NULL,
	[MemTypeName] [nvarchar](20) NULL,
	[MemTypeDesc] [nvarchar](50) NULL,
	[DelFlag] [int] NULL,
	[SubBy] [int] NULL,
 CONSTRAINT [PK_MemberType] PRIMARY KEY CLUSTERED 
(
	[MemType] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MemberType] ON
INSERT [dbo].[MemberType] ([MemType], [MemTypeName], [MemTypeDesc], [DelFlag], [SubBy]) VALUES (1, N'土豪会员', N'传说中的有钱人', 0, 1)
INSERT [dbo].[MemberType] ([MemType], [MemTypeName], [MemTypeDesc], [DelFlag], [SubBy]) VALUES (2, N'高级会员', N'传说中比较有钱的人', 0, 1)
INSERT [dbo].[MemberType] ([MemType], [MemTypeName], [MemTypeDesc], [DelFlag], [SubBy]) VALUES (3, N'普通会员', N'屌丝有个会员就不错了', 0, 1)
INSERT [dbo].[MemberType] ([MemType], [MemTypeName], [MemTypeDesc], [DelFlag], [SubBy]) VALUES (4, N'非会员', N'24k纯屌丝', 0, 1)
SET IDENTITY_INSERT [dbo].[MemberType] OFF
/****** Object:  Table [dbo].[MemberInfo]    Script Date: 04/20/2017 08:28:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MemberInfo](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[MemName] [nvarchar](50) NULL,
	[MemMobilePhone] [varchar](50) NULL,
	[MemAddress] [nvarchar](50) NULL,
	[MemType] [int] NULL,
	[MemNum] [nvarchar](50) NULL,
	[MemGender] [varchar](50) NULL,
	[MemDiscount] [float] NULL,
	[MemMoney] [float] NULL,
	[DelFlag] [int] NULL,
	[SubTime] [datetime] NULL,
	[MemIntegral] [int] NULL,
	[MemEndTime] [datetime] NULL,
	[MemBirthday] [datetime] NULL,
 CONSTRAINT [PK_MemberInfo] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[MemberInfo] ON
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (1, N'奥巴马', N'19912344321', N'北京', 1, N'010134', N'女', 5, 340.5, 0, CAST(0x0000A25E00000000 AS DateTime), 0, CAST(0x0000A3FF00000000 AS DateTime), CAST(0x0000638D00000000 AS DateTime))
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (2, N'金正恩', N'19912344322', N'北京', 1, N'010135', N'男', 1, 1141, 0, CAST(0x0000A25D00000000 AS DateTime), 0, CAST(0x0000A3FF00000000 AS DateTime), CAST(0x0000802200000000 AS DateTime))
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (3, N'都教授', N'11912012343', N'北京海淀区', 3, N'057327', N'男', 9, 5692, 0, CAST(0x0000A54C0158A1A7 AS DateTime), 0, CAST(0x0000A48A0024C804 AS DateTime), CAST(0x0000000300000000 AS DateTime))
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (4, N'油女志乃', N'19912344321', N'北京', 2, N'101342', N'男', 5, 935, 1, CAST(0x0000A25E00000000 AS DateTime), 0, CAST(0x0000A3FF00000000 AS DateTime), CAST(0x0000000100000000 AS DateTime))
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (5, N'大地主', N'01011011011', N'北京海淀', 1, N'030720', N'男', 2, 988260.5, 1, CAST(0x0000A488014D55AF AS DateTime), 0, CAST(0x0000D603014CED4C AS DateTime), CAST(0x0000000500000000 AS DateTime))
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (6, N'土豪', N'99899799610', N'天津', 1, N'063811', N'男', 9, 322122, 1, CAST(0x0000A488015D126E AS DateTime), 0, CAST(0x0000A48A015CC078 AS DateTime), CAST(0x0000000600000000 AS DateTime))
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (7, N'诸葛亮', N'87978765453', N'中国', 1, N'037058', N'男', 3, 235645, 1, CAST(0x0000A48A0006A0E8 AS DateTime), 0, CAST(0x0000A4CF00066C24 AS DateTime), CAST(0xFFFF716F00066C24 AS DateTime))
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (10, N'元首1', N'19912344321', N'北京', 1, N'010134', N'女', 5, 935, 2, CAST(0x0000A25E00000000 AS DateTime), 0, CAST(0x0000A3FF00000000 AS DateTime), CAST(0x0000638D00000000 AS DateTime))
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (11, N'拿破仑', N'19912344322', N'北京', 1, N'010135', N'男', 1, 1200, 1, CAST(0x0000A25D00000000 AS DateTime), 0, CAST(0x0000A3FF00000000 AS DateTime), CAST(0x0000802200000000 AS DateTime))
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (12, N'青雨', N'11', N'11', 1, N'20151109221325181760', N'女', 1, 111, 0, CAST(0x0000A54B016E8934 AS DateTime), 0, CAST(0x0000A556016E3BDC AS DateTime), CAST(0x0000A54B016E3BDC AS DateTime))
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (13, N'007', N'1', N'1', 4, N'20151110214549269280', N'男', 1, 1, 2, CAST(0x0000A54C0166BD80 AS DateTime), 0, CAST(0x0000A54D0166A73C AS DateTime), CAST(0x0000A54C0166A73C AS DateTime))
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (14, N'啊', N'111', N'啊', 1, N'20151126171425346394', N'男', 1, 14, 2, CAST(0x0000A55C011C574E AS DateTime), 0, CAST(0x0000A55D011C1C6C AS DateTime), CAST(0x0000A55C011C1D66 AS DateTime))
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (15, N'1', N'1', N'1', 3, N'20151130182652789067', N'男', 1, 1, 2, CAST(0x0000A56001302CB7 AS DateTime), 0, CAST(0x0000A56101300290 AS DateTime), CAST(0x0000A56001300314 AS DateTime))
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (16, N'2', N'2', N'2', 3, N'20151130182732954376', N'男', 2, 2, 2, CAST(0x0000A56001303D95 AS DateTime), 0, CAST(0x0000A56101303170 AS DateTime), CAST(0x0000A5600130322E AS DateTime))
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (17, N'1', N'1', N'1', 2, N'027039', N'男', 1, 1, 1, CAST(0x0000A56001310EAE AS DateTime), 0, CAST(0x0000A56101310334 AS DateTime), CAST(0x0000A560013103A8 AS DateTime))
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (18, N'奥巴马', N'19912344321', N'北京', NULL, NULL, N'女', NULL, 643, 2, NULL, 0, NULL, NULL)
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (19, N'金正恩', N'19912344322', N'北京', NULL, NULL, N'男', NULL, 1141, 2, NULL, 0, NULL, NULL)
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (20, N'都教授', N'11912012343', N'北京海淀区', NULL, NULL, N'男', NULL, 5692, 2, NULL, 0, NULL, NULL)
INSERT [dbo].[MemberInfo] ([MemberId], [MemName], [MemMobilePhone], [MemAddress], [MemType], [MemNum], [MemGender], [MemDiscount], [MemMoney], [DelFlag], [SubTime], [MemIntegral], [MemEndTime], [MemBirthday]) VALUES (21, N'青雨', N'11', N'11', NULL, NULL, N'女', NULL, 111, 2, NULL, 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[MemberInfo] OFF
/****** Object:  Table [dbo].[DeskInfo]    Script Date: 04/20/2017 08:28:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeskInfo](
	[DeskId] [int] IDENTITY(1,1) NOT NULL,
	[RoomId] [int] NULL,
	[DeskName] [nvarchar](50) NULL,
	[DeskRemark] [nvarchar](50) NULL,
	[DeskRegion] [nvarchar](50) NULL,
	[DeskState] [int] NULL,
	[DelFlag] [int] NULL,
	[SubTime] [datetime] NULL,
	[SubBy] [int] NULL,
 CONSTRAINT [PK_DeskInfo] PRIMARY KEY CLUSTERED 
(
	[DeskId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DeskInfo] ON
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (1, 1, N'001', N'这个餐桌是豪华包间的', N'餐桌在豪华包间门口位置', 1, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (2, 1, N'002', N'豪华包间的', N'门口位置', 0, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (3, 1, N'003', N'豪华包间的', N'门口位置', 0, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (6, 2, N'101', N'普通包间', N'门口位置', 0, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (7, 2, N'102', N'普通包间', N'靠窗位位置', 0, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (8, 2, N'103', N'普通包间', N'靠窗位置', 0, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (9, 2, N'104', N'普通包间', N'靠窗位置', 0, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (10, 2, N'105', N'普通包间', N'靠窗位置', 0, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (11, 2, N'106', N'普通包间', N'靠窗位置', 0, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (24, 3, N'206', N'普通大厅', N'门口位置', 1, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (25, 3, N'207', N'普通大厅', N'靠窗位位置', 1, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (26, 3, N'208', N'普通大厅', N'靠窗位置', 0, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (27, 3, N'209', N'普通大厅', N'靠窗位置', 0, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (28, 3, N'300', N'普通大厅', N'靠窗位置', 1, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (29, 3, N'301', N'普通大厅', N'靠窗位置', 0, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (30, 4, N'401', N'漂亮的包间', N'在楼顶', 0, 0, CAST(0x0000A48700CCDDAB AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (31, 4, N'402', N'漂亮的包间', N'在楼顶', 0, 0, CAST(0x0000A48700CCFB1B AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (32, 4, N'403', N'漂亮的包间', N'在楼顶', 0, 0, CAST(0x0000A48700CCFB1B AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (33, 4, N'404', N'漂亮的包间', N'在楼顶', 0, 0, CAST(0x0000A48700CCFB1B AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (34, 4, N'405', N'漂亮的包间', N'在楼顶', 0, 0, CAST(0x0000A48700CCFB1C AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (35, 4, N'406', N'漂亮的包间', N'在楼顶', 1, 0, CAST(0x0000A48700CCFB1C AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (36, 4, N'407', N'漂亮的包间', N'在楼顶', 0, 0, CAST(0x0000A48700CCFB1C AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (37, 4, N'6833', N'漂亮的房间', N'很好有阳光', 0, 0, CAST(0x0000A48800D39487 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (38, 4, N'674', N'好房间', N'阳光充裕', 0, 0, CAST(0x0000A48800D3D3F7 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (39, 5, N'12345', N'上档次', N'贵族奢华', 0, 0, CAST(0x0000A48800D4F1CD AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (40, 6, N'99991', N'神秘', N'很神秘', 0, 0, CAST(0x0000A48800D5A93A AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (41, 6, N'99992', N'嘎嘎', N'哈哈', 0, 0, CAST(0x0000A48800D60CEB AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (43, 6, N'7756', N'一般人不让进', N'哈哈哈', 0, 0, CAST(0x0000A488015E45B6 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (44, 7, N'76767', N'好惊讶', N'确实很惊讶', 0, 1, CAST(0x0000A48A010C2276 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (45, 8, N'1321', N'321321', N'321321', 0, 1, CAST(0x0000A48A016B4B18 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (46, 1, N'1412', N'这个餐桌是豪华包间的', N'餐桌在豪华包间门口位置', 1, 0, CAST(0x00008EAC00000000 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (47, 9, N'6455', N'32423', N'424324', 0, 0, CAST(0x0000A48B01704DD2 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (48, 10, N'8564564', N'323213', N'313213', 0, 1, CAST(0x0000A48B01707749 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (49, 11, N'太6', N'666', N'666', 0, 1, CAST(0x0000A54E011CDF57 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (50, 12, N'66', N'6', N'6', 1, 1, CAST(0x0000A54E013C5F65 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (51, 13, N'1113', N'1', N'1', 1, 1, CAST(0x0000A54F01126C37 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (52, 13, N'11161819', N'11161819', N'11161819', 0, 0, CAST(0x0000A552012E1620 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (53, 13, N'11161823', N'11161823', N'11161823', 0, 0, CAST(0x0000A552012F1D8D AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (54, 14, N'110', N'110', N'110', 1, 0, CAST(0x0000A56201204CB7 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (55, 14, N'1122', N'12', N'12', 0, 0, CAST(0x0000A562012CA0DC AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (56, 18, N'1', N'1', N'1', 0, 1, CAST(0x0000A562012F1E09 AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (57, 18, N'1', N'1', N'1', 0, 1, CAST(0x0000A56201328B3A AS DateTime), 1)
INSERT [dbo].[DeskInfo] ([DeskId], [RoomId], [DeskName], [DeskRemark], [DeskRegion], [DeskState], [DelFlag], [SubTime], [SubBy]) VALUES (58, 14, N'1', N'1', N'1', 0, 0, CAST(0x0000A5620132C035 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[DeskInfo] OFF
/****** Object:  Table [dbo].[CategoryInfo]    Script Date: 04/20/2017 08:28:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryInfo](
	[CId] [int] IDENTITY(1,1) NOT NULL,
	[CName] [nvarchar](50) NULL,
	[CNum] [nvarchar](50) NULL,
	[CRemark] [nvarchar](50) NULL,
	[DelFlag] [int] NULL,
	[SubTime] [datetime] NULL,
	[SubBy] [int] NULL,
 CONSTRAINT [PK_CategoryInfo] PRIMARY KEY CLUSTERED 
(
	[CId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CategoryInfo] ON
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (1, N'香烟', N'0', N'各种香烟', 1, CAST(0x00009E4A00000000 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (2, N'白酒', N'1', N'各种白酒', 1, CAST(0x00009E4A00000000 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (3, N'红酒', N'2', N'各种红酒', 0, CAST(0x00009E4A00000000 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (4, N'啤酒', N'3', N'各种啤酒', 0, CAST(0x00009E4A00000000 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (5, N'糖', N'4', N'各种糖', 0, CAST(0x00009E4A00000000 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (6, N'茶', N'5', N'各种茶', 0, CAST(0x00009E4A00000000 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (7, N'饮料', N'6', N'各种饮料', 0, CAST(0x00009E4A00000000 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (8, N'水果', N'7', N'各种水果', 0, CAST(0x00009E4A00000000 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (9, N'菜', N'8', N'各种炒菜', 0, CAST(0x00009E4A00000000 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (10, N'汤', N'9', N'各种汤', 0, CAST(0x00009E4A00000000 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (11, N'主食', N'10', N'各种主食', 0, CAST(0x00009E4A00000000 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (12, N'娱乐', N'11', N'饭后娱乐', 0, CAST(0x0000A48800EA65B3 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (13, N'测试', N'12', N'测试的', 1, CAST(0x0000A48800EAACBF AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (14, N'饭后娱乐啊', N'887', N'一般人消费不起', 1, CAST(0x0000A488015D8E09 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (15, N'娱乐项目', N'11', N'你懂的', 0, CAST(0x0000A54D009A1BB1 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (16, N'搞笑的', N'12', N'很好玩的', 1, CAST(0x0000A48A00BA0D57 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (17, N'吹牛逼', N'777', N'专治各种不服', 1, CAST(0x0000A54D0099FBA2 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (18, N'啊', N'啊', N'啊', 1, CAST(0x0000A41300000000 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (19, N'啊', N'啊', N'啊', 1, CAST(0x0000A54D01763783 AS DateTime), 1)
INSERT [dbo].[CategoryInfo] ([CId], [CName], [CNum], [CRemark], [DelFlag], [SubTime], [SubBy]) VALUES (20, N'666', N'666', N'666', 1, CAST(0x0000A54E0134053B AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[CategoryInfo] OFF
/****** Object:  Default [DF_UserInfo_DelFlag]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[UserInfo] ADD  CONSTRAINT [DF_UserInfo_DelFlag]  DEFAULT ((0)) FOR [DelFlag]
GO
/****** Object:  Default [DF_UserInfo_SubTime]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[UserInfo] ADD  CONSTRAINT [DF_UserInfo_SubTime]  DEFAULT ((1)) FOR [SubTime]
GO
/****** Object:  Default [DF_RoomInfo_DelFlag]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[RoomInfo] ADD  CONSTRAINT [DF_RoomInfo_DelFlag]  DEFAULT ((0)) FOR [DelFlag]
GO
/****** Object:  Default [DF_RoomInfo_SubBy]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[RoomInfo] ADD  CONSTRAINT [DF_RoomInfo_SubBy]  DEFAULT ((1)) FOR [SubBy]
GO
/****** Object:  Default [DF_R_Order_Product_DelFlag]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[R_Order_Product] ADD  CONSTRAINT [DF_R_Order_Product_DelFlag]  DEFAULT ((0)) FOR [DelFlag]
GO
/****** Object:  Default [DF_ProductInfo_DelFlag]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[ProductInfo] ADD  CONSTRAINT [DF_ProductInfo_DelFlag]  DEFAULT ((0)) FOR [DelFlag]
GO
/****** Object:  Default [DF_ProductInfo_SubBy]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[ProductInfo] ADD  CONSTRAINT [DF_ProductInfo_SubBy]  DEFAULT ((1)) FOR [SubBy]
GO
/****** Object:  Default [DF_OrderInfo_OrderState]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[OrderInfo] ADD  CONSTRAINT [DF_OrderInfo_OrderState]  DEFAULT ((1)) FOR [OrderState]
GO
/****** Object:  Default [DF_OrderInfo_DelFlag]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[OrderInfo] ADD  CONSTRAINT [DF_OrderInfo_DelFlag]  DEFAULT ((0)) FOR [DelFlag]
GO
/****** Object:  Default [DF_OrderInfo_SubBy]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[OrderInfo] ADD  CONSTRAINT [DF_OrderInfo_SubBy]  DEFAULT ((1)) FOR [SubBy]
GO
/****** Object:  Default [DF_OrderInfo_OrderMoney]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[OrderInfo] ADD  CONSTRAINT [DF_OrderInfo_OrderMoney]  DEFAULT ((0)) FOR [OrderMoney]
GO
/****** Object:  Default [DF_OrderInfo_DisCount]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[OrderInfo] ADD  CONSTRAINT [DF_OrderInfo_DisCount]  DEFAULT ((0)) FOR [DisCount]
GO
/****** Object:  Default [DF_MemberType_DelFlag]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[MemberType] ADD  CONSTRAINT [DF_MemberType_DelFlag]  DEFAULT ((0)) FOR [DelFlag]
GO
/****** Object:  Default [DF_MemberType_SubBy]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[MemberType] ADD  CONSTRAINT [DF_MemberType_SubBy]  DEFAULT ((1)) FOR [SubBy]
GO
/****** Object:  Default [DF_MemberInfo_DelFlag]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[MemberInfo] ADD  CONSTRAINT [DF_MemberInfo_DelFlag]  DEFAULT ((0)) FOR [DelFlag]
GO
/****** Object:  Default [DF_MemberInfo_MemIntegral]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[MemberInfo] ADD  CONSTRAINT [DF_MemberInfo_MemIntegral]  DEFAULT ((0)) FOR [MemIntegral]
GO
/****** Object:  Default [DF_DeskInfo_DelFlag]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[DeskInfo] ADD  CONSTRAINT [DF_DeskInfo_DelFlag]  DEFAULT ((0)) FOR [DelFlag]
GO
/****** Object:  Default [DF_DeskInfo_SubBy]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[DeskInfo] ADD  CONSTRAINT [DF_DeskInfo_SubBy]  DEFAULT ((1)) FOR [SubBy]
GO
/****** Object:  Default [DF_CategoryInfo_DelFlag]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[CategoryInfo] ADD  CONSTRAINT [DF_CategoryInfo_DelFlag]  DEFAULT ((0)) FOR [DelFlag]
GO
/****** Object:  Default [DF_CategoryInfo_SubBy]    Script Date: 04/20/2017 08:28:59 ******/
ALTER TABLE [dbo].[CategoryInfo] ADD  CONSTRAINT [DF_CategoryInfo_SubBy]  DEFAULT ((1)) FOR [SubBy]
GO
