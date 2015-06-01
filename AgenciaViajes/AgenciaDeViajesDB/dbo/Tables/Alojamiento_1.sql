CREATE TABLE [dbo].[Alojamiento] (
    [idAlojamiento]     INT  NOT NULL,
    [idTipoAlojamiento] INT  NOT NULL,
    [domicilio]         NVARCHAR (50) NOT NULL,
    [nombre]            NVARCHAR (50) NOT NULL,
    [telefono]          INT  NOT NULL,
    CONSTRAINT [PK_Alojamiento] PRIMARY KEY CLUSTERED ([idAlojamiento] ASC),
    CONSTRAINT [FK_Alojamiento_TipoAlojamiento] FOREIGN KEY ([idTipoAlojamiento]) REFERENCES [dbo].[TipoAlojamiento] ([idTipoAlojamiento])
);

