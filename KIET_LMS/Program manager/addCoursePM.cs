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
    public partial class addCoursePM : Form
    {
        int sid;
        public addCoursePM()
        {
            InitializeComponent();
        }
        public addCoursePM(int sid)
        {
            InitializeComponent();
            this.sid = sid;
        }

        private void addCoursePM_Load(object sender, EventArgs e)
        {
            new TouchScrollVertical(flowLayoutPanel1);
            CourseLoad();
        }

        private void CourseLoad()
        {
            flowLayoutPanel1.Controls.Clear();
            databaseAccess d = new databaseAccess();
            d.OpenConnection();
            d.LoadSpParameters("getClassIDs");
            d.ExecuteQuery();
            DataTable dt2 = d.GetDataTable();
            d.CloseConnection();

            d.OpenConnection();
            d.LoadSpParameters("getEnrolledfromSID",sid);
            d.ExecuteQuery();
            DataTable dt = d.GetDataTable();
            d.CloseConnection();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (dt.Rows.Count != 0)
                {
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        if (dt.Rows[j][0].ToString() != dt2.Rows[i][0].ToString())
                        {
                            User_Controls.Course2 c = new User_Controls.Course2();
                            c.id.Text = dt2.Rows[i][0].ToString();
                            d = new databaseAccess();
                            d.OpenConnection();
                            d.LoadSpParameters("getAbreviation", dt2.Rows[i][1].ToString());
                            string abr = d.ExecuteValue().ToString();
                            d.CloseConnection();
                            c.course.Text = abr.ToString();
                            c.Click += new EventHandler(CourseSelected);
                            flowLayoutPanel1.Controls.Add(c);
                            break;
                        }
                    }
                }
                else
                {
                    User_Controls.Course2 c = new User_Controls.Course2();
                    c.id.Text = dt2.Rows[i][0].ToString();
                    d = new databaseAccess();
                    d.OpenConnection();
                    d.LoadSpParameters("getAbreviation", dt2.Rows[i][1].ToString());
                    string abr = d.ExecuteValue().ToString();
                    d.CloseConnection();
                    c.course.Text = abr.ToString();
                    c.Click += new EventHandler(CourseSelected);
                    flowLayoutPanel1.Controls.Add(c);
                }

            }
        }

        private void CourseSelected(object sender, EventArgs e)
        {
            User_Controls.Course2 c = (User_Controls.Course2)sender;
            databaseAccess d = new databaseAccess();
            d.OpenConnection();
            d.LoadSpParameters("getClasses", c.id.Text);
            d.ExecuteQuery();
            DataTable dt = d.GetDataTable();
            d.CloseConnection();
            
            d = new databaseAccess();
            d.OpenConnection();
            d.LoadSpParameters("getTeacherfroName", dt.Rows[0][2].ToString());
            d.ExecuteQuery();
            DataTable dt2 = d.GetDataTable();
            d.CloseConnection();

            d = new databaseAccess();
            d.OpenConnection();
            d.LoadSpParameters("insertEnrolled", c.id.Text, sid, dt2.Rows[0][0].ToString(), 0, 0);
            d.ExecuteQuery();
            d.CloseConnection();

            MyMessageBox.Show("Course ID Registered Successfully");
            CourseLoad();
        }

        private void course22_Load(object sender, EventArgs e)
        {

        }
    }
}
