
CREATE PROCEDURE [dbo].[usp_Empleado_Insert]
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


	INSERT INTO Empleado (legajo,apellido,nombre,fechaAlta,fechaBaja,idUsuario,activo,supervisor)
	VALUES (@legajo,@apellido,@nombre,@fechaAlta,@fechaBaja,@idUsuario,@activo,@supervisor)

	SET @idEmpleado = SCOPE_IDENTITY()
END