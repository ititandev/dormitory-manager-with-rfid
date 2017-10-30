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

/****** Object:  Table [dbo].[DiemRenLuyen]    Script Date: 30/10/2017 2:20:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DiemRenLuyen](
	[MSSV] [nvarchar](10) NULL,
	[YThucCaNhan] [int] NULL,
	[KiemTraPhong] [int] NULL,
	[SinhHoat] [int] NULL,
	[ThamGiaKhac] [int] NULL,
	[CTXH] [int] NULL,
	[DiemThuongPhat] [int] NULL,
	[TongDiem] [int] NULL
) ON [PRIMARY]
GO

