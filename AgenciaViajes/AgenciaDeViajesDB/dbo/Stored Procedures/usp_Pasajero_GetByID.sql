
CREATE PROCEDURE [dbo].[usp_ReservasDetalle_GetByDocumento]
	(@Documento int)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM ReservaDetalle
	WHERE numeroDocumento= @Documento;
END