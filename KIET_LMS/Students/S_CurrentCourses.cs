﻿using Data_Access_Layer;
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
    public partial class S_CurrentCourses : Form
    {
        //public override CreateParams CreateParams
        //{ 
        //    get 
        //    {
        //        CreateParams handleParams = base.CreateParams;
        //        handleParams.ExStyle = 0x02000000;
        //        return handleParams; 
        //    }
        //}

        public S_CurrentCourses()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private Color generateColor()
        {
            Color color;
            Random random = new Random();
            int a = random.Next(1, 6);
            if (a == 1)
            {
                color = Color.FromArgb(127, 97, 110);
            }
            else if (a == 2)
            {
                color = Color.FromArgb(90, 108, 114);
            }
            else if (a == 3)
            {
                color = Color.FromArgb(162, 113, 101);
            }
            else if (a == 4)
            {
                color = Color.FromArgb(26, 97, 108);
            }
            else if (a == 5)
            {
                color = Color.FromArgb(80, 47, 64);
            }
            else
            {
                color = Color.FromArgb(85, 91, 91);
            }
            return color;
        }
        private void S_CurrentCourses_Load(object sender, EventArgs e)
        {
            new TouchScrollVertical(flowLayoutPanel1);
            databaseAccess.OpenConnection();
            databaseAccess.LoadSpParameters("getEnrolledfromSID", Student.SID);
            databaseAccess.ExecuteQuery();
            DataTable dt = databaseAccess.GetDataTable();
            databaseAccess.CloseConnection();
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    User_Controls.Course1 c1 = new User_Controls.Course1();
                    databaseAccess.OpenConnection();
                    databaseAccess.LoadSpParameters("getClasses", dt.Rows[i][0]);
                    databaseAccess.ExecuteQuery();
                    DataTable dt2 = databaseAccess.GetDataTable();
                    databaseAccess.CloseConnection();
                    string lorT = dt2.Rows[0][1].ToString().Substring(dt2.Rows[0][1].ToString().Length - 4, 3);
                    databaseAccess.OpenConnection();
                    databaseAccess.LoadSpParameters("getAbreviation",dt2.Rows[0][1].ToString());
                    string abr = databaseAccess.ExecuteValue().ToString();
                    databaseAccess.CloseConnection();
                    c1.course.Text = abr.ToString();
                    c1.id.Text = dt.Rows[i][0].ToString();
                    if (lorT == "Lab")
                    {
                        c1.BackColor = Color.FromArgb(81, 64, 64);
                    }
                    else
                    {
                        c1.BackColor = generateColor();
                    }
                    c1.Click += new EventHandler(OpenForm);
                    flowLayoutPanel1.Controls.Add(c1);
                }
            }
        }

        private void OpenForm(object sender, EventArgs e)
        {
            User_Controls.Course1 c1 = (User_Controls.Course1)sender;
            Form f = new CoursePageStudent(c1.id.Text, c1.course.Text);
            ((Student_LMS)ParentForm).OpenForm(f);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
