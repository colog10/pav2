CREATE PROCEDURE [dbo].[usp_Empleado_GetAll]  
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM Empleado
END