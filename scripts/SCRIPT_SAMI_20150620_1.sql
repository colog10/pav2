USE [AgenciaDeViajes]
GO

/****** Object:  StoredProcedure [dbo].[usp_ServicioTraslado_Insert]    Script Date: 20/06/2015 20:16:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_SeguroViajero_Insert]
(
	@idSeguroViajero int output,
	@comision int = 0,
	@monto float = null,
	@tipoSeguroViajero int = null,
	@numeroCompra int = null,
	@descripcion nvarchar(50) = null

)
AS 
BEGIN
SET NOCOUNT ON;

	INSERT INTO [dbo].[SeguroViajero]
           ([comision]
           ,[monto]
           ,[tipoSeguroViajero]
           ,[numeroCompra]
           ,[descripcion])
     VALUES
           (@comision, 
			   @monto, 
			   @tipoSeguroViajero, 
			   @numeroCompra,
			   @descripcion)

  			
	END  
  	SET @idSeguroViajero = SCOPE_IDENTITY();

GO


