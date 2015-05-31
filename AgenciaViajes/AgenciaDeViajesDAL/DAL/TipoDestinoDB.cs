using AgenciaDeViajesDAL.Util;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDAL.Parsers
{
    class TipoDestinoDB : DALBase
    {
        public static TipoDestinoDTO GetTipoDestinoByID(int IDTipoDestino)
        {
            SqlCommand command = GetDbSprocCommand("usp_TipoDestino_GetByID");
            command.Parameters.Add(CreateParameter("@IDTipoDestino", IDTipoDestino));
            return GetSingleDTO<TipoDestinoDTO>(ref command);
        }

        public static List<TipoDestinoDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_TipoDestino_GetAll");
            return GetDTOList<TipoDestinoDTO>(ref command);
        }

        public static void SaveTipoDestino(ref TipoDestinoDTO TipoDestino)
        {
            SqlCommand command;

            if (TipoDestino.IsNew)
            {
                command = GetDbSprocCommand("usp_TipoDestino_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDTipoDestino", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_TipoDestino_Update");
                command.Parameters.Add(CreateParameter("@IDTipoAlojamiento", TipoDestino.idTipoDestinoDTO));
            }


            command.Parameters.Add(CreateParameter("@Descripcion", TipoDestino.descripcionDTO, 50));

            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (TipoDestino.IsNew)
            {
                TipoDestino.idTipoDestinoDTO = (int)command.Parameters["@IDTipoDestino"].Value;
            }
        }

    }
}
