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

/****** Object:  Table [dbo].[HopDong]    Script Date: 11/11/2017 8:36:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HopDong](
	[MaSo] [int] IDENTITY(1,1) NOT NULL,
	[MSSV] [nvarchar](10) NOT NULL,
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
	[TinhTrang] [char](1) NOT NULL,
	[IDPhong] [nvarchar](10) NOT NULL,
	[GiaTienTongCong] [int] NOT NULL,
	[GiaTienDaNop] [int] NOT NULL,
	[ChuThich] [nvarchar](max) NULL,
 CONSTRAINT [PK_HopDong] PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

