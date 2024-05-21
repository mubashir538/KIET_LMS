using KIET_LMS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System.IO;
using System.Windows.Forms;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    public class InitialCode
    {
        string path = @"SOFTWARE\KIET_LMS";
        string servervalue = "ServerName";
        string dbvalue = "DatabaseName";
        string dbuservalue = "DatabaseUserID";
        string dbpassvalue = "DatabasePassword";
        public int SaveToDb()
        {
            databaseAccess v = new databaseAccess();
            v.OpenConnection();
            v.LoadSpParameters("checkemail",Student.email);
            v.ExecuteQuery();
            DataTable dt1 = v.GetDataTable();
            v.CloseConnection();

            if (dt1.Rows.Count == 0)
            {
                v = new databaseAccess();
                v.OpenConnection();
                v.LoadSpParameters("addStudent", Student.name, Student.email, Student.age, Student.DegreeProgram, Student.CNIC, Student.cellNo,
                    Student.gender, Student.Password, Student.crHourLimit);
                v.ExecuteQuery();
                v.CloseConnection();

                v = new databaseAccess();
                v.OpenConnection();
                v.LoadSpParameters("checkemail", Student.email);
                v.ExecuteQuery();
                DataTable dt2 = v.GetDataTable();
                v.CloseConnection();

                Student.SID = int.Parse(dt2.Rows[0][0].ToString());

                MyMessageBox.Show($"Welcome to KIET, You're now a Student of KIET with SID: {Student.SID}");
                return 0;
            }
            else
            {
                MyMessageBox.Show("This Email Already Exists");
                return 1;
            }
        }
        public int ValidateData(bool male,bool female, string name,string email,string age,string degreeprogram, string password,string conpass,string cell,string cnic)
        {
            if (name == "" || email == "" || age == "" || degreeprogram == "" ||
              cnic == "" || cell == "" || password == "" || conpass == "")
            {
                MyMessageBox.Show("Please Fill all the Information");
            }
            else
            {
                if (password == conpass)
                {
                    string gender = "";
                    if (male)
                    {
                        gender = "Male";
                    }
                    else if (female)
                    {
                        gender = "Female";
                    }
                    else
                    {
                        MyMessageBox.Show("Please Select a Gender");
                    }
                    Student.name = name;
                    Student.email = email;
                    Student.DegreeProgram = degreeprogram;
                    Student.CNIC = long.Parse(cnic);
                    Student.cellNo = long.Parse(cell);
                    Student.gender = gender;
                    Student.Password = password;
                    Student.age = int.Parse(age);
                    Student.crHourLimit = 15;


                    int error = SaveToDb();
                    return error;

                }

                else
                {
                    MyMessageBox.Show("Password don't match");
                }
                
            }
            return 1;
        }
    
        public int Login(string id, string pass)
        {
            if (int.Parse(id.ToString()) == 56057 && pass == "Basharat123")
            {
                return 2;
                
            }
            else
            {
                databaseAccess v = new databaseAccess();
                v.OpenConnection();
                v.LoadSpParameters("loginTeacher", id,pass);
                v.ExecuteQuery();
                DataTable dt = v.GetDataTable();
                v.CloseConnection();
                if (dt.Rows.Count != 0)
                {
                    Teacher.ID = int.Parse(dt.Rows[0][0].ToString());
                    Teacher.name = dt.Rows[0][1].ToString();
                    Teacher.faculty = dt.Rows[0][2].ToString();
                    Teacher.position = dt.Rows[0][3].ToString();
                    Teacher.department = dt.Rows[0][4].ToString();
                    Teacher.email = dt.Rows[0][6].ToString();
                    Teacher.password = dt.Rows[0][7].ToString();

                    return 1;
                    
                }
                else
                {
                    MyMessageBox.Show("Invalid ID or Password");
                }
                return 0;
            }
        }

        public int ConnecttoServer(string servername, string dbname, string userid, string password)
        {

            RegistryKey key = Registry.CurrentUser.OpenSubKey(path);
            if (key == null)
            {
                databaseConnection.server = servername;
                MessageBox.Show(databaseConnection.server);
                databaseConnection.database = dbname;

                databaseConnection.userid = userid;
                databaseConnection.password = password;
                databaseAccess v = new databaseAccess();
                v.OpenConnection();
                v.CloseConnection();

                string sname = servername.ToString();
                dbname = dbname.ToString();
                string dbuser = userid.ToString();
                string dbpass = password.ToString();

                var regkey = Registry.CurrentUser.CreateSubKey(path);
                regkey.SetValue(servervalue, sname, RegistryValueKind.String);
                regkey.SetValue(dbvalue, dbname, RegistryValueKind.String);
                regkey.SetValue(dbuservalue, dbuser, RegistryValueKind.String);
                regkey.SetValue(dbpassvalue, dbpass, RegistryValueKind.String);
                regkey.Close();
                
                return 0;
            }
            return 1;
          
        }
        public int CheckRegistry()
        {
      

        RegistryKey key = Registry.CurrentUser.OpenSubKey(path);
            if (key != null)
            {
                object svalue = key.GetValue(servervalue);
                object dvalue = key.GetValue(dbvalue);
                object duvalue = key.GetValue(dbuservalue);
                object dpvalue = key.GetValue(dbpassvalue);
                databaseConnection.server = svalue.ToString().Trim();
                databaseConnection.database = dvalue.ToString().Trim();
                databaseConnection.userid = duvalue.ToString().Trim();
                databaseConnection.password = dpvalue.ToString().Trim();


                key.Close();
                return 0;
            }
            return 1;

        }
    }
}
