
CREATE PROCEDURE [dbo].[usp_OperadorTuristico_Delete]
	(@IDOperadorTuristico int)
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM OperadorTuristico 
	WHERE IDOperadorTuristico = @IDOperadorTuristico
END