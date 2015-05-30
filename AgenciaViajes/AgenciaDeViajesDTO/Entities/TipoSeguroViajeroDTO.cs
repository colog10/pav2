using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class TipoSeguroViajeroDTO : DTOBase
    {
        public int tipoSeguroViajeroDTO {get; set;}
        public string descripcionDTO {get; set;}

        public TipoSeguroViajeroDTO ()
        {
            this.tipoSeguroViajeroDTO = Int_NullValue;
            this.descripcionDTO = String_NullValue;

        }

    }
}
