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
    class TipoSeguroViajeroDB : DALBase
    {
        public static TipoSeguroViajeroDTO GetTipoSeguroViajeroByID(int IDTipoSeguroViajero)
        {
            SqlCommand command = GetDbSprocCommand("usp_TipoSeguroViajero_GetByID");
            command.Parameters.Add(CreateParameter("@IDTipoSeguroViajero", IDTipoSeguroViajero));
            return GetSingleDTO<TipoSeguroViajeroDTO>(ref command);
        }

        public static List<TipoSeguroViajeroDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_TipoSeguroViajero_GetAll");
            return GetDTOList<TipoSeguroViajeroDTO>(ref command);
        }

        public static void SaveTipoSeguroViajero(ref TipoSeguroViajeroDTO TipoSeguroViajero)
        {
            SqlCommand command;

            if (TipoSeguroViajero.IsNew)
            {
                command = GetDbSprocCommand("usp_TipoSeguroViajero_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDTipoSeguroViajero", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_TipoSeguroViajero_Update");
                command.Parameters.Add(CreateParameter("@IDTipoSeguroViajero", TipoSeguroViajero.tipoSeguroViajeroDTO));
            }


            command.Parameters.Add(CreateParameter("@Descripcion", TipoSeguroViajero.descripcionDTO, 50));

            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (TipoSeguroViajero.IsNew)
            {
                TipoSeguroViajero.tipoSeguroViajeroDTO = (int)command.Parameters["@IDTipoSeguroViajero"].Value;
            }
        }

    }
}
