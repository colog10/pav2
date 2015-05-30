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
        public int idMotivoViajeDTO {get; set;}
        public int idPasajeroDTO {get; set;}
        public int numeroVentaDTO {get; set;}
        public int idTipoDocumentoDTO {get; set;}
        public string numeroDocumentoDTO {get; set;}
        public int idTipoDocumentoViajeDTO {get; set;}
        public DateTime fechaPasaporteDesdeDTO {get; set;}
        public DateTime fechaPasaporteHastaDTO {get; set;}
        public DateTime fechaVISADesdeDTO {get; set;}
        public DateTime fechaVISAHastaDTO {get; set;}
        public int idSeguroViajeroDTO {get; set;}
        public int idServicioAlojamientoDTO {get; set;}
        public int idServicioTrasladoDTO {get; set;}
        public int idDetalleReservaDTO {get; set;}

        public VentaDetalleDTO()
        {
            idDetalleVentaDTO = Int_NullValue;
            idMotivoViajeDTO = Int_NullValue;
            idPasajeroDTO = Int_NullValue;
            numeroVentaDTO = Int_NullValue;
            idTipoDocumentoDTO = Int_NullValue;
            numeroDocumentoDTO = String_NullValue;
            idTipoDocumentoViajeDTO = Int_NullValue;
            fechaPasaporteDesdeDTO = DateTime_NullValue;
            fechaPasaporteHastaDTO = DateTime_NullValue;
            fechaVISADesdeDTO = DateTime_NullValue;
            //fechaVISAHasta = DateTime_NullValue;
            idSeguroViajeroDTO = Int_NullValue;
            idServicioAlojamientoDTO = Int_NullValue;
            idServicioTrasladoDTO = Int_NullValue;
            idDetalleReservaDTO = Int_NullValue;

        }
    }
}
