<<<<<<< HEAD
﻿using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDAL.Util
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using AgenciaDeViajesDTO.Util;

namespace AgenciaDeViajesDAL.util
>>>>>>> 2444e8b27916882e5b23e8872e71cdb1162f9147
{
    internal abstract class DTOParserSQLClient : DTOParser
    {
        abstract internal DTOBase PopulateDTO(SqlDataReader reader);
        abstract internal void PopulateOrdinals(SqlDataReader reader);
<<<<<<< HEAD
        internal int GetOrdinalOrThrow(SqlDataReader reader, string columnName)
=======
        internal int getOrdinalOrThrow(SqlDataReader reader, string columnName)
>>>>>>> 2444e8b27916882e5b23e8872e71cdb1162f9147
        {
            try
            {
                return reader.GetOrdinal(columnName);
            }
<<<<<<< HEAD
            catch (IndexOutOfRangeException)
=======
            catch 
>>>>>>> 2444e8b27916882e5b23e8872e71cdb1162f9147
            {
                return -1;
            }
        }
    }
}
