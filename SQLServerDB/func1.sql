
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [CheckDate]
(
	@NgayBatDau datetime,
	@NgayKetThuc datetime
)
RETURNS BIT
AS
BEGIN
	DECLARE @ResultVar BIT;

	SET @ResultVar = CASE
		WHEN GETDATE() > @NgayBatDau AND GETDATE() <= @NgayKetThuc
	THEN 1
	ELSE 0
	END;
	
	RETURN @ResultVar

END
GO