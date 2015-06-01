CREATE TABLE [dbo].[Ciudad] (
    [CiudadID]        INT          NOT NULL,
    [CiudadNombre]    CHAR (20)    CONSTRAINT [DF__Ciudad__CiudadNo__10566F31] DEFAULT ('') NOT NULL,
    [PaisCodigo]      CHAR (3)     CONSTRAINT [DF__Ciudad__PaisCodi__114A936A] DEFAULT ('') NOT NULL,
    [CiudadDistrito]  CHAR (20)    CONSTRAINT [DF__Ciudad__CiudadDi__123EB7A3] DEFAULT ('') NOT NULL,
    [CiudadPoblacion] INT          CONSTRAINT [DF__Ciudad__CiudadPo__1332DBDC] DEFAULT ('0') NOT NULL,
    [TipoDestino]     INT NULL,
    CONSTRAINT [PK__Ciudad__E826E7900E6E26BF] PRIMARY KEY CLUSTERED ([CiudadID] ASC),
    CONSTRAINT [FK_Ciudad_TipoDestino] FOREIGN KEY ([TipoDestino]) REFERENCES [dbo].[TipoDestino] ([idTipoDestino])
);

