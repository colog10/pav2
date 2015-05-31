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
    public class EstadoCivilDB : DALBase
    {
        public static EstadoCivilDTO GetEstadoCivilByID(int IDEstadoCivil)
        {
            SqlCommand command = GetDbSprocCommand("usp_EstadosCiviles_GetByID");
            command.Parameters.Add(CreateParameter("@IDEstadoCivil", IDEstadoCivil));
            return GetSingleDTO<EstadoCivilDTO>(ref command);
        }

        public static List<EstadoCivilDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_EstadosCiviles_GetAll");
            return GetDTOList<EstadoCivilDTO>(ref command);
        }

        public static void SaveEstadoCivil(ref EstadoCivilDTO EstadoCivil)
        {
            SqlCommand command;

            if (EstadoCivil.IsNew)
            {
                command = GetDbSprocCommand("usp_EstadosCiviles_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDEstadoCivil", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_EstadosCiviles_Update");
                command.Parameters.Add(CreateParameter("@IDEstadoCivil", EstadoCivil.IdEstadoCivil));
            }

            command.Parameters.Add(CreateParameter("@Descripcion", EstadoCivil.Descripcion, 30));

            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (EstadoCivil.IsNew)
            {
                EstadoCivil.IdEstadoCivil = (int)command.Parameters["@IDEstadoCivil"].Value;
            }
        }

    }
}
