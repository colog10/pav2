using AgenciaDeViajesDAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesBLL
{
    public class CompaniaAereaManager
    {
        public static object GetAll()
        {
            return CompaniaAereaDB.GetAll();
        }
    }
}
