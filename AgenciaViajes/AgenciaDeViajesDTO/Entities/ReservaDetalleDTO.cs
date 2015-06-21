using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class ReservaDetalleDTO : DTOBase
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
        public int IdPasajero { get; set; }
        public ServicioAlojamientoDTO Alojamiento { get; set; }
        public ServicioTrasladoDTO ServicioTraslado { get; set; }
        public float Monto { get; set; }

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
            IdPasajero = Int_NullValue;
            Monto = Float_NullValue;
        }



        public PasajeroDTO Pasajero { get; set; }
       
        public string NombrePasajero {
            get
            {
                return Pasajero.Nombre;
            }
        }
        public string ApellidoPasajero
        {
            get
            {
                return Pasajero.Apellido;
            }
        }

        public SeguroViajeroDTO Seguro { get; set; }

        public string NombreSeguro
        {
            get
            {
                return Seguro.Descripcion;
            }
        }

       // public ServicioTrasladoDTO ServicioTraslado { get; set; }

        

        public ServicioAlojamientoDTO ServicioAlojamiento { get; set; }

        public string NombreAlojamiento
        {
            get
            {
                return ServicioAlojamiento.descripcionDTO;
            }
        }




        
    }
}
