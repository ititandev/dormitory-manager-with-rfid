/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2016
    Target Database Engine Edition : Microsoft SQL Server Express Edition
    Target Database Engine Type : Standalone SQL Server
*/

USE [DormitoryDB]
GO

/****** Object:  Table [dbo].[HopDong]    Script Date: 30/10/2017 2:29:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HopDong](
	[MaSo] [int] IDENTITY(1,1) NOT NULL,
	[MSSV] [nvarchar](10) NULL,
	[MaNhanVien] [nvarchar](10) NULL,
	[NgayLap] [date] NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
	[TinhTrang] [char](1) NOT NULL,
	[ChuThich] [nvarchar](50) NULL,
	[RFID] [nvarchar](12) NULL,
	[IDPhong] [nvarchar](10) NULL,
	[GiaTienTongCong] [int] NULL,
	[GiaTienDaNop] [int] NULL,
 CONSTRAINT [PK_HopDong] PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

