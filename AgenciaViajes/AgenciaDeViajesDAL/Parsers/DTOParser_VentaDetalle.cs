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
    class DTOParser_VentaDetalle : DTOParserSQLClient
    {
        private int Ord_idVentaDetalleDTO;
        private int Ord_motivoViajeDTO;
        private int Ord_idPasajeroDTO;
        private int Ord_numeroVentaDTO;
        private int Ord_idTipoDocumentoDTO;
        private int Ord_numeroDocumentoDTO;
        private int Ord_idTipoDocumentoViajeDTO;
        private int Ord_fechaPasaporteDesdeDTO;
        private int Ord_fechaPasaporteHastaDTO;
        private int Ord_fechaVISADesdeDTO;
        private int Ord_fechaVISAHastaDTO;
        private int Ord_idSeguroViajeroDTO;
        private int Ord_idServicioAlojamientoDTO;
        private int Ord_idServicioTrasladoDTO;
        private int Ord_idDetalleReservaDTO;


        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_idVentaDetalleDTO = reader.GetOrdinal("idDetalleVenta");
            Ord_motivoViajeDTO = reader.GetOrdinal("idMotivoViaje");
            Ord_idPasajeroDTO = reader.GetOrdinal("idPasajero");
            Ord_numeroVentaDTO = reader.GetOrdinal("numeroVenta");
            Ord_idTipoDocumentoDTO = reader.GetOrdinal("idTipoDocumento");
            Ord_numeroDocumentoDTO = reader.GetOrdinal("numeroDocumento");
            Ord_idTipoDocumentoViajeDTO = reader.GetOrdinal("idDocumentoViaje");
            Ord_fechaPasaporteDesdeDTO = reader.GetOrdinal("fechaPasaporteDesde");
            Ord_fechaPasaporteHastaDTO = reader.GetOrdinal("fechaPasaporteHasta");
            Ord_fechaVISADesdeDTO = reader.GetOrdinal("fechaVISADesde");
            Ord_fechaVISAHastaDTO = reader.GetOrdinal("fechaVISAHasta");
            Ord_idSeguroViajeroDTO = reader.GetOrdinal("idSeguroViajero");
            Ord_idServicioAlojamientoDTO = reader.GetOrdinal("idServicioAlojamiento");
            Ord_idServicioTrasladoDTO = reader.GetOrdinal("idServicioTraslado");
            Ord_idDetalleReservaDTO = reader.GetOrdinal("idDetalleReserva");

        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            VentaDetalleDTO VentaDetalle = new VentaDetalleDTO();
            if (!reader.IsDBNull(Ord_idPasajeroDTO))
            {
                VentaDetalle.idPasajeroDTO = reader.GetInt32(Ord_idPasajeroDTO);
            }
            // IdReserva
            if (!reader.IsDBNull(Ord_idDetalleReservaDTO))
            {
                VentaDetalle.idDetalleReservaDTO = reader.GetInt32(Ord_idDetalleReservaDTO);
            }
            
            // IdCliente
            if (!reader.IsDBNull(Ord_idSeguroViajeroDTO))
            {
                VentaDetalle.idSeguroViajeroDTO = reader.GetInt32(Ord_idSeguroViajeroDTO);
            }
            if (!reader.IsDBNull(Ord_idServicioAlojamientoDTO))
            {
                VentaDetalle.idServicioAlojamientoDTO = reader.GetInt32(Ord_idServicioAlojamientoDTO);
            }
            
            
            // IdDocumentoViaje
            if (!reader.IsDBNull(Ord_idVentaDetalleDTO))
            {
                VentaDetalle.idDetalleVentaDTO = reader.GetInt32(Ord_idVentaDetalleDTO);
            }
            
            // FechaReserva
            if (!reader.IsDBNull(Ord_idServicioTrasladoDTO))
            {
                VentaDetalle.idServicioTrasladoDTO = reader.GetInt32(Ord_idServicioTrasladoDTO);
            }
            // IdSeguroViajero
            if (!reader.IsDBNull(Ord_idTipoDocumentoViajeDTO))
            {
                VentaDetalle.idTipoDocumentoViajeDTO = reader.GetInt32(Ord_idTipoDocumentoViajeDTO);
            }
            
            return VentaDetalle;
        }
    }
}