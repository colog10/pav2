using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class VentaDetalleDTO: DTOBase
    {
        
        public int idDetalleVentaDTO {get; set;}
        public int idPasajeroDTO {get; set;}
        public int idTipoDocumentoViajeDTO {get; set;}
        public int idSeguroViajeroDTO {get; set;}
        public int idServicioAlojamientoDTO {get; set;}
        public int idServicioTrasladoDTO {get; set;}
        public int idDetalleReservaDTO {get; set;}
        public float Monto {get;set;}
        public int IdVenta { get; set; }

        public VentaDetalleDTO()
        {
            idDetalleVentaDTO = Int_NullValue;
        
            idPasajeroDTO = Int_NullValue;
            idTipoDocumentoViajeDTO = Int_NullValue;
            idSeguroViajeroDTO = Int_NullValue;
            idServicioAlojamientoDTO = Int_NullValue;
            idServicioTrasladoDTO = Int_NullValue;
            idDetalleReservaDTO = Int_NullValue;
            Monto = Float_NullValue;
            IdVenta = Int_NullValue;
        }
    }
}
