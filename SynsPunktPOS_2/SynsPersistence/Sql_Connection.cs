using SynsEntity;
using System;
using System.Data.SqlClient;
namespace SynsPersistence
{
    public class Sql_Connection
    {
        //Author: Jesper

        private string password;
        public Sql_Connection()
        {
            password = Credentials.loginPass;
        }

        private SqlConnection conn = null;
        private SqlCommand comm = null;

        public SqlConnection Connection()

        {
            conn = new SqlConnection($"Server = tcp:marc3411.database.windows.net; Initial Catalog = marcdatabase; Persist Security Info = False; User ID = marc3411; Password = {password}; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            return conn;
        }

        public void PrepareSql(String sqlString)
        {
            conn = Connection();
            conn.Open();
            comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = sqlString;
        }
        public void ExecuteSql(String sqlString)
        {
            PrepareSql(sqlString);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public SqlDataReader ReadData()
        {
            SqlDataReader sqld;
            sqld = comm.ExecuteReader();
            return sqld;
        }
        public void CloseConnection()
        {
            conn.Close();
        }

        public string VerifyConnection()
        {   
            conn = Connection();
            conn.Open();
            return conn.ServerVersion;
            
        }

    }
}
