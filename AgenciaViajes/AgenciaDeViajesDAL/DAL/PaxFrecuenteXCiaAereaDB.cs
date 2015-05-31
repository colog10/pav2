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
    public class PaxFrecuenteXCiaAereaDB : DALBase
    {
        public static PaxFrecuenteXCiaAereaDTO GetPaxFrecuenteByID(int IDPasajero, int IDCompaniaAerea)
        {
            SqlCommand command = GetDbSprocCommand("usp_PaxFrecuentesXCiaAerea_GetByID");
            command.Parameters.Add(CreateParameter("@IDPasajero", IDPasajero));
            command.Parameters.Add(CreateParameter("@IDCompaniaAerea", IDCompaniaAerea));
            return GetSingleDTO<PaxFrecuenteXCiaAereaDTO>(ref command);
        }

        public static List<PaxFrecuenteXCiaAereaDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_PaxFrecuentesXCiaAerea_GetAll");
            return GetDTOList<PaxFrecuenteXCiaAereaDTO>(ref command);
        }

        public static void SavePaxFrecuente(ref PaxFrecuenteXCiaAereaDTO paxFrecuente)
        {
            SqlCommand command;

            if (paxFrecuente.IsNew)
            {
                command = GetDbSprocCommand("usp_PaxFrecuentesXCiaAerea_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDPasajero", SqlDbType.Int));
                command.Parameters.Add(CreateOutputParameter("@IDCompaniaAerea", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_PaxFrecuentesXCiaAerea_Update");
                command.Parameters.Add(CreateParameter("@IDPasajero", paxFrecuente.IdPasajero));
                command.Parameters.Add(CreateParameter("@IDCompaniaAerea", paxFrecuente.IdCompaniaAerea));
            }

            command.Parameters.Add(CreateParameter("@NroPaxFrecuente", paxFrecuente.NroPaxFrecuente));

            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (paxFrecuente.IsNew)
            {
                paxFrecuente.IdPasajero = (int)command.Parameters["@IDPasajero"].Value;
                paxFrecuente.IdCompaniaAerea = (int)command.Parameters["@IDCompaniaAerea"].Value;
            }
        }
    }
}
