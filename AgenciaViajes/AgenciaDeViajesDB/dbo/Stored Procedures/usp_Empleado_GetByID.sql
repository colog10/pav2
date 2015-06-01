CREATE PROCEDURE [dbo].[usp_Empleado_GetByID]
	(@IDEmpleado int)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM Empleado
	WHERE IDEmpleado= @IDEmpleado;
END