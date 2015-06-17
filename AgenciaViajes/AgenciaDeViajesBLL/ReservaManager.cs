using AgenciaDeViajesDAL.DAL;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesBLL
{
    public class ReservaManager
    {

        public static void Save(ReservaDTO reserva)
        {
            ReservaDB.SaveReserva(ref reserva);
        }



        public static List<ReservaDTO> Reservas_getAll()
        {
            return ReservaDB.GetAll();
        }

            public static List<ReservaDTO> GetInforme(int monto, DateTime fecha, bool efectuada)
        {
            return ReservaDB.GetInforme(monto, fecha, efectuada);

        }
    
    }
}
