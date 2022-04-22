using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {
        const string consKeyDefaultCnnString = "ConnStringLocal";
        protected SqlConnection sqlConn;
        
        protected void OpenConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnStringDefault"].ConnectionString;
            this.sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
        }

        protected void CloseConnection()
        {
            sqlConn.Close();
            sqlConn = null;
        }

        
    }
}
