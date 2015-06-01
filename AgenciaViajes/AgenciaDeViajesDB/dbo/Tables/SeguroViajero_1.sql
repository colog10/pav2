CREATE TABLE [dbo].[SeguroViajero] (
    [idSeguroViajero]   INT  NOT NULL,
    [comision]          INT   NULL,
    [monto]             FLOAT (53)    NULL,
    [tipoSeguroViajero] INT   NOT NULL,
    [numeroCompra]      INT  NULL,
    [descripcion]       NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_SeguroViajero] PRIMARY KEY CLUSTERED ([idSeguroViajero] ASC),
    CONSTRAINT [FK_SeguroViajero_Compra] FOREIGN KEY ([numeroCompra]) REFERENCES [dbo].[Compra] ([idCompra]),
    CONSTRAINT [FK_SeguroViajero_TipoSeguroViajero] FOREIGN KEY ([tipoSeguroViajero]) REFERENCES [dbo].[TipoSeguroViajero] ([tipoSeguroViajero])
);

