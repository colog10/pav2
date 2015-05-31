
CREATE PROCEDURE [dbo].[usp_OperadorTuristico_GetByID]
	(@IDOperadorTuristico int)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM OperadorTuristico
	WHERE idOperadorTuristico = @IDOperadorTuristico
END