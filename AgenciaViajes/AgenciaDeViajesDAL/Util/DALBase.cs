using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using AgenciaDeViajesDTO.Util;


namespace AgenciaDeViajesDAL
{
    public abstract class DALBase
    {
        // ConnectionString
        protected static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        // ConnectionString - ConnectionName
        protected static string ConnectionString(string strConnectionName)
        {
            return ConfigurationManager.ConnectionStrings[strConnectionName].ConnectionString;
        }

        // GetDbConnection
        protected static SqlConnection GetDbConnection()
        {
            return new SqlConnection(ConnectionString());
        }

        // GetDbConnection - ConnectionName
        protected static SqlConnection GetDbConnection(string strConnectionName)
        {
            return new SqlConnection(ConnectionString(strConnectionName));
        }

        // GetDbSqlCommand
        protected static SqlCommand GetDbSQLCommand(string sqlQuery)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = GetDbConnection();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            return command;
        }

        // GetDbSqlCommand - ConnectionName
        protected static SqlCommand GetDbSQLCommand(string sqlQuery, string strConnectionName)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = GetDbConnection(strConnectionName);
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            return command;
        }

        // GetDbSprocCommand
        protected static SqlCommand GetDbSprocCommand(string sprocName)
        {
            SqlCommand command = new SqlCommand(sprocName);
            command.Connection = GetDbConnection();
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }

        // GetDbSprocCommand - ConnectionName
        protected static SqlCommand GetDbSprocCommand(string sprocName, string strConnectionName)
        {
            SqlCommand command = new SqlCommand(sprocName);
            command.Connection = GetDbConnection(strConnectionName);
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }

        // CreateNullParameter
        protected static SqlParameter CreateNullParameter(string name, SqlDbType paramType)
        {
            SqlParameter parameter = new SqlParameter();
            parameter.SqlDbType = paramType;
            parameter.ParameterName = name;
            parameter.Value = null;
            parameter.Direction = ParameterDirection.Input;
            return parameter;
        }

        // CreateNullParameter - with size for nvarchars
        protected static SqlParameter CreateNullParameter(string name, SqlDbType paramType, int size)
        {
            SqlParameter parameter = new SqlParameter();
            parameter.SqlDbType = paramType;
            parameter.ParameterName = name;
            parameter.Size = size;
            parameter.Value = null;
            parameter.Direction = ParameterDirection.Input;
            return parameter;
        }

        // CreateOutputParameter
        protected static SqlParameter CreateOutputParameter(string name, SqlDbType paramType)
        {
            SqlParameter parameter = new SqlParameter();
            parameter.SqlDbType = paramType;
            parameter.ParameterName = name;
            parameter.Direction = ParameterDirection.Output;
            return parameter;
        }

        // CreateOuputParameter - with size for varchars
        protected static SqlParameter CreateOutputParameter(string name, SqlDbType paramType, int size)
        {
            SqlParameter parameter = new SqlParameter();
            parameter.SqlDbType = paramType;
            parameter.Size = size;
            parameter.ParameterName = name;
            parameter.Direction = ParameterDirection.Output;
            return parameter;
        }

        // CreateParameter - uniqueidentifier
        protected static SqlParameter CreateParameter(string name, Guid value)
        {
            if (value.Equals(DTOBase.Guid_NullValue))
            {
                // If value is null then create a null parameter
                return CreateNullParameter(name, SqlDbType.UniqueIdentifier);
            }
            else
            {
                SqlParameter parameter = new SqlParameter();
                parameter.SqlDbType = SqlDbType.UniqueIdentifier;
                parameter.ParameterName = name;
                parameter.Value = value;
                parameter.Direction = ParameterDirection.Input;
                return parameter;
            }
        }

        // CreateParameter - int
        protected static SqlParameter CreateParameter(string name, int value)
        {
            if (value == DTOBase.Int_NullValue)
            {
                // If value is null then create a null parameter
                return CreateNullParameter(name, SqlDbType.Int);
            }
            else
            {
                SqlParameter parameter = new SqlParameter();
                parameter.SqlDbType = SqlDbType.Int;
                parameter.ParameterName = name;
                parameter.Value = value;
                parameter.Direction = ParameterDirection.Input;
                return parameter;
            }
        }

        // CreateParameter - datetime
        protected static SqlParameter CreateParameter(string name, DateTime value)
        {
            if (value == DTOBase.DateTime_NullValue)
            {
                // If value is null then create a null parameter
                return CreateNullParameter(name, SqlDbType.DateTime);
            }
            else
            {
                SqlParameter parameter = new SqlParameter();
                parameter.SqlDbType = SqlDbType.DateTime;
                parameter.ParameterName = name;
                parameter.Value = value;
                parameter.Direction = ParameterDirection.Input;
                return parameter;
            }
        }

        // CreateParameter - varchar
        protected static SqlParameter CreateParameter(string name, string value, int size)
        {
            if (value == DTOBase.String_NullValue)
            {
                // If value is null then create a null parameter
                return CreateNullParameter(name, SqlDbType.VarChar);
            }
            else
            {
                SqlParameter parameter = new SqlParameter();
                parameter.SqlDbType = SqlDbType.VarChar;
                parameter.Size = size;
                parameter.ParameterName = name;
                parameter.Value = value;
                parameter.Direction = ParameterDirection.Input;
                return parameter;
            }
        }

        // CreateParameter - float
        protected static SqlParameter CreateParameter(string name, float value)
        {
            if (value == DTOBase.Float_NullValue)
            {
                // If value is null then create a null parameter
                return CreateNullParameter(name, SqlDbType.Float);
            }
            else
            {
                SqlParameter parameter = new SqlParameter();
                parameter.SqlDbType = SqlDbType.Float;
                parameter.ParameterName = name;
                parameter.Value = value;
                parameter.Direction = ParameterDirection.Input;
                return parameter;
            }
        }

        // CreateParameter - decimal
        protected static SqlParameter CreateParameter(string name, decimal value)
        {
            if (value == DTOBase.Decimal_NullValue)
            {
                // If value is null then create a null parameter
                return CreateNullParameter(name, SqlDbType.Decimal);
            }
            else
            {
                SqlParameter parameter = new SqlParameter();
                parameter.SqlDbType = SqlDbType.Decimal;
                parameter.ParameterName = name;
                parameter.Value = value;
                parameter.Direction = ParameterDirection.Input;
                return parameter;
            }
        }

        // GetSingleDTO
        protected static T GetSingleDTO<T>(ref SqlCommand command) where T : DTOBase
        {
            T dto = null;
            try
            {
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    DTOParserSQLClient parser = DTOParserFactory.GetParserSQLClient(typeof(T));

                    parser.PopulateOrdinals(reader);
                    dto = (T)parser.PopulateDTO(reader);
                    reader.Close();
                }
                else
                {
                    // Whever there's no data, we return null.
                    dto = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error populating data", e);
            }
            finally
            {
                command.Connection.Close();
                command.Connection.Dispose();
            }
            // return the DTO, it's either populated with data or null.
            return dto;
        }

        // GetDTOList
        protected static List<T> GetDTOList<T>(ref SqlCommand command) where T : DTOBase
        {
            List<T> dtoList = new List<T>();
            try
            {
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    // Get a parser for this DTO type and populate
                    // the ordinals.
                    DTOParserSQLClient parser = DTOParserFactory.GetParserSQLClient(typeof(T));
                    parser.PopulateOrdinals(reader);
                    // Use the parser to build our list of DTOs.
                    while (reader.Read())
                    {
                        T dto = null;
                        dto = (T)parser.PopulateDTO(reader);
                        dtoList.Add(dto);
                    }
                    reader.Close();
                }
                else
                {
                    // Whenver there's no data, we return null.
                    //dtoList = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error populating data", e);
            }
            finally
            {
                command.Connection.Close();
                command.Connection.Dispose();
            }
            return dtoList;
        }


    }
}
