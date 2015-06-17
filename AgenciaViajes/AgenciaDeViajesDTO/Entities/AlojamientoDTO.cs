using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class AlojamientoDTO : DTOBase
    {
        public int idAlojamientoDTO { get; set; }
        public int idTipoAlojamientoDTO { get; set; }
        public string domicilioDTO { get; set; }
        public string nombreDTO { get; set; }
        public int numeroTelefonoDTO { get; set; }

        public AlojamientoDTO()
        {
            idAlojamientoDTO = Int_NullValue;
            idTipoAlojamientoDTO = Int_NullValue;
            domicilioDTO = String_NullValue;
            nombreDTO = String_NullValue;
            numeroTelefonoDTO = Int_NullValue;
        }

    }
}
