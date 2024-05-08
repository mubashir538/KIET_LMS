using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KIET_LMS.Teachers;
using Business_Logic_Layer;

namespace KIET_LMS
{
    public partial class home_teacher : Form
    {
        public home_teacher()
        {
            InitializeComponent();
        }

        private void home_teacher_Load(object sender, EventArgs e)
        {

            new TouchScrollVertical(flowLayoutPanel1);
            name.Text = "Name: " + Teacher.name;
            tid.Text = "Teacher ID: " + Teacher.ID.ToString();
            pos.Text = "Position: " + Teacher.position;
            fac.Text = "Faculty: " + Teacher.faculty;
            dept.Text = "Department: " + Teacher.department;


            FacultyCode f = new FacultyCode();
            DataTable dt3 = f.getCourses();
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                DataTable dt4 = f.getCourseNames(dt3.Rows[i][1].ToString());
                User_Controls.Course1 c1 = new User_Controls.Course1();
                c1.course.Text = dt4.Rows[0][3].ToString();
                c1.id.Text = dt3.Rows[i][0].ToString();
                c1.Click += new EventHandler(ShowInfo);
                c1.BackColor = f.generateColor();
                flowLayoutPanel1.Controls.Add(c1);
            }
        }


        private void ShowInfo(object sender, EventArgs e)
        {
            User_Controls.Course1 c1 = (User_Controls.Course1)sender;
            Form f = new TeacherLMS(int.Parse(c1.id.Text.Trim()));
            f.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new LoginAsFaculty();
            f.Show();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
