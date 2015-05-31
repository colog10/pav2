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
    public class CompaniaAereaDB : DALBase
    {
        public static CompaniaAereaDTO GetEstadoCivilByID(int idCompaniaAerea)
        {
            SqlCommand command = GetDbSprocCommand("usp_CompaniaAerea_GetByID");
            command.Parameters.Add(CreateParameter("@idCompaniaAerea", idCompaniaAerea));
            return GetSingleDTO<CompaniaAereaDTO>(ref command);
        }

        public static List<CompaniaAereaDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_CompaniaAerea_GetAll");
            return GetDTOList<CompaniaAereaDTO>(ref command);
        }

        public static void SaveCompaniaAerea(ref CompaniaAereaDTO companiaAerea)
        {
            SqlCommand command;

            if (companiaAerea.IsNew)
            {
                command = GetDbSprocCommand("usp_CompaniaAerea_Insert");
                command.Parameters.Add(CreateOutputParameter("@idCompaniaAerea", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_CompaniaAerea_Update");
                command.Parameters.Add(CreateParameter("@idCompaniaAerea", companiaAerea.idCompaniaAereaDTO));
            }

            command.Parameters.Add(CreateParameter("@nombre", companiaAerea.nombreDTO, 50));
            command.Parameters.Add(CreateParameter("@telefono", companiaAerea.telefonoDTO, 13));
            command.Parameters.Add(CreateParameter("@paginaWeb", companiaAerea.paginaWebDTO, 50));

            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (companiaAerea.IsNew)
            {
                companiaAerea.idCompaniaAereaDTO = (int)command.Parameters["@idCompaniaAerea"].Value;
            }
        }
    }
}
