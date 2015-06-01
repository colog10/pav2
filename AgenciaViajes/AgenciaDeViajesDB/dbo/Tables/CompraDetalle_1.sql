CREATE TABLE [dbo].[CompraDetalle] (
    [idDetalleCompra]   INT  NOT NULL,
    [idDetalleReserva] INT  NULL,
    [descripcion]       NVARCHAR (50) NULL,
    CONSTRAINT [PK_CompraDetalle] PRIMARY KEY CLUSTERED ([idDetalleCompra] ASC),
    CONSTRAINT [FK_CompraDetalle_ReservaDetalle] FOREIGN KEY ([idDetalleReserva]) REFERENCES [dbo].[ReservaDetalle] ([idDetallaReserva])
);

