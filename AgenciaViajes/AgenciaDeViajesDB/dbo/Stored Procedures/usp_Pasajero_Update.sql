-- =============================================
-- Author:		Voeffrey, Dario
-- Create date: 5/05/2015
-- Description:	Update a record
-- =============================================
CREATE PROCEDURE [dbo].[usp_CaseTypes_Update]
	(@IDCaseType int,
	@CaseTypeDesc varchar(30))
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE CaseTypes 
	SET CaseTypeDesc = @CaseTypeDesc
	WHERE IDCaseType = @IDCaseType
END