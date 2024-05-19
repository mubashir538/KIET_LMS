namespace KIET_LMS
{
    partial class LoginAsFaculty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAsFaculty));
            panel1 = new Panel();
            button3 = new Button();
            panel3 = new Panel();
            pass = new TextBox();
            button2 = new Button();
            panel2 = new Panel();
            id = new TextBox();
            pictureBox1 = new PictureBox();
            AsStudent = new Label();
            Login = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 45, 66);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(AsStudent);
            panel1.Controls.Add(Login);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 637);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(235, 134, 56);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(237, 242, 244);
            button3.Image = Properties.Resources.Icon_awesome_arrow_left;
            button3.Location = new Point(969, 14);
            button3.Name = "button3";
            button3.Size = new Size(36, 33);
            button3.TabIndex = 4;
            button3.TabStop = false;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(69, 80, 108);
            panel3.Controls.Add(pass);
            panel3.Location = new Point(62, 334);
            panel3.Name = "panel3";
            panel3.Size = new Size(421, 49);
            panel3.TabIndex = 9;
            // 
            // pass
            // 
            pass.BackColor = Color.FromArgb(69, 80, 108);
            pass.BorderStyle = BorderStyle.None;
            pass.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pass.ForeColor = Color.FromArgb(237, 242, 244);
            pass.Location = new Point(8, 8);
            pass.Name = "pass";
            pass.PasswordChar = '*';
            pass.PlaceholderText = "Password";
            pass.Size = new Size(405, 30);
            pass.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(230, 42, 42);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(237, 242, 244);
            button2.Location = new Point(1011, 14);
            button2.Name = "button2";
            button2.Size = new Size(36, 33);
            button2.TabIndex = 5;
            button2.TabStop = false;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(69, 80, 108);
            panel2.Controls.Add(id);
            panel2.Location = new Point(62, 268);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 49);
            panel2.TabIndex = 9;
            // 
            // id
            // 
            id.BackColor = Color.FromArgb(69, 80, 108);
            id.BorderStyle = BorderStyle.None;
            id.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            id.ForeColor = Color.FromArgb(237, 242, 244);
            id.Location = new Point(8, 8);
            id.Name = "id";
            id.PlaceholderText = "Faculty ID";
            id.Size = new Size(405, 30);
            id.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(537, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(528, 637);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // AsStudent
            // 
            AsStudent.AutoSize = true;
            AsStudent.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AsStudent.ForeColor = Color.FromArgb(237, 242, 244);
            AsStudent.Location = new Point(202, 481);
            AsStudent.Name = "AsStudent";
            AsStudent.Size = new Size(150, 20);
            AsStudent.TabIndex = 7;
            AsStudent.Text = "Or Login as Student";
            AsStudent.Click += AsStudent_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(235, 139, 56);
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Login.ForeColor = Color.FromArgb(43, 45, 66);
            Login.Location = new Point(148, 417);
            Login.Name = "Login";
            Login.Size = new Size(246, 51);
            Login.TabIndex = 7;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 24.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(237, 242, 244);
            label2.Location = new Point(84, 199);
            label2.Name = "label2";
            label2.Size = new Size(368, 46);
            label2.TabIndex = 4;
            label2.Text = "LOGIN  AS  FACULTY";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 45F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(237, 242, 244);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 83);
            label1.TabIndex = 2;
            label1.Text = "KIET";
            // 
            // LoginAsFaculty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 637);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginAsFaculty";
            Text = "Form6";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label AsStudent;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Panel panel3;
        private TextBox pass;
        private Panel panel2;
        private TextBox id;
        private Button Login;
        private Label label2;
    }
}