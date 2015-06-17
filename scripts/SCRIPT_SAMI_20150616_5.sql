USE [AgenciaDeViajes]
GO

/****** Object:  StoredProcedure [dbo].[usp_TipoSeguroViajero_GetAll]    Script Date: 17/06/2015 0:28:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_TipoSeguroViajero_GetAll]  
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM TipoSeguroViajero;
END

GO


