
CREATE PROCEDURE [dbo].[usp_TipoDestino_GetAll]  
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM TipoDestino;
END
	
