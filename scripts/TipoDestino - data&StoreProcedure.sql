USE [AgenciaViajes-PAVII]
GO
/****** Object:  Table [dbo].[TipoDestino]    Script Date: 06/03/2015 16:06:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDestino](
	[idTipoDestino] [int] NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TipoDestino] PRIMARY KEY CLUSTERED 
(
	[idTipoDestino] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[usp_TipoDestino_GetAll]    Script Date: 06/03/2015 16:06:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_TipoDestino_GetAll]  
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM TipoDestino;
END
GO
