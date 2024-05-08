namespace KIET_LMS
{
    partial class CourseInformatin_t
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
            Department = new Label();
            Slot = new Label();
            Day = new Label();
            ClassID = new Label();
            Room = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            CourseName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 45, 66);
            panel1.Controls.Add(Department);
            panel1.Controls.Add(Slot);
            panel1.Controls.Add(Day);
            panel1.Controls.Add(ClassID);
            panel1.Controls.Add(Room);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
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
            // Department
            // 
            Department.AutoSize = true;
            Department.BackColor = Color.FromArgb(69, 80, 108);
            Department.FlatStyle = FlatStyle.Flat;
            Department.ForeColor = Color.FromArgb(237, 242, 244);
            Department.Location = new Point(839, 792);
            Department.Margin = new Padding(4, 0, 4, 0);
            Department.Name = "Department";
            Department.Padding = new Padding(7, 8, 7, 8);
            Department.Size = new Size(186, 66);
            Department.TabIndex = 3;
            Department.Text = "  COCIS  ";
            Department.Click += label7_Click;
            // 
            // Slot
            // 
            Slot.AutoSize = true;
            Slot.BackColor = Color.FromArgb(69, 80, 108);
            Slot.FlatStyle = FlatStyle.Flat;
            Slot.ForeColor = Color.FromArgb(237, 242, 244);
            Slot.Location = new Point(839, 687);
            Slot.Margin = new Padding(4, 0, 4, 0);
            Slot.Name = "Slot";
            Slot.Padding = new Padding(7, 8, 7, 8);
            Slot.Size = new Size(265, 66);
            Slot.TabIndex = 3;
            Slot.Text = "  8:40 - 11:40  ";
            Slot.Click += label7_Click;
            // 
            // Day
            // 
            Day.AutoSize = true;
            Day.BackColor = Color.FromArgb(69, 80, 108);
            Day.FlatStyle = FlatStyle.Flat;
            Day.ForeColor = Color.FromArgb(237, 242, 244);
            Day.Location = new Point(839, 582);
            Day.Margin = new Padding(4, 0, 4, 0);
            Day.Name = "Day";
            Day.Padding = new Padding(7, 8, 7, 8);
            Day.Size = new Size(153, 66);
            Day.TabIndex = 3;
            Day.Text = "  Mon  ";
            Day.Click += label7_Click;
            // 
            // ClassID
            // 
            ClassID.AutoSize = true;
            ClassID.BackColor = Color.FromArgb(69, 80, 108);
            ClassID.FlatStyle = FlatStyle.Flat;
            ClassID.ForeColor = Color.FromArgb(237, 242, 244);
            ClassID.Location = new Point(839, 477);
            ClassID.Margin = new Padding(4, 0, 4, 0);
            ClassID.Name = "ClassID";
            ClassID.Padding = new Padding(7, 8, 7, 8);
            ClassID.Size = new Size(178, 66);
            ClassID.TabIndex = 3;
            ClassID.Text = "  110821  ";
            ClassID.Click += label7_Click;
            // 
            // Room
            // 
            Room.AutoSize = true;
            Room.BackColor = Color.FromArgb(69, 80, 108);
            Room.FlatStyle = FlatStyle.Flat;
            Room.ForeColor = Color.FromArgb(237, 242, 244);
            Room.Location = new Point(839, 372);
            Room.Margin = new Padding(4, 0, 4, 0);
            Room.Name = "Room";
            Room.Padding = new Padding(7, 8, 7, 8);
            Room.Size = new Size(156, 66);
            Room.TabIndex = 3;
            Room.Text = "  Audi  ";
            Room.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(189, 224, 254);
            label6.Location = new Point(199, 808);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(276, 50);
            label6.TabIndex = 2;
            label6.Text = "Department :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(189, 224, 254);
            label5.Location = new Point(199, 703);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 50);
            label5.TabIndex = 2;
            label5.Text = "Slot :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(189, 224, 254);
            label4.Location = new Point(199, 598);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 50);
            label4.TabIndex = 2;
            label4.Text = "Day :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(189, 224, 254);
            label3.Location = new Point(199, 493);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(190, 50);
            label3.TabIndex = 2;
            label3.Text = "Class ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(189, 224, 254);
            label2.Location = new Point(199, 388);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 50);
            label2.TabIndex = 2;
            label2.Text = "Room :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(69, 80, 108);
            panel2.Controls.Add(CourseName);
            panel2.Location = new Point(304, 75);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(656, 93);
            panel2.TabIndex = 1;
            // 
            // CourseName
            // 
            CourseName.AutoSize = true;
            CourseName.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CourseName.ForeColor = Color.White;
            CourseName.Location = new Point(60, 18);
            CourseName.Margin = new Padding(4, 0, 4, 0);
            CourseName.Name = "CourseName";
            CourseName.Size = new Size(587, 50);
            CourseName.TabIndex = 0;
            CourseName.Text = "Object Oriented  Programming";
            CourseName.TextAlign = ContentAlignment.MiddleCenter;
            CourseName.Click += label1_Click;
            // 
            // CourseInformatin_t
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 1106);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CourseInformatin_t";
            Text = "Form9";
            Load += CourseInformatin_t_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label CourseName;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Room;
        private Label Department;
        private Label Slot;
        private Label Day;
        private Label ClassID;
    }
}