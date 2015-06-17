USE [AgenciaDeViajes]
GO
/****** Object:  StoredProcedure [dbo].[usp_Reserva_GetInforme]    Script Date: 17/06/2015 18:08:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_Reserva_GetInforme]  
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
	WHERE (monto >= @monto OR @monto IS NULL) AND
		(fechaReserva like @fechaReserva OR @fechaReserva IS NULL) AND
		(efectuada = @efectuada OR @efectuada IS NULL)
	;
END


