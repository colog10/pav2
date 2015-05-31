
CREATE PROCEDURE [dbo].[usp_Pasajero_Insert]
	(@idPasajero int output,
	@apellido nvarchar(50),
	@nombre nvarchar(50),
	@idTipoDocumento numeric(2,0),
	@numeroDocumento numeric(8,0),
	@cuilcuit1 nvarchar(2),
	@cuilcuit2 nvarchar(8),
	@cuilcuit3 nvarchar(1),
	@idEstadoCivil numeric(2,0),
	@fechaNacimiento date,
	@idNacionalidad nvarchar(3),
	@profesion nvarchar(50),
	@domicilio nvarchar(20),
	@telefono nvarchar(20),
	@movil nvarchar(20),
	@email nvarchar(20),
	@eliminado nvarchar(20),
	@activo bit)
AS
BEGIN
	SET NOCOUNT ON;


	INSERT INTO Pasajero (idTipoDestino, calificacion,descripcion,direccion,email,nombre,paginaWeb,telefono,activo,fechaAlta)
	VALUES (@idTipoDestino,@calificacion ,@descripcion ,@direccion ,@email ,@nombre,@paginaWeb ,@telefono ,@activo ,@fechaAlta )

	SET @idPasajero = SCOPE_IDENTITY()
END