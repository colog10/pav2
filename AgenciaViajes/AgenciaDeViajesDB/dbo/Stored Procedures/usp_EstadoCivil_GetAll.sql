
CREATE PROCEDURE [dbo].[usp_EstadoCivil_GetAll]  
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM EstadoCivil;
END