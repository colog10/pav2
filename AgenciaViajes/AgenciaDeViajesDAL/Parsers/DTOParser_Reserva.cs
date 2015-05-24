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
    internal class DTOParser_Reserva : DTOParserSQLClient
    {
        private int Ord_IdReserva;
        private int Ord_IdDetalleReserva;
        private int Ord_IdCliente;
        private int Ord_IdTipoDocumento;
        private int Ord_NumeroDocumento;
        private int Ord_IdEmpleado;
        private int Ord_IdDocumentoViaje;
        private int Ord_NumeroReserva;
        private int Ord_Monto;
        private int Ord_FechaReserva;
        private int Ord_IdSeguroViajero;
        private int Ord_IdServicioAlojamiento;
        private int Ord_IdServicioTraslado;
        private int Ord_Comprada;
        private int Ord_Efectuada;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_IdReserva = reader.GetOrdinal("IdReserva");
            Ord_IdDetalleReserva = reader.GetOrdinal("IdDetalleReserva");
            Ord_IdCliente = reader.GetOrdinal("IdCliente");
            Ord_IdTipoDocumento = reader.GetOrdinal("IdTipoDocumento");
            Ord_NumeroDocumento = reader.GetOrdinal("NumeroDocumento");
            Ord_IdEmpleado = reader.GetOrdinal("IdEmpleado");
            Ord_IdDocumentoViaje = reader.GetOrdinal("IdDocumentoViaje"); Ord_NumeroReserva = reader.GetOrdinal("NumeroReserva");
            Ord_Monto = reader.GetOrdinal("Monto");
            Ord_FechaReserva = reader.GetOrdinal("FechaReserva");
            Ord_IdSeguroViajero = reader.GetOrdinal("IdSeguroViajero");
            Ord_IdServicioAlojamiento = reader.GetOrdinal("IdServicioAlojamiento");
            Ord_IdServicioTraslado = reader.GetOrdinal("IdServicioTraslado");
            Ord_Comprada = reader.GetOrdinal("Comprada");
            Ord_Efectuada = reader.GetOrdinal("Efectuada");
        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            ReservaDTO reserva = new ReservaDTO();
            // IdReserva
            if (!reader.IsDBNull(Ord_IdReserva))
            {
                reserva.IdReserva = reader.GetInt32(Ord_IdReserva);
            }
            // IdDetalleReserva
            if (!reader.IsDBNull(Ord_IdDetalleReserva))
            {
                reserva.IdDetalleReserva = reader.GetInt32(Ord_IdDetalleReserva);
            }
            // IdCliente
            if (!reader.IsDBNull(Ord_IdCliente))
            {
                reserva.IdCliente = reader.GetInt32(Ord_IdCliente);
            }
            // IdTipoDocumento
            if (!reader.IsDBNull(Ord_IdTipoDocumento))
            {
                reserva.IdTipoDocumento = reader.GetInt32(Ord_IdTipoDocumento);
            }
            // NumeroDocumento
            if (!reader.IsDBNull(Ord_NumeroDocumento))
            {
                reserva.NumeroDocumento = reader.GetString(Ord_NumeroDocumento);
            }
            // IdEmpleado
            if (!reader.IsDBNull(Ord_IdEmpleado))
            {
                reserva.IdEmpleado = reader.GetInt32(Ord_IdEmpleado);
            }
            // IdDocumentoViaje
            if (!reader.IsDBNull(Ord_IdDocumentoViaje))
            {
                reserva.IdDocumentoViaje = reader.GetInt32(Ord_IdDocumentoViaje);
            }    // NumeroReserva    if (!reader.IsDBNull(Ord_NumeroReserva))

            {
                reserva.NumeroReserva = reader.GetInt32(
                    Ord_NumeroReserva);
            }
            // Monto
            if (!reader.IsDBNull(Ord_Monto))
            {
                reserva.Monto = reader.GetInt32(Ord_Monto);
            }
            // FechaReserva
            if (!reader.IsDBNull(Ord_FechaReserva))
            {
                reserva.FechaReserva = reader.GetDateTime(Ord_FechaReserva);
            }
            // IdSeguroViajero
            if (!reader.IsDBNull(Ord_IdSeguroViajero))
            {
                reserva.IdSeguroViajero = reader.GetInt32(Ord_IdSeguroViajero);
            }
            // IdServicioAlojamiento
            if (!reader.IsDBNull(Ord_IdServicioAlojamiento))
            {
                reserva.IdServicioAlojamiento = reader.GetInt32(Ord_IdServicioAlojamiento);
            }


            // IdServicioTraslado
            if (!reader.IsDBNull(Ord_IdServicioTraslado))
            {
                reserva.IdServicioTraslado = reader.GetInt32(Ord_IdServicioTraslado);
            }
            // Comprada
            if (!reader.IsDBNull(Ord_Comprada))
            {
                reserva.Comprada = reader.GetBoolean(Ord_Comprada);
            }
            // Efectuada
            if (!reader.IsDBNull(Ord_Efectuada))
            {
                reserva.Efectuada = reader.GetBoolean(Ord_Efectuada);
            }
            return reserva;
        }
    }
}
