USE [AgenciaDeViajes]
GO
/****** Object:  StoredProcedure [dbo].[usp_ReservaDetalle_Insert]    Script Date: 20/06/2015 23:59:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_ReservaDetalle_Insert]
(
	@idDetalleReserva int output,
	@idReserva int = NULL,
    @idSeguroViajero int = NULL,
    @idServicioAlojamiento int = NULL,
    @idServicioTraslado int = NULL,
    @idTipoDocumento int = NULL,
    @numeroDocumento nvarchar(8) = NULL,
    @idDocumentoViaje int = NULL,
    @comprada bit = NULL,
    @efectuada bit = NULL,
    @vendido bit = NULL,
	@monto decimal = 0
)
AS 
BEGIN
SET NOCOUNT ON;
INSERT INTO [dbo].[ReservaDetalle]
           ([idReserva]
           ,[idSeguroViajero]
           ,[idServicioAlojamiento]
           ,[idServicioTraslado]
           ,[idTipoDocumento]
           ,[numeroDocumento]
           ,[idDocumentoViaje]
           ,[comprada]
           ,[efectuada]
           ,[vendido]
		   ,[monto] )
     VALUES
           (@idReserva,
           @idSeguroViajero,
           @idServicioAlojamiento,
           @idServicioTraslado,
           @idTipoDocumento,
           @numeroDocumento,
           @idDocumentoViaje,
           @comprada, 
           @efectuada, 
           @vendido, 
		   @monto)
	END  
  	SET @idDetalleReserva = SCOPE_IDENTITY();
