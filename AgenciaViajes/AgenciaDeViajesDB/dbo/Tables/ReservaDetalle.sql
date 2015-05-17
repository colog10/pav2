CREATE TABLE [dbo].[ReservaDetalle] (
    [idDetallaReserva]      NUMERIC (10) NOT NULL,
    [idReserva]             NUMERIC (10) NULL,
    [idSeguroViajero]       NUMERIC (2)  NULL,
    [idServicioAlojamiento] NUMERIC (2)  NULL,
    [idServicioTraslado]    NUMERIC (2)  NULL,
    [idTipoDocumento]       NUMERIC (2)  NULL,
    [numeroDocumento]       NVARCHAR (8) NULL,
    [idDocumentoViaje]      NUMERIC (2)  NULL,
    [comprada]              BIT          NULL,
    [efectuada]             BIT          NULL,
    CONSTRAINT [PK_DetalleReserva] PRIMARY KEY CLUSTERED ([idDetallaReserva] ASC)
);

