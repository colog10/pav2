using AgenciaDeViajesDAL.DAL;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesBLL
{
    public class ClienteManager
    {
        public static List<ClienteDTO> GetClienteByRazonSocialOrCuil(string filtroBusqueda)
        {
            return ClienteDB.GetClientesByRazonSocialOrCuil(filtroBusqueda);
        }
    }
}
