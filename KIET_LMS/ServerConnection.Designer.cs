namespace KIET_LMS
{
    partial class ServerConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            dbname = new TextBox();
            panel2 = new Panel();
            servername = new TextBox();
            connect = new Button();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            password = new TextBox();
            panel4 = new Panel();
            userid = new TextBox();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(69, 80, 108);
            panel3.Controls.Add(dbname);
            panel3.Location = new Point(414, 420);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(601, 82);
            panel3.TabIndex = 15;
            // 
            // dbname
            // 
            dbname.BackColor = Color.FromArgb(69, 80, 108);
            dbname.BorderStyle = BorderStyle.None;
            dbname.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dbname.ForeColor = Color.FromArgb(237, 242, 244);
            dbname.Location = new Point(11, 15);
            dbname.Margin = new Padding(4, 5, 4, 5);
            dbname.Name = "dbname";
            dbname.PlaceholderText = "Database Name";
            dbname.Size = new Size(579, 44);
            dbname.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(69, 80, 108);
            panel2.Controls.Add(servername);
            panel2.Location = new Point(414, 310);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(601, 82);
            panel2.TabIndex = 16;
            // 
            // servername
            // 
            servername.BackColor = Color.FromArgb(69, 80, 108);
            servername.BorderStyle = BorderStyle.None;
            servername.Font = new Font("Montserrat", 19F, FontStyle.Regular, GraphicsUnit.Point);
            servername.ForeColor = Color.FromArgb(237, 242, 244);
            servername.Location = new Point(11, 13);
            servername.Margin = new Padding(4, 5, 4, 5);
            servername.Name = "servername";
            servername.PlaceholderText = "Server Name/IP";
            servername.Size = new Size(579, 47);
            servername.TabIndex = 5;
            // 
            // connect
            // 
            connect.BackColor = Color.FromArgb(235, 139, 56);
            connect.FlatStyle = FlatStyle.Flat;
            connect.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            connect.ForeColor = Color.FromArgb(43, 45, 66);
            connect.Location = new Point(530, 830);
            connect.Margin = new Padding(4, 5, 4, 5);
            connect.Name = "connect";
            connect.Size = new Size(351, 85);
            connect.TabIndex = 14;
            connect.Text = "Connect";
            connect.UseVisualStyleBackColor = false;
            connect.Click += connect_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(237, 242, 244);
            label2.Location = new Point(393, 157);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(620, 58);
            label2.TabIndex = 13;
            label2.Text = "CONNECT THE SERVER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 45F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(237, 242, 244);
            label1.Location = new Point(17, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 102);
            label1.TabIndex = 12;
            label1.Text = "KIET";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(230, 42, 42);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(237, 242, 244);
            button2.Location = new Point(1374, 20);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(51, 55);
            button2.TabIndex = 18;
            button2.TabStop = false;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(69, 80, 108);
            panel1.Controls.Add(password);
            panel1.Location = new Point(414, 647);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 82);
            panel1.TabIndex = 19;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(69, 80, 108);
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.FromArgb(237, 242, 244);
            password.Location = new Point(11, 15);
            password.Margin = new Padding(4, 5, 4, 5);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Password";
            password.Size = new Size(579, 44);
            password.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(69, 80, 108);
            panel4.Controls.Add(userid);
            panel4.Location = new Point(414, 537);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(601, 82);
            panel4.TabIndex = 20;
            // 
            // userid
            // 
            userid.BackColor = Color.FromArgb(69, 80, 108);
            userid.BorderStyle = BorderStyle.None;
            userid.Font = new Font("Montserrat", 19F, FontStyle.Regular, GraphicsUnit.Point);
            userid.ForeColor = Color.FromArgb(237, 242, 244);
            userid.Location = new Point(11, 13);
            userid.Margin = new Padding(4, 5, 4, 5);
            userid.Name = "userid";
            userid.PlaceholderText = "User ID";
            userid.Size = new Size(579, 47);
            userid.TabIndex = 5;
            // 
            // ServerConnection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 45, 66);
            ClientSize = new Size(1443, 1087);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(connect);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ServerConnection";
            Text = "ServerConnection";
            Load += ServerConnection_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private TextBox dbname;
        private Panel panel2;
        private TextBox servername;
        private Button connect;
        private Label label2;
        private Label label1;
        private Button button2;
        private Panel panel1;
        private TextBox password;
        private Panel panel4;
        private TextBox userid;
    }
}