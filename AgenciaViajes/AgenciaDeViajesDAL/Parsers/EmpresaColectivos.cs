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
    internal class EmpresaColectivos : DTOParserSQLClient
    {
        private int Ord_idEmpresaColectivos;
        private int Ord_nombre;
        private int Ord_telefono;
        private int Ord_paginaWeb;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_idEmpresaColectivos = reader.GetOrdinal("idEmpresaColectivos");
            Ord_nombre = reader.GetOrdinal("nombre");
            Ord_telefono = reader.GetOrdinal("telefono");
            Ord_paginaWeb = reader.GetOrdinal("paginaWeb");
        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            EmpresaColectivoDTO empresaColectivosDTO = new EmpresaColectivoDTO();
            
            //idEmpresaColectivos
            if (!reader.IsDBNull(Ord_idEmpresaColectivos)) { empresaColectivosDTO.idEmpresaColectivoDTO = reader.GetInt32(Ord_idEmpresaColectivos);}

            //nombre
            if (!reader.IsDBNull(Ord_nombre)) { empresaColectivosDTO.nombreDTO = reader.GetString(Ord_nombre);}

            //telefono
            if (!reader.IsDBNull(Ord_telefono)) { empresaColectivosDTO.telefonoDTO = reader.GetString(Ord_telefono);}

            //paginaWeb
            if (!reader.IsDBNull(Ord_paginaWeb)) { empresaColectivosDTO.paginaWebDTO = reader.GetString(Ord_paginaWeb);}


            return empresaColectivosDTO;
        }
    }
}
