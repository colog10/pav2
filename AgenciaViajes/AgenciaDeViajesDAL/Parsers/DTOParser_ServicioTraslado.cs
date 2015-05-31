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
    class DTOParser_ServicioTraslado: DTOParserSQLClient
    {


        private int Ord_idServicioTrasladoDTO;
        private int Ord_comisionDTO;        
        private int Ord_destinoDTO;
        private int Ord_fechaSalidaDTO;
        private int Ord_fechaLlegadaDTO;
        private int Ord_fechaReservaDTO;
        private int Ord_monto;
        private int Ord_numeroReservaDTO;
        private int Ord_origenDTO;
        private int Ord_idCompaniaAereaDTO;
        private int Ord_idEmpresaColectivoDTO;
        private int Ord_numeroCompraDTO;
        private int Ord_numeroVentaDTO;
        private int Ord_tipoDocumentoDTO;
        private int Ord_numeroDocumentoDTO;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {

            Ord_idServicioTrasladoDTO = reader.GetOrdinal("idServicioTraslado");
            Ord_comisionDTO = reader.GetOrdinal("comision");
            Ord_destinoDTO = reader.GetOrdinal("destino");
            Ord_fechaSalidaDTO = reader.GetOrdinal("fechaSalida");
            Ord_fechaLlegadaDTO = reader.GetOrdinal("fechaRegreso");
            Ord_fechaReservaDTO = reader.GetOrdinal("fechaVtoReserva");
            Ord_monto = reader.GetOrdinal("monto");
            Ord_numeroReservaDTO = reader.GetOrdinal("numeroReserva");
            Ord_origenDTO = reader.GetOrdinal("origen");
            Ord_idCompaniaAereaDTO = reader.GetOrdinal("idCompaniaAerea");
            Ord_idEmpresaColectivoDTO = reader.GetOrdinal("idEmpresaColectivos");
            Ord_numeroVentaDTO = reader.GetOrdinal("numeroVenta");
            Ord_tipoDocumentoDTO= reader.GetOrdinal("tipoDocumento");
            Ord_numeroCompraDTO = reader.GetOrdinal("numeroCompra");
            Ord_numeroDocumentoDTO = reader.GetOrdinal("numeroDocumento");

        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            ServicioTrasladoDTO ServicioTraslado = new ServicioTrasladoDTO();
            // IdReserva
            if (!reader.IsDBNull(Ord_idServicioTrasladoDTO))
            {
                ServicioTraslado.idServicioTrasladoDTO= reader.GetInt32(Ord_idServicioTrasladoDTO);
            }
            // IdDetalleReserva
            if (!reader.IsDBNull(Ord_comisionDTO))
            {
                ServicioTraslado.comisionDTO = reader.GetInt32(Ord_comisionDTO);
            }
            // IdCliente
            if (!reader.IsDBNull(Ord_destinoDTO))
            {
                ServicioTraslado.destinoDTO = reader.GetInt32(Ord_destinoDTO);
            }
            // IdTipoDocumento
            if (!reader.IsDBNull(Ord_fechaSalidaDTO))
            {
                ServicioTraslado.fechaSalidaDTO= reader.GetDateTime(Ord_fechaSalidaDTO);
            }
            // NumeroDocumento
            if (!reader.IsDBNull(Ord_fechaLlegadaDTO))
            {
                ServicioTraslado.fechaLlegadaDTO = reader.GetDateTime(Ord_fechaLlegadaDTO);
            }
            // IdEmpleado
            if (!reader.IsDBNull(Ord_fechaReservaDTO))
            {
                ServicioTraslado.fechaReservaDTO= reader.GetDateTime(Ord_fechaReservaDTO);
            }
            // IdDocumentoViaje
            if (!reader.IsDBNull(Ord_origenDTO))
            {
                ServicioTraslado.origenDTO = reader.GetInt32(Ord_origenDTO);
            } 
            // Monto
            if (!reader.IsDBNull(Ord_monto))
            {
                ServicioTraslado.montoDTO = reader.GetInt32(Ord_monto);
            }
            // FechaReserva
            if (!reader.IsDBNull(Ord_numeroCompraDTO))
            {
                ServicioTraslado.numeroCompraDTO = reader.GetInt32(Ord_numeroCompraDTO);
            }
            // IdSeguroViajero
            if (!reader.IsDBNull(Ord_numeroVentaDTO))
            {
                ServicioTraslado.numeroVentaDTO = reader.GetInt32(Ord_numeroVentaDTO);
            }
            // IdServicioAlojamiento
            if (!reader.IsDBNull(Ord_numeroReservaDTO))
            {
                ServicioTraslado.numeroReservaDTO = reader.GetString(Ord_numeroReservaDTO);
            }


            // IdServicioTraslado
            if (!reader.IsDBNull(Ord_idCompaniaAereaDTO))
            {
                ServicioTraslado.idCompaniaAereaDTO= reader.GetInt32(Ord_idCompaniaAereaDTO);
            }
            // Comprada
            if (!reader.IsDBNull(Ord_idEmpresaColectivoDTO))
            {
                ServicioTraslado.idEmpresaColectivoDTO = reader.GetInt32(Ord_idEmpresaColectivoDTO);
            }

            if (!reader.IsDBNull(Ord_numeroDocumentoDTO))
            {
                ServicioTraslado.numeroDocumentoDTO = reader.GetString(Ord_numeroDocumentoDTO);
            }
             if (!reader.IsDBNull(Ord_tipoDocumentoDTO))
            {
                ServicioTraslado.tipoDocumentoDTO= reader.GetInt32(Ord_tipoDocumentoDTO);
            }
           
            return ServicioTraslado;
        }
    }
   
}
