using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class EmpleadoDTO : DTOBase
    {
        public int IdEmpleado { get; set; }
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int IdUsuario { get; set; }
        public Boolean Activo { get; set; }
        public Boolean Supervisor { get; set; }
        public UsuarioDTO Usuario { get; set; }

        public EmpleadoDTO()
        {
            IdEmpleado = Int_NullValue;
            Legajo = Int_NullValue;
            Nombre = String_NullValue;
            Apellido = String_NullValue;
            FechaAlta = DateTime_NullValue;
            FechaBaja = DateTime_NullValue;
            IdUsuario = Int_NullValue;
            Activo = Boolean_NullValue;
            Supervisor = Boolean_NullValue;
        }

        
    }
}
