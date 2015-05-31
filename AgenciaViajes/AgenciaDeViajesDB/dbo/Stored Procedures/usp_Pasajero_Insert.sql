
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
	@domicilio nvarchar(100),
	@telefono nvarchar(50),
	@movil nvarchar(50),
	@email nvarchar(50),
	@eliminado char(1),
	@activo bit)
AS
BEGIN
	SET NOCOUNT ON;


	INSERT INTO Pasajero (apellido, nombre,idTipoDocumento,numeroDocumento,cuilcuit1,cuilcuit2,cuilcuit3,idEstadoCivil,fechaNacimiento,idNacionalidad,profesion,domicilio,telefono,movil,email,eliminado,activo)
	VALUES (@apellido, @nombre,@idTipoDocumento,@numeroDocumento,@cuilcuit1,@cuilcuit2,@cuilcuit3,@idEstadoCivil,@fechaNacimiento,@idNacionalidad,@profesion,@domicilio,@telefono,@movil,@email,@eliminado,@activo)

	SET @idPasajero = SCOPE_IDENTITY()
END