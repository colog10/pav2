using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class UsuarioDTO :DTOBase
    {
        public int usuarioDTO { get; set; }
        public Boolean activoDTO { get; set; }
        public DateTime fechaAltaDTO { get; set; }
        public DateTime fechaBajaDTO { get; set; }
        public string nombreDTO { get; set; }
        public string passwordDTO { get; set; }

        public UsuarioDTO()
        {
            usuarioDTO = Int_NullValue;
            activoDTO = Boolean_NullValue;
            fechaAltaDTO = DateTime_NullValue;
            fechaBajaDTO = DateTime_NullValue;
            nombreDTO = String_NullValue;
            passwordDTO = String_NullValue;
        }

    }
}
