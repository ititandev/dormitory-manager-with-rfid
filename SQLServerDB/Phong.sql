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

/****** Object:  Table [dbo].[Phong]    Script Date: 11/11/2017 8:36:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Phong](
	[IDPhong] [nvarchar](10) NOT NULL,
	[SoPhong] [nvarchar](9) NOT NULL,
	[KhuNha] [nvarchar](10) NOT NULL,
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[SoLuongChoPhep] [int] NOT NULL,
	[TinhTrang] [nvarchar](50) NOT NULL,
	[SoLuongHienTai] [int] NOT NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[IDPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

