using AgenciaDeViajesDAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesBLL
{
    public class EstadoCivilManager
    {
        public static List<AgenciaDeViajesDTO.Entities.EstadoCivilDTO> GetEstadoCivil()
        {
            return EstadoCivilDB.GetAll();
        }

    }
}
