namespace KIET_LMS
{
    partial class home_student
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
            label10 = new Label();
            cgpa = new Label();
            age = new Label();
            sid = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            name = new Label();
            attendance_bar = new CircularProgressBar.CircularProgressBar();
            best_marksbar = new CircularProgressBar.CircularProgressBar();
            progressprogressbar = new CircularProgressBar.CircularProgressBar();
            label4 = new Label();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(43, 45, 66);
            label3.Location = new Point(392, 9);
            label3.Name = "label3";
            label3.Size = new Size(130, 37);
            label3.TabIndex = 0;
            label3.Text = "H O M E";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(235, 139, 56);
            label10.Location = new Point(39, 321);
            label10.Name = "label10";
            label10.Size = new Size(269, 29);
            label10.TabIndex = 20;
            label10.Text = "Semester Information";
            // 
            // cgpa
            // 
            cgpa.AutoSize = true;
            cgpa.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cgpa.ForeColor = Color.FromArgb(237, 242, 244);
            cgpa.Location = new Point(39, 267);
            cgpa.Name = "cgpa";
            cgpa.Size = new Size(111, 26);
            cgpa.TabIndex = 13;
            cgpa.Text = "CGPA: 3.81";
            // 
            // age
            // 
            age.AutoSize = true;
            age.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            age.ForeColor = Color.FromArgb(237, 242, 244);
            age.Location = new Point(39, 239);
            age.Name = "age";
            age.Size = new Size(78, 26);
            age.TabIndex = 14;
            age.Text = "Age: 19";
            // 
            // sid
            // 
            sid.AutoSize = true;
            sid.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            sid.ForeColor = Color.FromArgb(237, 242, 244);
            sid.Location = new Point(39, 211);
            sid.Name = "sid";
            sid.Size = new Size(185, 26);
            sid.TabIndex = 15;
            sid.Text = "Student ID: 65097";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(237, 242, 244);
            label13.Location = new Point(652, 378);
            label13.Name = "label13";
            label13.Size = new Size(143, 30);
            label13.TabIndex = 16;
            label13.Text = "Attendance";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(237, 242, 244);
            label12.Location = new Point(376, 378);
            label12.Name = "label12";
            label12.Size = new Size(136, 30);
            label12.TabIndex = 17;
            label12.Text = "Best Marks";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(237, 242, 244);
            label11.Location = new Point(92, 390);
            label11.Name = "label11";
            label11.Size = new Size(110, 30);
            label11.TabIndex = 18;
            label11.Text = "Progress";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            name.ForeColor = Color.FromArgb(237, 242, 244);
            name.Location = new Point(39, 183);
            name.Name = "name";
            name.Size = new Size(244, 26);
            name.TabIndex = 19;
            name.Text = "Name: Mubashir Ahmed";
            name.Click += name_Click;
            // 
            // attendance_bar
            // 
            attendance_bar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            attendance_bar.AnimationSpeed = 1000;
            attendance_bar.BackColor = Color.Transparent;
            attendance_bar.Font = new Font("Montserrat", 34F, FontStyle.Regular, GraphicsUnit.Point);
            attendance_bar.ForeColor = Color.FromArgb(237, 242, 244);
            attendance_bar.InnerColor = Color.Transparent;
            attendance_bar.InnerMargin = 2;
            attendance_bar.InnerWidth = -1;
            attendance_bar.Location = new Point(615, 424);
            attendance_bar.MarqueeAnimationSpeed = 2000;
            attendance_bar.Name = "attendance_bar";
            attendance_bar.OuterColor = Color.FromArgb(141, 153, 174);
            attendance_bar.OuterMargin = -30;
            attendance_bar.OuterWidth = 30;
            attendance_bar.ProgressColor = Color.FromArgb(61, 97, 164);
            attendance_bar.ProgressWidth = 25;
            attendance_bar.SecondaryFont = new Font("Montserrat", 20F, FontStyle.Regular, GraphicsUnit.Point);
            attendance_bar.Size = new Size(217, 216);
            attendance_bar.StartAngle = 270;
            attendance_bar.SubscriptColor = Color.FromArgb(166, 166, 166);
            attendance_bar.SubscriptMargin = new Padding(10, -35, 0, 0);
            attendance_bar.SubscriptText = "";
            attendance_bar.SuperscriptColor = Color.FromArgb(166, 166, 166);
            attendance_bar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            attendance_bar.SuperscriptText = "";
            attendance_bar.TabIndex = 10;
            attendance_bar.Text = "50%";
            attendance_bar.TextMargin = new Padding(8, 8, 0, 0);
            attendance_bar.Value = 50;
            // 
            // best_marksbar
            // 
            best_marksbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            best_marksbar.AnimationSpeed = 2000;
            best_marksbar.BackColor = Color.Transparent;
            best_marksbar.Font = new Font("Montserrat", 34F, FontStyle.Regular, GraphicsUnit.Point);
            best_marksbar.ForeColor = Color.FromArgb(237, 242, 244);
            best_marksbar.InnerColor = Color.Transparent;
            best_marksbar.InnerMargin = 2;
            best_marksbar.InnerWidth = -1;
            best_marksbar.Location = new Point(336, 424);
            best_marksbar.MarqueeAnimationSpeed = 2000;
            best_marksbar.Name = "best_marksbar";
            best_marksbar.OuterColor = Color.FromArgb(141, 153, 174);
            best_marksbar.OuterMargin = -30;
            best_marksbar.OuterWidth = 30;
            best_marksbar.ProgressColor = Color.FromArgb(61, 97, 164);
            best_marksbar.ProgressWidth = 25;
            best_marksbar.SecondaryFont = new Font("Montserrat", 20F, FontStyle.Regular, GraphicsUnit.Point);
            best_marksbar.Size = new Size(217, 216);
            best_marksbar.StartAngle = 270;
            best_marksbar.SubscriptColor = Color.FromArgb(166, 166, 166);
            best_marksbar.SubscriptMargin = new Padding(10, -35, 0, 0);
            best_marksbar.SubscriptText = "";
            best_marksbar.SuperscriptColor = Color.FromArgb(166, 166, 166);
            best_marksbar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            best_marksbar.SuperscriptText = "";
            best_marksbar.TabIndex = 11;
            best_marksbar.Text = "50%";
            best_marksbar.TextMargin = new Padding(8, 8, 0, 0);
            best_marksbar.Value = 68;
            // 
            // progressprogressbar
            // 
            progressprogressbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            progressprogressbar.AnimationSpeed = 2000;
            progressprogressbar.BackColor = Color.Transparent;
            progressprogressbar.Font = new Font("Montserrat", 34F, FontStyle.Regular, GraphicsUnit.Point);
            progressprogressbar.ForeColor = Color.FromArgb(237, 242, 244);
            progressprogressbar.InnerColor = Color.Transparent;
            progressprogressbar.InnerMargin = 2;
            progressprogressbar.InnerWidth = -1;
            progressprogressbar.Location = new Point(39, 436);
            progressprogressbar.MarqueeAnimationSpeed = 2000;
            progressprogressbar.Name = "progressprogressbar";
            progressprogressbar.OuterColor = Color.FromArgb(141, 153, 174);
            progressprogressbar.OuterMargin = -30;
            progressprogressbar.OuterWidth = 30;
            progressprogressbar.ProgressColor = Color.FromArgb(61, 97, 164);
            progressprogressbar.ProgressWidth = 25;
            progressprogressbar.SecondaryFont = new Font("Montserrat", 20F, FontStyle.Regular, GraphicsUnit.Point);
            progressprogressbar.Size = new Size(217, 216);
            progressprogressbar.StartAngle = 270;
            progressprogressbar.SubscriptColor = Color.FromArgb(166, 166, 166);
            progressprogressbar.SubscriptMargin = new Padding(10, -35, 0, 0);
            progressprogressbar.SubscriptText = "";
            progressprogressbar.SuperscriptColor = Color.FromArgb(166, 166, 166);
            progressprogressbar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            progressprogressbar.SuperscriptText = "";
            progressprogressbar.TabIndex = 12;
            progressprogressbar.Text = "50%";
            progressprogressbar.TextMargin = new Padding(8, 8, 0, 0);
            progressprogressbar.Value = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(235, 139, 56);
            label4.Location = new Point(39, 135);
            label4.Name = "label4";
            label4.Size = new Size(360, 29);
            label4.TabIndex = 9;
            label4.Text = "Student Personal Information";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(141, 153, 174);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(917, 60);
            panel2.TabIndex = 8;
            // 
            // home_student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 45, 66);
            ClientSize = new Size(917, 712);
            Controls.Add(label10);
            Controls.Add(cgpa);
            Controls.Add(age);
            Controls.Add(sid);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(name);
            Controls.Add(attendance_bar);
            Controls.Add(best_marksbar);
            Controls.Add(progressprogressbar);
            Controls.Add(label4);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "home_student";
            Text = "home_student";
            Load += home_student_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label10;
        private Label cgpa;
        private Label age;
        private Label sid;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label name;
        private CircularProgressBar.CircularProgressBar attendance_bar;
        private CircularProgressBar.CircularProgressBar best_marksbar;
        private CircularProgressBar.CircularProgressBar progressprogressbar;
        private Label label4;
        private Panel panel2;
    }
}