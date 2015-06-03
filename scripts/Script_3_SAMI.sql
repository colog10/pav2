USE [AgenciaDeViajes]
GO




INSERT INTO [dbo].[Rol]
           ([nombre])
     VALUES
           ('Administrador')
GO


INSERT INTO [dbo].[Rol]
           ([nombre])
     VALUES
           ('Usuario')
GO





INSERT INTO [dbo].[UsuarioXRol]
           ([idUsuario]
           ,[idRol])
     VALUES
           (1, 1)
GO


INSERT INTO [dbo].[UsuarioXRol]
           ([idUsuario]
           ,[idRol])
     VALUES
           (2, 1)
GO

INSERT INTO [dbo].[UsuarioXRol]
           ([idUsuario]
           ,[idRol])
     VALUES
           (3, 1)
GO

INSERT INTO [dbo].[UsuarioXRol]
           ([idUsuario]
           ,[idRol])
     VALUES
           (4, 1)
GO

