namespace KIET_LMS
{
    partial class RegisterOrLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterOrLogin));
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            Login = new Button();
            Register = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 45, 66);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Login);
            panel1.Controls.Add(Register);
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
            button3.Location = new Point(983, 14);
            button3.Name = "button3";
            button3.Size = new Size(36, 33);
            button3.TabIndex = 11;
            button3.TabStop = false;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(230, 42, 42);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(237, 242, 244);
            button2.Location = new Point(1025, 14);
            button2.Name = "button2";
            button2.Size = new Size(36, 33);
            button2.TabIndex = 12;
            button2.TabStop = false;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(582, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(483, 637);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(237, 242, 244);
            label2.Location = new Point(176, 380);
            label2.Name = "label2";
            label2.Size = new Size(226, 21);
            label2.TabIndex = 9;
            label2.Text = "Or Login as Existing Member";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(237, 242, 244);
            label3.Location = new Point(109, 219);
            label3.Name = "label3";
            label3.Size = new Size(354, 33);
            label3.TabIndex = 9;
            label3.Text = "Register as a Student in Kiet";
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(235, 139, 56);
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Login.ForeColor = Color.FromArgb(43, 45, 66);
            Login.Location = new Point(166, 419);
            Login.Name = "Login";
            Login.Size = new Size(246, 51);
            Login.TabIndex = 8;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // Register
            // 
            Register.BackColor = Color.FromArgb(235, 139, 56);
            Register.FlatStyle = FlatStyle.Flat;
            Register.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Register.ForeColor = Color.FromArgb(43, 45, 66);
            Register.Location = new Point(166, 296);
            Register.Name = "Register";
            Register.Size = new Size(246, 51);
            Register.TabIndex = 8;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 45F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(237, 242, 244);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 83);
            label1.TabIndex = 3;
            label1.Text = "KIET";
            // 
            // RegisterOrLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 637);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterOrLogin";
            Text = "Form7";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Button Register;
        private PictureBox pictureBox1;
        private Label label2;
        private Button Login;
        private Button button3;
        private Button button2;
    }
}