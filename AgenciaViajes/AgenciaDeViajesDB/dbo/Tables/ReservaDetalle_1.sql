CREATE TABLE [dbo].[ReservaDetalle] (
    [idDetallaReserva]      INT NOT NULL,
    [idReserva]             INT NULL,
    [idSeguroViajero]       INT  NULL,
    [idServicioAlojamiento] INT  NULL,
    [idServicioTraslado]    INT  NULL,
    [idTipoDocumento]       INT  NULL,
    [numeroDocumento]       NVARCHAR (8) NULL,
    [idDocumentoViaje]      INT  NULL,
    [comprada]              BIT          NULL,
    [efectuada]             BIT          NULL,
    CONSTRAINT [PK_DetalleReserva] PRIMARY KEY CLUSTERED ([idDetallaReserva] ASC)
);

