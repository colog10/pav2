using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaDeViajesDTO.Entities;
using AgenciaDeViajesDAL.DAL;


namespace AgenciaDeViajesBLL
{
    public class OperadorTuristicoManager
    {
        public static List<OperadorTuristicoDTO> GetOperadorTuristico()
        {
            return OperadorTuristicoDB.GetAll();
        }

        public static List<OperadorTuristicoDTO> GetOperadorTuristico(string termino)
        {
            return OperadorTuristicoDB.GetByTermino(termino);
        }

        public static void SaveOperadorTuristico(OperadorTuristicoDTO operadorTuristico)
        {
            OperadorTuristicoDB.SaveOperadorTuristico(ref operadorTuristico);

        }

    }
}
