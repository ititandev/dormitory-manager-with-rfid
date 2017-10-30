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

/****** Object:  Table [dbo].[SinhVien]    Script Date: 30/10/2017 2:31:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SinhVien](
	[HoTen] [nvarchar](50) NULL,
	[MSSV] [nvarchar](10) NOT NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[CMND] [nvarchar](12) NULL,
	[SoDienThoai] [nvarchar](12) NULL,
	[Lop] [nvarchar](10) NULL,
	[Khoa] [nvarchar](30) NULL,
	[QueQuan] [nvarchar](50) NULL,
	[DienUuTien] [nvarchar](50) NULL,
	[Anh] [varchar](50) NULL,
	[Email] [nvarchar](75) NULL,
 CONSTRAINT [PK_StudentInfo] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

