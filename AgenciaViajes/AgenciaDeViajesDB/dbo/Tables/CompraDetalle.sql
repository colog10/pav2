CREATE TABLE [dbo].[CompraDetalle] (
    [idDetalleCompra]   NUMERIC (10)  NOT NULL,
    [idDetalleReservaq] NUMERIC (10)  NULL,
    [descripcion]       NVARCHAR (50) NULL,
    CONSTRAINT [PK_CompraDetalle] PRIMARY KEY CLUSTERED ([idDetalleCompra] ASC),
    CONSTRAINT [FK_CompraDetalle_ReservaDetalle] FOREIGN KEY ([idDetalleReservaq]) REFERENCES [dbo].[ReservaDetalle] ([idDetallaReserva])
);

