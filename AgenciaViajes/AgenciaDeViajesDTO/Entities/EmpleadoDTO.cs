using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    class EmpleadoDTO : DTOBase
    {
        public int idEmpleadoDTO { get; set; }
        public int legajoDTO { get; set; }
        public string nombreDTO { get; set; }
        public string apellidoDTO { get; set; }
        public DateTime fechaAltaDTO { get; set; }
        public DateTime fechaBajaDTO { get; set; }
        public int idUsuarioDTO { get; set; }
        public Boolean activoDTO { get; set; }
        public int supervisorDTO { get; set; }

        public EmpleadoDTO()
        {
            idEmpleadoDTO = Int_NullValue;
            legajoDTO = Int_NullValue;
            nombreDTO = String_NullValue;
            apellidoDTO = String_NullValue;
            fechaAltaDTO = DateTime_NullValue;
            fechaBajaDTO = DateTime_NullValue;
            idUsuarioDTO = Int_NullValue;
            activoDTO = Boolean_NullValue;
            supervisorDTO = Int_NullValue;
        }
    }
}
