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
using KIET_LMS.Program_manager;
using Business_Logic_Layer;

namespace KIET_LMS
{
    public partial class LoginAsFaculty : Form
    {
        public LoginAsFaculty()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new RegisterOrLogin();
            f.Show();
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            InitialCode i = new InitialCode();
            int code = i.Login(id.Text, pass.Text);
            if (code == 2)
            {
                Form f = new ProgramManagerLMS();
                f.Show();
                this.Close();
            }
            else if (code == 1)
            {
                Form f = new home_teacher();
                f.Show();
                this.Close();
            }


        }

        private void AsStudent_Click(object sender, EventArgs e)
        {
            Form f = new LoginAsStudent();
            f.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
