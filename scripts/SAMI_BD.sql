USE [master]
GO
/****** Object:  Database [AgenciaDeViajes]    Script Date: 03/06/2015 15:34:54 ******/
CREATE DATABASE [AgenciaDeViajes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AgenciaDeViajes', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\AgenciaDeViajes.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AgenciaDeViajes_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\AgenciaDeViajes_log.ldf' , SIZE = 3136KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AgenciaDeViajes] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AgenciaDeViajes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AgenciaDeViajes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET ARITHABORT OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AgenciaDeViajes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AgenciaDeViajes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AgenciaDeViajes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AgenciaDeViajes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AgenciaDeViajes] SET  MULTI_USER 
GO
ALTER DATABASE [AgenciaDeViajes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AgenciaDeViajes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AgenciaDeViajes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AgenciaDeViajes] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [AgenciaDeViajes]
GO
/****** Object:  Table [dbo].[Alojamiento]    Script Date: 03/06/2015 15:34:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alojamiento](
	[idAlojamiento] [int] IDENTITY(1,1) NOT NULL,
	[idTipoAlojamiento] [int] NOT NULL,
	[domicilio] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[telefono] [int] NOT NULL,
 CONSTRAINT [PK_Alojamiento] PRIMARY KEY CLUSTERED 
(
	[idAlojamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ciudad](
	[idCiudad] [int] IDENTITY(1,1) NOT NULL,
	[CiudadNombre] [char](20) NOT NULL CONSTRAINT [DF__Ciudad__CiudadNo__10566F31]  DEFAULT (''),
	[PaisCodigo] [char](3) NOT NULL CONSTRAINT [DF__Ciudad__PaisCodi__114A936A]  DEFAULT (''),
	[CiudadDistrito] [char](20) NOT NULL CONSTRAINT [DF__Ciudad__CiudadDi__123EB7A3]  DEFAULT (''),
	[CiudadPoblacion] [int] NOT NULL CONSTRAINT [DF__Ciudad__CiudadPo__1332DBDC]  DEFAULT ('0'),
	[TipoDestino] [int] NULL,
 CONSTRAINT [PK__Ciudad__E826E7900E6E26BF] PRIMARY KEY CLUSTERED 
(
	[idCiudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[cuilcuit1] [nvarchar](2) NOT NULL,
	[cuilcuit2] [nvarchar](8) NOT NULL,
	[cuilcuit3] [nvarchar](1) NOT NULL,
	[razonSocial] [nvarchar](50) NOT NULL,
	[movil] [nvarchar](50) NULL,
	[domicilioComercial] [nvarchar](60) NULL,
	[domicilioParticular] [nvarchar](60) NULL,
	[email] [nvarchar](40) NULL,
	[telfax] [nvarchar](50) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cobro]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cobro](
	[idCobro] [int] IDENTITY(1,1) NOT NULL,
	[fechaCobro] [datetime] NOT NULL,
	[numeroVenta] [int] NOT NULL,
	[monto] [float] NOT NULL,
 CONSTRAINT [PK_cobro] PRIMARY KEY CLUSTERED 
(
	[idCobro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CompaniaAerea]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompaniaAerea](
	[idCompaniaAerea] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[telefono] [numeric](13, 0) NULL,
	[paginaWeb] [nvarchar](50) NULL,
 CONSTRAINT [PK_CompaniaAerea] PRIMARY KEY CLUSTERED 
(
	[idCompaniaAerea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Compra]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[idCompra] [int] IDENTITY(1,1) NOT NULL,
	[idOperadorTuristico] [int] NOT NULL,
	[idDetalleCompra] [int] NULL,
	[fechaCompra] [datetime] NOT NULL,
	[fechaPago] [datetime] NOT NULL,
	[monto] [float] NOT NULL,
	[saldo] [float] NOT NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[idCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CompraDetalle]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompraDetalle](
	[idDetalleCompra] [int] IDENTITY(1,1) NOT NULL,
	[idDetalleReserva] [int] NULL,
	[descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_CompraDetalle] PRIMARY KEY CLUSTERED 
(
	[idDetalleCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[legajo] [int] NOT NULL,
	[apellido] [nvarchar](30) NOT NULL,
	[nombre] [nvarchar](30) NOT NULL,
	[fechaAlta] [date] NOT NULL,
	[fechaBaja] [date] NULL,
	[idUsuario] [int] NULL,
	[activo] [bit] NULL,
	[supervisor] [bit] NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmpresaColectivos]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpresaColectivos](
	[idEmpresaColectivos] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[telefono] [int] NOT NULL,
	[paginaWeb] [nvarchar](50) NULL,
 CONSTRAINT [PK_EmpresaColectivos] PRIMARY KEY CLUSTERED 
(
	[idEmpresaColectivos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EstadoCivil]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoCivil](
	[idEstadoCivil] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_EstadoCivil] PRIMARY KEY CLUSTERED 
(
	[idEstadoCivil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MotivoViaje]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MotivoViaje](
	[idMotivoViaje] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_MotivoViaje] PRIMARY KEY CLUSTERED 
(
	[idMotivoViaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OperadorTuristico]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperadorTuristico](
	[idOperadorTuristico] [int] IDENTITY(1,1) NOT NULL,
	[idTipoDestino] [int] NULL,
	[calificacion] [int] NULL,
	[descripcion] [nvarchar](50) NULL,
	[direccion] [nvarchar](100) NULL,
	[email] [nvarchar](35) NULL,
	[nombre] [nvarchar](50) NULL,
	[paginaWeb] [nvarchar](50) NULL,
	[telefono] [nvarchar](20) NULL,
	[activo] [bit] NULL,
	[fechaAlta] [date] NULL,
 CONSTRAINT [PK_OperadorTuristico] PRIMARY KEY CLUSTERED 
(
	[idOperadorTuristico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pais]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pais](
	[PaisCodigo] [nvarchar](3) NOT NULL CONSTRAINT [DF__Pais__PaisCodigo__778AC167]  DEFAULT (''),
	[PaisNombre] [char](52) NOT NULL CONSTRAINT [DF__Pais__PaisNombre__787EE5A0]  DEFAULT (''),
	[PaisContinente] [varchar](50) NULL CONSTRAINT [DF__Pais__PaisContin__797309D9]  DEFAULT ('Asia'),
	[PaisRegion] [varchar](26) NULL CONSTRAINT [DF__Pais__PaisRegion__7A672E12]  DEFAULT (''),
	[PaisArea] [float] NULL CONSTRAINT [DF__Pais__PaisArea__7B5B524B]  DEFAULT ('0.00'),
	[PaisIndependencia] [smallint] NULL CONSTRAINT [DF__Pais__PaisIndepe__7C4F7684]  DEFAULT (NULL),
	[PaisPoblacion] [int] NULL CONSTRAINT [DF__Pais__PaisPoblac__7D439ABD]  DEFAULT ('0'),
	[PaisExpectativaDeVida] [float] NULL CONSTRAINT [DF__Pais__PaisExpect__7E37BEF6]  DEFAULT (NULL),
	[PaisProductoInternoBruto] [float] NULL CONSTRAINT [DF__Pais__PaisProduc__7F2BE32F]  DEFAULT (NULL),
	[PaisProductoInternoBrutoAntiguo] [float] NULL CONSTRAINT [DF__Pais__PaisProduc__00200768]  DEFAULT (NULL),
	[PaisNombreLocal] [varchar](45) NULL CONSTRAINT [DF__Pais__PaisNombre__01142BA1]  DEFAULT (''),
	[PaisGobierno] [varchar](45) NULL CONSTRAINT [DF__Pais__PaisGobier__02084FDA]  DEFAULT (''),
	[PaisJefeDeEstado] [varchar](60) NULL CONSTRAINT [DF__Pais__PaisJefeDe__02FC7413]  DEFAULT (NULL),
	[PaisCapital] [int] NULL CONSTRAINT [DF__Pais__PaisCapita__03F0984C]  DEFAULT (NULL),
	[PaisCodigo2] [char](2) NULL CONSTRAINT [DF__Pais__PaisCodigo__04E4BC85]  DEFAULT (''),
 CONSTRAINT [PK__Pais__F3A7B39A75A278F5] PRIMARY KEY CLUSTERED 
(
	[PaisCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pasajero]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pasajero](
	[idPasajero] [int] IDENTITY(1,1) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[idTipoDocumento] [int] NOT NULL,
	[numeroDocumento] [int] NOT NULL,
	[cuilcuit1] [nvarchar](2) NULL,
	[cuilcuit2] [nvarchar](8) NULL,
	[cuilcuit3] [nvarchar](1) NULL,
	[idEstadoCivil] [int] NULL,
	[fechaNacimiento] [date] NULL,
	[idNacionalidad] [nvarchar](3) NULL,
	[profesion] [nvarchar](50) NULL,
	[domicilio] [nvarchar](100) NULL,
	[telefono] [nvarchar](50) NULL,
	[movil] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[eliminado] [char](1) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_Pasajer] PRIMARY KEY CLUSTERED 
(
	[idPasajero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PaxFrecuenteXCiaAerea]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaxFrecuenteXCiaAerea](
	[idPasajero] [int] IDENTITY(1,1) NOT NULL,
	[idCompaniaAerea] [int] NOT NULL,
	[nroPaxFrecuente] [int] NOT NULL,
 CONSTRAINT [PK_PaxFrecuenteXCiaAerea_1] PRIMARY KEY CLUSTERED 
(
	[idPasajero] ASC,
	[idCompaniaAerea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[idReserva] [int] IDENTITY(1,1) NOT NULL,
	[idDetalleReserva] [int] NULL,
	[idCliente] [int] NULL,
	[idEmpleado] [int] NULL,
	[idTipoDocumento] [int] NULL,
	[numeroDocumento] [nvarchar](8) NULL,
	[idDocumentoViaje] [int] NULL,
	[numeroReserva] [int] NULL,
	[monto] [int] NULL,
	[fechaReserva] [date] NULL,
	[idSeguroViajero] [int] NULL,
	[idServicioAlojamiento] [int] NULL,
	[idServicioTraslado] [int] NULL,
	[comprada] [bit] NULL,
	[efectuada] [bit] NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[idReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ReservaDetalle]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservaDetalle](
	[idDetallaReserva] [int] IDENTITY(1,1) NOT NULL,
	[idReserva] [int] NULL,
	[idSeguroViajero] [int] NULL,
	[idServicioAlojamiento] [int] NULL,
	[idServicioTraslado] [int] NULL,
	[idTipoDocumento] [int] NULL,
	[numeroDocumento] [nvarchar](8) NULL,
	[idDocumentoViaje] [int] NULL,
	[comprada] [bit] NULL,
	[efectuada] [bit] NULL,
 CONSTRAINT [PK_DetalleReserva] PRIMARY KEY CLUSTERED 
(
	[idDetallaReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rol]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SeguroViajero]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SeguroViajero](
	[idSeguroViajero] [int] IDENTITY(1,1) NOT NULL,
	[comision] [int] NULL,
	[monto] [float] NULL,
	[tipoSeguroViajero] [int] NOT NULL,
	[numeroCompra] [int] NULL,
	[descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SeguroViajero] PRIMARY KEY CLUSTERED 
(
	[idSeguroViajero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ServicioAlojamiento]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServicioAlojamiento](
	[idServicioAlojamiento] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [nvarchar](50) NOT NULL,
	[comision] [int] NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
	[fechaDesde] [datetime] NOT NULL,
	[fechaHasta] [datetime] NOT NULL,
	[fechaVencReserva] [datetime] NOT NULL,
	[monto] [float] NOT NULL,
	[numeroReserva] [nvarchar](10) NOT NULL,
	[idAlojamiento] [int] NOT NULL,
	[numeroVenta] [int] NOT NULL,
	[tipoDocumento] [int] NOT NULL,
	[numeroDocumento] [nvarchar](8) NOT NULL,
	[numeroCompra] [int] NOT NULL,
 CONSTRAINT [PK_ServicioAlojamiento] PRIMARY KEY CLUSTERED 
(
	[idServicioAlojamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ServicioTraslado]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServicioTraslado](
	[idServicioTraslado] [int] IDENTITY(1,1) NOT NULL,
	[comision] [int] NOT NULL,
	[destino] [int] NOT NULL,
	[fechaSalida] [datetime] NOT NULL,
	[fechaRegreso] [datetime] NOT NULL,
	[fechaVtoReserva] [datetime] NOT NULL,
	[monto] [float] NOT NULL,
	[numeroReserva] [nvarchar](10) NOT NULL,
	[origen] [int] NOT NULL,
	[idCompaniaAerea] [int] NOT NULL,
	[idEmpresaColectivos] [int] NOT NULL,
	[numeroCompra] [int] NOT NULL,
	[numeroVenta] [int] NOT NULL,
	[tipoDocumento] [int] NOT NULL,
	[numeroDocumento] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_ServicioTraslado] PRIMARY KEY CLUSTERED 
(
	[idServicioTraslado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoAlojamiento]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoAlojamiento](
	[idTipoAlojamiento] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TipoAlojamiento] PRIMARY KEY CLUSTERED 
(
	[idTipoAlojamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoDestino]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDestino](
	[idTipoDestino] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TipoDestino] PRIMARY KEY CLUSTERED 
(
	[idTipoDestino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[idTipoDocumento] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_tipoDocumento] PRIMARY KEY CLUSTERED 
(
	[idTipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoSeguroViajero]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoSeguroViajero](
	[idTipoSeguroViajero] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_TipoSeguroViajero] PRIMARY KEY CLUSTERED 
(
	[idTipoSeguroViajero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[activo] [bit] NOT NULL,
	[fechaAlta] [datetime] NOT NULL,
	[fechaBaja] [datetime] NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[password] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UsuarioXRol]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioXRol](
	[idUsuario] [int] NOT NULL,
	[idRol] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioXRol] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC,
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Venta]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NULL,
	[idVentaDetalle] [int] NULL,
	[idVendedor] [int] NOT NULL,
	[idSeguroViajero] [int] NULL,
	[idServicioAlojamiento] [int] NULL,
	[idServicioTraslado] [int] NULL,
	[monto] [float] NOT NULL,
	[comision] [int] NOT NULL,
	[paisOrigen] [nvarchar](3) NULL,
	[ciudadOrigen] [int] NULL,
	[paisDestino] [nvarchar](3) NULL,
	[ciudadDestino] [int] NULL,
	[fechaSalida] [date] NULL,
	[fechaRetorno] [date] NULL,
	[documentoviaje] [int] NULL,
	[fechaVenta] [date] NOT NULL,
	[motivoViaje] [int] NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VentaDetalle]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VentaDetalle](
	[idDetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[idMotivoViaje] [int] NULL,
	[idPasajero] [int] NULL,
	[numeroVenta] [int] NOT NULL,
	[idTipoDocumento] [int] NOT NULL,
	[numeroDocumento] [varchar](50) NOT NULL,
	[idDocumentoViaje] [int] NULL,
	[fechaPasaporteDesde] [date] NULL,
	[fechaPasaporteHasta] [date] NULL,
	[fechaVISADesde] [date] NULL,
	[fechaVISAHasta] [date] NULL,
	[idSeguroViajero] [int] NULL,
	[idServicioAlojamiento] [int] NULL,
	[idServicioTraslado] [int] NULL,
	[idDetalleReserva] [int] NULL,
 CONSTRAINT [PK_VentaDetalle] PRIMARY KEY CLUSTERED 
(
	[idDetalleVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Index [IX_Empleado]    Script Date: 03/06/2015 15:34:55 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Empleado] ON [dbo].[Empleado]
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Alojamiento]  WITH CHECK ADD  CONSTRAINT [FK_Alojamiento_TipoAlojamiento] FOREIGN KEY([idTipoAlojamiento])
REFERENCES [dbo].[TipoAlojamiento] ([idTipoAlojamiento])
GO
ALTER TABLE [dbo].[Alojamiento] CHECK CONSTRAINT [FK_Alojamiento_TipoAlojamiento]
GO
ALTER TABLE [dbo].[Ciudad]  WITH CHECK ADD  CONSTRAINT [FK_Ciudad_TipoDestino] FOREIGN KEY([TipoDestino])
REFERENCES [dbo].[TipoDestino] ([idTipoDestino])
GO
ALTER TABLE [dbo].[Ciudad] CHECK CONSTRAINT [FK_Ciudad_TipoDestino]
GO
ALTER TABLE [dbo].[Cobro]  WITH CHECK ADD  CONSTRAINT [FK_cobro_Venta] FOREIGN KEY([numeroVenta])
REFERENCES [dbo].[Venta] ([idVenta])
GO
ALTER TABLE [dbo].[Cobro] CHECK CONSTRAINT [FK_cobro_Venta]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_CompraDetalle] FOREIGN KEY([idDetalleCompra])
REFERENCES [dbo].[CompraDetalle] ([idDetalleCompra])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_CompraDetalle]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_OperadorTuristico] FOREIGN KEY([idOperadorTuristico])
REFERENCES [dbo].[OperadorTuristico] ([idOperadorTuristico])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_OperadorTuristico]
GO
ALTER TABLE [dbo].[CompraDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CompraDetalle_ReservaDetalle] FOREIGN KEY([idDetalleReserva])
REFERENCES [dbo].[ReservaDetalle] ([idDetallaReserva])
GO
ALTER TABLE [dbo].[CompraDetalle] CHECK CONSTRAINT [FK_CompraDetalle_ReservaDetalle]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Usuario]
GO
ALTER TABLE [dbo].[OperadorTuristico]  WITH CHECK ADD  CONSTRAINT [FK_OperadorTuristico_TipoDestino] FOREIGN KEY([idTipoDestino])
REFERENCES [dbo].[TipoDestino] ([idTipoDestino])
GO
ALTER TABLE [dbo].[OperadorTuristico] CHECK CONSTRAINT [FK_OperadorTuristico_TipoDestino]
GO
ALTER TABLE [dbo].[Pasajero]  WITH CHECK ADD  CONSTRAINT [FK_Pasajer_EstadoCivil] FOREIGN KEY([idEstadoCivil])
REFERENCES [dbo].[EstadoCivil] ([idEstadoCivil])
GO
ALTER TABLE [dbo].[Pasajero] CHECK CONSTRAINT [FK_Pasajer_EstadoCivil]
GO
ALTER TABLE [dbo].[Pasajero]  WITH CHECK ADD  CONSTRAINT [FK_Pasajer_Pais] FOREIGN KEY([idNacionalidad])
REFERENCES [dbo].[Pais] ([PaisCodigo])
GO
ALTER TABLE [dbo].[Pasajero] CHECK CONSTRAINT [FK_Pasajer_Pais]
GO
ALTER TABLE [dbo].[Pasajero]  WITH CHECK ADD  CONSTRAINT [FK_Pasajer_TipoDocumento] FOREIGN KEY([idTipoDocumento])
REFERENCES [dbo].[TipoDocumento] ([idTipoDocumento])
GO
ALTER TABLE [dbo].[Pasajero] CHECK CONSTRAINT [FK_Pasajer_TipoDocumento]
GO
ALTER TABLE [dbo].[PaxFrecuenteXCiaAerea]  WITH CHECK ADD  CONSTRAINT [FK_PaxFrecuenteXCiaAerea_Pasajer] FOREIGN KEY([idPasajero])
REFERENCES [dbo].[Pasajero] ([idPasajero])
GO
ALTER TABLE [dbo].[PaxFrecuenteXCiaAerea] CHECK CONSTRAINT [FK_PaxFrecuenteXCiaAerea_Pasajer]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Cliente]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Empleado]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_ReservaDetalle] FOREIGN KEY([idDetalleReserva])
REFERENCES [dbo].[ReservaDetalle] ([idDetallaReserva])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_ReservaDetalle]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_SeguroViajero] FOREIGN KEY([idSeguroViajero])
REFERENCES [dbo].[SeguroViajero] ([idSeguroViajero])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_SeguroViajero]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_ServicioAlojamiento] FOREIGN KEY([idServicioAlojamiento])
REFERENCES [dbo].[ServicioAlojamiento] ([idServicioAlojamiento])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_ServicioAlojamiento]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_ServicioTraslado] FOREIGN KEY([idServicioTraslado])
REFERENCES [dbo].[ServicioTraslado] ([idServicioTraslado])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_ServicioTraslado]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_TipoDocumento1] FOREIGN KEY([idTipoDocumento])
REFERENCES [dbo].[TipoDocumento] ([idTipoDocumento])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_TipoDocumento1]
GO
ALTER TABLE [dbo].[SeguroViajero]  WITH CHECK ADD  CONSTRAINT [FK_SeguroViajero_Compra] FOREIGN KEY([numeroCompra])
REFERENCES [dbo].[Compra] ([idCompra])
GO
ALTER TABLE [dbo].[SeguroViajero] CHECK CONSTRAINT [FK_SeguroViajero_Compra]
GO
ALTER TABLE [dbo].[SeguroViajero]  WITH CHECK ADD  CONSTRAINT [FK_SeguroViajero_TipoSeguroViajero] FOREIGN KEY([tipoSeguroViajero])
REFERENCES [dbo].[TipoSeguroViajero] ([idTipoSeguroViajero])
GO
ALTER TABLE [dbo].[SeguroViajero] CHECK CONSTRAINT [FK_SeguroViajero_TipoSeguroViajero]
GO
ALTER TABLE [dbo].[ServicioAlojamiento]  WITH CHECK ADD  CONSTRAINT [FK_ServicioAlojamiento_Alojamiento] FOREIGN KEY([idAlojamiento])
REFERENCES [dbo].[Alojamiento] ([idAlojamiento])
GO
ALTER TABLE [dbo].[ServicioAlojamiento] CHECK CONSTRAINT [FK_ServicioAlojamiento_Alojamiento]
GO
ALTER TABLE [dbo].[ServicioAlojamiento]  WITH CHECK ADD  CONSTRAINT [FK_ServicioAlojamiento_Compra] FOREIGN KEY([numeroCompra])
REFERENCES [dbo].[Compra] ([idCompra])
GO
ALTER TABLE [dbo].[ServicioAlojamiento] CHECK CONSTRAINT [FK_ServicioAlojamiento_Compra]
GO
ALTER TABLE [dbo].[ServicioTraslado]  WITH CHECK ADD  CONSTRAINT [FK_ServicioTraslado_CompaniaAerea] FOREIGN KEY([idCompaniaAerea])
REFERENCES [dbo].[CompaniaAerea] ([idCompaniaAerea])
GO
ALTER TABLE [dbo].[ServicioTraslado] CHECK CONSTRAINT [FK_ServicioTraslado_CompaniaAerea]
GO
ALTER TABLE [dbo].[ServicioTraslado]  WITH CHECK ADD  CONSTRAINT [FK_ServicioTraslado_EmpresaColectivos] FOREIGN KEY([idEmpresaColectivos])
REFERENCES [dbo].[EmpresaColectivos] ([idEmpresaColectivos])
GO
ALTER TABLE [dbo].[ServicioTraslado] CHECK CONSTRAINT [FK_ServicioTraslado_EmpresaColectivos]
GO
ALTER TABLE [dbo].[UsuarioXRol]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioXRol_Rol] FOREIGN KEY([idRol])
REFERENCES [dbo].[Rol] ([idRol])
GO
ALTER TABLE [dbo].[UsuarioXRol] CHECK CONSTRAINT [FK_UsuarioXRol_Rol]
GO
ALTER TABLE [dbo].[UsuarioXRol]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioXRol_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[UsuarioXRol] CHECK CONSTRAINT [FK_UsuarioXRol_Usuario]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Ciudad] FOREIGN KEY([ciudadOrigen])
REFERENCES [dbo].[Ciudad] ([idCiudad])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Ciudad]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Ciudad1] FOREIGN KEY([ciudadDestino])
REFERENCES [dbo].[Ciudad] ([idCiudad])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Ciudad1]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Empleado] FOREIGN KEY([idVendedor])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Empleado]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Pais] FOREIGN KEY([paisOrigen])
REFERENCES [dbo].[Pais] ([PaisCodigo])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Pais]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Pais1] FOREIGN KEY([paisDestino])
REFERENCES [dbo].[Pais] ([PaisCodigo])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Pais1]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_VentaDetalle] FOREIGN KEY([idVentaDetalle])
REFERENCES [dbo].[VentaDetalle] ([idDetalleVenta])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_VentaDetalle]
GO
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentaDetalle_MotivoViaje] FOREIGN KEY([idMotivoViaje])
REFERENCES [dbo].[MotivoViaje] ([idMotivoViaje])
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_VentaDetalle_MotivoViaje]
GO
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentaDetalle_Pasajero] FOREIGN KEY([idPasajero])
REFERENCES [dbo].[Pasajero] ([idPasajero])
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_VentaDetalle_Pasajero]
GO
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentaDetalle_SeguroViajero] FOREIGN KEY([idSeguroViajero])
REFERENCES [dbo].[SeguroViajero] ([idSeguroViajero])
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_VentaDetalle_SeguroViajero]
GO
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentaDetalle_ServicioAlojamiento] FOREIGN KEY([idServicioAlojamiento])
REFERENCES [dbo].[ServicioAlojamiento] ([idServicioAlojamiento])
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_VentaDetalle_ServicioAlojamiento]
GO
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentaDetalle_ServicioTraslado] FOREIGN KEY([idServicioTraslado])
REFERENCES [dbo].[ServicioTraslado] ([idServicioTraslado])
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_VentaDetalle_ServicioTraslado]
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_GetAll]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Empleado_GetAll]  
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM Empleado;
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_GetByID]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Empleado_GetByID]
	(@IDEmpleado int)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * 
	FROM Empleado
	WHERE IDEmpleado= @IDEmpleado;
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_Insert]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Empleado_Insert]
	(@legajo int,
	@nombre nvarchar(30),
	@apellido nvarchar(30),
	@fechaAlta date,
	@fechaBaja date = null,
	@activo bit = false,
	@idUsuario int,
	@supervisor bit = false)
AS
BEGIN
	SET NOCOUNT ON;


	INSERT INTO Empleado (legajo,apellido,nombre,fechaAlta,fechaBaja,idUsuario,activo,supervisor)
	VALUES (@legajo,@apellido,@nombre,@fechaAlta,@fechaBaja,@idUsuario,@activo,@supervisor);
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_Update]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Empleado_Update]
	(@idEmpleado int output,
	@legajo int,
	@nombre nvarchar(30),
	@apellido nvarchar(30),
	@fechaAlta date,
	@fechaBaja date = null,
	@activo bit = false,
	@idUsuario int,
	@supervisor bit = false)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE Empleado 
	SET legajo= @legajo, 
		nombre = @nombre,
		apellido= @apellido,
		fechaAlta= @fechaAlta,
		fechaBaja= @fechaBaja,
		activo= @activo,
		idUsuario= @idUsuario,
		supervisor=@supervisor
	WHERE idEmpleado = @idEmpleado;
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Pasajero_GetAll]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Pasajero_GetAll]  
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM Pasajero;
END
GO
/****** Object:  StoredProcedure [dbo].[usp_TipoDocumento_GetAll]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_TipoDocumento_GetAll]  
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM TipoDocumento;
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Usuario_GetAll]    Script Date: 03/06/2015 15:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Usuario_GetAll]
	AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM Usuario 
	WHERE activo = 1;
END

GO
USE [master]
GO
ALTER DATABASE [AgenciaDeViajes] SET  READ_WRITE 
GO
