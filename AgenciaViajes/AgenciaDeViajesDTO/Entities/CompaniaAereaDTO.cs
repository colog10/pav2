using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class CompaniaAereaDTO : DTOBase
    {
        public int idCompaniaAereaDTO { get; set; }
        public string nombreDTO { get; set; }
        public string telefonoDTO { get; set; }
        public string paginaWebDTO { get; set; }

        public CompaniaAereaDTO()
        {
            idCompaniaAereaDTO = Int_NullValue;
            nombreDTO = String_NullValue;
            telefonoDTO = String_NullValue;
            paginaWebDTO = String_NullValue;

        }
    }
}
