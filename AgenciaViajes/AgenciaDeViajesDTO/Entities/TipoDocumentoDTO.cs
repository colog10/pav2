using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class TipoDocumentoDTO : DTOBase
    {
        public int idTipoDocumentoDTO  {get; set;}
        public string descripcionDTO {get; set;}

        public TipoDocumentoDTO ()
        {
            this.idTipoDocumentoDTO = Int_NullValue;
            this.descripcionDTO = String_NullValue;

        }

    }
}
