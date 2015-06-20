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
    public class ReservaDetalleDB : DALBase
    {
        public static ReservaDetalleDTO GetReservasDetallesByID(int IDReservaDetalle)
        {
            SqlCommand command = GetDbSprocCommand("usp_ReservasDetalles_GetByID");
            command.Parameters.Add(CreateParameter("@IDDetalleReserva", IDReservaDetalle));
            ReservaDetalleDTO dr = GetSingleDTO<ReservaDetalleDTO>(ref command);

            dr.Pasajero = PasajeroDB.GetPasajeroByID(dr.IdPasajero);
            dr.ServicioAlojamiento = ServicioAlojamientoDB.GetServicioAlojamientoByID(dr.IdServicioAlojamiento);
            dr.Seguro = SeguroViajeroDB.GetSegurosViajerosByID(dr.IdSeguroViajero);
            return dr;
        }

        public static List<ReservaDetalleDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_ReservasDetalle_GetAll");
            List<ReservaDetalleDTO> dr = GetDTOList<ReservaDetalleDTO>(ref command);
            foreach (ReservaDetalleDTO re in dr)
            {
                re.Pasajero = PasajeroDB.GetPasajeroByID(re.IdPasajero);
                re.ServicioAlojamiento = ServicioAlojamientoDB.GetServicioAlojamientoByID(re.IdServicioAlojamiento);
                re.Seguro = SeguroViajeroDB.GetSegurosViajerosByID(re.IdSeguroViajero);
            }
            return dr;
        }
        public static ReservaDetalleDTO GetReservasGetByDocumento(int documento)
        {
            SqlCommand command = GetDbSprocCommand("usp_ReservasDetalle_GetByDocumento");
            command.Parameters.Add(CreateParameter("@Documento", documento));
            return GetSingleDTO<ReservaDetalleDTO>(ref command);
        }
        public static void SaveReservaDetalle(ref ReservaDetalleDTO reservaDetalle)
        {
            SqlCommand command;

            if (reservaDetalle.IsNew)
            {
                command = GetDbSprocCommand("usp_ReservasDetalles_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDDetalleReserva", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_ReservasDetalles_Update");
                command.Parameters.Add(CreateParameter("@IDDetalleReserva", reservaDetalle.IdDetallaReserva));

            }

            command.Parameters.Add(CreateParameter("@Comprada", reservaDetalle.Comprada));
            command.Parameters.Add(CreateParameter("@Efectuada", reservaDetalle.Efectuada));
            command.Parameters.Add(CreateParameter("@IdDetallaReserva", reservaDetalle.IdDetallaReserva));
            command.Parameters.Add(CreateParameter("@IdDocumentoViaje", reservaDetalle.IdDocumentoViaje));
            command.Parameters.Add(CreateParameter("@IdReserva", reservaDetalle.IdReserva));
            command.Parameters.Add(CreateParameter("@IdSeguroViajero", reservaDetalle.IdSeguroViajero));
            command.Parameters.Add(CreateParameter("@IdServicioAlojamiento", reservaDetalle.IdServicioAlojamiento));
            command.Parameters.Add(CreateParameter("@IdServicioTraslado", reservaDetalle.IdServicioTraslado));
            command.Parameters.Add(CreateParameter("@IdTipoDocumento", reservaDetalle.IdTipoDocumento));
            command.Parameters.Add(CreateParameter("@NumeroDocumento", reservaDetalle.NumeroDocumento, 8));


            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (reservaDetalle.IsNew)
            {
                reservaDetalle.IdDetallaReserva = (int)command.Parameters["@IdDetallaReserva"].Value;
            }
        }
    }
}
