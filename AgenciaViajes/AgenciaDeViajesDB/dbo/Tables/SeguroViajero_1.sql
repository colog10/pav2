CREATE TABLE [dbo].[SeguroViajero] (
    [idSeguroViajero]   NUMERIC (10)  NOT NULL,
    [comision]          NUMERIC (2)   NULL,
    [monto]             FLOAT (53)    NULL,
    [tipoSeguroViajero] NUMERIC (2)   NOT NULL,
    [numeroCompra]      NUMERIC (10)  NULL,
    [descripcion]       NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_SeguroViajero] PRIMARY KEY CLUSTERED ([idSeguroViajero] ASC),
    CONSTRAINT [FK_SeguroViajero_Compra] FOREIGN KEY ([numeroCompra]) REFERENCES [dbo].[Compra] ([idCompra]),
    CONSTRAINT [FK_SeguroViajero_TipoSeguroViajero] FOREIGN KEY ([tipoSeguroViajero]) REFERENCES [dbo].[TipoSeguroViajero] ([tipoSeguroViajero])
);

