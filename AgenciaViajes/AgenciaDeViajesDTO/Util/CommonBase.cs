using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Util
{
    public class CommonBase : DTOBase
    {
        public static DateTime DateTime_NullValue = DateTime.MinValue;
        public static Guid Guid_NullValue = Guid.Empty;
        public static int Int_NullValue = int.MinValue;
        public static float Float_NullValue = float.MinValue;
        public static decimal Decimal_NullValue = decimal.MinValue;
        public static string String_NullValue = "";
        public static bool Boolean_NullValue = false;
    }   
}
