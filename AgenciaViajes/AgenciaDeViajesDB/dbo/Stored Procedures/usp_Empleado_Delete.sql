
CREATE PROCEDURE [dbo].[usp_Empleado_Delete]
	(@IDEmpleado int)
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM Empleado 
	WHERE IDEmpleado = @IDEmpleado
END