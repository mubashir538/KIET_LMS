namespace KIET_LMS
{
    partial class addCoursePM
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
            panel2 = new Panel();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            course21 = new User_Controls.Course2();
            course22 = new User_Controls.Course2();
            course23 = new User_Controls.Course2();
            course24 = new User_Controls.Course2();
            course25 = new User_Controls.Course2();
            course26 = new User_Controls.Course2();
            panel1 = new Panel();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(43, 45, 66);
            label3.Location = new Point(345, 9);
            label3.Name = "label3";
            label3.Size = new Size(209, 37);
            label3.TabIndex = 0;
            label3.Text = "ADD COURSE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(141, 153, 174);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(890, 60);
            panel2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(235, 139, 56);
            label4.Location = new Point(345, 116);
            label4.Name = "label4";
            label4.Size = new Size(203, 25);
            label4.TabIndex = 10;
            label4.Text = "Available Courses";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(course21);
            flowLayoutPanel1.Controls.Add(course22);
            flowLayoutPanel1.Controls.Add(course23);
            flowLayoutPanel1.Controls.Add(course24);
            flowLayoutPanel1.Controls.Add(course25);
            flowLayoutPanel1.Controls.Add(course26);
            flowLayoutPanel1.Location = new Point(94, 169);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(706, 505);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // course21
            // 
            course21.BackColor = Color.FromArgb(162, 113, 101);
            course21.Location = new Point(30, 30);
            course21.Margin = new Padding(30, 30, 30, 30);
            course21.Name = "course21";
            course21.Size = new Size(279, 192);
            course21.TabIndex = 0;
            // 
            // course22
            // 
            course22.BackColor = Color.FromArgb(162, 113, 101);
            course22.Location = new Point(369, 30);
            course22.Margin = new Padding(30, 30, 30, 30);
            course22.Name = "course22";
            course22.Size = new Size(279, 192);
            course22.TabIndex = 1;
            course22.Load += course22_Load;
            // 
            // course23
            // 
            course23.BackColor = Color.FromArgb(162, 113, 101);
            course23.Location = new Point(30, 282);
            course23.Margin = new Padding(30, 30, 30, 30);
            course23.Name = "course23";
            course23.Size = new Size(279, 192);
            course23.TabIndex = 2;
            // 
            // course24
            // 
            course24.BackColor = Color.FromArgb(162, 113, 101);
            course24.Location = new Point(369, 282);
            course24.Margin = new Padding(30, 30, 30, 30);
            course24.Name = "course24";
            course24.Size = new Size(279, 192);
            course24.TabIndex = 3;
            // 
            // course25
            // 
            course25.BackColor = Color.FromArgb(162, 113, 101);
            course25.Location = new Point(30, 534);
            course25.Margin = new Padding(30, 30, 30, 30);
            course25.Name = "course25";
            course25.Size = new Size(279, 192);
            course25.TabIndex = 4;
            // 
            // course26
            // 
            course26.BackColor = Color.FromArgb(162, 113, 101);
            course26.Location = new Point(369, 534);
            course26.Margin = new Padding(30, 30, 30, 30);
            course26.Name = "course26";
            course26.Size = new Size(279, 192);
            course26.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Location = new Point(781, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(44, 505);
            panel1.TabIndex = 17;
            // 
            // addCoursePM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 45, 66);
            ClientSize = new Size(890, 717);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label4);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addCoursePM";
            Text = "addCoursePM";
            Load += addCoursePM_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Panel panel2;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private User_Controls.Course2 course21;
        private User_Controls.Course2 course22;
        private User_Controls.Course2 course23;
        private User_Controls.Course2 course24;
        private User_Controls.Course2 course25;
        private User_Controls.Course2 course26;
        private Panel panel1;
    }
}