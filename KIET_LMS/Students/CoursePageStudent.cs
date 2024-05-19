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
            databaseAccess.OpenConnection();
            databaseAccess.LoadSpParameters("getClasses",cid);
            databaseAccess.ExecuteQuery();
            DataTable dt = databaseAccess.GetDataTable();
            databaseAccess.CloseConnection();
            day.Text = dt.Rows[0][3].ToString();
            room.Text = dt.Rows[0][4].ToString();
            slot.Text = dt.Rows[0][5].ToString();
            tname.Text = dt.Rows[0][2].ToString();

            databaseAccess.OpenConnection();
            databaseAccess.LoadSpParameters("getTeacherfroName",dt.Rows[0][2].ToString());
            databaseAccess.ExecuteQuery();
            DataTable dt2 = databaseAccess.GetDataTable();
            databaseAccess.CloseConnection();
            tmail.Text = dt2.Rows[0][6].ToString();
            tpost.Text = dt2.Rows[0][3].ToString();
            courseAbr.Text = name;

        }
    }
}
