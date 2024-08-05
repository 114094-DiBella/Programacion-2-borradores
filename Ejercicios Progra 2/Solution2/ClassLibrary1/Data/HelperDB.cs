using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Data
{
    public class HelperDB 
    {
        private readonly string connectionString;
        private SqlConnection cnn;

        public HelperDB()
        {
            connectionString = @"Data Source=DESKTOP-F08K4QC\SQLEXPRESS;Initial Catalog=Ordenes;Integrated Security=True;Trust Server Certificate=True";
            cnn = new SqlConnection(connectionString);       
        }

       
        public DataTable ConsultarSql(string sp) { 
        
            DataTable dt = new DataTable();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = sp;
            cmd.CommandType = CommandType.StoredProcedure;    
            cnn.Open();
            var reader = cmd.ExecuteReader();
            dt.Load(reader);
            cnn.Close();
            return dt;

        }

        public SqlConnection GetConnection()
        {
            return cnn;
        }

    }
}
