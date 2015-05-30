using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class TipoDestinoDTO : DTOBase
    {
        public int idTipoDestinoDTO {get; set;}
        public string descripcionDTO {get; set;}

        public TipoDestinoDTO ()
        {
            this.idTipoDestinoDTO = Int_NullValue;
            this.descripcionDTO = String_NullValue;

        }

    }
}
