CREATE PROCEDURE [dbo].[usp_Empleado_Insert]
	(@legajo int,
	@nombre nvarchar(30),
	@apellido nvarchar(30),
	@fechaAlta date,
	@fechaBaja date = null,
	@activo bit = false,
	@idUsuario int,
	@supervisor bit = false)
AS
BEGIN
	SET NOCOUNT ON;


	INSERT INTO Empleado (legajo,apellido,nombre,fechaAlta,fechaBaja,idUsuario,activo,supervisor)
	VALUES (@legajo,@apellido,@nombre,@fechaAlta,@fechaBaja,@idUsuario,@activo,@supervisor);
END