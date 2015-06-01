CREATE TABLE [dbo].[ServicioAlojamiento] (
    [idServicioAlojamiento] INT  NOT NULL,
    [categoria]             NVARCHAR (50) NOT NULL,
    [comision]              INT   NOT NULL,
    [descripcion]           NVARCHAR (50) NOT NULL,
    [fechaDesde]            DATETIME      NOT NULL,
    [fechaHasta]            DATETIME      NOT NULL,
    [fechaVencReserva]      DATETIME      NOT NULL,
    [monto]                 FLOAT (53)    NOT NULL,
    [numeroReserva]         NVARCHAR (10) NOT NULL,
    [idAlojamiento]         INT  NOT NULL,
    [numeroVenta]           INT           NOT NULL,
    [tipoDocumento]         INT   NOT NULL,
    [numeroDocumento]       NVARCHAR (8)  NOT NULL,
    [numeroCompra]          INT  NOT NULL,
    CONSTRAINT [PK_ServicioAlojamiento] PRIMARY KEY CLUSTERED ([idServicioAlojamiento] ASC),
    CONSTRAINT [FK_ServicioAlojamiento_Alojamiento] FOREIGN KEY ([idAlojamiento]) REFERENCES [dbo].[Alojamiento] ([idAlojamiento]),
    CONSTRAINT [FK_ServicioAlojamiento_Compra] FOREIGN KEY ([numeroCompra]) REFERENCES [dbo].[Compra] ([idCompra])
);

