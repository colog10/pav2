CREATE TABLE [dbo].[PaxFrecuenteXCiaAerea] (
    [IdPasajero]      INT NOT NULL,
    [idCompaniaAerea] INT  NOT NULL,
    [nroPaxFrecuente] INT          NOT NULL,
    CONSTRAINT [PK_PaxFrecuenteXCiaAerea_1] PRIMARY KEY CLUSTERED ([IdPasajero] ASC, [idCompaniaAerea] ASC),
    CONSTRAINT [FK_PaxFrecuenteXCiaAerea_Pasajer] FOREIGN KEY ([IdPasajero]) REFERENCES [dbo].[Pasajero] ([idPasajero])
);

