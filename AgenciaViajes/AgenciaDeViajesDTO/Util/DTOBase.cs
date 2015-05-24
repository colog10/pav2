using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Util
{
    public abstract class DTOBase : CommonBase
    {
        public bool IsNew { get; set; }
    }
}
