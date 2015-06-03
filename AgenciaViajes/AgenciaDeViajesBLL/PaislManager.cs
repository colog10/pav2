using AgenciaDeViajesDAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesBLL
{
    public class PaislManager
    {
        public static List<AgenciaDeViajesDTO.Entities.PaisDTO> GetPais()
        {
            return PaisDB.GetAll();
        }

    }
}
