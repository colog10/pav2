CREATE TABLE [dbo].[TipoAlojamiento] (
    [idTipoAlojamiento] INT  NOT NULL,
    [descripcion]       NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_TipoAlojamiento] PRIMARY KEY CLUSTERED ([idTipoAlojamiento] ASC)
);

