
CREATE PROCEDURE [dbo].[usp_OperadorTuristico_GetAll]  
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM OperadorTuristico;
END