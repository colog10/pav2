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
    public class SeguroViajeroDB : DALBase
    {
        public static SeguroViajeroDTO GetSegurosViajerosByID(int IDSeguroViajero)
        {
            SqlCommand command = GetDbSprocCommand("usp_SegurosViajeros_GetByID");
            command.Parameters.Add(CreateParameter("@IDSeguroViajero", IDSeguroViajero));
            return GetSingleDTO<SeguroViajeroDTO>(ref command);
        }

        public static List<SeguroViajeroDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_SegurosViajeros_GetAll");
            return GetDTOList<SeguroViajeroDTO>(ref command);
        }

        public static void SaveSeguroViajero(ref SeguroViajeroDTO seguroViajero)
        {
            SqlCommand command;

            if (seguroViajero.IsNew)
            {
                command = GetDbSprocCommand("usp_SegurosViajeros_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDSeguroViajero", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_SegurosViajeros_Update");
                command.Parameters.Add(CreateParameter("@IDSeguroViajero", seguroViajero.IdSeguroViajero));
            }

            command.Parameters.Add(CreateParameter("@Comision", seguroViajero.Comision));
            command.Parameters.Add(CreateParameter("@Descripcion", seguroViajero.Descripcion, 50));
            command.Parameters.Add(CreateParameter("@Monto", seguroViajero.Monto));
            command.Parameters.Add(CreateParameter("@NumeroCompra", seguroViajero.NumeroCompra));
            command.Parameters.Add(CreateParameter("@TipoSeguroViajero", seguroViajero.TipoSeguroViajero));
            

            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (seguroViajero.IsNew)
            {
                seguroViajero.IdSeguroViajero = (int)command.Parameters["@IDSeguroViajero"].Value;
            }
        }
    }
}
