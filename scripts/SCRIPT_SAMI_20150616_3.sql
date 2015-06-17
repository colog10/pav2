USE [AgenciaDeViajes]
GO

/****** Object:  StoredProcedure [dbo].[usp_Ciudad_GetByIDPais]    Script Date: 16/06/2015 22:34:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Ciudad_GetByIDPais]  
	(@codigoPais nvarchar(3))
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM Ciudad 
	WHERE PaisCodigo = @codigoPais
	;
END

GO


