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
    public partial class ServerConnection : Form
    {
        public ServerConnection()
        {
            InitializeComponent();
        }

        private void ServerConnection_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            InitialCode c = new InitialCode();
            int errorcode = c.ConnecttoServer(servername.Text.ToString(), dbname.Text.ToString(), userid.Text.ToString(), password.Text.ToString());
            if (errorcode == 0)
            {
                RegisterOrLogin rl = new RegisterOrLogin();
                rl.Show();
                this.Close();
            }
        }
    }
}
