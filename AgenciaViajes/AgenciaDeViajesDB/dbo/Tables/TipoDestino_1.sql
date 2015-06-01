CREATE TABLE [dbo].[TipoDestino] (
    [idTipoDestino] INT  NOT NULL,
    [descripcion]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_TipoDestino] PRIMARY KEY CLUSTERED ([idTipoDestino] ASC)
);

