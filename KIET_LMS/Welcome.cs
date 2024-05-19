using Business_Logic_Layer;
using Microsoft.Win32;
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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private string path = @"SOFTWARE\KIET_LMS";
        private string servervalue = "ServerName";
        private string dbvalue = "DatabaseName";
        private string dbuservalue = "DatabaseUserID";
        private string dbpassvalue = "DatabasePassword";
        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new ServerConnection();
            f.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
          
        }
    }
}
