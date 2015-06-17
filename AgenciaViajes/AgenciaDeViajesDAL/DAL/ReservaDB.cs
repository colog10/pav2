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
            SqlCommand command = GetDbSprocCommand("usp_Pasajero_GetAll");
            return GetDTOList<ReservaDTO>(ref command);
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
    }
}
