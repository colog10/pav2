using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class PaxFrecuenteXCiaAereaDTO : CommonBase
    {
        public int IdPasajero { get; set; }
        public int IdCompaniaAerea { get; set; }
        public int NroPaxFrecuente { get; set; }

        public PaxFrecuenteXCiaAereaDTO()
        {
	        IdPasajero = Int_NullValue;
            IdCompaniaAerea = Int_NullValue;
	        NroPaxFrecuente = Int_NullValue;
        }
    }
}
