﻿CREATE TABLE [dbo].[Reserva] (
    [idReserva]             NUMERIC (10) NOT NULL,
    [idDetalleReserva]      NUMERIC (10) NULL,
    [idCliente]             NUMERIC (10) NULL,
    [idEmpleado]            NUMERIC (10) NULL,
    [idTipoDocumento]       NUMERIC (2)  NULL,
    [numeroDocumento]       NVARCHAR (8) NULL,
    [idDocumentoViaje]      NUMERIC (2)  NULL,
    [numeroReserva]         NUMERIC (18) NULL,
    [monto]                 NUMERIC (18) NULL,
    [fechaReserva]          DATE         NULL,
    [idSeguroViajero]       NUMERIC (10) NULL,
    [idServicioAlojamiento] NUMERIC (10) NULL,
    [idServicioTraslado]    NUMERIC (10) NULL,
    [comprada]              BIT          NULL,
    [efectuada]             BIT          NULL,
    CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED ([idReserva] ASC),
    CONSTRAINT [FK_Reserva_Cliente] FOREIGN KEY ([idCliente]) REFERENCES [dbo].[Cliente] ([idCliente]),
    CONSTRAINT [FK_Reserva_Empleado] FOREIGN KEY ([idEmpleado]) REFERENCES [dbo].[Empleado] ([idEmpleado]),
    CONSTRAINT [FK_Reserva_ReservaDetalle] FOREIGN KEY ([idDetalleReserva]) REFERENCES [dbo].[ReservaDetalle] ([idDetallaReserva]),
    CONSTRAINT [FK_Reserva_SeguroViajero] FOREIGN KEY ([idSeguroViajero]) REFERENCES [dbo].[SeguroViajero] ([idSeguroViajero]),
    CONSTRAINT [FK_Reserva_ServicioAlojamiento] FOREIGN KEY ([idServicioAlojamiento]) REFERENCES [dbo].[ServicioAlojamiento] ([idServicioAlojamiento]),
    CONSTRAINT [FK_Reserva_ServicioTraslado] FOREIGN KEY ([idServicioTraslado]) REFERENCES [dbo].[ServicioTraslado] ([idServicioTraslado]),
    CONSTRAINT [FK_Reserva_TipoDocumento1] FOREIGN KEY ([idTipoDocumento]) REFERENCES [dbo].[TipoDocumento] ([idTipoDocumento])
);

