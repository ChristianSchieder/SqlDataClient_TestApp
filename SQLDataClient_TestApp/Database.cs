using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SQLDataClient_TestApp
{
    public class Database
    {
        private string _ConnectionString { get; set; }
        protected Dictionary<string, SqlParameterCollection> _CommandCache = new Dictionary<string, SqlParameterCollection>();

        public Database(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("Connection string has to be provided!");
            }
            else
            {
                _ConnectionString = connectionString;
            }            
        }

        public SqlCommand GetStoredProcCommand(string spName)
        {
            SqlCommand Result = new SqlCommand(spName);
            Result.CommandType = CommandType.StoredProcedure;

            if (!_CommandCache.ContainsKey(spName))
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    SqlCommand Resolve = Result.Clone();
                    Resolve.Connection = con;
                    SqlCommandBuilder.DeriveParameters(Resolve); // Causing trouble when sp contains a parameter of type XML
                    _CommandCache.Add(spName,Resolve.Parameters);
                    Resolve.Dispose();
                }
            }

            // There would go other stuff but this part isn't hit at all

            return Result;
        }
    }
}
