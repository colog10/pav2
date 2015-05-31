CREATE PROCEDURE [dbo].[usp_Pasajero_GetAll]  
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM Pasajero
END