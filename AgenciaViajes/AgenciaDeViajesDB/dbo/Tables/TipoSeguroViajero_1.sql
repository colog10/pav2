CREATE TABLE [dbo].[TipoSeguroViajero] (
    [tipoSeguroViajero] NUMERIC (2)   NOT NULL,
    [descripcion]       NVARCHAR (30) NOT NULL,
    CONSTRAINT [PK_TipoSeguroViajero] PRIMARY KEY CLUSTERED ([tipoSeguroViajero] ASC)
);

