USE [AgenciaDeViajes]
GO
/****** Object:  StoredProcedure [dbo].[usp_Reserva_Insert]    Script Date: 21/06/2015 0:02:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[usp_Reserva_Insert]
(
	@idReserva int output,
	@idCliente int = NULL,
	@idEmpleado int = NULL,
	@idTipoDocumento int = NULL,
    @numeroDocumento nvarchar(8) = NULL,
	@idDocumentoViaje int = NULL,
    @numeroReserva int = NULL,
    @monto decimal = NULL,
    @fechaReserva date = NULL,
    @idSeguroViajero int = NULL,
    @idServicioAlojamiento int = NULL,
    @idServicioTraslado int = NULL,
    @comprada bit = NULL,
    @efectuada bit = NULL
)
AS 
BEGIN
SET NOCOUNT ON;
INSERT INTO [dbo].[Reserva]
           ([idCliente]
           ,[idEmpleado]
           ,[idTipoDocumento]
           ,[numeroDocumento]
           ,[idDocumentoViaje]
           ,[numeroReserva]
           ,[monto]
           ,[fechaReserva]
           ,[idSeguroViajero]
           ,[idServicioAlojamiento]
           ,[idServicioTraslado]
           ,[comprada]
           ,[efectuada])
     VALUES
           (@idCliente,
           @idEmpleado,
           @idTipoDocumento,
           @numeroDocumento,
           @idDocumentoViaje,
           @numeroReserva,
           @monto, 
           @fechaReserva,
           @idSeguroViajero, 
           @idServicioAlojamiento,
           @idServicioTraslado, 
           @comprada, 
           @efectuada)
		   END
	SET @idReserva = SCOPE_IDENTITY();
