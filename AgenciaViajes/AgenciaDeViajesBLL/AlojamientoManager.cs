using AgenciaDeViajesDAL.DAL;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesBLL
{
    public class AlojamientoManager
    {

        public static List<AlojamientoDTO> GetAll()
        {
            return AlojamientoDB.GetAll();
        }
    }
}
