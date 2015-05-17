CREATE TABLE [dbo].[EstadoCivil] (
    [idEstadoCivil] NUMERIC (2)   NOT NULL,
    [descripcion]   NVARCHAR (30) NOT NULL,
    CONSTRAINT [PK_EstadoCivil] PRIMARY KEY CLUSTERED ([idEstadoCivil] ASC)
);

