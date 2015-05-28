using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    class EmpresaColectivoDTO : DTOBase
    {
        public int idEmpresaColectivoDTO { get; set; }
        public string nombreDTO{ get; set; }
        public string telefonoDTO { get; set; }
        public string paginaWebDTO { get; set; }

        public EmpresaColectivoDTO()
        {
            idEmpresaColectivoDTO = Int_NullValue;
            nombreDTO = String_NullValue;
            telefonoDTO = String_NullValue;
            paginaWebDTO = String_NullValue;
        }

    }
}
