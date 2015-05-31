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
    class DTOParser_Usuario : DTOParserSQLClient
    {


        private int Ord_usuarioDTO;
        private int Ord_activoDTO;
        private int Ord_fechaAltaDTO;
        private int Ord_fechaBajaDTO;
        private int Ord_nombreDTO;
        private int Ord_passwordDTO;
       

        internal override void PopulateOrdinals(SqlDataReader reader)
        {

            Ord_usuarioDTO = reader.GetOrdinal("usuario");
            Ord_activoDTO = reader.GetOrdinal("activo");
            Ord_fechaAltaDTO = reader.GetOrdinal("fechaAlta");
            Ord_fechaBajaDTO = reader.GetOrdinal("fechaBaja");
            Ord_nombreDTO = reader.GetOrdinal("nombre");
            Ord_passwordDTO = reader.GetOrdinal("password");
           

        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            UsuarioDTO Usuario = new UsuarioDTO();
            if (!reader.IsDBNull(Ord_usuarioDTO))
            {
                Usuario.usuarioDTO = reader.GetInt32(Ord_usuarioDTO);
            }
            // IdReserva
            if (!reader.IsDBNull(Ord_activoDTO))
            {
                Usuario.activoDTO = reader.GetBoolean(Ord_activoDTO);
            }
            // IdDetalleReserva
         
            // IdCliente
            if (!reader.IsDBNull(Ord_nombreDTO))
            {
                Usuario.nombreDTO = reader.GetString(Ord_nombreDTO);
            }
            // IdTipoDocumento
            if (!reader.IsDBNull(Ord_fechaAltaDTO))
            {
                Usuario.fechaAltaDTO = reader.GetDateTime(Ord_fechaAltaDTO);
            }
            // NumeroDocumento
            if (!reader.IsDBNull(Ord_fechaBajaDTO))
            {
                Usuario.fechaBajaDTO = reader.GetDateTime(Ord_fechaBajaDTO);
            }

            if (!reader.IsDBNull(Ord_passwordDTO))
            {
                Usuario.passwordDTO = reader.GetString(Ord_passwordDTO);
            }

            return Usuario;
        }
    }
}