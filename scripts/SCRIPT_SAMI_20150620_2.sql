USE [AgenciaDeViajes]
GO
/****** Object:  StoredProcedure [dbo].[usp_ServicioAlojamiento_Insert]    Script Date: 20/06/2015 20:42:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[usp_ServicioAlojamiento_Insert]
(
			@idServicioAlojamiento int output,
			@categoria nvarchar(50) = NULL,
			@comision int = NULL,
			@descripcion nvarchar(50) = NULL,
            @fechaDesde datetime = NULL,
            @fechaHasta datetime = NULL,
            @fechaVencReserva datetime = NULL,
            @monto float = NULL,
            @numeroReserva nvarchar(10) = NULL,
            @idAlojamiento int = NULL,
            @numeroVenta int = NULL,
            @tipoDocumento int = NULL,
            @numeroDocumento nvarchar(8) = NULL,
			@numeroCompra int = NULL
)
AS 
BEGIN
SET NOCOUNT ON;
	

	INSERT INTO [dbo].[ServicioAlojamiento]
           ([categoria]
           ,[comision]
           ,[descripcion]
           ,[fechaDesde]
           ,[fechaHasta]
           ,[fechaVencReserva]
           ,[monto]
           ,[numeroReserva]
           ,[idAlojamiento]
           ,[numeroVenta]
           ,[tipoDocumento]
           ,[numeroDocumento]
           ,[numeroCompra])
     VALUES
           (@categoria,
           @comision,
           @descripcion,
           @fechaDesde,
           @fechaHasta,
           @fechaVencReserva,
           @monto, 
           @numeroReserva,
           @idAlojamiento,
           @numeroVenta,
           @tipoDocumento,
           @numeroDocumento, 
           @numeroCompra)		
	END  
  	SET @idServicioAlojamiento = SCOPE_IDENTITY();
