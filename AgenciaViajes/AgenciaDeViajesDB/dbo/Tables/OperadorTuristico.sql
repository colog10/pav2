CREATE TABLE [dbo].[OperadorTuristico] (
    [idOperadorTuristico] NUMERIC (10)   NOT NULL,
    [idTipoDestino]       NUMERIC (10)   NULL,
    [calificacion]        NUMERIC (1)    NULL,
    [descripcion]         NVARCHAR (50)  NULL,
    [direccion]           NVARCHAR (100) NULL,
    [email]               NVARCHAR (35)  NULL,
    [nombre]              NVARCHAR (50)  NULL,
    [paginaWeb]           NVARCHAR (50)  NULL,
    [telefono]            NVARCHAR (20)  NULL,
    [activo]              BIT            NULL,
    [fechaAlta]           DATE           NULL,
    CONSTRAINT [PK_OperadorTuristico] PRIMARY KEY CLUSTERED ([idOperadorTuristico] ASC),
    CONSTRAINT [FK_OperadorTuristico_TipoDestino] FOREIGN KEY ([idTipoDestino]) REFERENCES [dbo].[TipoDestino] ([idTipoDestino])
);

