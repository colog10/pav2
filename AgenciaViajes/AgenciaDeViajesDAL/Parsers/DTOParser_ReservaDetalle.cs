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
    internal class DTOParser_ReservaDetalle : DTOParserSQLClient
    {
        private int Ord_IdDetallaReserva;
        private int Ord_IdReserva;
        private int Ord_IdSeguroViajero;
        private int Ord_IdTipoDocumento;
        private int Ord_NumeroDocumento;
        private int Ord_IdServicioAlojamiento;
        private int Ord_IdServicioTraslado;
        private int Ord_IdDocumentoViaje;
        private int Ord_Comprada;
        private int Ord_Efectuada;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_IdDetallaReserva = reader.GetOrdinal("IdDetallaReserva");
            Ord_IdReserva = reader.GetOrdinal("IdReserva");
            Ord_IdSeguroViajero = reader.GetOrdinal("IdSeguroViajero");
            Ord_IdTipoDocumento = reader.GetOrdinal("IdTipoDocumento");
            Ord_NumeroDocumento = reader.GetOrdinal("NumeroDocumento");
            Ord_IdServicioAlojamiento = reader.GetOrdinal("IdServicioAlojamiento");
            Ord_IdServicioTraslado = reader.GetOrdinal("IdServicioTraslado");
            Ord_IdDocumentoViaje = reader.GetOrdinal("IdDocumentoViaje");
            Ord_Comprada = reader.GetOrdinal("Comprada");
            Ord_Efectuada = reader.GetOrdinal("Efectuada");

        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            ReservaDetalleDTO detalleReserva = new ReservaDetalleDTO();
            // IdDetallaReserva
            if (!reader.IsDBNull(Ord_IdDetallaReserva))
            {
                detalleReserva.IdDetallaReserva = reader.GetInt32(Ord_IdDetallaReserva);
            }
            // IdReserva
            if (!reader.IsDBNull(Ord_IdReserva))
            {
                detalleReserva.IdReserva = reader.GetInt32(Ord_IdReserva);
            }
            // IdSeguroViajero
            if (!reader.IsDBNull(Ord_IdSeguroViajero))
            {
                detalleReserva.IdSeguroViajero = reader.GetInt32(Ord_IdSeguroViajero);
            }
            // IdTipoDocumento
            if (!reader.IsDBNull(Ord_IdTipoDocumento))
            {
                detalleReserva.IdTipoDocumento = reader.GetInt32(Ord_IdTipoDocumento);
            }
            // NumeroDocumento
            if (!reader.IsDBNull(Ord_NumeroDocumento))
            {
                detalleReserva.NumeroDocumento = reader.GetString(Ord_NumeroDocumento);
            }
            // IdServicioAlojamiento
            if (!reader.IsDBNull(Ord_IdServicioAlojamiento))
            {
                detalleReserva.IdServicioAlojamiento = reader.GetInt32(Ord_IdServicioAlojamiento);
            }
            // IdServicioTraslado
            if (!reader.IsDBNull(Ord_IdServicioTraslado))
            {
                detalleReserva.IdServicioTraslado = reader.GetInt32(Ord_IdServicioTraslado);
            }
            // IdDocumentoViaje
            if (!reader.IsDBNull(Ord_IdDocumentoViaje))
            {
                detalleReserva.IdDocumentoViaje = reader.GetInt32(Ord_IdDocumentoViaje);
            }
            // Comprada
            if (!reader.IsDBNull(Ord_Comprada))
            {
                detalleReserva.Comprada = reader.GetBoolean(Ord_Comprada);
            }
            // Efectuada
            if (!reader.IsDBNull(Ord_Efectuada))
            {
                detalleReserva.Efectuada = reader.GetBoolean(Ord_Efectuada);
            }

            return detalleReserva;
        }
    }
}
