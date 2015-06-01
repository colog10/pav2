
CREATE PROCEDURE [dbo].[usp_Pasajero_Delete]
	(@IDPasajero int)
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM Pasajero 
	WHERE idPasajero = @IDPasajero;
END