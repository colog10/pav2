using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaDeViajesDTO.Entities;
using AgenciaDeViajesDAL.DAL;

namespace AgenciaDeViajesBLL
{
    public class EmpleadoManager 
    {
        public static List<EmpleadoDTO> GetEmpleados()
        {
            return EmpleadoDB.GetAll();
        }

        public static List<EmpleadoDTO> GetEmpleados(string termino)
        {
            return EmpleadoDB.GetByTermino(termino);
        }

        public static void SaveEmpleado(EmpleadoDTO empleado)
        {
            EmpleadoDB.SaveEmpleado(ref empleado);

        }

        public static EmpleadoDTO GetEmpleado(int idEmpleado)
        {
            return EmpleadoDB.GetEmpleadoByID(idEmpleado);
        }

        public static void DeleteEmpleado(int idEmpleado)
        {
            EmpleadoDB.DeleteEmpleado(idEmpleado);
        }
    }
}
