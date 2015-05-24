using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class EstadoCivilDTO : CommonBase
    {
        public int IdEstadoCivil { get; set; }
        public string Descripcion { get; set; }

        public EstadoCivilDTO(){
            IdEstadoCivil = Int_NullValue;
            Descripcion = String_NullValue;
        }


    }
}
