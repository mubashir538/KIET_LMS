namespace KIET_LMS
{
    partial class CourseTimingsPM
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
            panel2 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            sun = new Button();
            sat = new Button();
            fri = new Button();
            thurs = new Button();
            wed = new Button();
            tues = new Button();
            mon = new Button();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(141, 153, 174);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 60);
            panel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(43, 45, 66);
            label3.Location = new Point(367, 7);
            label3.Name = "label3";
            label3.Size = new Size(237, 37);
            label3.TabIndex = 0;
            label3.Text = "Course Timings";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 139, 56);
            panel1.Controls.Add(sun);
            panel1.Controls.Add(sat);
            panel1.Controls.Add(fri);
            panel1.Controls.Add(thurs);
            panel1.Controls.Add(wed);
            panel1.Controls.Add(tues);
            panel1.Controls.Add(mon);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 67);
            panel1.TabIndex = 11;
            // 
            // sun
            // 
            sun.Dock = DockStyle.Left;
            sun.FlatAppearance.BorderSize = 0;
            sun.FlatStyle = FlatStyle.Flat;
            sun.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sun.ForeColor = Color.FromArgb(43, 45, 66);
            sun.Image = Properties.Resources.Line_16;
            sun.ImageAlign = ContentAlignment.MiddleRight;
            sun.Location = new Point(762, 0);
            sun.Name = "sun";
            sun.Size = new Size(127, 67);
            sun.TabIndex = 6;
            sun.Text = "Sun";
            sun.TextImageRelation = TextImageRelation.TextBeforeImage;
            sun.UseVisualStyleBackColor = true;
            sun.Click += sun_Click;
            // 
            // sat
            // 
            sat.Dock = DockStyle.Left;
            sat.FlatAppearance.BorderSize = 0;
            sat.FlatStyle = FlatStyle.Flat;
            sat.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sat.ForeColor = Color.FromArgb(43, 45, 66);
            sat.Image = Properties.Resources.Line_16;
            sat.ImageAlign = ContentAlignment.MiddleRight;
            sat.Location = new Point(635, 0);
            sat.Name = "sat";
            sat.Size = new Size(127, 67);
            sat.TabIndex = 5;
            sat.Text = "Sat";
            sat.TextImageRelation = TextImageRelation.TextBeforeImage;
            sat.UseVisualStyleBackColor = true;
            sat.Click += sat_Click;
            // 
            // fri
            // 
            fri.Dock = DockStyle.Left;
            fri.FlatAppearance.BorderSize = 0;
            fri.FlatStyle = FlatStyle.Flat;
            fri.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fri.ForeColor = Color.FromArgb(43, 45, 66);
            fri.Image = Properties.Resources.Line_16;
            fri.ImageAlign = ContentAlignment.MiddleRight;
            fri.Location = new Point(508, 0);
            fri.Name = "fri";
            fri.Size = new Size(127, 67);
            fri.TabIndex = 4;
            fri.Text = "Fri";
            fri.TextImageRelation = TextImageRelation.TextBeforeImage;
            fri.UseVisualStyleBackColor = true;
            fri.Click += fri_Click;
            // 
            // thurs
            // 
            thurs.Dock = DockStyle.Left;
            thurs.FlatAppearance.BorderSize = 0;
            thurs.FlatStyle = FlatStyle.Flat;
            thurs.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            thurs.ForeColor = Color.FromArgb(43, 45, 66);
            thurs.Image = Properties.Resources.Line_16;
            thurs.ImageAlign = ContentAlignment.MiddleRight;
            thurs.Location = new Point(381, 0);
            thurs.Name = "thurs";
            thurs.Size = new Size(127, 67);
            thurs.TabIndex = 3;
            thurs.Text = "Thurs";
            thurs.TextImageRelation = TextImageRelation.TextBeforeImage;
            thurs.UseVisualStyleBackColor = true;
            thurs.Click += thurs_Click;
            // 
            // wed
            // 
            wed.Dock = DockStyle.Left;
            wed.FlatAppearance.BorderSize = 0;
            wed.FlatStyle = FlatStyle.Flat;
            wed.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            wed.ForeColor = Color.FromArgb(43, 45, 66);
            wed.Image = Properties.Resources.Line_16;
            wed.ImageAlign = ContentAlignment.MiddleRight;
            wed.Location = new Point(254, 0);
            wed.Name = "wed";
            wed.Size = new Size(127, 67);
            wed.TabIndex = 2;
            wed.Text = "Wed";
            wed.TextImageRelation = TextImageRelation.TextBeforeImage;
            wed.UseVisualStyleBackColor = true;
            wed.Click += wed_Click;
            // 
            // tues
            // 
            tues.Dock = DockStyle.Left;
            tues.FlatAppearance.BorderSize = 0;
            tues.FlatStyle = FlatStyle.Flat;
            tues.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tues.ForeColor = Color.FromArgb(43, 45, 66);
            tues.Image = Properties.Resources.Line_16;
            tues.ImageAlign = ContentAlignment.MiddleRight;
            tues.Location = new Point(127, 0);
            tues.Name = "tues";
            tues.Size = new Size(127, 67);
            tues.TabIndex = 1;
            tues.Text = "Tues";
            tues.TextImageRelation = TextImageRelation.TextBeforeImage;
            tues.UseVisualStyleBackColor = true;
            tues.Click += tues_Click;
            // 
            // mon
            // 
            mon.Dock = DockStyle.Left;
            mon.FlatAppearance.BorderSize = 0;
            mon.FlatStyle = FlatStyle.Flat;
            mon.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mon.ForeColor = Color.FromArgb(43, 45, 66);
            mon.Image = Properties.Resources.Line_16;
            mon.ImageAlign = ContentAlignment.MiddleRight;
            mon.Location = new Point(0, 0);
            mon.Name = "mon";
            mon.Size = new Size(127, 67);
            mon.TabIndex = 0;
            mon.Text = "Mon";
            mon.TextImageRelation = TextImageRelation.TextBeforeImage;
            mon.UseVisualStyleBackColor = true;
            mon.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(237, 242, 244);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(23, 178);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(3, 3, 3, 3);
            panel3.Size = new Size(833, 511);
            panel3.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(43, 45, 66);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 60);
            flowLayoutPanel1.Margin = new Padding(0, 3, 0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(827, 448);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(43, 45, 66);
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Margin = new Padding(0, 0, 0, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(827, 57);
            panel4.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(237, 242, 244);
            label6.Location = new Point(738, 15);
            label6.Name = "label6";
            label6.Size = new Size(74, 27);
            label6.TabIndex = 0;
            label6.Text = "Room";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(237, 242, 244);
            label5.Location = new Point(639, 15);
            label5.Name = "label5";
            label5.Size = new Size(64, 27);
            label5.TabIndex = 0;
            label5.Text = "Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(237, 242, 244);
            label4.Location = new Point(547, 15);
            label4.Name = "label4";
            label4.Size = new Size(53, 27);
            label4.TabIndex = 0;
            label4.Text = "Day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(237, 242, 244);
            label2.Location = new Point(248, 15);
            label2.Name = "label2";
            label2.Size = new Size(87, 27);
            label2.TabIndex = 0;
            label2.Text = "Course";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(237, 242, 244);
            label1.Location = new Point(31, 15);
            label1.Name = "label1";
            label1.Size = new Size(51, 27);
            label1.TabIndex = 0;
            label1.Text = "CID";
            // 
            // CourseTimingsPM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 45, 66);
            ClientSize = new Size(884, 713);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CourseTimingsPM";
            Text = "CourseTimingsPM";
            Load += CourseTimingsPM_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label3;
        private Panel panel1;
        private Button sun;
        private Button sat;
        private Button fri;
        private Button thurs;
        private Button wed;
        private Button tues;
        private Button mon;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}