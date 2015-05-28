using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class CobroDTO : DTOBase
    {
        public int numeroCobroDTO { get; set; }
        public DateTime fechaCobroDTO { get; set; }
        public int numeroVentaDTO { get; set; }
        public float montoDTO { get; set; }

        public CobroDTO()
        {
            numeroCobroDTO = Int_NullValue;
            fechaCobroDTO = DateTime_NullValue;
            numeroVentaDTO = Int_NullValue;
            montoDTO = Float_NullValue;
        }

    }
}
