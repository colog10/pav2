using AgenciaDeViajesDAL.Util;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDAL.DAL
{
    public class ReservaDB : DALBase
    {
        public static ReservaDTO GetReservasByID(int IDReserva)
        {
            SqlCommand command = GetDbSprocCommand("usp_Reservas_GetByID");
            command.Parameters.Add(CreateParameter("@IDReserva", IDReserva));
            ReservaDTO dr = GetSingleDTO<ReservaDTO>(ref command);

            dr.Cliente = ClienteDB.GetClienteByID(dr.IdCliente);
            
            return dr;
        }

        public static List<ReservaDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_Reservas_GetAll");
            List<ReservaDTO> dr = GetDTOList<ReservaDTO>(ref command);
            foreach (ReservaDTO re in dr)
            {
                re.Cliente = ClienteDB.GetClienteByID(re.IdCliente);
                
            }
            return dr;
        }

        public static void SaveReserva(ref ReservaDTO reserva)
        {
            
            SqlCommand command = null;
            

            try {
                command = GetDbSprocCommand("usp_Reserva_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDReserva", SqlDbType.Int));
                command.Parameters.Add(CreateParameter("@Comprada", reserva.Comprada));
                command.Parameters.Add(CreateParameter("@Efectuada", reserva.Efectuada));
                command.Parameters.Add(CreateParameter("@FechaReserva", reserva.FechaReserva));
                command.Parameters.Add(CreateParameter("@Idcliente", reserva.IdCliente));
                command.Parameters.Add(CreateParameter("@IdDocumentoViaje", reserva.IdDocumentoViaje));
                command.Parameters.Add(CreateParameter("@IdEmpleado", reserva.IdEmpleado));
                command.Parameters.Add(CreateParameter("@IdSeguroViajero", reserva.IdSeguroViajero));
                command.Parameters.Add(CreateParameter("@IdServicioAlojamiento", reserva.IdServicioAlojamiento));
                command.Parameters.Add(CreateParameter("@IdServicioTraslado", reserva.IdServicioTraslado));
                command.Parameters.Add(CreateParameter("@IdTipoDocumento", reserva.IdTipoDocumento));
                command.Parameters.Add(CreateParameter("@Monto", reserva.Monto));
                command.Parameters.Add(CreateParameter("@NumeroDocumento", reserva.NumeroDocumento, 8));
                command.Parameters.Add(CreateParameter("@NumeroReserva", reserva.NumeroReserva));
                command.Connection.Open();
                command.Transaction = command.Connection.BeginTransaction();
                command.ExecuteNonQuery();
                

               
                // If this is a new record, let's set the ID so the object
                // will have it.
                if (reserva.IsNew)
                {
                    reserva.IdReserva = (int)command.Parameters["@IDReserva"].Value;
                }
                foreach (ReservaDetalleDTO reservaDetalle in reserva.DetallesReserva)
                {

                    ServicioAlojamientoDTO servicioAlojamiento = reservaDetalle.ServicioAlojamiento;

                    if (servicioAlojamiento != null) { 
                        command.Parameters.Clear();
                        command.CommandText = "usp_ServicioAlojamiento_Insert";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(CreateOutputParameter("@idServicioAlojamiento", SqlDbType.Int));
                        command.Parameters.Add(CreateParameter("@categoria", servicioAlojamiento.CategoriaDTO, 50));
                        command.Parameters.Add(CreateParameter("@comision", servicioAlojamiento.comisionDTO));
                        command.Parameters.Add(CreateParameter("@descripcion", servicioAlojamiento.descripcionDTO, 50));
                        command.Parameters.Add(CreateParameter("@fechaDesde", servicioAlojamiento.fechaDesdeDTO));
                        command.Parameters.Add(CreateParameter("@fechaHasta", servicioAlojamiento.fechaHastaDTO));
                        command.Parameters.Add(CreateParameter("@fechaVencReserva", servicioAlojamiento.fechaVencReservaDTO));
                        command.Parameters.Add(CreateParameter("@monto", servicioAlojamiento.montoDTO));
                        command.Parameters.Add(CreateParameter("@numeroReserva", servicioAlojamiento.numeroReservaDTO, 10));
                        command.Parameters.Add(CreateParameter("@idAlojamiento", servicioAlojamiento.idAlojamientoDTO));
                        command.Parameters.Add(CreateParameter("@numeroVenta", servicioAlojamiento.numeroVentaDTO));
                        command.Parameters.Add(CreateParameter("@tipoDocumento", servicioAlojamiento.tipoDocumentoDTO));
                        command.Parameters.Add(CreateParameter("@numeroDocumento", servicioAlojamiento.numeroDocumentoDTO, 8));
                        command.Parameters.Add(CreateParameter("@numeroCompra", servicioAlojamiento.numeroCompraDTO));

                        command.ExecuteNonQuery();

                        reservaDetalle.IdServicioAlojamiento = (int)command.Parameters["@idServicioAlojamiento"].Value;
                    }

                    SeguroViajeroDTO seguroViajero = reservaDetalle.Seguro;
                    
                    if (seguroViajero != null) {
                        command.Parameters.Clear();
                        command.CommandText = "usp_SeguroViajero_Insert";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(CreateOutputParameter("@idSeguroViajero", SqlDbType.Int));
                        command.Parameters.Add(CreateParameter("@comision", seguroViajero.Comision));
                        command.Parameters.Add(CreateParameter("@monto", seguroViajero.Monto));
                        command.Parameters.Add(CreateParameter("@tipoSeguroViajero", seguroViajero.TipoSeguroViajero));
                        command.Parameters.Add(CreateParameter("@numeroCompra", seguroViajero.NumeroCompra));
                        command.Parameters.Add(CreateParameter("@descripcion", seguroViajero.Descripcion, 50));
                        command.ExecuteNonQuery();

                        reservaDetalle.IdSeguroViajero = (int)command.Parameters["@idSeguroViajero"].Value;
                    }
                    
                    


                    ServicioTrasladoDTO servicioTraslado = reservaDetalle.ServicioTraslado;
                    if (servicioTraslado != null)
                    { 
                        command.Parameters.Clear();
                        command.CommandText = "usp_ServicioTraslado_Insert";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(CreateOutputParameter("@idServicioTraslado", SqlDbType.Int));
                        command.Parameters.Add(CreateParameter("@comision", servicioTraslado.comisionDTO));
                        command.Parameters.Add(CreateParameter("@destino", servicioTraslado.destinoDTO));
                        command.Parameters.Add(CreateParameter("@fechaSalida", servicioTraslado.fechaSalidaDTO));
                        command.Parameters.Add(CreateParameter("@fechaRegreso", servicioTraslado.fechaLlegadaDTO));
                        command.Parameters.Add(CreateParameter("@monto", servicioTraslado.montoDTO));
                        command.Parameters.Add(CreateParameter("@numeroReserva", servicioTraslado.numeroReservaDTO, 10));
                        command.Parameters.Add(CreateParameter("@origen", servicioTraslado.origenDTO));
                        command.Parameters.Add(CreateParameter("@idCompaniaAerea", servicioTraslado.idCompaniaAereaDTO));
                        command.Parameters.Add(CreateParameter("@idEmpresaColectivos", servicioTraslado.idEmpresaColectivoDTO));
                        command.Parameters.Add(CreateParameter("@numeroCompra", servicioTraslado.numeroCompraDTO));
                        command.Parameters.Add(CreateParameter("@numeroVenta", servicioTraslado.numeroVentaDTO));
                        command.Parameters.Add(CreateParameter("@tipoDocumento", servicioTraslado.tipoDocumentoDTO));
                        command.Parameters.Add(CreateParameter("@numeroDocumento", servicioTraslado.numeroDocumentoDTO, 8));
                        command.ExecuteNonQuery();
                        reservaDetalle.IdServicioTraslado = (int)command.Parameters["@idServicioTraslado"].Value;
                    }
                    
                    command.Parameters.Clear();
                    command.CommandText = "usp_ReservaDetalle_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(CreateOutputParameter("@IDDetalleReserva", SqlDbType.Int));
                    command.Parameters.Add(CreateParameter("@Comprada", reservaDetalle.Comprada));
                    command.Parameters.Add(CreateParameter("@Efectuada", reservaDetalle.Efectuada));
                    command.Parameters.Add(CreateParameter("@IdDocumentoViaje", reservaDetalle.IdDocumentoViaje));
                    command.Parameters.Add(CreateParameter("@IdReserva", reserva.IdReserva));
                    command.Parameters.Add(CreateParameter("@IdSeguroViajero", reservaDetalle.IdSeguroViajero));
                    command.Parameters.Add(CreateParameter("@IdServicioAlojamiento", reservaDetalle.IdServicioAlojamiento));
                    command.Parameters.Add(CreateParameter("@IdServicioTraslado", reservaDetalle.IdServicioTraslado));
                    command.Parameters.Add(CreateParameter("@IdTipoDocumento", reservaDetalle.IdTipoDocumento));
                    command.Parameters.Add(CreateParameter("@Monto", reservaDetalle.Monto));
                    command.Parameters.Add(CreateParameter("@NumeroDocumento", reservaDetalle.NumeroDocumento, 8));
                    command.ExecuteNonQuery();

                }
                // Run the command.

                
                command.Transaction.Commit();
                command.Connection.Close();
            
            }
            catch (Exception e) {
                if (command != null) {
                    command.Transaction.Rollback();
                }
                throw e;
                
            }
        }
    
      

        public static List<ReservaDTO> GetInforme(int monto, DateTime fecha, bool efectuada)
        {
            SqlCommand command = GetDbSprocCommand("usp_Reserva_GetInforme");
            command.Parameters.Add(CreateParameter("@monto", monto));
            command.Parameters.Add(CreateParameter("@fechaReserva", fecha));
            command.Parameters.Add(CreateParameter("@efectuada", efectuada));
            return GetDTOList<ReservaDTO>(ref command);

        }

        public static List<ReservaDTO> GetReservasByCliente(string termino)
        {
            SqlCommand command = GetDbSprocCommand("usp_Reserva_GetByRazonSocialOrCuil");
            command.Parameters.Add(CreateParameter("@filtroCliente", termino, 50));


            List<ReservaDTO> dr = GetDTOList<ReservaDTO>(ref command);

            foreach (ReservaDTO re in dr)
            {
                re.Cliente = ClienteDB.GetClienteByID(re.IdCliente);
                
            }
            return dr;
        }
    }
    }

