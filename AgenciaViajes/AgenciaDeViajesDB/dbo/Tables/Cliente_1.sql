CREATE TABLE [dbo].[Cliente] (
    [idCliente]           INT  NOT NULL,
    [cuilcuit1]           NVARCHAR (2)  NOT NULL,
    [cuilcuit2]           NVARCHAR (8)  NOT NULL,
    [cuilcuit3]           NVARCHAR (1)  NOT NULL,
    [razonSocial]         NVARCHAR (50) NOT NULL,
    [movil]               NVARCHAR (50) NULL,
    [domicilioComercial]  NVARCHAR (60) NULL,
    [domicilioParticular] NVARCHAR (60) NULL,
    [email]               NVARCHAR (40) NULL,
    [telfax]              NVARCHAR (50) NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([idCliente] ASC)
);

