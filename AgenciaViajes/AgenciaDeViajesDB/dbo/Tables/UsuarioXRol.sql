USE [AgenciaDeViajes]
GO

/****** Object:  Table [dbo].[UsuarioXRol]    Script Date: 03/06/2015 0:14:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UsuarioXRol](
	[idUsuario] [int] NOT NULL,
	[idRol] [int] NOT NULL	
 CONSTRAINT [PK_UsuarioXRol] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC,
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[UsuarioXRol]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioXRol_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([usuario])
GO
ALTER TABLE [dbo].[UsuarioXRol]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioXRol_Rol] FOREIGN KEY([idRol])
REFERENCES [dbo].[Rol] ([idRol])
GO

