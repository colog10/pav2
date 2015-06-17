CREATE PROCEDURE [dbo].[usp_CompaniaAerea_GetAll]
	AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM CompaniaAerea;
END

