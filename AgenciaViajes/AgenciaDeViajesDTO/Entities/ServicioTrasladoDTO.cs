using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class ServicioTrasladoDTO : DTOBase
    {
        public int idServicioTrasladoDTO {get; set;}
        public int comisionDTO {get; set;}
        public int destinoDTO {get; set;}
        public DateTime fechaSalidaDTO {get; set;}
        public DateTime fechaLlegadaDTO {get; set;}
        public DateTime fechaReservaDTO {get; set;}
        public float montoDTO {get; set;}
        public string numeroReservaDTO {get; set;}
        public int origenDTO {get; set;}
        public int idCompaniaAereaDTO {get; set;}
        public int idEmpresaColectivoDTO {get; set;}
        public int numeroCompraDTO {get; set;}
        public int numeroVentaDTO {get; set;}
        public int tipoDocumentoDTO {get; set;}
        public string numeroDocumentoDTO {get; set;}

        public ServicioTrasladoDTO ()
        {
            this.idServicioTrasladoDTO = Int_NullValue;
            this.comisionDTO = Int_NullValue;
            this.destinoDTO = Int_NullValue;
            this.fechaSalidaDTO = DateTime_NullValue;
            this.fechaLlegadaDTO = DateTime_NullValue;
            this.fechaReservaDTO = DateTime_NullValue;
            this.montoDTO = Float_NullValue;
            this.numeroReservaDTO = String_NullValue;
            this.origenDTO = Int_NullValue;
            this.idCompaniaAereaDTO = Int_NullValue;
            this.idEmpresaColectivoDTO = Int_NullValue;
            this.numeroCompraDTO = Int_NullValue;
            this.numeroVentaDTO = Int_NullValue;
            this.tipoDocumentoDTO = Int_NullValue;
            this.numeroDocumentoDTO = String_NullValue;

        }
    }
}
