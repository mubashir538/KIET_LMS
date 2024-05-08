namespace KIET_LMS
{
    partial class stReg_pm
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
            label3 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            CGPA = new Label();
            Age = new Label();
            S_ID = new Label();
            name = new Label();
            label14 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            StudentID = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(43, 45, 66);
            label3.Location = new Point(353, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(669, 55);
            label3.TabIndex = 0;
            label3.Text = "S t u d e n t   R e g i s t r a t i o n";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(141, 153, 174);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1256, 125);
            panel3.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(235, 139, 56);
            label5.Location = new Point(53, 707);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(270, 37);
            label5.TabIndex = 18;
            label5.Text = "Student Courses";
            // 
            // CGPA
            // 
            CGPA.AutoSize = true;
            CGPA.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CGPA.ForeColor = Color.FromArgb(237, 242, 244);
            CGPA.Location = new Point(53, 543);
            CGPA.Margin = new Padding(4, 0, 4, 0);
            CGPA.Name = "CGPA";
            CGPA.Size = new Size(161, 39);
            CGPA.TabIndex = 14;
            CGPA.Text = "CGPA: 3.81";
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Age.ForeColor = Color.FromArgb(237, 242, 244);
            Age.Location = new Point(53, 500);
            Age.Margin = new Padding(4, 0, 4, 0);
            Age.Name = "Age";
            Age.Size = new Size(113, 39);
            Age.TabIndex = 15;
            Age.Text = "Age: 19";
            // 
            // S_ID
            // 
            S_ID.AutoSize = true;
            S_ID.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            S_ID.ForeColor = Color.FromArgb(237, 242, 244);
            S_ID.Location = new Point(53, 457);
            S_ID.Margin = new Padding(4, 0, 4, 0);
            S_ID.Name = "S_ID";
            S_ID.Size = new Size(266, 39);
            S_ID.TabIndex = 16;
            S_ID.Text = "Student ID: 65097";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            name.ForeColor = Color.FromArgb(237, 242, 244);
            name.Location = new Point(53, 413);
            name.Margin = new Padding(4, 0, 4, 0);
            name.Name = "name";
            name.Size = new Size(363, 39);
            name.TabIndex = 17;
            name.Text = "Name: Mubashir Ahmed";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(235, 139, 56);
            label14.Location = new Point(53, 342);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(460, 37);
            label14.TabIndex = 13;
            label14.Text = "Student Personal Information";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(40, 765);
            flowLayoutPanel1.Margin = new Padding(7, 0, 7, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(3, 3, 3, 3);
            flowLayoutPanel1.Size = new Size(1189, 358);
            flowLayoutPanel1.TabIndex = 27;
            // 
            // StudentID
            // 
            StudentID.BorderStyle = BorderStyle.None;
            StudentID.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            StudentID.Location = new Point(103, 12);
            StudentID.Margin = new Padding(4, 5, 4, 5);
            StudentID.Multiline = true;
            StudentID.Name = "StudentID";
            StudentID.PlaceholderText = "STUDENT ID";
            StudentID.Size = new Size(466, 52);
            StudentID.TabIndex = 28;
            StudentID.TextChanged += StudentID_TextChanged;
            StudentID.KeyDown += StudentID_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(StudentID);
            panel1.Location = new Point(53, 173);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 73);
            panel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Icon_awesome_search;
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // stReg_pm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 45, 66);
            ClientSize = new Size(1256, 1106);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(CGPA);
            Controls.Add(Age);
            Controls.Add(S_ID);
            Controls.Add(name);
            Controls.Add(label14);
            Margin = new Padding(4, 5, 4, 5);
            Name = "stReg_pm";
            Text = "Form8";
            Load += stReg_pm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel3;
        private Label label5;
        private Label CGPA;
        private Label Age;
        private Label S_ID;
        private Label name;
        private Label label14;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox StudentID;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}