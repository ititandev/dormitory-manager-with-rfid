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

/****** Object:  Table [dbo].[NhanVien]    Script Date: 25/10/2017 2:48:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NhanVien](
	[hoTen] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[maNhanVien] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AI NOT NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [nvarchar](5) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[diaChi] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[queQuan] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[soDienThoai] [nvarchar](12) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[email] [nvarchar](75) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[chucVu] [nvarchar](1) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

