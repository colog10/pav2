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
    internal class DTOParser_CompraDetalle : DTOParserSQLClient
    {
        private int Ord_idDetalleCompra;
        private int Ord_idDetalleReserva;
        private int Ord_descripcion;
        private int Ord_monto;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_idDetalleCompra = reader.GetOrdinal("idDetalleCompra");
            Ord_idDetalleReserva = reader.GetOrdinal("idDetalleReserva");
            Ord_descripcion = reader.GetOrdinal("descripcion");
            Ord_monto = reader.GetOrdinal("monto");
        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            CompraDetalleDTO compraDetalleDTO = new CompraDetalleDTO();

            //idDetalleCompra
            if (!reader.IsDBNull(Ord_idDetalleCompra)) { compraDetalleDTO.idCompraDetalleDTO = reader.GetInt32(Ord_idDetalleCompra);}

            //idDetalleReserva
            if (!reader.IsDBNull(Ord_idDetalleReserva)) { compraDetalleDTO.idDetalleReservaDTO = reader.GetInt32(Ord_idDetalleReserva);}

            //descripcion
            if (!reader.IsDBNull(Ord_descripcion)) { compraDetalleDTO.descripcionDTO = reader.GetString(Ord_descripcion);}
            
            //monto 
            if (!reader.IsDBNull(Ord_monto)) { compraDetalleDTO.Monto = reader.GetFloat(Ord_monto); }

            return compraDetalleDTO;

        }
    }
}
