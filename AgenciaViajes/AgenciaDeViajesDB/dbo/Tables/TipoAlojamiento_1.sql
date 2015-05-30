CREATE TABLE [dbo].[TipoAlojamiento] (
    [idTipoAlojamiento] NUMERIC (10)  NOT NULL,
    [descripcion]       NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_TipoAlojamiento] PRIMARY KEY CLUSTERED ([idTipoAlojamiento] ASC)
);

