namespace KIET_LMS
{
    partial class StudentsClassSchedule
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
            label1 = new Label();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(141, 153, 174);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(879, 63);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(43, 45, 66);
            label1.Location = new Point(288, 9);
            label1.Name = "label1";
            label1.Size = new Size(334, 37);
            label1.TabIndex = 0;
            label1.Text = "C l a s s   S c h e d u l e";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(237, 242, 244);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(22, 120);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(3, 3, 3, 3);
            panel3.Size = new Size(833, 527);
            panel3.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(43, 45, 66);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 60);
            flowLayoutPanel1.Margin = new Padding(0, 3, 0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(827, 464);
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
            panel4.Controls.Add(label3);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(237, 242, 244);
            label3.Location = new Point(31, 15);
            label3.Name = "label3";
            label3.Size = new Size(51, 27);
            label3.TabIndex = 0;
            label3.Text = "CID";
            // 
            // StudentsClassSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 45, 66);
            ClientSize = new Size(879, 637);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentsClassSchedule";
            Text = "Form11";
            Load += StudentsClassSchedule_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
    }
}