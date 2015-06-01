CREATE TABLE [dbo].[VentaDetalle] (
    [idDetalleVenta]        INT NOT NULL,
    [idMotivoViaje]         INT  NULL,
    [idPasajero]            INT NULL,
    [numeroVenta]           INT          NOT NULL,
    [idTipoDocumento]       INT  NOT NULL,
    [numeroDocumento]       VARCHAR (50) NOT NULL,
    [idDocumentoViaje]      INT  NULL,
    [fechaPasaporteDesde]   DATE         NULL,
    [fechaPasaporteHasta]   DATE         NULL,
    [fechaVISADesde]        DATE         NULL,
    [fechaVISAHasta]        DATE         NULL,
    [idSeguroViajero]       INT NULL,
    [idServicioAlojamiento] INT NULL,
    [idServicioTraslado]    INT NULL,
    [idDetalleReserva]      INT NULL,
    CONSTRAINT [PK_VentaDetalle] PRIMARY KEY CLUSTERED ([idDetalleVenta] ASC),
    CONSTRAINT [FK_VentaDetalle_MotivoViaje] FOREIGN KEY ([idMotivoViaje]) REFERENCES [dbo].[MotivoViaje] ([idMotivoViaje]),
    CONSTRAINT [FK_VentaDetalle_Pasajero] FOREIGN KEY ([idPasajero]) REFERENCES [dbo].[Pasajero] ([idPasajero]),
    CONSTRAINT [FK_VentaDetalle_SeguroViajero] FOREIGN KEY ([idSeguroViajero]) REFERENCES [dbo].[SeguroViajero] ([idSeguroViajero]),
    CONSTRAINT [FK_VentaDetalle_ServicioAlojamiento] FOREIGN KEY ([idServicioAlojamiento]) REFERENCES [dbo].[ServicioAlojamiento] ([idServicioAlojamiento]),
    CONSTRAINT [FK_VentaDetalle_ServicioTraslado] FOREIGN KEY ([idServicioTraslado]) REFERENCES [dbo].[ServicioTraslado] ([idServicioTraslado])
);

