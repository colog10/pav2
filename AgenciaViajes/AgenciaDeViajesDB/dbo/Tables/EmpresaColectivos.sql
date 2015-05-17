CREATE TABLE [dbo].[EmpresaColectivos] (
    [idEmpresaColectivos] NUMERIC (10)  NOT NULL,
    [nombre]              NVARCHAR (50) NOT NULL,
    [telefono]            NUMERIC (13)  NOT NULL,
    [paginaWeb]           NVARCHAR (50) NULL,
    CONSTRAINT [PK_EmpresaColectivos] PRIMARY KEY CLUSTERED ([idEmpresaColectivos] ASC)
);

