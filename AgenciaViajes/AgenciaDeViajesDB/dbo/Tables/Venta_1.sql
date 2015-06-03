﻿CREATE TABLE [dbo].[Venta] (
    [numeroVenta]           INT          NOT NULL,
    [idCliente]             INT NULL,
    [idVentaDetalle]        INT NULL,
    [idVendedor]            INT NOT NULL,
    [idSeguroViajero]       INT NULL,
    [idServicioAlojamiento] INT NULL,
    [idServicioTraslado]    INT NULL,
    [monto]                 FLOAT (53)   NOT NULL,
    [comision]              INT          NOT NULL,
    [paisOrigen]            NVARCHAR (3) NULL,
    [ciudadOrigen]          INT          NULL,
    [paisDestino]           NVARCHAR (3) NULL,
    [ciudadDestino]         INT          NULL,
    [fechaSalida]           DATE         NULL,
    [fechaRetorno]          DATE         NULL,
    [documentoviaje]        INT          NULL,
    [fechaVenta]            DATE         NOT NULL,
    [motivoViaje]           INT  NULL,
    CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED ([numeroVenta] ASC),
    CONSTRAINT [FK_Venta_Ciudad] FOREIGN KEY ([ciudadOrigen]) REFERENCES [dbo].[Ciudad] ([CiudadID]),
    CONSTRAINT [FK_Venta_Ciudad1] FOREIGN KEY ([ciudadDestino]) REFERENCES [dbo].[Ciudad] ([CiudadID]),
    CONSTRAINT [FK_Venta_Empleado] FOREIGN KEY ([idVendedor]) REFERENCES [dbo].[Empleado] ([idEmpleado]),
    CONSTRAINT [FK_Venta_Pais] FOREIGN KEY ([paisOrigen]) REFERENCES [dbo].[Pais] ([idPais]),
    CONSTRAINT [FK_Venta_Pais1] FOREIGN KEY ([paisDestino]) REFERENCES [dbo].[Pais] ([idPais]),
    CONSTRAINT [FK_Venta_VentaDetalle] FOREIGN KEY ([idVentaDetalle]) REFERENCES [dbo].[VentaDetalle] ([idDetalleVenta])
);

