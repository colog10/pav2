CREATE TABLE [dbo].[Compra] (
    [idCompra]            INT NOT NULL,
    [idOperadorTuristico] INT NOT NULL,
    [idDetalleCompra]     INT NULL,
    [fechaCompra]         DATETIME     NOT NULL,
    [fechaPago]           DATETIME     NOT NULL,
    [monto]               FLOAT (53)   NOT NULL,
    [saldo]               FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED ([idCompra] ASC),
    CONSTRAINT [FK_Compra_CompraDetalle] FOREIGN KEY ([idDetalleCompra]) REFERENCES [dbo].[CompraDetalle] ([idDetalleCompra]),
    CONSTRAINT [FK_Compra_OperadorTuristico] FOREIGN KEY ([idOperadorTuristico]) REFERENCES [dbo].[OperadorTuristico] ([idOperadorTuristico])
);

