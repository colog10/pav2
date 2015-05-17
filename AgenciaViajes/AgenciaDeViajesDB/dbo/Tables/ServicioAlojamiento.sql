CREATE TABLE [dbo].[ServicioAlojamiento] (
    [idServicioAlojamiento] NUMERIC (10)  NOT NULL,
    [categoria]             NVARCHAR (50) NOT NULL,
    [comision]              NUMERIC (2)   NOT NULL,
    [descripcion]           NVARCHAR (50) NOT NULL,
    [fechaDesde]            DATETIME      NOT NULL,
    [fechaHasta]            DATETIME      NOT NULL,
    [fechaVencReserva]      DATETIME      NOT NULL,
    [monto]                 FLOAT (53)    NOT NULL,
    [numeroReserva]         NVARCHAR (10) NOT NULL,
    [idAlojamiento]         NUMERIC (10)  NOT NULL,
    [numeroVenta]           INT           NOT NULL,
    [tipoDocumento]         NUMERIC (2)   NOT NULL,
    [numeroDocumento]       NVARCHAR (8)  NOT NULL,
    [numeroCompra]          NUMERIC (10)  NOT NULL,
    CONSTRAINT [PK_ServicioAlojamiento] PRIMARY KEY CLUSTERED ([idServicioAlojamiento] ASC),
    CONSTRAINT [FK_ServicioAlojamiento_Alojamiento] FOREIGN KEY ([idAlojamiento]) REFERENCES [dbo].[Alojamiento] ([idAlojamiento]),
    CONSTRAINT [FK_ServicioAlojamiento_Compra] FOREIGN KEY ([numeroCompra]) REFERENCES [dbo].[Compra] ([idCompra])
);

