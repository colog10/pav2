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
    internal class DTOParser_Ciudad : DTOParser_Cliente
    {
        private int Ord_idCiudad;
        private int Ord_CiudadNombre;
        private int Ord_idPais;
        private int Ord_CiudadDistrito;
        private int Ord_CiudadPoblacion;
        private int Ord_TipoDestino;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_idCiudad = reader.GetOrdinal("idCiudad");
            Ord_CiudadNombre = reader.GetOrdinal("CiudadNombre");
            Ord_idPais = reader.GetOrdinal("PaisCodigo");
            Ord_CiudadDistrito = reader.GetOrdinal("CiudadDistrito");
            Ord_CiudadPoblacion = reader.GetOrdinal("CiudadPoblacion");
            Ord_TipoDestino = reader.GetOrdinal("TipoDestino");
        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            CiudadDTO ciudadDTO = new CiudadDTO();

            //idCiudad
            if (!reader.IsDBNull(Ord_idCiudad)) { ciudadDTO.idCiudadDTO =  reader.GetInt32(Ord_idCiudad);}

            //CiudadNombre
            if (!reader.IsDBNull(Ord_CiudadNombre)) {ciudadDTO.ciudadNombreDTO = reader.GetString(Ord_CiudadNombre) ;}

            //idPais
            if (!reader.IsDBNull(Ord_idPais)) { ciudadDTO.idPaisDTO = reader.GetString(Ord_idPais);}

            //CiudadDistrito
            if (!reader.IsDBNull(Ord_CiudadDistrito)) { ciudadDTO.ciudadDistritoDTO = reader.GetString(Ord_CiudadDistrito);}

            //CiudadPoblacion
            if (!reader.IsDBNull(Ord_CiudadPoblacion)) { ciudadDTO.ciudadPoblacionDTO = reader.GetInt32(Ord_CiudadPoblacion); }

            //TipoDestino
            if(!reader.IsDBNull(Ord_TipoDestino)) {ciudadDTO.tipoDestinoDTO = reader.GetInt32(Ord_TipoDestino);}
            return ciudadDTO;
        }
    

    }
}
