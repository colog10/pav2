CREATE TABLE [dbo].[ServicioTraslado] (
    [idServicioTraslado]  NUMERIC (10)  NOT NULL,
    [comision]            NUMERIC (2)   NOT NULL,
    [destino]             INT           NOT NULL,
    [fechaSalida]         DATETIME      NOT NULL,
    [fechaRegreso]        DATETIME      NOT NULL,
    [fechaVtoReserva]     DATETIME      NOT NULL,
    [monto]               FLOAT (53)    NOT NULL,
    [numeroReserva]       NVARCHAR (10) NOT NULL,
    [origen]              INT           NOT NULL,
    [idCompaniaAerea]     NUMERIC (10)  NOT NULL,
    [idEmpresaColectivos] NUMERIC (10)  NOT NULL,
    [numeroCompra]        NUMERIC (10)  NOT NULL,
    [numeroVenta]         INT           NOT NULL,
    [tipoDocumento]       NUMERIC (2)   NOT NULL,
    [numeroDocumento]     NVARCHAR (8)  NOT NULL,
    CONSTRAINT [PK_ServicioTraslado] PRIMARY KEY CLUSTERED ([idServicioTraslado] ASC),
    CONSTRAINT [FK_ServicioTraslado_CompaniaAerea] FOREIGN KEY ([idCompaniaAerea]) REFERENCES [dbo].[CompaniaAerea] ([idCompaniaAerea]),
    CONSTRAINT [FK_ServicioTraslado_EmpresaColectivos] FOREIGN KEY ([idEmpresaColectivos]) REFERENCES [dbo].[EmpresaColectivos] ([idEmpresaColectivos])
);

