using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class CompraDTO : DTOBase
    {
        public int idCompraDTO { get; set; }
        public int idOperadorTuristicoDTO { get; set; }
        public int idDetalleCompraDTO { get; set; }
        public DateTime fechaCompraDTO { get; set; }
        public DateTime fechaPagoDTO { get; set; }
        public float montoDTO { get; set; }
        public float saldoDTO { get; set; }

        public CompraDTO()
        {
            idCompraDTO = Int_NullValue;
            idOperadorTuristicoDTO = Int_NullValue;
            idDetalleCompraDTO = Int_NullValue;
            fechaCompraDTO = DateTime_NullValue;
            fechaPagoDTO = DateTime_NullValue;
            montoDTO = Float_NullValue;
            saldoDTO = Float_NullValue;
        }


        public List<CompraDetalleDTO> Detalles { get; set; }
    }
}
