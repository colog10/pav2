using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaDeViajesDAL.DAL;

namespace AgenciaDeViajesBLL
{
   public class TipoDocumentoManager
    {
        public static string[] GetTipoDocumento(string tipoDoc)
        {
            
                 return new string[] { "DNI" };
        
        }
        public static List<AgenciaDeViajesDTO.Entities.TipoDocumentoDTO> GetTipoDocumento()
        {
            return TipoDocumentoDB.GetAll();
        }


        
    }
}
