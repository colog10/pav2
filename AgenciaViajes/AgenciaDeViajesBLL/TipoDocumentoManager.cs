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
            //switch (tipoDoc.ToLower())
            //{
            //    case "administrador":
            //        return new string[] { "administrador", };
            //    case "usuario":
            //        return new string[] { "usuario" };
            //    default:
                 return new string[] { "clientes" };
            //}
        }
        public static List<AgenciaDeViajesDTO.Entities.TipoDocumentoDTO> GetTipoDocumento()
        {
            return TipoDocumentoDB.GetAll();
        }

    }
}
