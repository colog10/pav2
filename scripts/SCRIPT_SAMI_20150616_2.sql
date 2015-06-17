USE [AgenciaDeViajes]
GO
/****** Object:  StoredProcedure [dbo].[usp_Pasajero_GetByTermino]    Script Date: 16/06/2015 22:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_Pasajero_GetByTermino]
	(@termino nvarchar(30) = '')
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM Pasajero
	WHERE nombre like @termino + '%' or apellido like @termino + '%';
END
