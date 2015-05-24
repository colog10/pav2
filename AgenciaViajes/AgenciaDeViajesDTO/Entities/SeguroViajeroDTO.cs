using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class SeguroViajeroDTO : CommonBase
    {
        public int IdSeguroViajero { get; set; }
        public int Comision { get; set; }
        public float Monto { get; set; }
        public int TipoSeguroViajero { get; set; }
        public int NumeroCompra { get; set; }
        public string Descripcion { get; set; }

        public SeguroViajeroDTO() {
            IdSeguroViajero = Int_NullValue;
            Comision = Int_NullValue;
            Monto = Float_NullValue;
            TipoSeguroViajero = Int_NullValue;
            NumeroCompra = Int_NullValue;
            Descripcion = String_NullValue;
        }
    }
}
