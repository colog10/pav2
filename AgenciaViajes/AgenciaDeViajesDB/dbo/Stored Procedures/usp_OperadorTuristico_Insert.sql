
CREATE PROCEDURE [dbo].[usp_OperadorTuristico_Insert]
	(@idOperadorTuristico int output,
	@idTipoDestino int,
	@calificacion int,
	@descripcion nchar(10),
	@direccion nvarchar(100),
	@email nvarchar(35),
	@nombre nvarchar(50),
	@paginaWeb nvarchar(50),
	@telefono nvarchar(20),
	@activo bit,
	@fechaAlta date)
AS
BEGIN
	SET NOCOUNT ON;


	INSERT INTO OperadorTuristico (idTipoDestino, calificacion,descripcion,direccion,email,nombre,paginaWeb,telefono,activo,fechaAlta)
	VALUES (@idTipoDestino,@calificacion ,@descripcion ,@direccion ,@email ,@nombre,@paginaWeb ,@telefono ,@activo ,@fechaAlta );

	SET @idOperadorTuristico = SCOPE_IDENTITY();
END