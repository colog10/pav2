using AgenciaDeViajesDAL.Util;
using AgenciaDeViajesDTO.Entities;
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

            if (empleado.IsNew)
            {
                command = GetDbSprocCommand("usp_Empleado_Insert");
                command.Parameters.Add(CreateOutputParameter("@idEmpleado", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_Empleado_Update");
                command.Parameters.Add(CreateParameter("@idEmpleado", empleado.idEmpleadoDTO));
            }

            command.Parameters.Add(CreateParameter("@legajo", empleado.legajoDTO));
            command.Parameters.Add(CreateParameter("@apellido", empleado.apellidoDTO, 30));
            command.Parameters.Add(CreateParameter("@nombre", empleado.nombreDTO, 30));
            command.Parameters.Add(CreateParameter("@fechaAlta", empleado.fechaAltaDTO));
            command.Parameters.Add(CreateParameter("@fechaBaja", empleado.fechaBajaDTO));
            command.Parameters.Add(CreateParameter("@idUsuario", empleado.idUsuarioDTO));
            command.Parameters.Add(CreateParameter("@activo", empleado.activoDTO));
            command.Parameters.Add(CreateParameter("@supervisor", empleado.supervisorDTO));

            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (empleado.IsNew)
            {
                empleado.idEmpleadoDTO = (int)command.Parameters["@idEmpleado"].Value;
            }
        }

    }
}
