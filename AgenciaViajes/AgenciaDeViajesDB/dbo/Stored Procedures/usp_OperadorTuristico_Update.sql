
CREATE PROCEDURE [dbo].[usp_OperadorTuristico_Update]
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

	UPDATE OperadorTuristico 
	SET idTipoDestino=@idTipoDestino,
		calificacion=@calificacion ,
		descripcion=@descripcion ,
		direccion=@direccion,
		email=@email,
		nombre=@nombre,
		paginaWeb =@paginaWeb ,
		telefono=@telefono ,
		activo =@activo,
		fechaAlta =@fechaAlta 
	WHERE @idOperadorTuristico = @idOperadorTuristico;
END