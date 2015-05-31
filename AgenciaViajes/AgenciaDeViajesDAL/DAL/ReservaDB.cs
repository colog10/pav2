using AgenciaDeViajesDAL.Util;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDAL.Parsers
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
            SqlCommand command;

            if (reserva.IsNew)
            {
                command = GetDbSprocCommand("usp_Reservas_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDReserva", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_Reservas_Update");
                command.Parameters.Add(CreateParameter("@IDReserva", reserva.IdReserva));
                
            }

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
            
            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (reserva.IsNew)
            {
                reserva.IdReserva = (int)command.Parameters["@IDReserva"].Value;
            }
        }
    }
}
