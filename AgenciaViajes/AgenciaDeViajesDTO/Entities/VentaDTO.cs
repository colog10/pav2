using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class VentaDTO : DTOBase
    {
        public int numeroVentaDTO {get; set;}
        public int idClienteDTO { get; set; }
        public int idVentaDetalleDTO { get; set; }
        public int idVendedorDTO {get; set;}
        public int idSeguroViajeroDTO { get; set; }
        public int idServicioAlojamientoDTO { get; set; }
        public int idServicioTrasladoDTO { get; set; }
        public float montoDTO { get; set; }
        public int comisionDTO { get; set; }
        public string paisOrigenDTO { get; set; }
        public int ciudadOrigenDTO { get; set; }
        public string paisDestinoDTO { get; set; }
        public int ciudadDestinoDTO { get; set; }
        public DateTime fechaSalidaDTO { get; set; }
        public DateTime fechaRetornoDTO { get; set; }
        public int documentoViajeDTO { get; set; }
        public DateTime fechaVentaDTO { get; set; }
        public int motivoViajeDTO { get; set; }

       public VentaDTO ()
        {
            numeroVentaDTO = Int_NullValue;
            idClienteDTO = Int_NullValue;
            idVentaDetalleDTO = Int_NullValue;
            idVendedorDTO = Int_NullValue;
            idSeguroViajeroDTO = Int_NullValue;
            idServicioAlojamientoDTO = Int_NullValue;
            idServicioTrasladoDTO = Int_NullValue;
            montoDTO = Float_NullValue;
            comisionDTO = Int_NullValue;
            paisOrigenDTO = String_NullValue;
            ciudadOrigenDTO = Int_NullValue;
            paisDestinoDTO = String_NullValue;
            ciudadDestinoDTO = Int_NullValue;
            fechaSalidaDTO = DateTime_NullValue;
            fechaRetornoDTO = DateTime_NullValue;
            documentoViajeDTO = Int_NullValue;
            fechaVentaDTO = DateTime_NullValue;
            motivoViajeDTO = Int_NullValue;
        }
    }
}
