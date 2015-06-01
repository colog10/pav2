CREATE TABLE [dbo].[MotivoViaje] (
    [idMotivoViaje] INT   NOT NULL,
    [descripcion]   NVARCHAR (30) NOT NULL,
    CONSTRAINT [PK_MotivoViaje] PRIMARY KEY CLUSTERED ([idMotivoViaje] ASC)
);

