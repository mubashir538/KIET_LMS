namespace KIET_LMS
{
    partial class RegisterScr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterScr));
            panel1 = new Panel();
            button3 = new Button();
            panel9 = new Panel();
            ConPass = new TextBox();
            button2 = new Button();
            panel = new Panel();
            Password = new TextBox();
            panel7 = new Panel();
            Cell = new TextBox();
            panel6 = new Panel();
            CNIC = new TextBox();
            panel5 = new Panel();
            DegreeProgram = new TextBox();
            panel4 = new Panel();
            Age = new TextBox();
            panel3 = new Panel();
            Email = new TextBox();
            panel2 = new Panel();
            MyName = new TextBox();
            Reg = new Button();
            label3 = new Label();
            Male = new RadioButton();
            Female = new RadioButton();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 45, 66);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Reg);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Male);
            panel1.Controls.Add(Female);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-24, 4);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1544, 1152);
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
            button3.Location = new Point(1393, 22);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(51, 55);
            button3.TabIndex = 4;
            button3.TabStop = false;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(69, 80, 108);
            panel9.Controls.Add(ConPass);
            panel9.Location = new Point(90, 935);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(634, 82);
            panel9.TabIndex = 7;
            // 
            // ConPass
            // 
            ConPass.BackColor = Color.FromArgb(69, 80, 108);
            ConPass.BorderStyle = BorderStyle.None;
            ConPass.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ConPass.ForeColor = Color.FromArgb(237, 242, 244);
            ConPass.Location = new Point(23, 12);
            ConPass.Margin = new Padding(4, 5, 4, 5);
            ConPass.Name = "ConPass";
            ConPass.PasswordChar = '*';
            ConPass.PlaceholderText = "Confirm Password";
            ConPass.Size = new Size(600, 44);
            ConPass.TabIndex = 3;
            ConPass.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(230, 42, 42);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(237, 242, 244);
            button2.Location = new Point(1453, 22);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(51, 55);
            button2.TabIndex = 5;
            button2.TabStop = false;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(69, 80, 108);
            panel.Controls.Add(Password);
            panel.Location = new Point(90, 843);
            panel.Margin = new Padding(4, 5, 4, 5);
            panel.Name = "panel";
            panel.Size = new Size(634, 82);
            panel.TabIndex = 7;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(69, 80, 108);
            Password.BorderStyle = BorderStyle.None;
            Password.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = Color.FromArgb(237, 242, 244);
            Password.Location = new Point(23, 12);
            Password.Margin = new Padding(4, 5, 4, 5);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.PlaceholderText = "Password";
            Password.Size = new Size(600, 44);
            Password.TabIndex = 3;
            Password.TextChanged += textBox1_TextChanged;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(69, 80, 108);
            panel7.Controls.Add(Cell);
            panel7.Location = new Point(90, 658);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(634, 82);
            panel7.TabIndex = 7;
            // 
            // Cell
            // 
            Cell.BackColor = Color.FromArgb(69, 80, 108);
            Cell.BorderStyle = BorderStyle.None;
            Cell.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Cell.ForeColor = Color.FromArgb(237, 242, 244);
            Cell.Location = new Point(23, 12);
            Cell.Margin = new Padding(4, 5, 4, 5);
            Cell.Name = "Cell";
            Cell.PlaceholderText = "Cell No.";
            Cell.Size = new Size(600, 44);
            Cell.TabIndex = 3;
            Cell.TextChanged += textBox1_TextChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(69, 80, 108);
            panel6.Controls.Add(CNIC);
            panel6.Location = new Point(90, 567);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(634, 82);
            panel6.TabIndex = 7;
            // 
            // CNIC
            // 
            CNIC.BackColor = Color.FromArgb(69, 80, 108);
            CNIC.BorderStyle = BorderStyle.None;
            CNIC.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CNIC.ForeColor = Color.FromArgb(237, 242, 244);
            CNIC.Location = new Point(23, 12);
            CNIC.Margin = new Padding(4, 5, 4, 5);
            CNIC.Name = "CNIC";
            CNIC.PlaceholderText = "CNIC";
            CNIC.Size = new Size(600, 44);
            CNIC.TabIndex = 3;
            CNIC.TextChanged += textBox1_TextChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(69, 80, 108);
            panel5.Controls.Add(DegreeProgram);
            panel5.Location = new Point(90, 475);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(634, 82);
            panel5.TabIndex = 7;
            // 
            // DegreeProgram
            // 
            DegreeProgram.BackColor = Color.FromArgb(69, 80, 108);
            DegreeProgram.BorderStyle = BorderStyle.None;
            DegreeProgram.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DegreeProgram.ForeColor = Color.FromArgb(237, 242, 244);
            DegreeProgram.Location = new Point(23, 12);
            DegreeProgram.Margin = new Padding(4, 5, 4, 5);
            DegreeProgram.Name = "DegreeProgram";
            DegreeProgram.PlaceholderText = "Degree Program (COCIS)";
            DegreeProgram.Size = new Size(600, 44);
            DegreeProgram.TabIndex = 3;
            DegreeProgram.TextChanged += textBox1_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(69, 80, 108);
            panel4.Controls.Add(Age);
            panel4.Location = new Point(90, 383);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(634, 82);
            panel4.TabIndex = 7;
            // 
            // Age
            // 
            Age.BackColor = Color.FromArgb(69, 80, 108);
            Age.BorderStyle = BorderStyle.None;
            Age.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Age.ForeColor = Color.FromArgb(237, 242, 244);
            Age.Location = new Point(23, 12);
            Age.Margin = new Padding(4, 5, 4, 5);
            Age.Name = "Age";
            Age.PlaceholderText = "Age";
            Age.Size = new Size(600, 44);
            Age.TabIndex = 3;
            Age.TextChanged += textBox1_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(69, 80, 108);
            panel3.Controls.Add(Email);
            panel3.Location = new Point(90, 292);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(634, 82);
            panel3.TabIndex = 7;
            // 
            // Email
            // 
            Email.BackColor = Color.FromArgb(69, 80, 108);
            Email.BorderStyle = BorderStyle.None;
            Email.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Email.ForeColor = Color.FromArgb(237, 242, 244);
            Email.Location = new Point(23, 12);
            Email.Margin = new Padding(4, 5, 4, 5);
            Email.Name = "Email";
            Email.PlaceholderText = "Email";
            Email.Size = new Size(600, 44);
            Email.TabIndex = 3;
            Email.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(69, 80, 108);
            panel2.Controls.Add(MyName);
            panel2.Location = new Point(90, 200);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(634, 82);
            panel2.TabIndex = 7;
            // 
            // MyName
            // 
            MyName.BackColor = Color.FromArgb(69, 80, 108);
            MyName.BorderStyle = BorderStyle.None;
            MyName.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MyName.ForeColor = Color.FromArgb(237, 242, 244);
            MyName.Location = new Point(23, 12);
            MyName.Margin = new Padding(4, 5, 4, 5);
            MyName.Name = "MyName";
            MyName.PlaceholderText = "Name";
            MyName.Size = new Size(600, 44);
            MyName.TabIndex = 3;
            MyName.TextChanged += textBox1_TextChanged;
            // 
            // Reg
            // 
            Reg.BackColor = Color.FromArgb(235, 139, 56);
            Reg.FlatStyle = FlatStyle.Flat;
            Reg.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Reg.ForeColor = Color.FromArgb(43, 45, 66);
            Reg.Location = new Point(249, 1050);
            Reg.Margin = new Padding(4, 5, 4, 5);
            Reg.Name = "Reg";
            Reg.Size = new Size(341, 80);
            Reg.TabIndex = 6;
            Reg.Text = "Register";
            Reg.UseVisualStyleBackColor = false;
            Reg.Click += Reg_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(237, 242, 244);
            label3.ImageAlign = ContentAlignment.TopRight;
            label3.Location = new Point(169, 750);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 50);
            label3.TabIndex = 5;
            label3.Text = "Gender:";
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Male.ForeColor = Color.FromArgb(237, 242, 244);
            Male.Location = new Point(354, 755);
            Male.Margin = new Padding(4, 5, 4, 5);
            Male.Name = "Male";
            Male.Size = new Size(116, 45);
            Male.TabIndex = 4;
            Male.TabStop = true;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Female.ForeColor = Color.FromArgb(237, 242, 244);
            Female.Location = new Point(496, 755);
            Female.Margin = new Padding(4, 5, 4, 5);
            Female.Name = "Female";
            Female.Size = new Size(155, 45);
            Female.TabIndex = 4;
            Female.TabStop = true;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(840, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(704, 1152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(237, 242, 244);
            label2.Location = new Point(214, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(497, 58);
            label2.TabIndex = 1;
            label2.Text = "REGISTER AT KIET";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(237, 242, 244);
            label1.Location = new Point(-6, -25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 91);
            label1.TabIndex = 0;
            label1.Text = "KIET";
            // 
            // RegisterScr
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1521, 1106);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RegisterScr";
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Label label2;
        private TextBox MyName;
        private Button Reg;
        private Label label3;
        private RadioButton Male;
        private RadioButton Female;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel9;
        private TextBox ConPass;
        private Panel panel;
        private TextBox Password;
        private Panel panel7;
        private TextBox Cell;
        private Panel panel6;
        private TextBox CNIC;
        private Panel panel5;
        private TextBox DegreeProgram;
        private Panel panel4;
        private TextBox Age;
        private Panel panel3;
        private TextBox Email;
        private Button button3;
        private Button button2;
    }
}