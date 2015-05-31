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
    public class CobroDB : DALBase
    {
        public static CobroDTO GetCobroByID(int numeroCobro)
        {
            SqlCommand command = GetDbSprocCommand("usp_Cobro_GetByID");
            command.Parameters.Add(CreateParameter("@numeroCobro", numeroCobro));
            return GetSingleDTO<CobroDTO>(ref command);
        }

        public static List<CobroDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_cobro_GetAll");
            return GetDTOList<CobroDTO>(ref command);
        }

        public static void Savecobro(ref CobroDTO cobro)
        {
            SqlCommand command;

            if (cobro.IsNew)
            {
                command = GetDbSprocCommand("usp_Cobro_Insert");
                command.Parameters.Add(CreateOutputParameter("@numeroCobro", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_Cobro_Update");
                command.Parameters.Add(CreateParameter("@numeroCobro", cobro.numeroCobroDTO));
            }

            command.Parameters.Add(CreateParameter("@fechaCobro", cobro.fechaCobroDTO));
            command.Parameters.Add(CreateParameter("@numeroVenta", cobro.numeroVentaDTO));
            command.Parameters.Add(CreateParameter("@monto", cobro.montoDTO));

            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (cobro.IsNew)
            {
                cobro.numeroCobroDTO = (int)command.Parameters["@numeroCobro"].Value;
            }
        }
    }
}
