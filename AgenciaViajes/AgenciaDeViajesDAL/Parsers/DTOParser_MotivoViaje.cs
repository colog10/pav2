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
    internal class DTOParser_MotivoViaje : DTOParserSQLClient
    {
        private int Ord_IdMotivoViaje;
        private int Ord_Descripcion;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_IdMotivoViaje = reader.GetOrdinal("IdMotivoViaje");
            Ord_Descripcion = reader.GetOrdinal("Descripcion");
        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            MotivoViajeDTO motivoViaje = new MotivoViajeDTO();

            // IdMotivoViaje
            if (!reader.IsDBNull(Ord_IdMotivoViaje))
            {
                motivoViaje.IdMotivoViaje = reader.GetInt32(Ord_IdMotivoViaje);
            }
            // Descripcion
            if (!reader.IsDBNull(Ord_Descripcion)) { motivoViaje.Descripcion = reader.GetString(Ord_Descripcion); }

            return motivoViaje;
        }
    }
}
