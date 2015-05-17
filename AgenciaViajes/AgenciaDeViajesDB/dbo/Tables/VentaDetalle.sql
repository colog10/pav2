CREATE TABLE [dbo].[VentaDetalle] (
    [idDetalleVenta]        NUMERIC (10) NOT NULL,
    [idMotivoViaje]         NUMERIC (2)  NULL,
    [idPasajero]            NUMERIC (10) NULL,
    [numeroVenta]           INT          NOT NULL,
    [idTipoDocumento]       NUMERIC (2)  NOT NULL,
    [numeroDocumento]       VARCHAR (50) NOT NULL,
    [idDocumentoViaje]      NUMERIC (2)  NULL,
    [fechaPasaporteDesde]   DATE         NULL,
    [fechaPasaporteHasta]   DATE         NULL,
    [fechaVISADesde]        DATE         NULL,
    [fechaVISAHasta]        DATE         NULL,
    [idSeguroViajero]       NUMERIC (10) NULL,
    [idServicioAlojamiento] NUMERIC (10) NULL,
    [idServicioTraslado]    NUMERIC (10) NULL,
    [idDetalleReserva]      NUMERIC (10) NULL,
    CONSTRAINT [PK_VentaDetalle] PRIMARY KEY CLUSTERED ([idDetalleVenta] ASC),
    CONSTRAINT [FK_VentaDetalle_MotivoViaje] FOREIGN KEY ([idMotivoViaje]) REFERENCES [dbo].[MotivoViaje] ([idMotivoViaje]),
    CONSTRAINT [FK_VentaDetalle_Pasajero] FOREIGN KEY ([idPasajero]) REFERENCES [dbo].[Pasajero] ([idPasajero]),
    CONSTRAINT [FK_VentaDetalle_SeguroViajero] FOREIGN KEY ([idSeguroViajero]) REFERENCES [dbo].[SeguroViajero] ([idSeguroViajero]),
    CONSTRAINT [FK_VentaDetalle_ServicioAlojamiento] FOREIGN KEY ([idServicioAlojamiento]) REFERENCES [dbo].[ServicioAlojamiento] ([idServicioAlojamiento]),
    CONSTRAINT [FK_VentaDetalle_ServicioTraslado] FOREIGN KEY ([idServicioTraslado]) REFERENCES [dbo].[ServicioTraslado] ([idServicioTraslado])
);

