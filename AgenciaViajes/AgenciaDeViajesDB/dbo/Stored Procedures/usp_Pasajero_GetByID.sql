
CREATE PROCEDURE [dbo].[usp_Pasajero_GetByID]
	(@IDPasajero int)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM Pasajero
	WHERE IDPasajero = @IDPasajero
END