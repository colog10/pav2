
CREATE PROCEDURE [dbo].[usp_TipoDocumento_GetAll]  
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM TipoDocumento;
END