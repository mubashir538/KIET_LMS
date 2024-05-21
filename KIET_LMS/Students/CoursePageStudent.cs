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
    public partial class CoursePageStudent : Form
    {
        private string cid;
        private string name;
        public CoursePageStudent()
        {
            InitializeComponent();
        }
        public CoursePageStudent(string cid, string name)
        {
            this.cid = cid;
            InitializeComponent();
            this.name = name;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CoursePageStudent_Load(object sender, EventArgs e)
        {
            databaseAccess v = new databaseAccess();
            v.OpenConnection();
            v.LoadSpParameters("getClasses",cid);
            v.ExecuteQuery();
            DataTable dt = v.GetDataTable();
            v.CloseConnection();
            day.Text = dt.Rows[0][3].ToString();
            room.Text = dt.Rows[0][4].ToString();
            slot.Text = dt.Rows[0][5].ToString();
            tname.Text = dt.Rows[0][2].ToString();

            v = new databaseAccess();
            v.OpenConnection();
            v.LoadSpParameters("getTeacherfroName",dt.Rows[0][2].ToString());
            v.ExecuteQuery();
            DataTable dt2 = v.GetDataTable();
            v.CloseConnection();
            tmail.Text = dt2.Rows[0][6].ToString();
            tpost.Text = dt2.Rows[0][3].ToString();
            courseAbr.Text = name;

        }
    }
}
