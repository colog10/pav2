using AgenciaDeViajesDAL.DAL;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesBLL
{
    public class PasajeroManager
    {
        public static List<PasajeroDTO> GetPasajeros()
        {
            return PasajeroDB.GetAll();
        }

        public static List<PasajeroDTO> GetPasajeros(string termino)
        {
            return PasajeroDB.GetByTermino(termino);
        }

        public static void SavePasajero(PasajeroDTO pasajero)
        {
            PasajeroDB.SavePasajero(ref pasajero);

        }
        public static PasajeroDTO GetPasajeroByID(int idPasajero)
        {
            return PasajeroDB.GetPasajeroByID(idPasajero);
        }
    }
}
