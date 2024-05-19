using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KIET_LMS;

namespace Data_Access_Layer
{
    public static class databaseAccess
    {
        private static System.Collections.Hashtable SqlparamCache = System.Collections.Hashtable.Synchronized(new System.Collections.Hashtable());
        private static SqlConnection Connection = new SqlConnection();

        private static SqlCommand DbCommand = new SqlCommand();
        private static SqlDataAdapter DtAdapter = new SqlDataAdapter();
        private static DataSet SqlDataSet = new DataSet();
        private static DataTable SqlTable = new DataTable();


        public static void UnLoadSpParameters()
        {
            DbCommand.Parameters.Clear();
        }

        public static void LoadSpParameters(string SpName, params object[] ParaValues)
        {
            SqlParameter[] TheParameters = (SqlParameter[])SqlparamCache[SpName];
            DbCommand.Parameters.Clear();
            if (TheParameters == null)
            {
                DbCommand.CommandType = CommandType.StoredProcedure;
                DbCommand.CommandText = SpName;
                SqlCommandBuilder.DeriveParameters(DbCommand);
                TheParameters = new SqlParameter[DbCommand.Parameters.Count];

                DbCommand.Parameters.CopyTo(TheParameters, 0);
                SqlparamCache[SpName] = TheParameters;

            }
            else
            {
                short i;
                SqlParameter SqPr;
                DbCommand.CommandType = CommandType.StoredProcedure;
                DbCommand.CommandText = SpName;
                for (i = 0; i < TheParameters.Length; i++)
                {
                    SqPr = (SqlParameter)((System.ICloneable)(TheParameters[i])).Clone();
                    DbCommand.Parameters.Add(SqPr);
                }

            }
            MoveSqlParameters(ParaValues);

        }

        private static void MoveSqlParameters(object[] Paras)
        {
            short ic;
            SqlParameter sqlPara;
            if (Paras.Length >= 0)
            {
                for (ic = 0; ic < Paras.Length; ic++)
                {
                    sqlPara = DbCommand.Parameters[ic + 1];
                    string s = sqlPara.ParameterName;
                    sqlPara.Value = Paras[ic];
                }
            }
        }

        public static SqlParameter Parameters(int P)
        {
            return DbCommand.Parameters[P];
        }

        public static bool OpenConnection()
        {
            DbCommand = new SqlCommand();
            try
            {
                if (Connection.State == ConnectionState.Open) return true;
                Connection = new SqlConnection();
                Connection.ConnectionString = databaseConnection.CreateConnectionString();
                Connection.Open();
                if (Connection.State == ConnectionState.Open)
                {
                    DbCommand.Connection = Connection;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Exception ee)
            {
                throw new System.Exception("Database:OpenConnection:" + ee.Message);
            }
        }

        public static void CloseConnection()
        {
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
                DbCommand.Dispose();
                DtAdapter.Dispose();
                SqlDataSet.Dispose();
                SqlTable.Dispose();
            }
        }

        public static SqlDataReader GetDataReader()
        {
            return DbCommand.ExecuteReader();

        }

        public static int ExecuteQuery()
        {
            return DbCommand.ExecuteNonQuery();
        }

        public static object ExecuteValue()
        {
            return DbCommand.ExecuteScalar();
        }

        public static object ExecuteValue(string SQLStatement)
        {
            DbCommand.CommandType = CommandType.Text;
            DbCommand.CommandText = SQLStatement;
            return DbCommand.ExecuteScalar();
        }


        public static string ReturnValue(string _PName)
        {
            DbCommand.ExecuteNonQuery();
            return (string)DbCommand.Parameters[_PName].Value.ToString();

        }

        public static DataTable GetDataTable()
        {
            DtAdapter.SelectCommand = DbCommand;
            DtAdapter.Fill(SqlTable);
            return SqlTable;
        }

      
    }
}
