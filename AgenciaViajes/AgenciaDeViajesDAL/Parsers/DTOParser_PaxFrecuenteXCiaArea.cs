using AgenciaDeViajesDAL.Util;
using AgenciaDeViajesDTO.Entities;
using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDAL.Parsers
{
    internal class DTOParser_PaxFrecuenteXCiaArea : DTOParserSQLClient
    {
        private int Ord_IdPasajero;
        private int Ord_IdCompaniaAerea;
        private int Ord_NroPaxFrecuente;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_IdPasajero = reader.GetOrdinal("IdPasajero");
            Ord_IdCompaniaAerea = reader.GetOrdinal("IdCompaniaAerea");
            Ord_NroPaxFrecuente = reader.GetOrdinal("NroPaxFrecuente");
        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            PaxFrecuenteXCiaAereaDTO paxFrecuenteXCiaArea = new PaxFrecuenteXCiaAereaDTO();
            // IdPasajero
            if (!reader.IsDBNull(Ord_IdPasajero))
            {
                paxFrecuenteXCiaArea.IdPasajero = reader.GetInt32(Ord_IdPasajero);
            }
            // IdCompaniaAerea
            if (!reader.IsDBNull(Ord_IdCompaniaAerea))
            {
                paxFrecuenteXCiaArea.IdCompaniaAerea = reader.GetInt32(Ord_IdCompaniaAerea);
            }
            // NroPaxFrecuente
            if (!reader.IsDBNull(Ord_NroPaxFrecuente))
            {
                paxFrecuenteXCiaArea.NroPaxFrecuente = reader.GetInt32(Ord_NroPaxFrecuente);
            }
            return paxFrecuenteXCiaArea;
        }
    }
}
