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
