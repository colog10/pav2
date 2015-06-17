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
    internal class DTOParser_Alojamiento : DTOParserSQLClient
    {
        private int Ord_idAlojamiento;
        private int Ord_idTipoAlojamiento;
        private int Ord_domicilio;
        private int Ord_nombre;
        private int Ord_telefono;

        internal override void PopulateOrdinals (SqlDataReader reader)
        {
            Ord_idAlojamiento = reader.GetOrdinal("idAlojamiento");
            Ord_idTipoAlojamiento = reader.GetOrdinal("idTipoAlojamiento");
            Ord_domicilio = reader.GetOrdinal("domicilio");
            Ord_nombre = reader.GetOrdinal("nombre");
            Ord_telefono = reader.GetOrdinal("telefono");
        }

        internal override DTOBase PopulateDTO (SqlDataReader reader)
        {
            AlojamientoDTO alojamientoDTO = new AlojamientoDTO();
            
            //idAlojamiento
            if(!reader.IsDBNull(Ord_idAlojamiento)) {alojamientoDTO.idAlojamientoDTO = reader.GetInt32(Ord_idAlojamiento);}

            //idTipoAlojamiento
            if(!reader.IsDBNull(Ord_idTipoAlojamiento)){alojamientoDTO.idTipoAlojamientoDTO = reader.GetInt32(Ord_idTipoAlojamiento);}

            //domicilio
            if(!reader.IsDBNull(Ord_domicilio)){alojamientoDTO.domicilioDTO = reader.GetString(Ord_domicilio);}

            //nombre
            if(!reader.IsDBNull(Ord_nombre)) {alojamientoDTO.nombreDTO = reader.GetString(Ord_nombre);}

            //Telefono
            if (!reader.IsDBNull(Ord_telefono)) { alojamientoDTO.numeroTelefonoDTO = reader.GetInt32(Ord_telefono); }


            return alojamientoDTO;
        }


    }
}
