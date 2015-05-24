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
    internal class DTOParser_EstadoCivil : DTOParserSQLClient
    {
        private int Ord_IdEstadoCivil;
        private int Ord_Descripcion;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_IdEstadoCivil = reader.GetOrdinal("IdEstadoCivil");
            Ord_Descripcion = reader.GetOrdinal("Descripcion");
        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            EstadoCivilDTO estadoCivil = new EstadoCivilDTO();

            // IDEstadoCivil
            if (!reader.IsDBNull(Ord_IdEstadoCivil))
            {
                estadoCivil.IdEstadoCivil = reader.GetInt32(Ord_IdEstadoCivil);
            }
            // Descripcion
            if (!reader.IsDBNull(Ord_Descripcion)) { estadoCivil.Descripcion = reader.GetString(Ord_Descripcion); }

            return estadoCivil;
        }
    }
}
