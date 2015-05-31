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
    class DTOParser_TipoAlojamiento: DTOParserSQLClient
    {


        private int Ord_idTipoAlojamiento;

        private int Ord_descripcionDTO;
      
        internal override void PopulateOrdinals(SqlDataReader reader)
        {

            Ord_idTipoAlojamiento = reader.GetOrdinal("idTipoDestino");
            Ord_descripcionDTO = reader.GetOrdinal("descripcion");
          

        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            TipoAlojamientoDTO TipoAlojamiento = new TipoAlojamientoDTO();
           
            if (!reader.IsDBNull(Ord_idTipoAlojamiento))
            {
                TipoAlojamiento.idTipoAlojamientoDTO = reader.GetInt32(Ord_idTipoAlojamiento);
            }
            // IdCliente
            if (!reader.IsDBNull(Ord_descripcionDTO))
            {
                TipoAlojamiento.descripcionDTO = reader.GetString(Ord_descripcionDTO);
            }
           

            return TipoAlojamiento;
        }
    }
}
