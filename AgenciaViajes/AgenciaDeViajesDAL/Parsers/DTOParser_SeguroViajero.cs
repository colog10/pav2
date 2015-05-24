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
    internal class DTOParser_SeguroViajero : DTOParserSQLClient
    {
        private int Ord_IdSeguroViajero;
        private int Ord_Comision;
        private int Ord_Monto;
        private int Ord_TipoSeguroViajero;
        private int Ord_NumeroCompra;
        private int Ord_Descripcion;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_IdSeguroViajero = reader.GetOrdinal("IdSeguroViajero");
            Ord_Comision = reader.GetOrdinal("Comision");
            Ord_Monto = reader.GetOrdinal("Monto");
            Ord_TipoSeguroViajero = reader.GetOrdinal("TipoSeguroViajero");
            Ord_NumeroCompra = reader.GetOrdinal("NumeroCompra");
            Ord_Descripcion = reader.GetOrdinal("Descripcion");

        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            SeguroViajeroDTO seguroViajero = new SeguroViajeroDTO();
            // IdSeguroViajero
            if (!reader.IsDBNull(Ord_IdSeguroViajero))
            {
                seguroViajero.IdSeguroViajero = reader.GetInt32(Ord_IdSeguroViajero);
            }
            // Comision
            if (!reader.IsDBNull(Ord_Comision))
            {
                seguroViajero.Comision = reader.GetInt32(Ord_Comision);
            }
            // Monto
            if (!reader.IsDBNull(Ord_Monto))
            {
                seguroViajero.Monto = reader.GetFloat(Ord_Monto);
            }
            // TipoSeguroViajero
            if (!reader.IsDBNull(Ord_TipoSeguroViajero))
            {
                seguroViajero.TipoSeguroViajero = reader.GetInt32(Ord_TipoSeguroViajero);
            }
            // NumeroCompra
            if (!reader.IsDBNull(Ord_NumeroCompra))
            {
                seguroViajero.NumeroCompra = reader.GetInt32(Ord_NumeroCompra);
            }
            // Descripcion
            if (!reader.IsDBNull(Ord_Descripcion))
            {
                seguroViajero.Descripcion = reader.GetString(Ord_Descripcion);
            }
            return seguroViajero;
        }
    }
}
