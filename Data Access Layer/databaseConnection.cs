﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace KIET_LMS
{
    public static class databaseConnection
    {
        public static string server;
        public static string database;
        public static string userid;
        public static string password;
       
        
        public static string CreateConnectionString()
        {
             string con = "data source = " + server.Trim() + "; initial catalog = " + database.Trim() + "; user id = " + userid.Trim() + "; password = " + password.Trim() + ";";
            // "data source = tcp:192.168.0.107,1433; initial catalog = KIET_LMS; user id = Mubashir;password = mub123;";
            return con;

        }


    }
}
