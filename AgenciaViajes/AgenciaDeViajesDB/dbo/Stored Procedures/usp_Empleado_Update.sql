CREATE PROCEDURE [dbo].[usp_Empleado_Update]
	(@idEmpleado int output,
	@legajo int,
	@nombre nvarchar(30),
	@apellido nvarchar(30),
	@fechaAlta date,
	@fechaBaja date,
	@activo bit,
	@idUsuario int,
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
	WHERE idEmpleado = @idEmpleado;
END