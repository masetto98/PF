using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
namespace Data.Database
{
    public class Adapter
    {
        const string consKeyDefaultCnnString = "ConnStringLocal";
        protected SqlConnection sqlConn;
        
        protected void OpenConnection()
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["ConnStringDefault"].ConnectionString;
            //this.sqlConn = new SqlConnection(connectionString);
           
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
            string connectionString = configuration.GetConnectionString("ConnStringLocal");
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
