using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    class CompraDTO : DTOBase
    {
        public int idCompraDTO { get; set; }
        public int idOperadorTuristicoDTO { get; set; }
        public int idDetalleCompraDTO { get; set; }
        public DateTime fechaCompraDTO { get; set; }
        public DateTime fechaPagoDTO { get; set; }
        public float montoDTO { get; set; }
        public float saldoDTO { get; set; }

    }
}
