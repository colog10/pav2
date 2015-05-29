using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class ServicioAlojamientoDTO : DTOBase
    {
        public int ServicioAlojamientoDTO {get; set;}
        public string CategoriaDTO {get; set;}
        public int comisionDTO {get; set;}
        public string descripcionDTO {get; set;}
        public DateTime fechaDesdeDTO {get; set;}
        public DateTime fechaHastaDTO {get; set;}
        public DateTime fechaVencReservaDTO {get; set;}
        public float montoDTO {get; set;}
        public string numeroReservaDTO {get; set;}
        public int idAlojamientoDTO {get; set;}
        public int numeroVentaDTO {get; set;}
        public int tipoDocumentoDTO {get; set;}
        public string numeroDocumentoDTO {get; set;}
        public int numeroCompraDTO {get; set;}

        public ServicioAlojamientoDTO ()
        {
            this.ServicioAlojamientoDTO = Int_NullValue;
            this.CategoriaDTO = String_NullValue;
            this.comisionDTO = Int_NullValue;
            this.descripcionDTO = String_NullValue;
            this.fechaDesdeDTO = DateTime_NullValue;
            this.fechaHastaDTO = DateTime_NullValue;
            this.fechaVencReservaDTO = DateTime_NullValue;
            this.montoDTO = float;
            this.numeroReservaDTO = String_NullValue;
            this.idAlojamientoDTO = Int_NullValue;
            this.numeroVentaDTO = Int_NullValue;
            this.tipoDocumentoDTO = Int_NullValue;
            this.numeroDocumentoDTO = String_NullValue;
            this.numeroCompraDTO = Int_NullValue;

        }
    }
}
