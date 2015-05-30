CREATE TABLE [dbo].[Compra] (
    [idCompra]            NUMERIC (10) NOT NULL,
    [idOperadorTuristico] NUMERIC (10) NOT NULL,
    [idDetalleCompra]     NUMERIC (10) NULL,
    [fechaCompra]         DATETIME     NOT NULL,
    [fechaPago]           DATETIME     NOT NULL,
    [monto]               FLOAT (53)   NOT NULL,
    [saldo]               FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED ([idCompra] ASC),
    CONSTRAINT [FK_Compra_CompraDetalle] FOREIGN KEY ([idDetalleCompra]) REFERENCES [dbo].[CompraDetalle] ([idDetalleCompra]),
    CONSTRAINT [FK_Compra_OperadorTuristico] FOREIGN KEY ([idOperadorTuristico]) REFERENCES [dbo].[OperadorTuristico] ([idOperadorTuristico])
);

