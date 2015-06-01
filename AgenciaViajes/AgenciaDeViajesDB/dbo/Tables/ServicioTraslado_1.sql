CREATE TABLE [dbo].[ServicioTraslado] (
    [idServicioTraslado]  INT  NOT NULL,
    [comision]            INT   NOT NULL,
    [destino]             INT           NOT NULL,
    [fechaSalida]         DATETIME      NOT NULL,
    [fechaRegreso]        DATETIME      NOT NULL,
    [fechaVtoReserva]     DATETIME      NOT NULL,
    [monto]               FLOAT (53)    NOT NULL,
    [numeroReserva]       NVARCHAR (10) NOT NULL,
    [origen]              INT           NOT NULL,
    [idCompaniaAerea]     INT  NOT NULL,
    [idEmpresaColectivos] INT  NOT NULL,
    [numeroCompra]        INT  NOT NULL,
    [numeroVenta]         INT           NOT NULL,
    [tipoDocumento]       INT   NOT NULL,
    [numeroDocumento]     NVARCHAR (8)  NOT NULL,
    CONSTRAINT [PK_ServicioTraslado] PRIMARY KEY CLUSTERED ([idServicioTraslado] ASC),
    CONSTRAINT [FK_ServicioTraslado_CompaniaAerea] FOREIGN KEY ([idCompaniaAerea]) REFERENCES [dbo].[CompaniaAerea] ([idCompaniaAerea]),
    CONSTRAINT [FK_ServicioTraslado_EmpresaColectivos] FOREIGN KEY ([idEmpresaColectivos]) REFERENCES [dbo].[EmpresaColectivos] ([idEmpresaColectivos])
);

