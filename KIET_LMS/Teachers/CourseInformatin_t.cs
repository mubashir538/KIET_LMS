using Business_Logic_Layer;
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
    public partial class CourseInformatin_t : Form
    {
        private int cid;
        public CourseInformatin_t()
        {
            InitializeComponent();
        }

        public CourseInformatin_t(int cid)
        {
            InitializeComponent();
            this.cid = cid;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CourseInformatin_t_Load(object sender, EventArgs e)
        {
            FacultyCode f = new FacultyCode();
            DataTable dt = f.getCourseInfo(cid);
            Room.Text = dt.Rows[0][4].ToString();
            ClassID.Text = dt.Rows[0][0].ToString();
            Day.Text = dt.Rows[0][3].ToString();
            Slot.Text = dt.Rows[0][5].ToString();
            Department.Text = "COCIS";
            CourseName.Text = dt.Rows[0][1].ToString();


        }
    }
}
