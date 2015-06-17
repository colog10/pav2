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
            return GetSingleDTO<ReservaDTO>(ref command);
        }

        public static List<ReservaDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_Reservas_GetAll");
            return GetDTOList<ReservaDTO>(ref command);
        }

        public static void SaveReserva(ref ReservaDTO reserva)
        {
            SqlTransaction transaccion = null;
            SqlCommand command;
            SqlCommand commandDetalle;

            try {
            command = GetDbSprocCommand("usp_Reservas_Insert");
            command.Parameters.Add(CreateOutputParameter("@IDReserva", SqlDbType.Int));
            transaccion = command.Connection.BeginTransaction();


            command.Parameters.Add(CreateParameter("@Comprada", reserva.Comprada));
            command.Parameters.Add(CreateParameter("@Efectuada", reserva.Efectuada));
            command.Parameters.Add(CreateParameter("@FechaReserva", reserva.FechaReserva));
            command.Parameters.Add(CreateParameter("@Idcliente", reserva.IdCliente));
            command.Parameters.Add(CreateParameter("@IdDetalleReserva", reserva.IdDetalleReserva));
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


            foreach (ReservaDetalleDTO reservaDetalle in reserva.DetallesReserva)
            {
                commandDetalle = GetDbSprocCommand("usp_ReservasDetalles_Insert");
                commandDetalle.Connection = command.Connection;
                commandDetalle.Transaction = transaccion;
                commandDetalle.Parameters.Add(CreateOutputParameter("@IDDetalleReserva", SqlDbType.Int));
                commandDetalle.Parameters.Add(CreateParameter("@Comprada", reservaDetalle.Comprada));
                commandDetalle.Parameters.Add(CreateParameter("@Efectuada", reservaDetalle.Efectuada));
                commandDetalle.Parameters.Add(CreateParameter("@IdDetallaReserva", reservaDetalle.IdDetallaReserva));
                commandDetalle.Parameters.Add(CreateParameter("@IdDocumentoViaje", reservaDetalle.IdDocumentoViaje));
                commandDetalle.Parameters.Add(CreateParameter("@IdReserva", reservaDetalle.IdReserva));
                commandDetalle.Parameters.Add(CreateParameter("@IdSeguroViajero", reservaDetalle.IdSeguroViajero));
                commandDetalle.Parameters.Add(CreateParameter("@IdServicioAlojamiento", reservaDetalle.IdServicioAlojamiento));
                commandDetalle.Parameters.Add(CreateParameter("@IdServicioTraslado", reservaDetalle.IdServicioTraslado));
                commandDetalle.Parameters.Add(CreateParameter("@IdTipoDocumento", reservaDetalle.IdTipoDocumento));
                commandDetalle.Parameters.Add(CreateParameter("@NumeroDocumento", reservaDetalle.NumeroDocumento, 8));
                commandDetalle.ExecuteNonQuery();
            }
            
            // Run the command.
            
            command.ExecuteNonQuery();
            command.Connection.Close();
            transaccion.Commit();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (reserva.IsNew)
            {
                reserva.IdReserva = (int)command.Parameters["@IDReserva"].Value;
            }
            }
            catch (Exception e) {
                if (transaccion != null) {
                    transaccion.Rollback();
                }
                throw e;
                
            }
        }

        
    }
}
