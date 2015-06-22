USE [AgenciaDeViajes]
GO
/****** Object:  StoredProcedure [dbo].[usp_VentaDetalle_Insert]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_VentaDetalle_Insert]
GO
/****** Object:  StoredProcedure [dbo].[usp_Venta_Insert]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Venta_Insert]
GO
/****** Object:  StoredProcedure [dbo].[usp_Venta_GetByFiltros]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Venta_GetByFiltros]
GO
/****** Object:  StoredProcedure [dbo].[usp_Usuario_GetAll]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Usuario_GetAll]
GO
/****** Object:  StoredProcedure [dbo].[usp_TipoSeguroViajero_GetAll]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_TipoSeguroViajero_GetAll]
GO
/****** Object:  StoredProcedure [dbo].[usp_TipoDocumento_GetAll]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_TipoDocumento_GetAll]
GO
/****** Object:  StoredProcedure [dbo].[usp_TipoDestino_GetAll]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_TipoDestino_GetAll]
GO
/****** Object:  StoredProcedure [dbo].[usp_ServicioTraslado_Insert]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_ServicioTraslado_Insert]
GO
/****** Object:  StoredProcedure [dbo].[usp_ServicioAlojamiento_Insert]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_ServicioAlojamiento_Insert]
GO
/****** Object:  StoredProcedure [dbo].[usp_ServicioAlojamiento_GetByID]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_ServicioAlojamiento_GetByID]
GO
/****** Object:  StoredProcedure [dbo].[usp_SeguroViajero_Insert]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_SeguroViajero_Insert]
GO
/****** Object:  StoredProcedure [dbo].[usp_SegurosViajeros_GetByID]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_SegurosViajeros_GetByID]
GO
/****** Object:  StoredProcedure [dbo].[usp_ReservasDetalle_GetByIDReserva]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_ReservasDetalle_GetByIDReserva]
GO
/****** Object:  StoredProcedure [dbo].[usp_ReservasDetalle_GetByIDCliente]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_ReservasDetalle_GetByIDCliente]
GO
/****** Object:  StoredProcedure [dbo].[usp_ReservasDetalle_GetByDocumento]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_ReservasDetalle_GetByDocumento]
GO
/****** Object:  StoredProcedure [dbo].[usp_ReservasDetalle_GetAll]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_ReservasDetalle_GetAll]
GO
/****** Object:  StoredProcedure [dbo].[usp_Reservas_GetByID]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Reservas_GetByID]
GO
/****** Object:  StoredProcedure [dbo].[usp_Reservas_GetAll]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Reservas_GetAll]
GO
/****** Object:  StoredProcedure [dbo].[usp_ReservaDetalle_Sell]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_ReservaDetalle_Sell]
GO
/****** Object:  StoredProcedure [dbo].[usp_ReservaDetalle_Insert]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_ReservaDetalle_Insert]
GO
/****** Object:  StoredProcedure [dbo].[usp_ReservaDetalle_Buy]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_ReservaDetalle_Buy]
GO
/****** Object:  StoredProcedure [dbo].[usp_Reserva_Insert]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Reserva_Insert]
GO
/****** Object:  StoredProcedure [dbo].[usp_Reserva_GetInforme]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Reserva_GetInforme]
GO
/****** Object:  StoredProcedure [dbo].[usp_Reserva_GetByRazonSocialOrCuil]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Reserva_GetByRazonSocialOrCuil]
GO
/****** Object:  StoredProcedure [dbo].[usp_Pasajero_Update]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Pasajero_Update]
GO
/****** Object:  StoredProcedure [dbo].[usp_Pasajero_Insert]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Pasajero_Insert]
GO
/****** Object:  StoredProcedure [dbo].[usp_Pasajero_GetByTermino]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Pasajero_GetByTermino]
GO
/****** Object:  StoredProcedure [dbo].[usp_Pasajero_GetByID]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Pasajero_GetByID]
GO
/****** Object:  StoredProcedure [dbo].[usp_Pasajero_GetAll]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Pasajero_GetAll]
GO
/****** Object:  StoredProcedure [dbo].[usp_Pasajero_Delete]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Pasajero_Delete]
GO
/****** Object:  StoredProcedure [dbo].[usp_Paises_GetAll]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Paises_GetAll]
GO
/****** Object:  StoredProcedure [dbo].[usp_OperadorTuristico_Update]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_OperadorTuristico_Update]
GO
/****** Object:  StoredProcedure [dbo].[usp_OperadorTuristico_Insert]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_OperadorTuristico_Insert]
GO
/****** Object:  StoredProcedure [dbo].[usp_OperadorTuristico_GetByTermino]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_OperadorTuristico_GetByTermino]
GO
/****** Object:  StoredProcedure [dbo].[usp_OperadorTuristico_GetByID]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_OperadorTuristico_GetByID]
GO
/****** Object:  StoredProcedure [dbo].[usp_OperadorTuristico_GetAll]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_OperadorTuristico_GetAll]
GO
/****** Object:  StoredProcedure [dbo].[usp_OperadorTuristico_DeleteByID]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_OperadorTuristico_DeleteByID]
GO
/****** Object:  StoredProcedure [dbo].[usp_OperadorTuristico_Delete]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_OperadorTuristico_Delete]
GO
/****** Object:  StoredProcedure [dbo].[usp_EstadoCivil_GetAll]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_EstadoCivil_GetAll]
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_Update]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Empleado_Update]
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_Insert]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Empleado_Insert]
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_GetByUsuario]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Empleado_GetByUsuario]
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_GetByID]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Empleado_GetByID]
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_GetAll]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Empleado_GetAll]
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_Delete]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Empleado_Delete]
GO
/****** Object:  StoredProcedure [dbo].[usp_DetalleReserva_GetAll]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_DetalleReserva_GetAll]
GO
/****** Object:  StoredProcedure [dbo].[usp_CompraDetalle_Insert]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_CompraDetalle_Insert]
GO
/****** Object:  StoredProcedure [dbo].[usp_Compra_Insert]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Compra_Insert]
GO
/****** Object:  StoredProcedure [dbo].[usp_Compra_GetByFiltros]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Compra_GetByFiltros]
GO
/****** Object:  StoredProcedure [dbo].[usp_CompaniaAerea_GetAll]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_CompaniaAerea_GetAll]
GO
/****** Object:  StoredProcedure [dbo].[usp_Cliente_GetByRazonSocialOrCuil]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Cliente_GetByRazonSocialOrCuil]
GO
/****** Object:  StoredProcedure [dbo].[usp_Cliente_GetByID]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Cliente_GetByID]
GO
/****** Object:  StoredProcedure [dbo].[usp_Ciudad_GetByIDPais]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Ciudad_GetByIDPais]
GO
/****** Object:  StoredProcedure [dbo].[usp_Alojamiento_GetAll]    Script Date: 22/06/2015 2:27:28 ******/
DROP PROCEDURE [dbo].[usp_Alojamiento_GetAll]
GO
ALTER TABLE [dbo].[VentaDetalle] DROP CONSTRAINT [FK_VentaDetalle_ServicioTraslado]
GO
ALTER TABLE [dbo].[VentaDetalle] DROP CONSTRAINT [FK_VentaDetalle_ServicioAlojamiento]
GO
ALTER TABLE [dbo].[VentaDetalle] DROP CONSTRAINT [FK_VentaDetalle_SeguroViajero]
GO
ALTER TABLE [dbo].[VentaDetalle] DROP CONSTRAINT [FK_VentaDetalle_Pasajero]
GO
ALTER TABLE [dbo].[Venta] DROP CONSTRAINT [FK_Venta_Empleado]
GO
ALTER TABLE [dbo].[UsuarioXRol] DROP CONSTRAINT [FK_UsuarioXRol_Usuario]
GO
ALTER TABLE [dbo].[UsuarioXRol] DROP CONSTRAINT [FK_UsuarioXRol_Rol]
GO
ALTER TABLE [dbo].[ServicioTraslado] DROP CONSTRAINT [FK_ServicioTraslado_EmpresaColectivos]
GO
ALTER TABLE [dbo].[ServicioTraslado] DROP CONSTRAINT [FK_ServicioTraslado_CompaniaAerea]
GO
ALTER TABLE [dbo].[ServicioAlojamiento] DROP CONSTRAINT [FK_ServicioAlojamiento_Compra]
GO
ALTER TABLE [dbo].[ServicioAlojamiento] DROP CONSTRAINT [FK_ServicioAlojamiento_Alojamiento]
GO
ALTER TABLE [dbo].[SeguroViajero] DROP CONSTRAINT [FK_SeguroViajero_TipoSeguroViajero]
GO
ALTER TABLE [dbo].[SeguroViajero] DROP CONSTRAINT [FK_SeguroViajero_Compra]
GO
ALTER TABLE [dbo].[Reserva] DROP CONSTRAINT [FK_Reserva_TipoDocumento1]
GO
ALTER TABLE [dbo].[Reserva] DROP CONSTRAINT [FK_Reserva_ServicioTraslado]
GO
ALTER TABLE [dbo].[Reserva] DROP CONSTRAINT [FK_Reserva_ServicioAlojamiento]
GO
ALTER TABLE [dbo].[Reserva] DROP CONSTRAINT [FK_Reserva_SeguroViajero]
GO
ALTER TABLE [dbo].[Reserva] DROP CONSTRAINT [FK_Reserva_Empleado]
GO
ALTER TABLE [dbo].[Reserva] DROP CONSTRAINT [FK_Reserva_Cliente]
GO
ALTER TABLE [dbo].[PaxFrecuenteXCiaAerea] DROP CONSTRAINT [FK_PaxFrecuenteXCiaAerea_Pasajer]
GO
ALTER TABLE [dbo].[Pasajero] DROP CONSTRAINT [FK_Pasajer_TipoDocumento]
GO
ALTER TABLE [dbo].[Pasajero] DROP CONSTRAINT [FK_Pasajer_Pais]
GO
ALTER TABLE [dbo].[Pasajero] DROP CONSTRAINT [FK_Pasajer_EstadoCivil]
GO
ALTER TABLE [dbo].[OperadorTuristico] DROP CONSTRAINT [FK_OperadorTuristico_TipoDestino]
GO
ALTER TABLE [dbo].[Empleado] DROP CONSTRAINT [FK_Empleado_Usuario]
GO
ALTER TABLE [dbo].[CompraDetalle] DROP CONSTRAINT [FK_CompraDetalle_ReservaDetalle]
GO
ALTER TABLE [dbo].[Compra] DROP CONSTRAINT [FK_Compra_OperadorTuristico]
GO
ALTER TABLE [dbo].[Compra] DROP CONSTRAINT [FK_Compra_CompraDetalle]
GO
ALTER TABLE [dbo].[Cobro] DROP CONSTRAINT [FK_cobro_Venta]
GO
ALTER TABLE [dbo].[Ciudad] DROP CONSTRAINT [FK_Ciudad_TipoDestino]
GO
ALTER TABLE [dbo].[Alojamiento] DROP CONSTRAINT [FK_Alojamiento_TipoAlojamiento]
GO
/****** Object:  Table [dbo].[VentaDetalle]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[VentaDetalle]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[Venta]
GO
/****** Object:  Table [dbo].[UsuarioXRol]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[UsuarioXRol]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[Usuario]
GO
/****** Object:  Table [dbo].[TipoSeguroViajero]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[TipoSeguroViajero]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[TipoDocumento]
GO
/****** Object:  Table [dbo].[TipoDestino]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[TipoDestino]
GO
/****** Object:  Table [dbo].[TipoAlojamiento]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[TipoAlojamiento]
GO
/****** Object:  Table [dbo].[ServicioTraslado]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[ServicioTraslado]
GO
/****** Object:  Table [dbo].[ServicioAlojamiento]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[ServicioAlojamiento]
GO
/****** Object:  Table [dbo].[SeguroViajero]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[SeguroViajero]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[Rol]
GO
/****** Object:  Table [dbo].[ReservaDetalle]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[ReservaDetalle]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[Reserva]
GO
/****** Object:  Table [dbo].[PaxFrecuenteXCiaAerea]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[PaxFrecuenteXCiaAerea]
GO
/****** Object:  Table [dbo].[Pasajero]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[Pasajero]
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[Pais]
GO
/****** Object:  Table [dbo].[OperadorTuristicoCalificacion]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[OperadorTuristicoCalificacion]
GO
/****** Object:  Table [dbo].[OperadorTuristico]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[OperadorTuristico]
GO
/****** Object:  Table [dbo].[MotivoViaje]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[MotivoViaje]
GO
/****** Object:  Table [dbo].[EstadoCivil]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[EstadoCivil]
GO
/****** Object:  Table [dbo].[EmpresaColectivos]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[EmpresaColectivos]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[Empleado]
GO
/****** Object:  Table [dbo].[CompraDetalle]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[CompraDetalle]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[Compra]
GO
/****** Object:  Table [dbo].[CompaniaAerea]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[CompaniaAerea]
GO
/****** Object:  Table [dbo].[Cobro]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[Cobro]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[Cliente]
GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[Ciudad]
GO
/****** Object:  Table [dbo].[Alojamiento]    Script Date: 22/06/2015 2:27:28 ******/
DROP TABLE [dbo].[Alojamiento]
GO
USE [master]
GO
/****** Object:  Database [AgenciaDeViajes]    Script Date: 22/06/2015 2:27:28 ******/
DROP DATABASE [AgenciaDeViajes]
GO
