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
    public class CiudadDB : DALBase
    {
        public static CiudadDTO GetCiudadByID(int idCiudad)
        {
            SqlCommand command = GetDbSprocCommand("usp_Ciudad_GetByID");
            command.Parameters.Add(CreateParameter("@idCiudad", idCiudad));
            return GetSingleDTO<CiudadDTO>(ref command);
        }

        public static List<CiudadDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_Ciudad_GetAll");
            return GetDTOList<CiudadDTO>(ref command);
        }

        public static void SaveCiudad(ref CiudadDTO ciudad)
        {
            SqlCommand command;

            if (ciudad.IsNew)
            {
                command = GetDbSprocCommand("usp_Ciudad_Insert");
                command.Parameters.Add(CreateOutputParameter("@idCiudad", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_Ciudad_Update");
                command.Parameters.Add(CreateParameter("@idCiudad", ciudad.idCiudadDTO));
            }

            command.Parameters.Add(CreateParameter("@CiudadNombre", ciudad.ciudadNombreDTO, 20));
            command.Parameters.Add(CreateParameter("@idPais", ciudad.idPaisDTO, 3));
            command.Parameters.Add(CreateParameter("@CiudadDistrito", ciudad.ciudadDistritoDTO, 20));
            command.Parameters.Add(CreateParameter("@CiudadPoblacion", ciudad.ciudadPoblacionDTO));
            command.Parameters.Add(CreateParameter("@TipoDestino", ciudad.tipoDestinoDTO));


            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (ciudad.IsNew)
            {
                ciudad.idCiudadDTO = (int)command.Parameters["@idCiudad"].Value;
            }
        }

    }
}
