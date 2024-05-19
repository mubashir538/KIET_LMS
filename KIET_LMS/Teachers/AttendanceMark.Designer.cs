namespace KIET_LMS
{
    partial class AttendanceMark
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
            panel1 = new Panel();
            label1 = new Label();
            absent = new Button();
            present = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(62, 67, 88);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(300, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 54);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(237, 242, 244);
            label1.Location = new Point(25, 12);
            label1.Name = "label1";
            label1.Size = new Size(220, 29);
            label1.TabIndex = 0;
            label1.Text = "Attendance Upload";
            // 
            // absent
            // 
            absent.BackColor = Color.FromArgb(62, 67, 88);
            absent.FlatAppearance.BorderColor = Color.FromArgb(237, 242, 244);
            absent.FlatAppearance.BorderSize = 2;
            absent.FlatStyle = FlatStyle.Flat;
            absent.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            absent.ForeColor = Color.FromArgb(237, 242, 244);
            absent.Location = new Point(51, 102);
            absent.Name = "absent";
            absent.Size = new Size(210, 54);
            absent.TabIndex = 4;
            absent.Text = "Absent";
            absent.UseVisualStyleBackColor = false;
            absent.Click += absent_Click;
            // 
            // present
            // 
            present.BackColor = Color.FromArgb(62, 67, 88);
            present.FlatAppearance.BorderColor = Color.FromArgb(237, 242, 244);
            present.FlatAppearance.BorderSize = 2;
            present.FlatStyle = FlatStyle.Flat;
            present.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            present.ForeColor = Color.FromArgb(237, 242, 244);
            present.ImageAlign = ContentAlignment.MiddleLeft;
            present.Location = new Point(600, 102);
            present.Name = "present";
            present.Size = new Size(210, 54);
            present.TabIndex = 4;
            present.Text = " Present";
            present.UseVisualStyleBackColor = false;
            present.Click += present_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(23, 188);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(831, 436);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(235, 139, 56);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(43, 45, 66);
            button1.Location = new Point(669, 641);
            button1.Name = "button1";
            button1.Size = new Size(141, 48);
            button1.TabIndex = 15;
            button1.Text = "Mark";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(821, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(33, 462);
            panel2.TabIndex = 16;
            // 
            // AttendanceMark
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 45, 66);
            ClientSize = new Size(879, 637);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(present);
            Controls.Add(absent);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AttendanceMark";
            Text = "AttendanceMark";
            Load += AttendanceMark_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button absent;
        private Button present;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Panel panel2;
    }
}