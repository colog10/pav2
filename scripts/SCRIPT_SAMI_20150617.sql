USE [AgenciaDeViajes]
GO
CREATE PROCEDURE [dbo].[usp_Reserva_Insert]
(
	@idReserva int output,
	@idCliente int,
	@idEmpleado int,
	@idTipoDocumento int,
    @numeroDocumento nvarchar(8),
	@idDocumentoViaje int,
    @numeroReserva int,
    @monto int,
    @fechaReserva date,
    @idSeguroViajero int,
    @idServicioAlojamiento int,
    @idServicioTraslado int,
    @comprada bit,
    @efectuada bit
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
GO

USE [AgenciaDeViajes]
GO
CREATE PROCEDURE [dbo].[usp_ReservaDetalle_Insert]
(
	@idDetalleReserva int output,
	@idReserva int,
    @idSeguroViajero int,
    @idServicioAlojamiento int,
    @idServicioTraslado int,
    @idTipoDocumento int,
    @numeroDocumento nvarchar(8),
    @idDocumentoViaje int,
    @comprada bit,
    @efectuada bit,
    @vendido bit
		   
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
           ,[vendido])
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
           @vendido)
	END  
  	SET @idDetalleReserva = SCOPE_IDENTITY();
GO



USE [AgenciaDeViajes]
GO
CREATE PROCEDURE [dbo].[usp_ServicioTraslado_Insert]
(
			@idServicioTraslado int output,
			@comision int,
			@destino int,
            @fechaSalida datetime,
            @fechaRegreso datetime,
            @fechaVtoReserva datetime,
            @monto float,
            @numeroReserva nvarchar(10),
            @origen int,
            @idCompaniaAerea int,
            @idEmpresaColectivos int,
            @numeroCompra int,
            @numeroVenta int,
            @tipoDocumento int,
            @numeroDocumento nvarchar(8)	
)
AS 
BEGIN
SET NOCOUNT ON;
	

	INSERT INTO [dbo].[ServicioTraslado]
           ([comision]
           ,[destino]
           ,[fechaSalida]
           ,[fechaRegreso]
           ,[fechaVtoReserva]
           ,[monto]
           ,[numeroReserva]
           ,[origen]
           ,[idCompaniaAerea]
           ,[idEmpresaColectivos]
           ,[numeroCompra]
           ,[numeroVenta]
           ,[tipoDocumento]
           ,[numeroDocumento])
     VALUES
           (@comision,
			@destino,
            @fechaSalida,
            @fechaRegreso,
            @fechaVtoReserva,
            @monto,
            @numeroReserva,
            @origen,
            @idCompaniaAerea,
            @idEmpresaColectivos,
            @numeroCompra,
            @numeroVenta,
            @tipoDocumento,
            @numeroDocumento)

		
	END  
  	SET @idServicioTraslado = SCOPE_IDENTITY();
GO




CREATE PROCEDURE [dbo].[usp_Reserva_GetInforme]  
(
	@monto float = NULL, 
	@fechaReserva datetime = NULL,
	@efectuada bit = NULL
)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM Reserva R
	INNER JOIN Cliente C
		ON R.idCliente = R.idCliente
	WHERE (monto >= @monto OR @monto IS NULL) AND
		(fechaReserva like @fechaReserva OR @fechaReserva IS NULL) AND
		(efectuada = @efectuada OR @efectuada IS NULL)
	;
END


USE [AgenciaDeViajes]
GO
/****** Object:  StoredProcedure [dbo].[usp_CompaniaAerea_GetAll]    Script Date: 16/06/2015 23:34:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CompaniaAerea_GetAll]  
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM CompaniaAerea;
END

USE [AgenciaDeViajes]
GO

/****** Object:  StoredProcedure [dbo].[usp_Alojamiento_GetAll]    Script Date: 17/06/2015 0:28:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Alojamiento_GetAll]  
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM Alojamiento;
END

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
    @monto int = NULL,
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
GO



USE [AgenciaDeViajes]
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
    @vendido bit = NULL
		   
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
           ,[vendido])
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
           @vendido)
	END  
  	SET @idDetalleReserva = SCOPE_IDENTITY();
GO



USE [AgenciaDeViajes]
GO
ALTER PROCEDURE [dbo].[usp_ServicioTraslado_Insert]
(
			@idServicioTraslado int output,
			@comision int = NULL,
			@destino int = NULL,
            @fechaSalida datetime = NULL,
            @fechaRegreso datetime = NULL,
            @fechaVtoReserva datetime = NULL,
            @monto float = NULL,
            @numeroReserva nvarchar(10) = NULL,
            @origen int = NULL,
            @idCompaniaAerea int = NULL,
            @idEmpresaColectivos int = NULL,
            @numeroCompra int = NULL,
            @numeroVenta int = NULL,
            @tipoDocumento int = NULL,
            @numeroDocumento nvarchar(8) = NULL	
)
AS 
BEGIN
SET NOCOUNT ON;
	

	INSERT INTO [dbo].[ServicioTraslado]
           ([comision]
           ,[destino]
           ,[fechaSalida]
           ,[fechaRegreso]
           ,[fechaVtoReserva]
           ,[monto]
           ,[numeroReserva]
           ,[origen]
           ,[idCompaniaAerea]
           ,[idEmpresaColectivos]
           ,[numeroCompra]
           ,[numeroVenta]
           ,[tipoDocumento]
           ,[numeroDocumento])
     VALUES
           (@comision,
			@destino,
            @fechaSalida,
            @fechaRegreso,
            @fechaVtoReserva,
            @monto,
            @numeroReserva,
            @origen,
            @idCompaniaAerea,
            @idEmpresaColectivos,
            @numeroCompra,
            @numeroVenta,
            @tipoDocumento,
            @numeroDocumento)

		
	END  
  	SET @idServicioTraslado = SCOPE_IDENTITY();
GO


