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
    public class UsuarioDB : DALBase
    {
        public static UsuarioDTO GetUsuarioByID(int IDUsuario)
        {
            SqlCommand command = GetDbSprocCommand("usp_Usuario_GetByID");
            command.Parameters.Add(CreateParameter("@IDUsuario", IDUsuario));
            return GetSingleDTO<UsuarioDTO>(ref command);
        }

        public static List<UsuarioDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_Usuario_GetAll");
            return GetDTOList<UsuarioDTO>(ref command);
        }

        public static void SaveUsuario(ref UsuarioDTO Usuario)
        {
            SqlCommand command;

            if (Usuario.IsNew)
            {
                command = GetDbSprocCommand("usp_Usuario_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDUsuario", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_Usuario_Update");
                command.Parameters.Add(CreateParameter("@IDUsuario", Usuario.IdUsuario));
            }


            command.Parameters.Add(CreateParameter("@Comision", Usuario.Activo));
            command.Parameters.Add(CreateParameter("@FechaLlegada", Usuario.FechaAlta));
            command.Parameters.Add(CreateParameter("@FechaReserva", Usuario.FechaBaja));
            command.Parameters.Add(CreateParameter("@FechaSalida", Usuario.Nombre,50));
            command.Parameters.Add(CreateParameter("@IDCompaniaAerea", Usuario.Password,8));
            
            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (Usuario.IsNew)
            {
                Usuario.IdUsuario = (int)command.Parameters["@IDUsuario"].Value;
            }
        }
       
    }
}
