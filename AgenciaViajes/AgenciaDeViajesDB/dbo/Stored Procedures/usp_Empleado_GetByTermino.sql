CREATE PROCEDURE [dbo].[usp_Empleado_GetByTermino]
	(@termino nvarchar(60))
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM Empleado
	WHERE nombre like (@termino + '%') or apellido like (@termino + '%');
END