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
    class DTOParser_TipoDestino : DTOParserSQLClient
    {


        private int Ord_idTipoDestino;

        private int Ord_descripcionDTO;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {

            Ord_idTipoDestino = reader.GetOrdinal("idTipoAlojamiento");
            Ord_descripcionDTO = reader.GetOrdinal("descripcion");


        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            TipoDestinoDTO TipoDestino = new TipoDestinoDTO();

            if (!reader.IsDBNull(Ord_idTipoDestino))
            {
                TipoDestino.idTipoDestinoDTO = reader.GetInt32(Ord_idTipoDestino);
            }
            // IdCliente
            if (!reader.IsDBNull(Ord_descripcionDTO))
            {
                TipoDestino.descripcionDTO = reader.GetString(Ord_descripcionDTO);
            }


            return TipoDestino;
        }
    }
}
