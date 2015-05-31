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
    class DTOParser_TipoDocumento : DTOParserSQLClient
    {


        private int Ord_TipoDocumento;

        private int Ord_descripcionDTO;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {

            Ord_TipoDocumento = reader.GetOrdinal("idTipoDocumento");
            Ord_descripcionDTO = reader.GetOrdinal("descripcion");


        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            TipoDocumentoDTO TipoDocumento = new TipoDocumentoDTO();

            if (!reader.IsDBNull(Ord_TipoDocumento))
            {
                TipoDocumento.idTipoDocumentoDTO = reader.GetInt32(Ord_TipoDocumento);
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
