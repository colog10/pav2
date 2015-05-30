CREATE TABLE [dbo].[TipoDocumento] (
    [idTipoDocumento] NUMERIC (2)   NOT NULL,
    [descripcion]     NVARCHAR (30) NOT NULL,
    CONSTRAINT [PK_tipoDocumento] PRIMARY KEY CLUSTERED ([idTipoDocumento] ASC)
);

