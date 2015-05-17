CREATE TABLE [dbo].[Alojamiento] (
    [idAlojamiento]     NUMERIC (10)  NOT NULL,
    [idTipoAlojamiento] NUMERIC (10)  NOT NULL,
    [domicilio]         NVARCHAR (50) NOT NULL,
    [nombre]            NVARCHAR (50) NOT NULL,
    [telefono]          NUMERIC (13)  NOT NULL,
    CONSTRAINT [PK_Alojamiento] PRIMARY KEY CLUSTERED ([idAlojamiento] ASC),
    CONSTRAINT [FK_Alojamiento_TipoAlojamiento] FOREIGN KEY ([idTipoAlojamiento]) REFERENCES [dbo].[TipoAlojamiento] ([idTipoAlojamiento])
);

