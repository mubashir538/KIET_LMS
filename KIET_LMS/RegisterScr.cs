using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Business_Logic_Layer;

namespace KIET_LMS
{
    public partial class RegisterScr : Form
    {
        public RegisterScr()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void Reg_Click(object sender, EventArgs e)
        {
            InitialCode i = new InitialCode();
            int error = i.ValidateData(Male.Checked, Female.Checked, MyName.Text, Email.Text, Age.Text, DegreeProgram.Text, Password.Text, ConPass.Text, Cell.Text, CNIC.Text);
            if (error == 0)
            {
                Form f = new Student_LMS();
                f.Show();
                this.Close();
            }
        }


    }
}
