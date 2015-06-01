CREATE TABLE [dbo].[CompaniaAerea] (
    [idCompaniaAerea] INT  NOT NULL,
    [nombre]          NVARCHAR (50) NOT NULL,
    [telefono]        NUMERIC (13)  NULL,
    [paginaWeb]       NVARCHAR (50) NULL,
    CONSTRAINT [PK_CompaniaAerea] PRIMARY KEY CLUSTERED ([idCompaniaAerea] ASC)
);

