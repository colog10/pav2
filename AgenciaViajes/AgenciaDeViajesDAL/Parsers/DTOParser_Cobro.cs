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
    internal class DTOParser_Cobro : DTOParserSQLClient
    {
        private int Ord_numeroCobro;
        private int Ord_FechaCobro;
        private int Ord_numeroVenta;
        private int Ord_monto;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_numeroCobro = reader.GetOrdinal("numeroCobro");
            Ord_FechaCobro = reader.GetOrdinal("FechaCobro");
            Ord_numeroVenta = reader.GetOrdinal("numeroVenta");
            Ord_monto = reader.GetOrdinal("monto");
        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            CobroDTO cobroDTO = new CobroDTO();

            //numeroCobro
            if (!reader.IsDBNull(Ord_numeroCobro)) { cobroDTO.numeroCobroDTO = reader.GetInt32(Ord_numeroCobro);}

            //FechaCobro
            if (!reader.IsDBNull(Ord_FechaCobro)) { cobroDTO.fechaCobroDTO = reader.GetDateTime(Ord_FechaCobro);}

            //numeroVenta
            if (!reader.IsDBNull(Ord_numeroVenta)) { cobroDTO.numeroCobroDTO = reader.GetInt32(Ord_numeroVenta);}

            //monto
            if (!reader.IsDBNull(Ord_monto)) { cobroDTO.montoDTO = reader.GetFloat(Ord_monto);}

            return cobroDTO;
        }
    }
}
