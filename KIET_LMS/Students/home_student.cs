using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIET_LMS
{
    public partial class home_student : Form
    {
        double attendance;
        public home_student()
        {
            InitializeComponent();
        }

        private void home_student_Load(object sender, EventArgs e)
        {
            name.Text = "Name: " + Student.name;
            sid.Text = "Student ID: " + Student.SID;
            age.Text = "Age: " + Student.age;
            cgpa.Text = "CGPA: " + Student.CGPA;
            CheckAttendance();
            attendance_bar.Value = (int)attendance;
            attendance_bar.Text = ((int)attendance).ToString() + "%";
            CheckBestMarks();
            CheckProgress();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void CheckAttendance()
        {
            databaseAccess v = new databaseAccess();
            v.OpenConnection();
            v.LoadSpParameters("getEnrolledfromSID",Student.SID);
            v.ExecuteQuery();
            DataTable dt = v.GetDataTable();
            v.CloseConnection();
            if (dt.Rows.Count != 0)
            {
                double totaldays = 0;
                double presents = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    totaldays += int.Parse(dt.Rows[i][4].ToString());
                    totaldays += int.Parse(dt.Rows[i][5].ToString());
                    presents += int.Parse(dt.Rows[i][4].ToString());
                }

                if (totaldays == 0)
                {
                    attendance = 0;
                }
                else
                {
                    double points = (double)presents / (double)totaldays;
                    attendance = points * 100;
                }
            }
      
        }

        private void CheckBestMarks()
        {
            double max = 0;
            string course = "";
            double obtained = 0;
            databaseAccess v = new databaseAccess();
            v.OpenConnection();
            v.LoadSpParameters("getEnrolledfromSID", Student.SID);
            v.ExecuteQuery();
            DataTable dt = v.GetDataTable();
            v.CloseConnection();
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][3].ToString() != "")
                    {
                        v = new databaseAccess();
                        v.OpenConnection();
                        v.LoadSpParameters("getAssesmenfromAID", dt.Rows[i][3].ToString());
                        v.ExecuteQuery();
                        DataTable dt2 = v.GetDataTable();
                        v.CloseConnection();
                        if (dt2.Rows.Count != 0)
                        {
                            double total = checknull(dt2.Rows[0][10].ToString()) +
                                checknull(dt2.Rows[0][11].ToString()) +
                                checknull(dt2.Rows[0][12].ToString()) +
                                checknull(dt2.Rows[0][13].ToString()) +
                                checknull(dt2.Rows[0][14].ToString()) +
                                checknull(dt2.Rows[0][15].ToString()) +
                                checknull(dt2.Rows[0][16].ToString()) +
                                checknull(dt2.Rows[0][17].ToString()) +
                                checknull(dt2.Rows[0][18].ToString());
                            double obt = checknull(dt2.Rows[0][1].ToString()) +
                                checknull(dt2.Rows[0][2].ToString()) +
                                checknull(dt2.Rows[0][3].ToString()) +
                                checknull(dt2.Rows[0][4].ToString()) +
                                checknull(dt2.Rows[0][5].ToString()) +
                                checknull(dt2.Rows[0][6].ToString()) +
                                checknull(dt2.Rows[0][7].ToString()) +
                                checknull(dt2.Rows[0][8].ToString()) +
                                checknull(dt2.Rows[0][9].ToString());

                            double points = obt / total;
                            double per = points * 100;
                            if (max < per)
                            {
                                max = per;
                                obtained = obt;
                                v = new databaseAccess();
                                v.OpenConnection();
                                v.LoadSpParameters("getClasses", dt2.Rows[0][19].ToString());
                                v.ExecuteQuery();
                                DataTable dt3 = v.GetDataTable();
                                v.CloseConnection();

                                v = new databaseAccess();
                                v.OpenConnection();
                                v.LoadSpParameters("getAbreviation", dt3.Rows[0][1].ToString());
                                string abr = v.ExecuteValue().ToString();
                                v.CloseConnection();
                                course = abr.ToString();
                            }
                        }
                    }
                }
            }

            best_marksbar.Text = course + "\n" + ((int)obtained).ToString() + " ";
            best_marksbar.Value = (int)obtained;
        }

        private void CheckProgress()
        {
            databaseAccess v = new databaseAccess();
            v.OpenConnection();
            v.LoadSpParameters("getEnrolledfromSID", Student.SID);
            v.ExecuteQuery();
            DataTable dt = v.GetDataTable();
            v.CloseConnection();
            double selectedCourses = dt.Rows.Count;
            double points = selectedCourses / 5.0;
            double per = points * 100;
            progressprogressbar.Value = (int)per;
            progressprogressbar.Text = ((int)per).ToString() + "%";
        }
        private int checknull(string val)
        {
            int a;
            if (val == "")
            {
                a = 0;
            }
            else
            {
                a = int.Parse(val);
            }

            return a;
        }
    }
}
