CREATE FUNCTION [dbo].[KiemTraChuyenPhong]
(
	@idPhong nvarchar
)
RETURNS INT
AS
BEGIN
	DECLARE @hientai INT;
	DECLARE @toida INT;
	DECLARE @result INT;
	SET @hientai=(SELECT COUNT(*) FROM  HopDong
                                        WHERE HopDong.IDPhong=@idPhong COLLATE DATABASE_DEFAULT
                                        AND dbo.KiemTraThoiHan(HopDong.MSSV) = 1);
	SET @toida=(SELECT SoLuongToiDa FROM Phong WHERE IDPhong=@idPhong);
	IF @hientai<@toida SET @result=1
	ELSE SET @result=0
	RETURN @result
END
