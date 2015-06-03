
CREATE PROCEDURE [dbo].[usp_Pasajero_GetByTermino]
	(@termino nvarchar(30))
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM Pasajero
	WHERE nombre = (@termino + '%');
END