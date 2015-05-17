CREATE TABLE [dbo].[MotivoViaje] (
    [idMotivoViaje] NUMERIC (2)   NOT NULL,
    [descripcion]   NVARCHAR (30) NOT NULL,
    CONSTRAINT [PK_MotivoViaje] PRIMARY KEY CLUSTERED ([idMotivoViaje] ASC)
);

