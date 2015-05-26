using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class ReservaDTO : DTOBase
    {
        public int IdReserva { get; set; }
        public int IdDetalleReserva { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int IdDocumentoViaje { get; set; }
        public int NumeroReserva { get; set; }
        public int Monto { get; set; }
        public DateTime FechaReserva { get; set; }
        public int IdSeguroViajero { get; set; }
        public int IdServicioAlojamiento { get; set; }
        public int IdServicioTraslado { get; set; }
        public bool Comprada { get; set; }
        public bool Efectuada { get; set; }

        public ReservaDTO()
        {
            IdReserva = Int_NullValue;
            IdDetalleReserva = Int_NullValue;
            IdCliente = Int_NullValue;
            IdEmpleado = Int_NullValue;
            IdTipoDocumento = Int_NullValue;
            NumeroDocumento = String_NullValue;
            IdDocumentoViaje = Int_NullValue;
            NumeroReserva = Int_NullValue;
            Monto = Int_NullValue;
            FechaReserva = DateTime_NullValue;
            IdSeguroViajero = Int_NullValue;
            IdServicioAlojamiento = Int_NullValue;
            IdServicioTraslado = Int_NullValue;
            Comprada = Boolean_NullValue;
            Efectuada = Boolean_NullValue;
        }

    }
}
