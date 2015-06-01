
CREATE PROCEDURE [dbo].[usp_Empleado_Insert]
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


	INSERT INTO Empleado (legajo,apellido,nombre,fechaAlta,fechaBaja,idUsuario,activo,supervisor)
	VALUES (@legajo,@apellido,@nombre,@fechaAlta,@fechaBaja,@idUsuario,@activo,@supervisor);

	SET @idEmpleado = SCOPE_IDENTITY();
END