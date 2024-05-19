using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Access_Layer;
using KIET_LMS.Program_manager;

namespace KIET_LMS
{
    public partial class stReg_pm : Form
    {
        int sid;
        public stReg_pm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadCourses(DataTable dt)
        {
            if (dt.Rows.Count != 0)
            {
                flowLayoutPanel1.Controls.Clear();
                databaseAccess.OpenConnection();
                databaseAccess.LoadSpParameters("getEnrolledfromSID", dt.Rows[0][0].ToString());
                databaseAccess.ExecuteQuery();
                DataTable d = databaseAccess.GetDataTable();
                databaseAccess.CloseConnection();
                if (d.Rows.Count != 0)
                {
                    for (int i = 0; i < d.Rows.Count; i++)
                    {
                        User_Controls.Course_3 c1 = new User_Controls.Course_3();
                        databaseAccess.OpenConnection();
                        databaseAccess.LoadSpParameters("getClasses", d.Rows[i][0]);
                        databaseAccess.ExecuteQuery();
                        DataTable dt2 = databaseAccess.GetDataTable();
                        databaseAccess.CloseConnection();
       
                        string lorT = dt2.Rows[0][1].ToString().Substring(dt2.Rows[0][1].ToString().Length - 4, 3);
                        databaseAccess.OpenConnection();
                        databaseAccess.LoadSpParameters("getAbreviation",dt2.Rows[0][1].ToString());
                        string abr = databaseAccess.ExecuteValue().ToString();
                        databaseAccess.CloseConnection();
                        c1.course.Text = abr.ToString();
                        c1.id.Text = d.Rows[i][0].ToString();
                        if (lorT == "Lab")
                        {
                            c1.BackColor = Color.FromArgb(81, 64, 64);
                        }
                        else
                        {
                            c1.BackColor = Color.FromArgb(54, 59, 75);
                        }
                        c1.Click += new EventHandler(RemoveCourse);
                        flowLayoutPanel1.Controls.Add(c1);
                    }
                }
                AddNew addNew = new AddNew();
                addNew.Click += new EventHandler(OpenForm);
                flowLayoutPanel1.Controls.Add(addNew);
            }
            else
            {
                MyMessageBox.Show("No Courses to Show!");
            }
        }
        private void stReg_pm_Load(object sender, EventArgs e)
        {
            name.Text = "Name: ";
            S_ID.Text = "Student ID: ";
            CGPA.Text = "CGPA: ";
            Age.Text = "Age: ";


        }

        private void OpenForm(object? sender, EventArgs e)
        {
            Form f = new addCoursePM(sid);
            ((ProgramManagerLMS)ParentForm).OpenForm(f);
        }

        private void StudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                databaseAccess.OpenConnection();
                databaseAccess.LoadSpParameters("getStudentofID", StudentID.Text.ToString());
                databaseAccess.ExecuteQuery();
                DataTable dt = databaseAccess.GetDataTable();
                databaseAccess.CloseConnection();
                string query = String.Format("select * from Std where ID={0}");
                sid = int.Parse(StudentID.Text);
                if (dt.Rows.Count == 0)
                {
                    MyMessageBox.Show("This Student Does not Exist");
                }
                else
                {
                    sid = int.Parse(dt.Rows[0][0].ToString());
                    name.Text = "Name: " + dt.Rows[0][1].ToString();
                    S_ID.Text = "Student ID: " + dt.Rows[0][0].ToString();
                    if (dt.Rows[0][12].ToString() == "")
                    {
                        CGPA.Text = "CGPA: N/A";
                    }
                    else
                    {
                        CGPA.Text = "CGPA: " + dt.Rows[0][12].ToString();
                    }
                    Age.Text = "Age: " + dt.Rows[0][3].ToString();
                }
                StudentID.Text = "";
                LoadCourses(dt);
            }
        }

        private void RemoveCourse(object sender, EventArgs e)
        {
            User_Controls.Course_3 c3 = (User_Controls.Course_3)sender;
            string cid = c3.id.Text;

            databaseAccess.OpenConnection();
            databaseAccess.LoadSpParameters("getStudentofCid", cid, sid.ToString());
            databaseAccess.ExecuteQuery();
            DataTable dt = databaseAccess.GetDataTable();
            databaseAccess.CloseConnection();

            if (dt.Rows[0][3].ToString() != "")
            {
                databaseAccess.OpenConnection();
                databaseAccess.LoadSpParameters("deleteAssesment", dt.Rows[0][3].ToString());
                databaseAccess.ExecuteQuery();
                databaseAccess.CloseConnection();
            }

            databaseAccess.OpenConnection();
            databaseAccess.LoadSpParameters("deleteEnrollment ", cid, sid.ToString());
            databaseAccess.ExecuteQuery();
            databaseAccess.CloseConnection();
            MyMessageBox.Show("Course Dropped Successfully");

            databaseAccess.OpenConnection();
            databaseAccess.LoadSpParameters("getStudentofID  ", sid);
            databaseAccess.ExecuteQuery();
            DataTable dt4 = databaseAccess.GetDataTable();
            databaseAccess.CloseConnection();
            LoadCourses(dt4);
        }
    }
}
