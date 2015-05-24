using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class ReservaDetalleDTO : CommonBase
    {
        public int IdDetallaReserva { get; set; }
        public int IdReserva { get; set; }
        public int IdSeguroViajero { get; set; }
        public int IdServicioAlojamiento { get; set; }
        public int IdServicioTraslado { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int IdDocumentoViaje { get; set; }
        public bool Comprada { get; set; }
        public bool Efectuada { get; set; }

        public ReservaDetalleDTO()
        {
            IdDetallaReserva = Int_NullValue;
            IdReserva = Int_NullValue;
            IdSeguroViajero = Int_NullValue;
            IdServicioAlojamiento = Int_NullValue;
            IdServicioTraslado = Int_NullValue;
            IdTipoDocumento = Int_NullValue;
            NumeroDocumento = String_NullValue;
            IdDocumentoViaje = Int_NullValue;
            Comprada = Boolean_NullValue;
            Efectuada = Boolean_NullValue;
        }
    }
}
