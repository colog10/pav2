using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDAL.Util
{
    internal abstract class DTOParserSQLClient : DTOParser
    {
        abstract internal DTOBase PopulateDTO(SqlDataReader reader);
        abstract internal void PopulateOrdinals(SqlDataReader reader);
        internal int GetOrdinalOrThrow(SqlDataReader reader, string columnName)
        {
            try
            {
                return reader.GetOrdinal(columnName);
            }
            catch (IndexOutOfRangeException)
            {
                return -1;
            }
        }
    }
}
