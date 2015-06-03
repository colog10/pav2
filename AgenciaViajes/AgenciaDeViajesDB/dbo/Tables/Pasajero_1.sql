﻿CREATE TABLE [dbo].[Pasajero] (
    [idPasajero]      INT   NOT NULL,
    [apellido]        NVARCHAR (50)  NOT NULL,
    [nombre]          NVARCHAR (50)  NOT NULL,
    [idTipoDocumento] INT    NOT NULL,
    [numeroDocumento] INT    NOT NULL,
    [cuilcuit1]       NVARCHAR (2)   NULL,
    [cuilcuit2]       NVARCHAR (8)   NULL,
    [cuilcuit3]       NVARCHAR (1)   NULL,
    [idEstadoCivil]   INT    NULL,
    [fechaNacimiento] DATE           NULL,
    [idNacionalidad]  NVARCHAR (3)   NULL,
    [profesion]       NVARCHAR (50)  NULL,
    [domicilio]       NVARCHAR (100) NULL,
    [telefono]        NVARCHAR (50)  NULL,
    [movil]           NVARCHAR (50)  NULL,
    [email]           NVARCHAR (50)  NULL,
    [eliminado]       CHAR (1)       NULL,
    [activo]          BIT            NULL,
    CONSTRAINT [PK_Pasajer] PRIMARY KEY CLUSTERED ([idPasajero] ASC),
    CONSTRAINT [FK_Pasajer_EstadoCivil] FOREIGN KEY ([idEstadoCivil]) REFERENCES [dbo].[EstadoCivil] ([idEstadoCivil]),
    CONSTRAINT [FK_Pasajer_Pais] FOREIGN KEY ([idNacionalidad]) REFERENCES [dbo].[Pais] ([idPais]),
    CONSTRAINT [FK_Pasajer_TipoDocumento] FOREIGN KEY ([idTipoDocumento]) REFERENCES [dbo].[TipoDocumento] ([idTipoDocumento])
);

