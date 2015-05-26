using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class MotivoViajeDTO : DTOBase
    {
        public int IdMotivoViaje { get; set; }
        public string Descripcion { get; set; }

        public MotivoViajeDTO()
        {
            IdMotivoViaje = Int_NullValue;
            Descripcion = String_NullValue;
        }

    }
}
