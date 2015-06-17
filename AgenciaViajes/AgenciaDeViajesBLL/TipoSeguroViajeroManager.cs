using AgenciaDeViajesDAL.DAL;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesBLL
{
    public class TipoSeguroViajeroManager
    {
        public static List<TipoSeguroViajeroDTO> GetAll()
        {
            return TipoSeguroViajeroDB.GetAll();
        }
    }
}
