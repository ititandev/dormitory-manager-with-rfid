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

/****** Object:  Table [dbo].[Phong]    Script Date: 25/10/2017 4:02:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Phong](
	[soPhong] [nvarchar](9) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[khuNha] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[maNhanVien] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[soLuongChoPhep] [int] NULL,
	[tinhTrang] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[idPhong] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[soLuongHienTai] [int] NULL
) ON [PRIMARY]
GO

