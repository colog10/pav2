using AgenciaDeViajesDAL.DAL;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesBLL
{
    public class CompraManager
    {
        public static void SaveCompra(CompraDTO compra)
        {
            CompraDB.SaveCompra(ref compra);
        }
    }
}
