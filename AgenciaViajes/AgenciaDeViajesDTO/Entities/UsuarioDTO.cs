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
        public int IdUsuario { get; set; }
        public Boolean Activo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }

        public UsuarioDTO()
        {
            IdUsuario = Int_NullValue;
            Activo = Boolean_NullValue;
            FechaAlta = DateTime_NullValue;
            FechaBaja = DateTime_NullValue;
            Nombre = String_NullValue;
            Password = String_NullValue;
        }

    }
}
