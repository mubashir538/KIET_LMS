namespace KIET_LMS
{
    partial class IdCreation_pm
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
            GenerateID = new Button();
            CoursePanel1 = new Panel();
            CoursePanel = new FlowLayoutPanel();
            MyCourse = new Button();
            panel1 = new Panel();
            panel6 = new Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            MyRoom = new Button();
            panel5 = new Panel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            MySlot = new Button();
            panel4 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            MyDay = new Button();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            MyFaculty = new Button();
            panel2.SuspendLayout();
            CoursePanel1.SuspendLayout();
            CoursePanel.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            panel5.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(141, 153, 174);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1256, 105);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(43, 45, 66);
            label1.Location = new Point(411, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(348, 55);
            label1.TabIndex = 0;
            label1.Text = "ID  C r e a t i o n";
            label1.Click += label1_Click;
            // 
            // GenerateID
            // 
            GenerateID.BackColor = Color.FromArgb(235, 139, 56);
            GenerateID.FlatAppearance.BorderColor = Color.White;
            GenerateID.FlatAppearance.BorderSize = 0;
            GenerateID.FlatStyle = FlatStyle.Flat;
            GenerateID.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            GenerateID.ForeColor = Color.FromArgb(43, 45, 66);
            GenerateID.Location = new Point(870, 1008);
            GenerateID.Margin = new Padding(4, 5, 4, 5);
            GenerateID.Name = "GenerateID";
            GenerateID.Size = new Size(311, 88);
            GenerateID.TabIndex = 2;
            GenerateID.Text = "Generate ID";
            GenerateID.UseVisualStyleBackColor = false;
            GenerateID.Click += GenerateID_Click;
            // 
            // CoursePanel1
            // 
            CoursePanel1.Controls.Add(CoursePanel);
            CoursePanel1.Location = new Point(159, 308);
            CoursePanel1.Margin = new Padding(4, 5, 4, 5);
            CoursePanel1.Name = "CoursePanel1";
            CoursePanel1.Size = new Size(879, 77);
            CoursePanel1.TabIndex = 4;
            // 
            // CoursePanel
            // 
            CoursePanel.Controls.Add(MyCourse);
            CoursePanel.Dock = DockStyle.Fill;
            CoursePanel.Location = new Point(0, 0);
            CoursePanel.Margin = new Padding(4, 5, 4, 5);
            CoursePanel.Name = "CoursePanel";
            CoursePanel.Size = new Size(879, 77);
            CoursePanel.TabIndex = 0;
            // 
            // MyCourse
            // 
            MyCourse.BackColor = Color.FromArgb(69, 80, 108);
            MyCourse.FlatAppearance.BorderSize = 0;
            MyCourse.FlatStyle = FlatStyle.Flat;
            MyCourse.ForeColor = Color.FromArgb(237, 242, 244);
            MyCourse.Image = Properties.Resources.Icon_awesome_chevron_down3;
            MyCourse.ImageAlign = ContentAlignment.MiddleRight;
            MyCourse.Location = new Point(0, 0);
            MyCourse.Margin = new Padding(0);
            MyCourse.Name = "MyCourse";
            MyCourse.Size = new Size(879, 77);
            MyCourse.TabIndex = 1;
            MyCourse.Text = "    Course Name";
            MyCourse.TextAlign = ContentAlignment.MiddleLeft;
            MyCourse.UseVisualStyleBackColor = false;
            MyCourse.Click += button2_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 45, 66);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(CoursePanel1);
            panel1.Controls.Add(GenerateID);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1256, 1050);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel6
            // 
            panel6.Controls.Add(flowLayoutPanel4);
            panel6.Location = new Point(159, 748);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(879, 77);
            panel6.TabIndex = 5;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(MyRoom);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(0, 0);
            flowLayoutPanel4.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(879, 77);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // MyRoom
            // 
            MyRoom.BackColor = Color.FromArgb(69, 80, 108);
            MyRoom.FlatAppearance.BorderSize = 0;
            MyRoom.FlatStyle = FlatStyle.Flat;
            MyRoom.ForeColor = Color.FromArgb(237, 242, 244);
            MyRoom.Image = Properties.Resources.Icon_awesome_chevron_down3;
            MyRoom.ImageAlign = ContentAlignment.MiddleRight;
            MyRoom.Location = new Point(0, 0);
            MyRoom.Margin = new Padding(0);
            MyRoom.Name = "MyRoom";
            MyRoom.Size = new Size(879, 77);
            MyRoom.TabIndex = 1;
            MyRoom.Text = "    Room No.";
            MyRoom.TextAlign = ContentAlignment.MiddleLeft;
            MyRoom.UseVisualStyleBackColor = false;
            MyRoom.Click += button5_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(flowLayoutPanel3);
            panel5.Location = new Point(159, 638);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(879, 77);
            panel5.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(MySlot);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(879, 77);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // MySlot
            // 
            MySlot.BackColor = Color.FromArgb(69, 80, 108);
            MySlot.FlatAppearance.BorderSize = 0;
            MySlot.FlatStyle = FlatStyle.Flat;
            MySlot.ForeColor = Color.FromArgb(237, 242, 244);
            MySlot.Image = Properties.Resources.Icon_awesome_chevron_down3;
            MySlot.ImageAlign = ContentAlignment.MiddleRight;
            MySlot.Location = new Point(0, 0);
            MySlot.Margin = new Padding(0);
            MySlot.Name = "MySlot";
            MySlot.Size = new Size(879, 77);
            MySlot.TabIndex = 1;
            MySlot.Text = "    Slot";
            MySlot.TextAlign = ContentAlignment.MiddleLeft;
            MySlot.UseVisualStyleBackColor = false;
            MySlot.Click += button4_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(flowLayoutPanel2);
            panel4.Location = new Point(159, 528);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(879, 77);
            panel4.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(MyDay);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(879, 77);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // MyDay
            // 
            MyDay.BackColor = Color.FromArgb(69, 80, 108);
            MyDay.FlatAppearance.BorderSize = 0;
            MyDay.FlatStyle = FlatStyle.Flat;
            MyDay.ForeColor = Color.FromArgb(237, 242, 244);
            MyDay.Image = Properties.Resources.Icon_awesome_chevron_down3;
            MyDay.ImageAlign = ContentAlignment.MiddleRight;
            MyDay.Location = new Point(0, 0);
            MyDay.Margin = new Padding(0);
            MyDay.Name = "MyDay";
            MyDay.Size = new Size(879, 77);
            MyDay.TabIndex = 1;
            MyDay.Text = "    Day";
            MyDay.TextAlign = ContentAlignment.MiddleLeft;
            MyDay.UseVisualStyleBackColor = false;
            MyDay.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Location = new Point(159, 418);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(879, 77);
            panel3.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(MyFaculty);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(879, 77);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // MyFaculty
            // 
            MyFaculty.BackColor = Color.FromArgb(69, 80, 108);
            MyFaculty.FlatAppearance.BorderSize = 0;
            MyFaculty.FlatStyle = FlatStyle.Flat;
            MyFaculty.ForeColor = Color.FromArgb(237, 242, 244);
            MyFaculty.Image = Properties.Resources.Icon_awesome_chevron_down3;
            MyFaculty.ImageAlign = ContentAlignment.MiddleRight;
            MyFaculty.Location = new Point(0, 0);
            MyFaculty.Margin = new Padding(0);
            MyFaculty.Name = "MyFaculty";
            MyFaculty.Size = new Size(879, 77);
            MyFaculty.TabIndex = 1;
            MyFaculty.Text = "    Faculty";
            MyFaculty.TextAlign = ContentAlignment.MiddleLeft;
            MyFaculty.UseVisualStyleBackColor = false;
            MyFaculty.Click += button1_Click;
            // 
            // IdCreation_pm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 1106);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "IdCreation_pm";
            Text = "Form3";
            Load += IdCreation_pm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            CoursePanel1.ResumeLayout(false);
            CoursePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Button GenerateID;
        private Panel CoursePanel1;
        private Panel panel1;
        private FlowLayoutPanel CoursePanel;
        private Button MyCourse;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button MyFaculty;
        private Panel panel6;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button MyRoom;
        private Panel panel5;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button MySlot;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button MyDay;
    }
}