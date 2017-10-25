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

/****** Object:  Table [dbo].[HopDong]    Script Date: 25/10/2017 1:43:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HopDong](
	[maSo] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AI NULL ,
	[MSSV] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[maNhanVien] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[ngayLap] [date]  NULL,
	[ngayBatDau] [date] NULL,
	[ngayKetThuc] [date] NULL,
	[tinhTrang] [int] NULL,
	[rfid] [nvarchar](12) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[idPhong] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[giaTienTongCong] [int] NULL,
	[giaTienDaNop] [int] NULL
) ON [PRIMARY]
GO


