using AgenciaDeViajesDAL.Util;
using AgenciaDeViajesDTO.Entities;
using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgenciaDeViajesDAL.DAL
{
    public class EmpleadoDB : DALBase
    {
        public static EmpleadoDTO GetEmpleadoByID(int idEmpleado)
        {
            SqlCommand command = GetDbSprocCommand("usp_Empleado_GetByID");
            command.Parameters.Add(CreateParameter("@idEmpleado", idEmpleado));
            return GetSingleDTO<EmpleadoDTO>(ref command);
        }

        public static List<EmpleadoDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_Empleado_GetAll");
            return GetDTOList<EmpleadoDTO>(ref command);
        }

        public static void SaveEmpleado(ref EmpleadoDTO empleado)
        {
            SqlCommand command;
            
            UsuarioDTO usuario = empleado.Usuario;

            if (empleado.IsNew)
            {
                command = GetDbSprocCommand("usp_Empleado_Insert");
            }
            else
            {
                command = GetDbSprocCommand("usp_Empleado_Update");
                command.Parameters.Add(CreateParameter("@idEmpleado", empleado.IdEmpleado));
            }

            command.Parameters.Add(CreateParameter("@legajo", empleado.Legajo));
            command.Parameters.Add(CreateParameter("@apellido", empleado.Apellido, 30));
            command.Parameters.Add(CreateParameter("@nombre", empleado.Nombre, 30));
            command.Parameters.Add(CreateParameter("@fechaAlta", empleado.FechaAlta));
            if (empleado.FechaBaja != CommonBase.DateTime_NullValue)
                command.Parameters.Add(CreateParameter("@fechaBaja", empleado.FechaBaja.Value));
            command.Parameters.Add(CreateParameter("@idUsuario", empleado.IdUsuario));
            command.Parameters.Add(CreateParameter("@activo", empleado.Activo));
            command.Parameters.Add(CreateParameter("@supervisor", empleado.Supervisor));

            // Run the command.
            command.Connection.Open();
            
            command.ExecuteNonQuery();

            //if (empleado.IsNew)
            //{
            //    empleado.IdEmpleado = (int)command.Parameters["@idEmpleado"].Value;

            //}
            command.Connection.Close();
        }

        public static List<EmpleadoDTO> GetByTermino(string termino)
        {
            SqlCommand command = GetDbSprocCommand("usp_Empleado_GetByTermino");
            command.Parameters.Add(CreateParameter("@Termino", termino, 70));
            return GetDTOList<EmpleadoDTO>(ref command);
        }
    }
}
