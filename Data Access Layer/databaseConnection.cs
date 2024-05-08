using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace KIET_LMS
{
    public static class databaseConnection
    {
        public static string server;
        public static string database;
        public static string userid;
        public static string password;
       
        public static SqlConnection sql = new SqlConnection(databaseConnection.CreateConnectionString());

        public static string CreateConnectionString()
        {
          //    string con = "data source = " + databaseConnection.server.Trim() + "; initial catalog = " + databaseConnection.database.Trim() + "; user id = " + databaseConnection.userid.Trim() + "; password = " + databaseConnection.password.Trim() + ";";
          string con = "data source = tcp:192.168.0.107,1433; initial catalog = KIET_LMS; user id = Mubashir;password = mub123;";
            return con;

        }
        public static SqlConnection getConnection() 
        {
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }

            return sql;
        }

        public static DataTable getTable(string query)
        {
            SqlCommand cmd = new SqlCommand(query, databaseConnection.getConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            return dt;
        }

        public static void Execute(string query) 
        {
            SqlCommand cmd = new SqlCommand(query,databaseConnection.getConnection());
            cmd.ExecuteNonQuery();
        }
       
    }
}
