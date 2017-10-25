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

/****** Object:  Table [dbo].[StudentInfo]    Script Date: 25/10/2017 4:05:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SinhVien](
	[hoTen] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[MSSV] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AI NOT NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [nvarchar](5) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[CMND] [nvarchar](12) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[soDienThoai] [nvarchar](12) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[lop] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[khoa] [nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[queQuan] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[dienUuTien] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
	[diemRenLuyen] [int] NULL,
	[anh] [varchar](50) NULL,
	[email] [nvarchar](75) COLLATE SQL_Latin1_General_CP1_CI_AI NULL,
 CONSTRAINT [PK_StudentInfo] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

