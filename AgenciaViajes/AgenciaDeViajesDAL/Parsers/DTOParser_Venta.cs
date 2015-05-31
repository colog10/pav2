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

        private int Ord_numeroVentaDTO;
        private int Ord_idClienteDTO;
        private int Ord_idVentaDetalleDTO;
        private int Ord_idVendedorDTO;
        private int Ord_idSeguroViajeroDTO;
        private int Ord_idServicioAlojamientoDTO;
        private int Ord_idServicioTrasladoDTO;
        private int Ord_monto;
        private int Ord_comisionDTO;
        private int Ord_paisOrigenDTO;
        private int Ord_ciudadOrigenDTO;
        private int Ord_paisDestinoDTO;
        private int Ord_ciudadDestinoDTO;
        private int Ord_fechaSalidaDTO;
        private int Ord_fechaRetornoDTO;
        private int Ord_documentoViajeDTO;
        private int Ord_fechaVentaDTO;
        private int Ord_motivoViajeDTO;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_numeroVentaDTO = reader.GetOrdinal("numeroVenta");
            Ord_idClienteDTO = reader.GetOrdinal("idCliente");
            Ord_idVentaDetalleDTO = reader.GetOrdinal("idVentaDetalle");
            Ord_idVendedorDTO = reader.GetOrdinal("idVendedor");
            Ord_idSeguroViajeroDTO = reader.GetOrdinal("idSeguroViajero");
            Ord_idServicioAlojamientoDTO = reader.GetOrdinal("idServicioAlojamiento");
            Ord_idServicioTrasladoDTO = reader.GetOrdinal("idServicioTraslado");
            Ord_monto = reader.GetOrdinal("monto");
            Ord_comisionDTO = reader.GetOrdinal("comision");
            Ord_paisOrigenDTO = reader.GetOrdinal("paisOrigen");
            Ord_ciudadOrigenDTO = reader.GetOrdinal("ciudadOrigen");
            Ord_paisDestinoDTO = reader.GetOrdinal("paisDestino");
            Ord_ciudadDestinoDTO = reader.GetOrdinal("ciudadDestino");
            Ord_fechaSalidaDTO = reader.GetOrdinal("fechaSalida");
            Ord_fechaRetornoDTO = reader.GetOrdinal("fechaRetorno");
            Ord_documentoViajeDTO = reader.GetOrdinal("documentoviaje");
            Ord_fechaVentaDTO = reader.GetOrdinal("fechaVenta");
            Ord_motivoViajeDTO = reader.GetOrdinal("motivoViaje");
           
            
            

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
            // IdCliente
            if (!reader.IsDBNull(Ord_idSeguroViajeroDTO))
            {
                Venta.idSeguroViajeroDTO = reader.GetInt32(Ord_idSeguroViajeroDTO);
            }
            if (!reader.IsDBNull(Ord_idServicioAlojamientoDTO))
            {
                Venta.idServicioAlojamientoDTO = reader.GetInt32(Ord_idServicioAlojamientoDTO);
            }
            // IdTipoDocumento
            if (!reader.IsDBNull(Ord_fechaSalidaDTO))
            {
                Venta.fechaSalidaDTO = reader.GetDateTime(Ord_fechaSalidaDTO);
            }
            // NumeroDocumento
            if (!reader.IsDBNull(Ord_fechaRetornoDTO))
            {
                Venta.fechaRetornoDTO = reader.GetDateTime(Ord_fechaRetornoDTO);
            }
            // IdEmpleado
            if (!reader.IsDBNull(Ord_fechaVentaDTO))
            {
                Venta.fechaVentaDTO = reader.GetDateTime(Ord_fechaVentaDTO);
            }
            // IdDocumentoViaje
            if (!reader.IsDBNull(Ord_idVentaDetalleDTO))
            {
                Venta.idVentaDetalleDTO = reader.GetInt32(Ord_idVentaDetalleDTO);
            }
            // Monto
            if (!reader.IsDBNull(Ord_monto))
            {
                Venta.montoDTO = reader.GetInt32(Ord_monto);
            }
            // FechaReserva
            if (!reader.IsDBNull(Ord_idServicioTrasladoDTO))
            {
                Venta.idServicioTrasladoDTO = reader.GetInt32(Ord_idServicioTrasladoDTO);
            }
            // IdSeguroViajero
            if (!reader.IsDBNull(Ord_documentoViajeDTO))
            {
                Venta.documentoViajeDTO = reader.GetInt32(Ord_documentoViajeDTO);
            }
            // IdServicioAlojamiento
            if (!reader.IsDBNull(Ord_paisOrigenDTO))
            {
                Venta.paisOrigenDTO = reader.GetString(Ord_paisOrigenDTO);
            }
            // Comprada
            if (!reader.IsDBNull(Ord_ciudadOrigenDTO))
            {
                Venta.ciudadOrigenDTO = reader.GetInt32(Ord_ciudadOrigenDTO);
            }

            // IdServicioAlojamiento
            if (!reader.IsDBNull(Ord_paisDestinoDTO))
            {
                Venta.paisDestinoDTO = reader.GetString(Ord_paisDestinoDTO);
            }
            // Comprada
            if (!reader.IsDBNull(Ord_ciudadDestinoDTO))
            {
                Venta.ciudadDestinoDTO = reader.GetInt32(Ord_ciudadDestinoDTO);
            }
            // IdServicioTraslado
            if (!reader.IsDBNull(Ord_numeroVentaDTO))
            {
                Venta.numeroVentaDTO = reader.GetInt32(Ord_numeroVentaDTO);
            }
            if (!reader.IsDBNull(Ord_motivoViajeDTO))
            {
                Venta.motivoViajeDTO= reader.GetInt32(Ord_motivoViajeDTO);
            }

            return Venta;
        }
    }
}