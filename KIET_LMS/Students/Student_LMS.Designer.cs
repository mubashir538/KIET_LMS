namespace KIET_LMS
{
    partial class Student_LMS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_LMS));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            classSchedule = new Button();
            selfRegistration = new Button();
            testResults = new Button();
            currentCourses = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            showpanel = new Panel();
            show = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 97, 164);
            panel1.Controls.Add(classSchedule);
            panel1.Controls.Add(selfRegistration);
            panel1.Controls.Add(testResults);
            panel1.Controls.Add(currentCourses);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 637);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // classSchedule
            // 
            classSchedule.AutoSize = true;
            classSchedule.BackColor = Color.FromArgb(61, 97, 164);
            classSchedule.BackgroundImageLayout = ImageLayout.None;
            classSchedule.FlatAppearance.BorderSize = 0;
            classSchedule.FlatStyle = FlatStyle.Flat;
            classSchedule.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            classSchedule.ForeColor = Color.FromArgb(237, 242, 244);
            classSchedule.Image = (Image)resources.GetObject("classSchedule.Image");
            classSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            classSchedule.Location = new Point(9, 383);
            classSchedule.Margin = new Padding(0);
            classSchedule.Name = "classSchedule";
            classSchedule.Size = new Size(295, 63);
            classSchedule.TabIndex = 4;
            classSchedule.Text = "    Class Schedule";
            classSchedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            classSchedule.UseVisualStyleBackColor = false;
            classSchedule.Click += classSchedule_Click;
            classSchedule.MouseHover += selfRegistration_MouseHover;
            // 
            // selfRegistration
            // 
            selfRegistration.AutoSize = true;
            selfRegistration.BackColor = Color.FromArgb(61, 97, 164);
            selfRegistration.BackgroundImageLayout = ImageLayout.None;
            selfRegistration.FlatAppearance.BorderSize = 0;
            selfRegistration.FlatStyle = FlatStyle.Flat;
            selfRegistration.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            selfRegistration.ForeColor = Color.FromArgb(237, 242, 244);
            selfRegistration.Image = (Image)resources.GetObject("selfRegistration.Image");
            selfRegistration.ImageAlign = ContentAlignment.MiddleLeft;
            selfRegistration.Location = new Point(9, 314);
            selfRegistration.Margin = new Padding(0);
            selfRegistration.Name = "selfRegistration";
            selfRegistration.Size = new Size(319, 63);
            selfRegistration.TabIndex = 4;
            selfRegistration.Text = "    Self Registration";
            selfRegistration.TextImageRelation = TextImageRelation.ImageBeforeText;
            selfRegistration.UseVisualStyleBackColor = false;
            selfRegistration.Click += selfRegistration_Click;
            selfRegistration.MouseHover += selfRegistration_MouseHover;
            // 
            // testResults
            // 
            testResults.AutoSize = true;
            testResults.BackColor = Color.FromArgb(61, 97, 164);
            testResults.BackgroundImageLayout = ImageLayout.None;
            testResults.FlatAppearance.BorderSize = 0;
            testResults.FlatStyle = FlatStyle.Flat;
            testResults.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            testResults.ForeColor = Color.FromArgb(237, 242, 244);
            testResults.Image = (Image)resources.GetObject("testResults.Image");
            testResults.ImageAlign = ContentAlignment.MiddleLeft;
            testResults.Location = new Point(22, 251);
            testResults.Margin = new Padding(0);
            testResults.Name = "testResults";
            testResults.Size = new Size(279, 63);
            testResults.TabIndex = 4;
            testResults.Text = "    Test Results";
            testResults.TextImageRelation = TextImageRelation.ImageBeforeText;
            testResults.UseVisualStyleBackColor = false;
            testResults.Click += button2_Click;
            testResults.MouseHover += selfRegistration_MouseHover;
            // 
            // currentCourses
            // 
            currentCourses.AutoSize = true;
            currentCourses.BackColor = Color.FromArgb(61, 97, 164);
            currentCourses.BackgroundImageLayout = ImageLayout.None;
            currentCourses.FlatAppearance.BorderSize = 0;
            currentCourses.FlatStyle = FlatStyle.Flat;
            currentCourses.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            currentCourses.ForeColor = Color.FromArgb(237, 242, 244);
            currentCourses.Image = (Image)resources.GetObject("currentCourses.Image");
            currentCourses.ImageAlign = ContentAlignment.MiddleLeft;
            currentCourses.Location = new Point(22, 182);
            currentCourses.Margin = new Padding(0);
            currentCourses.Name = "currentCourses";
            currentCourses.Size = new Size(302, 63);
            currentCourses.TabIndex = 4;
            currentCourses.Text = "    Current Courses";
            currentCourses.TextImageRelation = TextImageRelation.ImageBeforeText;
            currentCourses.UseVisualStyleBackColor = false;
            currentCourses.Click += currentCourses_Click;
            currentCourses.MouseHover += selfRegistration_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(10, 10, 10, 10);
            pictureBox1.Size = new Size(315, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(237, 242, 244);
            label2.Location = new Point(22, 73);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(380, 29);
            label2.TabIndex = 3;
            label2.Text = "The redesigned Learning Platform";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(237, 242, 244);
            label1.Location = new Point(0, -19);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 4, 4, 4);
            label1.Size = new Size(187, 81);
            label1.TabIndex = 2;
            label1.Text = "KIET";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(235, 134, 56);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(237, 242, 244);
            button4.Image = Properties.Resources.Icon_awesome_arrow_left;
            button4.Location = new Point(792, 6);
            button4.Name = "button4";
            button4.Size = new Size(36, 33);
            button4.TabIndex = 4;
            button4.TabStop = false;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(230, 42, 42);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(237, 242, 244);
            button5.Location = new Point(834, 6);
            button5.Name = "button5";
            button5.Size = new Size(36, 33);
            button5.TabIndex = 5;
            button5.TabStop = false;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(235, 134, 56);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(showpanel);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(315, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(879, 45);
            panel2.TabIndex = 8;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(237, 242, 244);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.Icon_metro_switch;
            button1.Location = new Point(744, 6);
            button1.Name = "button1";
            button1.Size = new Size(42, 33);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // showpanel
            // 
            showpanel.BackColor = Color.FromArgb(43, 45, 66);
            showpanel.Location = new Point(3, 45);
            showpanel.Name = "showpanel";
            showpanel.Size = new Size(879, 701);
            showpanel.TabIndex = 9;
            // 
            // show
            // 
            show.BackColor = Color.FromArgb(43, 45, 66);
            show.Dock = DockStyle.Fill;
            show.Location = new Point(315, 45);
            show.Name = "show";
            show.Size = new Size(879, 592);
            show.TabIndex = 9;
            // 
            // Student_LMS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 637);
            Controls.Add(show);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student_LMS";
            Text = "  ";
            Load += Student_LMS_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button classSchedule;
        private Button selfRegistration;
        private Button testResults;
        private Button currentCourses;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button5;
        private Panel panel2;
        private Panel showpanel;
        private Panel show;
        private Button button1;
    }
}