using AgenciaDeViajesDAL.DAL;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesBLL
{
    public class DetalleReservaManager
    {

        public static ReservaDetalleDTO Reservas_ReservaDTO(int documento)
        {
            return ReservaDetalleDB.GetReservasGetByDocumento(documento);
        }

        public static void Save(ReservaDTO reserva)
        {
            // ReservaDetalleDB.SaveReservaDetalle(ref reserva);
        }



        public static List<ReservaDetalleDTO> ReservasDetalle_getAll()
        {
            return ReservaDetalleDB.GetAll();
        }

        public static List<ReservaDetalleDTO> GetInforme(int monto, DateTime fecha, bool efectuada)
        {
            //  return ReservaDetalleDB.GetInforme(monto, fecha, efectuada);
            return null;
        }
    }
}
