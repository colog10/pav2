

CREATE TABLE [dbo].[Usuario](
	[usuario] [int] IDENTITY(1,1) NOT NULL,
	[activo] [bit] NOT NULL,
	[fechaAlta] [datetime] NOT NULL,
	[fechaBaja] [datetime] NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[password] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];


