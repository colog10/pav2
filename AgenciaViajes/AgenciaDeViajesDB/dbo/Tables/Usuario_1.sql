CREATE TABLE [dbo].[Usuario] (
    [usuario]   NUMERIC (2)   NOT NULL,
    [activo]    BIT           NOT NULL,
    [fechaAlta] DATETIME      NOT NULL,
    [fechaBaja] DATETIME      NOT NULL,
    [nombre]    NVARCHAR (50) NOT NULL,
    [password]  NVARCHAR (8)  NOT NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([usuario] ASC)
);

