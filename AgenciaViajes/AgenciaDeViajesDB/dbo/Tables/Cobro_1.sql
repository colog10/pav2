CREATE TABLE [dbo].[Cobro] (
    [numeroCobro] INT NOT NULL,
    [fechaCobro]  DATETIME     NOT NULL,
    [numeroVenta] INT          NOT NULL,
    [monto]       FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_cobro] PRIMARY KEY CLUSTERED ([numeroCobro] ASC),
    CONSTRAINT [FK_cobro_Venta] FOREIGN KEY ([numeroVenta]) REFERENCES [dbo].[Venta] ([numeroVenta])
);

