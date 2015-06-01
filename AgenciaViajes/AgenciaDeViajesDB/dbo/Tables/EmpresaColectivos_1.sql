CREATE TABLE [dbo].[EmpresaColectivos] (
    [idEmpresaColectivos] INT  NOT NULL,
    [nombre]              NVARCHAR (50) NOT NULL,
    [telefono]            INT  NOT NULL,
    [paginaWeb]           NVARCHAR (50) NULL,
    CONSTRAINT [PK_EmpresaColectivos] PRIMARY KEY CLUSTERED ([idEmpresaColectivos] ASC)
);

