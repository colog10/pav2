using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class TipoAlojamientoDTO : DTOBase
    {
        public int idTipoAlojamientoDTO {get; set;}
        public string descripcionDTO {get; set;}

        public TipoAlojamientoDTO ()
        {
            this.idTipoAlojamientoDTO = Int_NullValue;
            this.descripcionDTO = String_NullValue;
        }

    }
}
