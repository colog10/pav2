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
    class DTOParser_ServicioAlojamiento : DTOParserSQLClient
    {


        private int Ord_idServicioAlojamiento;
        private int Ord_CategoriaDTO;
        private int Ord_comisionDTO;
        private int Ord_descripcionDTO;
        private int Ord_fechaDesdeDTO;
        private int Ord_fechaHastaDTO;
        private int Ord_fechaVencReservaDTO;
        private int Ord_numeroReservaDTO;
        private int Ord_idAlojamientoDTO;
        private int Ord_numeroVentaDTO;
        private int Ord_tipoDocumentoDTO;
        private int Ord_numeroDocumentoDTO;
        private int Ord_numeroCompraDTO;
        private int Ord_monto;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {

            Ord_idServicioAlojamiento = reader.GetOrdinal("idServicioAlojamiento");
            Ord_CategoriaDTO = reader.GetOrdinal("categoria");
            Ord_comisionDTO = reader.GetOrdinal("comision");
            Ord_descripcionDTO = reader.GetOrdinal("descripcion");
            Ord_fechaDesdeDTO = reader.GetOrdinal("fechaDesde");
            Ord_fechaHastaDTO = reader.GetOrdinal("fechaHasta");
            Ord_fechaVencReservaDTO = reader.GetOrdinal("fechaVencReserva");
            Ord_monto = reader.GetOrdinal("monto");
            Ord_numeroReservaDTO = reader.GetOrdinal("numeroReserva");
            Ord_idAlojamientoDTO = reader.GetOrdinal("idAlojamiento");
            Ord_numeroVentaDTO = reader.GetOrdinal("numeroVenta");
            Ord_tipoDocumentoDTO = reader.GetOrdinal("tipoDocumento");
            Ord_numeroDocumentoDTO = reader.GetOrdinal("numeroDocumento");
            Ord_numeroCompraDTO = reader.GetOrdinal("numeroCompra");

        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            ServicioAlojamientoDTO ServicioAlojamiento = new ServicioAlojamientoDTO();
            if (!reader.IsDBNull(Ord_idServicioAlojamiento))
            {
                ServicioAlojamiento.ServicioAlojamiento= reader.GetInt32(Ord_idServicioAlojamiento);
            }
            // IdReserva
            if (!reader.IsDBNull(Ord_CategoriaDTO))
            {
                ServicioAlojamiento.CategoriaDTO = reader.GetString(Ord_CategoriaDTO);
            }
            // IdDetalleReserva
            if (!reader.IsDBNull(Ord_comisionDTO))
            {
                ServicioAlojamiento.comisionDTO = reader.GetInt32(Ord_comisionDTO);
            }
            // IdCliente
            if (!reader.IsDBNull(Ord_descripcionDTO))
            {
                ServicioAlojamiento.descripcionDTO = reader.GetString(Ord_descripcionDTO);
            }
            // IdTipoDocumento
            if (!reader.IsDBNull(Ord_fechaDesdeDTO))
            {
                ServicioAlojamiento.fechaDesdeDTO = reader.GetDateTime(Ord_fechaDesdeDTO);
            }
            // NumeroDocumento
            if (!reader.IsDBNull(Ord_fechaHastaDTO))
            {
                ServicioAlojamiento.fechaHastaDTO = reader.GetDateTime(Ord_fechaHastaDTO);
            }
            // IdEmpleado
            if (!reader.IsDBNull(Ord_fechaVencReservaDTO))
            {
                ServicioAlojamiento.fechaVencReservaDTO = reader.GetDateTime(Ord_fechaVencReservaDTO);
            }
            // IdDocumentoViaje
            if (!reader.IsDBNull(Ord_idAlojamientoDTO))
            {
                ServicioAlojamiento.idAlojamientoDTO = reader.GetInt32(Ord_idAlojamientoDTO);
            } 
            // Monto
            if (!reader.IsDBNull(Ord_monto))
            {
                ServicioAlojamiento.montoDTO = (float)reader.GetDecimal(Ord_monto);
            }
            // FechaReserva
            if (!reader.IsDBNull(Ord_numeroCompraDTO))
            {
                ServicioAlojamiento.numeroCompraDTO = reader.GetInt32(Ord_numeroCompraDTO);
            }
            // IdSeguroViajero
            if (!reader.IsDBNull(Ord_numeroDocumentoDTO))
            {
                ServicioAlojamiento.numeroDocumentoDTO = reader.GetString(Ord_numeroDocumentoDTO);
            }
            // IdServicioAlojamiento
            if (!reader.IsDBNull(Ord_numeroReservaDTO))
            {
                ServicioAlojamiento.numeroReservaDTO = reader.GetString(Ord_numeroReservaDTO);
            }


            // IdServicioTraslado
            if (!reader.IsDBNull(Ord_numeroVentaDTO))
            {
                ServicioAlojamiento.numeroVentaDTO = reader.GetInt32(Ord_numeroVentaDTO);
            }
            // Comprada
            if (!reader.IsDBNull(Ord_tipoDocumentoDTO))
            {
                ServicioAlojamiento.tipoDocumentoDTO = reader.GetInt32(Ord_tipoDocumentoDTO);
            }
           
            return ServicioAlojamiento;
        }
    }
}
