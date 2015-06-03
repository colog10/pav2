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
    public class TipoDocumentoDB : DALBase
    {
        public static TipoDocumentoDTO GetTipoDocumentoByID(int IDTipoDocumento)
        {
            SqlCommand command = GetDbSprocCommand("usp_TipoDocumento_GetByID");
            command.Parameters.Add(CreateParameter("@IDTipoDocumento", IDTipoDocumento));
            return GetSingleDTO<TipoDocumentoDTO>(ref command);
        }

        public static List<TipoDocumentoDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_TipoDocumento_GetAll");
            return GetDTOList<TipoDocumentoDTO>(ref command);
        }

        public static void SaveTipoDocumento(ref TipoDocumentoDTO TipoDocumento)
        {
            SqlCommand command;

            if (TipoDocumento.IsNew)
            {
                command = GetDbSprocCommand("usp_TipoDocumento_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDTipoDocumento", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_TipoDocumento_Update");
                command.Parameters.Add(CreateParameter("@IDTipoDocumento", TipoDocumento.idTipoDocumentoDTO));
            }


            command.Parameters.Add(CreateParameter("@Descripcion", TipoDocumento.descripcionDTO, 50));

            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (TipoDocumento.IsNew)
            {
                TipoDocumento.idTipoDocumentoDTO = (int)command.Parameters["@IDTipoDocumento"].Value;
            }
        }

    }
}
