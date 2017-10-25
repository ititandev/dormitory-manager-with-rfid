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

/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 25/10/2017 4:08:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TaiKhoan](
	[maNhanVien] [nvarchar](10) NULL,
	[tenDangNhap] [nvarchar](50) NULL,
	[matKhau] [nvarchar](128) NULL
) ON [PRIMARY]
GO

