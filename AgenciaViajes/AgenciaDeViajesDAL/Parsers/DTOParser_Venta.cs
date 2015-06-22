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
    class DTOParser_Venta : DTOParserSQLClient
    {


        private int Ord_idClienteDTO;
        private int Ord_idVendedorDTO;
        private int Ord_monto;
        private int Ord_comisionDTO;
        private int Ord_fechaVentaDTO;
        private int Ord_motivoViajeDTO;
        private int Ord_NumeroFactura;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {

            Ord_idClienteDTO = reader.GetOrdinal("idCliente");
            Ord_idVendedorDTO = reader.GetOrdinal("idVendedor");
            Ord_monto = reader.GetOrdinal("monto");
            Ord_comisionDTO = reader.GetOrdinal("comision");
            Ord_fechaVentaDTO = reader.GetOrdinal("fechaVenta");
            Ord_motivoViajeDTO = reader.GetOrdinal("motivoViaje");
            Ord_NumeroFactura = reader.GetOrdinal("numeroFactura");
        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            VentaDTO Venta = new VentaDTO();
            if (!reader.IsDBNull(Ord_idClienteDTO))
            {
                Venta.idClienteDTO = reader.GetInt32(Ord_idClienteDTO);
            }
            // IdReserva
            if (!reader.IsDBNull(Ord_idVendedorDTO))
            {
                Venta.idVendedorDTO = reader.GetInt32(Ord_idVendedorDTO);
            }
            // IdDetalleReserva
            if (!reader.IsDBNull(Ord_comisionDTO))
            {
                Venta.comisionDTO = reader.GetInt32(Ord_comisionDTO);
            }
            if (!reader.IsDBNull(Ord_fechaVentaDTO))
            {
                Venta.fechaVentaDTO = reader.GetDateTime(Ord_fechaVentaDTO);
            }
            // Monto
            if (!reader.IsDBNull(Ord_monto))
            {
                Venta.montoDTO = reader.GetInt32(Ord_monto);
            }
            
            if (!reader.IsDBNull(Ord_motivoViajeDTO))
            {
                Venta.motivoViajeDTO= reader.GetInt32(Ord_motivoViajeDTO);
            }

            if (!reader.IsDBNull(Ord_NumeroFactura))
            {
                Venta.NumeroFactura = reader.GetInt32(Ord_NumeroFactura);
            }

            return Venta;
        }
    }
}
