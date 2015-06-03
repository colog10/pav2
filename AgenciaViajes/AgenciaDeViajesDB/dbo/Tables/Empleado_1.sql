CREATE TABLE [dbo].[Empleado] (
    [idEmpleado] INT  IDENTITY(1,1) NOT NULL,
    [legajo]     INT  NOT NULL,
    [apellido]   NVARCHAR (30) NOT NULL,
    [nombre]     NVARCHAR (30) NOT NULL,
    [fechaAlta]  DATE          NOT NULL,
    [fechaBaja]  DATE          NULL,
    [idUsuario]  INT   NULL,
    [activo]     BIT           NULL,
    [supervisor] BIT           NULL,
    CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED ([idEmpleado] ASC),
    CONSTRAINT [FK_Empleado_Usuario] FOREIGN KEY ([idUsuario]) REFERENCES [dbo].[Usuario] ([usuario])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Empleado]
    ON [dbo].[Empleado]([legajo] ASC);

