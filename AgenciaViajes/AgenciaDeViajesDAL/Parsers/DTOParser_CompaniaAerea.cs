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
    class DTOParser_CompaniaAerea
    {
        private int Ord_idCompaniaAerea;
        private int Ord_nombre;
        private int Ord_telefono;
        private int Ord_paginaWeb;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_idCompaniaAerea = reader.GetOrdinal("idCompaniaAerea");
            Ord_nombre = reader.GetOrdinal("nombre");
            Ord_telefono = reader.GetOrdinal("telefono");
            Ord_paginaWeb = reader.GetOrdinal("paginaWeb");
        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            CompaniaAereaDTO companiaAereaDTO = new CompaniaAereaDTO();
            //idCompaniaAerea
            if (!reader.IsDBNull(Ord_idCompaniaAerea)) { companiaAereaDTO.idCompaniaAereaDTO = reader.GetInt32(Ord_idCompaniaAerea); }

            //nombre
            if (!reader.IsDBNull(Ord_nombre)) { companiaAereaDTO.nombreDTO = reader.GetString(Ord_nombre); }

            //telefono
            if (!reader.IsDBNull(Ord_telefono)) { companiaAereaDTO.telefonoDTO = reader.GetString(Ord_telefono); }

            //paginaWeb
            if (!reader.IsDBNull(Ord_paginaWeb)) { companiaAereaDTO.paginaWebDTO = reader.GetString(Ord_paginaWeb); }

            return companiaAereaDTO;
        }
    }
}