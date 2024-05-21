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
                databaseAccess v = new databaseAccess();
                v.OpenConnection();
                v.LoadSpParameters("getEnrolledfromSID", dt.Rows[0][0].ToString());
                v.ExecuteQuery();
                DataTable d = v.GetDataTable();
                v.CloseConnection();
                if (d.Rows.Count != 0)
                {
                    for (int i = 0; i < d.Rows.Count; i++)
                    {
                        User_Controls.Course_3 c1 = new User_Controls.Course_3();
                        v = new databaseAccess();
                        v.OpenConnection();
                        v.LoadSpParameters("getClasses", d.Rows[i][0]);
                        v.ExecuteQuery();
                        DataTable dt2 = v.GetDataTable();
                        v.CloseConnection();
       
                        string lorT = dt2.Rows[0][1].ToString().Substring(dt2.Rows[0][1].ToString().Length - 4, 3);
                        v = new databaseAccess();
                        v.OpenConnection();
                        v.LoadSpParameters("getAbreviation",dt2.Rows[0][1].ToString());
                        string abr = v.ExecuteValue().ToString();
                        v.CloseConnection();
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
                databaseAccess v = new databaseAccess();
                v.OpenConnection();
                v.LoadSpParameters("getStudentofID", StudentID.Text.ToString());
                v.ExecuteQuery();
                DataTable dt = v.GetDataTable();
                v.CloseConnection();
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
            databaseAccess v = new databaseAccess();
            v.OpenConnection();
            v.LoadSpParameters("getStudentofCid", cid, sid.ToString());
            v.ExecuteQuery();
            DataTable dt = v.GetDataTable();
            v.CloseConnection();

            if (dt.Rows[0][3].ToString() != "")
            {
                v = new databaseAccess();
                v.OpenConnection();
                v.LoadSpParameters("deleteAssesment", dt.Rows[0][3].ToString());
                v.ExecuteQuery();
                v.CloseConnection();
            }

            v = new databaseAccess();
            v.OpenConnection();
            v.LoadSpParameters("deleteEnrollment ", cid, sid.ToString());
            v.ExecuteQuery();
            v.CloseConnection();
            MyMessageBox.Show("Course Dropped Successfully");

            v.OpenConnection();
            v.LoadSpParameters("getStudentofID  ", sid);
            v.ExecuteQuery();
            DataTable dt4 = v.GetDataTable();
            v.CloseConnection();
            LoadCourses(dt4);
        }
    }
}
