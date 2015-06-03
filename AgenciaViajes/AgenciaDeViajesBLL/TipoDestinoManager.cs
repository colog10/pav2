using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaDeViajesDTO.Entities;
using AgenciaDeViajesDAL.DAL;

namespace AgenciaDeViajesBLL
{
    public class TipoDestinoManager
    {
        public static List<TipoDestinoDTO> GettiposDeDestino()
        {
            return TipoDestinoDB.GetAll();
        }



    }
}
