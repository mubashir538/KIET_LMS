namespace KIET_LMS
{
    partial class StudentInfoTeacher
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
            label1 = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(237, 242, 244);
            label1.Location = new Point(48, 17);
            label1.Name = "label1";
            label1.Size = new Size(229, 29);
            label1.TabIndex = 0;
            label1.Text = "Student Information";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(62, 67, 88);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(283, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 62);
            panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(46, 143);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(784, 506);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(812, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(18, 541);
            panel2.TabIndex = 3;
            // 
            // StudentInfoTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 45, 66);
            ClientSize = new Size(879, 637);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentInfoTeacher";
            Text = "StudentInfoTeacher";
            Load += StudentInfoTeacher_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
    }
}