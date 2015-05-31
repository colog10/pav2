using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class CompraDetalleDTO : DTOBase
    {
        public int idCompraDetalleDTO { get; set; }
        public int idDetalleReservaDTO { get; set; }
        public string descripcionDTO { get; set; }

        public CompraDetalleDTO()
        {
            idCompraDetalleDTO = Int_NullValue;
            idDetalleReservaDTO = Int_NullValue;
            descripcionDTO = String_NullValue;
        }
    }
}
