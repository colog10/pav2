
CREATE PROCEDURE [dbo].[usp_Pasajero_Update]
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

	UPDATE Pasajero 
	 SET apellido=@apellido,
		nombre=@nombre ,
		idTipoDocumento=@idTipoDocumento ,
		numeroDocumento=@numeroDocumento,
		cuilcuit1 =@cuilcuit1,
		cuilcuit2 =@cuilcuit2,
		cuilcuit3 =@cuilcuit3,
		idEstadoCivil=@idEstadoCivil,
		fechaNacimiento=@fechaNacimiento,
		idNacionalidad=@idNacionalidad,
		profesion=@profesion,
		domicilio=@domicilio,
		movil=@movil,
		telefono=@telefono ,
		eliminado=@eliminado,
		email=@email,
		activo =@activo
	WHERE idPasajero = @IdPasajero
END