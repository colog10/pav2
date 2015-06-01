CREATE TABLE [dbo].[TipoDocumento] (
    [idTipoDocumento] INT   NOT NULL,
    [descripcion]     NVARCHAR (30) NOT NULL,
    CONSTRAINT [PK_tipoDocumento] PRIMARY KEY CLUSTERED ([idTipoDocumento] ASC)
);

