CREATE PROCEDURE [dbo].[usp_Empleado_Update]
	(@idEmpleado int output,
	@legajo numeric(10,0),
	@nombre nvarchar(30),
	@apellido nvarchar(30),
	@fechaAlta date,
	@fechaBaja date,
	@activo bit,
	@idUsuario numeric(2,0),
	@supervisor bit)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE Empleado 
	SET legajo= @legajo, 
		nombre = @nombre,
		apellido= @apellido,
		fechaAlta= @fechaAlta,
		fechaBaja= @fechaBaja,
		activo= @activo,
		idUsuario= @idUsuario,
		supervisor=@supervisor

	WHERE idEmpleado = @idEmpleado
END