CREATE TABLE [dbo].[PaxFrecuenteXCiaAerea] (
    [IdPasajero]      NUMERIC (10) NOT NULL,
    [idCompaniaAerea] NUMERIC (2)  NOT NULL,
    [nroPaxFrecuente] INT          NOT NULL,
    CONSTRAINT [PK_PaxFrecuenteXCiaAerea_1] PRIMARY KEY CLUSTERED ([IdPasajero] ASC, [idCompaniaAerea] ASC),
    CONSTRAINT [FK_PaxFrecuenteXCiaAerea_Pasajer] FOREIGN KEY ([IdPasajero]) REFERENCES [dbo].[Pasajero] ([idPasajero])
);

