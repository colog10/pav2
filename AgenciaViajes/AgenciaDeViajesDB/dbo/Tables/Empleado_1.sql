CREATE TABLE [dbo].[Empleado] (
    [idEmpleado] NUMERIC (10)  NOT NULL,
    [legajo]     NUMERIC (10)  NOT NULL,
    [apellido]   NVARCHAR (30) NOT NULL,
    [nombre]     NVARCHAR (30) NOT NULL,
    [fechaAlta]  DATE          NOT NULL,
    [fechaBaja]  DATE          NULL,
    [idUsuario]  NUMERIC (2)   NULL,
    [activo]     BIT           NULL,
    [supervisor] BIT           NULL,
    CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED ([idEmpleado] ASC),
    CONSTRAINT [FK_Empleado_Usuario] FOREIGN KEY ([idUsuario]) REFERENCES [dbo].[Usuario] ([usuario])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Empleado]
    ON [dbo].[Empleado]([legajo] ASC);

