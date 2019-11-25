using System;
using System.Data.SqlClient;

namespace SQLDataClient_TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = "";
            Database DB = new Database(ConnectionString);
            string StoredProcName = "sp_WriteToTestTable";

            try
            {
                SqlCommand Command = DB.GetStoredProcCommand(StoredProcName);
            }
            catch (Exception ex)
            {

            }            
        }
    }
}
