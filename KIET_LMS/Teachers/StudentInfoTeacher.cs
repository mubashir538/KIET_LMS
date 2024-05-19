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
    public partial class StudentInfoTeacher : Form
    {
        private int cid;
        public StudentInfoTeacher()
        {
            InitializeComponent();
        }
        public StudentInfoTeacher(int cid)
        {
            InitializeComponent();
            this.cid = cid;
        }


        private void StudentInfoTeacher_Load(object sender, EventArgs e)
        {
            new TouchScrollVertical(flowLayoutPanel1);
            databaseAccess.OpenConnection();
            databaseAccess.LoadSpParameters("loadAttendance",cid.ToString());
            databaseAccess.ExecuteQuery();
            DataTable dt = databaseAccess.GetDataTable();
            databaseAccess.CloseConnection();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string sid = dt.Rows[i][1].ToString();
                databaseAccess.OpenConnection();
                databaseAccess.LoadSpParameters("getStudentofID", sid);
                databaseAccess.ExecuteQuery();
                DataTable dt1 = databaseAccess.GetDataTable();
                databaseAccess.CloseConnection();
                User_Controls.Table1 t1 = new User_Controls.Table1();
                t1.Sno.Text = (i + 1) + ".";
                t1.name.Text = dt1.Rows[0][1].ToString();
                t1.sid.Text = sid;
                flowLayoutPanel1.Controls.Add(t1);

            }
        }
    }
}
