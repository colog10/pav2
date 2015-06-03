
CREATE PROCEDURE [dbo].[usp_OperadorTuristico_GetByTermino]
	(@termino nvarchar(30))
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM OperadorTuristico
	WHERE descripcion = (@termino + '%');
END