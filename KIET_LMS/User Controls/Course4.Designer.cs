namespace KIET_LMS.User_Controls
{
    partial class Course4
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            abb = new Label();
            panel1 = new Panel();
            course = new Label();
            panel2 = new Panel();
            crHour = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(abb);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(5, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 186);
            panel3.TabIndex = 3;
            // 
            // abb
            // 
            abb.AutoSize = true;
            abb.Font = new Font("Montserrat ExtraBold", 35F, FontStyle.Bold, GraphicsUnit.Point);
            abb.ForeColor = Color.FromArgb(237, 242, 244);
            abb.Location = new Point(80, 23);
            abb.Name = "abb";
            abb.Size = new Size(140, 65);
            abb.TabIndex = 4;
            abb.Text = "DCN";
            abb.Click += abb_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 97, 164);
            panel1.Controls.Add(course);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 86);
            panel1.TabIndex = 3;
            // 
            // course
            // 
            course.AutoSize = true;
            course.Font = new Font("Montserrat Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            course.ForeColor = Color.FromArgb(237, 242, 244);
            course.Location = new Point(8, 14);
            course.MaximumSize = new Size(276, 0);
            course.Name = "course";
            course.Size = new Size(262, 52);
            course.TabIndex = 0;
            course.Text = "DataCommunication and Networking";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 97, 164);
            panel2.Controls.Add(crHour);
            panel2.Location = new Point(5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(61, 41);
            panel2.TabIndex = 5;
            // 
            // crHour
            // 
            crHour.AutoSize = true;
            crHour.Font = new Font("Montserrat Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            crHour.ForeColor = Color.FromArgb(237, 242, 244);
            crHour.Location = new Point(15, 2);
            crHour.MaximumSize = new Size(276, 0);
            crHour.Name = "crHour";
            crHour.Size = new Size(30, 33);
            crHour.TabIndex = 1;
            crHour.Text = "3";
            // 
            // Course4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 67, 88);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Margin = new Padding(10);
            Name = "Course4";
            Padding = new Padding(5);
            Size = new Size(283, 196);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Label abb;
        private Panel panel1;
        public Label course;
        private Panel panel2;
        public Label crHour;
        public Panel panel3;
    }
}
