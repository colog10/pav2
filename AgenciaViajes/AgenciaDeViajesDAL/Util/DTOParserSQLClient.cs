using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using AgenciaDeViajesDTO.Util;

namespace AgenciaDeViajesDAL.util
{
    internal abstract class DTOParserSQLClient : DTOParser
    {
        abstract internal DTOBase PopulateDTO(SqlDataReader reader);
        abstract internal void PopulateOrdinals(SqlDataReader reader);
        internal int getOrdinalOrThrow(SqlDataReader reader, string columnName)
        {
            try
            {
                return reader.GetOrdinal(columnName);
            }
            catch 
            {
                return -1;
            }
        }
    }
}
