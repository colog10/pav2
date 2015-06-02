CREATE PROCEDURE [dbo].[usp_Usuario_GetAll]
	AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM Usuario 
	WHERE activo = 1;
END
