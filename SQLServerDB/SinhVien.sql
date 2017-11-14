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

/****** Object:  Table [dbo].[SinhVien]    Script Date: 11/11/2017 8:36:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SinhVien](
	[MSSV] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](5) NOT NULL,
	[CMND] [nvarchar](12) NOT NULL,
	[Lop] [nvarchar](10) NOT NULL,
	[SoDienThoai] [nvarchar](12) NOT NULL,
	[Khoa] [nvarchar](30) NOT NULL,
	[QueQuan] [nvarchar](50) NOT NULL,
	[DienUuTien] [nvarchar](50) NOT NULL,
	[Anh] [varchar](50) NOT NULL,
	[Email] [nvarchar](75) NOT NULL,
	[RFID] [nvarchar](12) NOT NULL,
 CONSTRAINT [PK_StudentInfo] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_RFID] UNIQUE NONCLUSTERED 
(
	[RFID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

