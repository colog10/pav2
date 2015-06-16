USE [AgenciaDeViajes]
GO

/****** Object:  StoredProcedure [dbo].[usp_Cliente_GetByRazonSocialOrCuil]    Script Date: 16/06/2015 0:06:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Cliente_GetByRazonSocialOrCuil]
	(@filtroCliente VARCHAR = '')
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * 
	FROM Cliente
	WHERE razonSocial like @filtroCliente+'%'
	or cuilcuit1+'-'+cuilcuit2+'-'+cuilcuit3 like @filtroCliente+'%';
END

GO


