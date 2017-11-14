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

/****** Object:  Table [dbo].[HoaDonDienNuoc]    Script Date: 11/11/2017 8:36:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HoaDonDienNuoc](
	[MaSo] [int] IDENTITY(1,1) NOT NULL,
	[IDPhong] [nvarchar](10) NOT NULL,
	[ChiSoDienDau] [int] NOT NULL,
	[ChiSoDienCuoi] [int] NOT NULL,
	[ChiSoNuocDau] [int] NOT NULL,
	[ChiSoNuocCuoi] [int] NOT NULL,
	[DaThanhToan] [bit] NOT NULL,
	[MaDot] [int] NOT NULL,
	[GiaTien] [bigint] NOT NULL,
	[ChuThich] [nvarchar](50) NULL,
 CONSTRAINT [PK_HoaDonDienNuoc] PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

