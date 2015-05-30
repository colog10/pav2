using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgenciaDeViajesDTO.Entities
{
    public class CiudadDTO : DTOBase
    {
        public int idCiudadDTO { get; set; }
        public string ciudadNombreDTO { get; set; }
        public string idPaisDTO { get; set; }
        public string ciudadDistritoDTO { get; set; }
        public int ciudadPoblacionDTO { get; set; }
        public int tipoDestinoDTO { get; set; }

        public CiudadDTO()
        {
            idCiudadDTO = Int_NullValue;
            ciudadNombreDTO = String_NullValue;
            idPaisDTO = String_NullValue;
            ciudadDistritoDTO = String_NullValue;
            ciudadPoblacionDTO = Int_NullValue;
            tipoDestinoDTO = Int_NullValue;
        }

    }
}
