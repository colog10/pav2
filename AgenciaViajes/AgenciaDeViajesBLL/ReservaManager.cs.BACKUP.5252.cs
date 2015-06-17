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

<<<<<<< HEAD
        public static List<ReservaDTO> GetInforme(int monto, DateTime fecha, bool efectuada)
        {
            return ReservaDB.GetInforme(monto, fecha, efectuada);
=======
        public static List<ReservaDTO> Reservas_ReservaDTO()
        {
            return ReservaDB.GetReservasByName();
>>>>>>> 1450c0d803a0efe6f65c84f903b684a1ebe00f32
        }
    }
}
