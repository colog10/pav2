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
    class DTOParser_TipoSeguroViajero : DTOParserSQLClient
    {


        private int Ord_TipoSeguroViajero;

        private int Ord_descripcionDTO;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {

            Ord_TipoSeguroViajero = reader.GetOrdinal("idTipoSeguroViajero");
            Ord_descripcionDTO = reader.GetOrdinal("descripcion");


        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            TipoSeguroViajeroDTO TipoDocumento = new TipoSeguroViajeroDTO();

            if (!reader.IsDBNull(Ord_TipoSeguroViajero))
            {
                TipoDocumento.tipoSeguroViajeroDTO = reader.GetInt32(Ord_TipoSeguroViajero);
            }
            // IdCliente
            if (!reader.IsDBNull(Ord_descripcionDTO))
            {
                TipoDocumento.descripcionDTO = reader.GetString(Ord_descripcionDTO);
            }


            return TipoDocumento;
        }
    }
}
