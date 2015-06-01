CREATE TABLE [dbo].[EstadoCivil] (
    [idEstadoCivil] INT   NOT NULL,
    [descripcion]   NVARCHAR (30) NOT NULL,
    CONSTRAINT [PK_EstadoCivil] PRIMARY KEY CLUSTERED ([idEstadoCivil] ASC)
);

