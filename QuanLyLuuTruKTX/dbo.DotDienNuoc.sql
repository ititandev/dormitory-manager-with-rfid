CREATE TABLE [dbo].[DotDienNuoc] (
    [MaDot]       INT  IDENTITY (1, 1) NOT NULL,
    [NgayBatDau]  DATE NOT NULL,
    [NgayKetThuc] DATE NOT NULL, 
    [DonGiaDien] INT NOT NULL, 
    [DonGiaNuoc] INT NULL
);

