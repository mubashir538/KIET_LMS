﻿namespace KIET_LMS
{
    partial class CoursePageStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursePageStudent));
            panel1 = new Panel();
            courseAbr = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            room = new Label();
            label9 = new Label();
            slot = new Label();
            label8 = new Label();
            day = new Label();
            label7 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            tpost = new Label();
            tmail = new Label();
            tname = new Label();
            panel4 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label23 = new Label();
            label22 = new Label();
            label16 = new Label();
            label21 = new Label();
            label13 = new Label();
            label20 = new Label();
            label15 = new Label();
            label19 = new Label();
            label12 = new Label();
            label18 = new Label();
            label14 = new Label();
            label17 = new Label();
            label11 = new Label();
            label10 = new Label();
            panel5 = new Panel();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 97, 164);
            panel1.Controls.Add(courseAbr);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1256, 167);
            panel1.TabIndex = 0;
            // 
            // courseAbr
            // 
            courseAbr.AutoSize = true;
            courseAbr.Font = new Font("Microsoft Sans Serif", 35F, FontStyle.Bold, GraphicsUnit.Point);
            courseAbr.ForeColor = Color.FromArgb(237, 242, 244);
            courseAbr.Location = new Point(643, 15);
            courseAbr.Margin = new Padding(4, 0, 4, 0);
            courseAbr.Name = "courseAbr";
            courseAbr.Size = new Size(192, 79);
            courseAbr.TabIndex = 2;
            courseAbr.Text = "OOP";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(62, 67, 88);
            panel2.Controls.Add(room);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(slot);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(day);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(30, 260);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(393, 348);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // room
            // 
            room.AutoSize = true;
            room.Font = new Font("Montserrat Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            room.ForeColor = Color.FromArgb(237, 242, 244);
            room.Location = new Point(203, 243);
            room.Margin = new Padding(4, 0, 4, 0);
            room.Name = "room";
            room.Size = new Size(87, 41);
            room.TabIndex = 0;
            room.Text = "8 - B";
            room.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(189, 224, 254);
            label9.Location = new Point(17, 243);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(124, 41);
            label9.TabIndex = 0;
            label9.Text = "Room :";
            // 
            // slot
            // 
            slot.AutoSize = true;
            slot.Font = new Font("Montserrat Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            slot.ForeColor = Color.FromArgb(237, 242, 244);
            slot.Location = new Point(203, 178);
            slot.Margin = new Padding(4, 0, 4, 0);
            slot.Name = "slot";
            slot.Size = new Size(178, 41);
            slot.TabIndex = 0;
            slot.Text = "8:40 - 11:40";
            slot.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(189, 224, 254);
            label8.Location = new Point(17, 178);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(89, 41);
            label8.TabIndex = 0;
            label8.Text = "Slot :";
            // 
            // day
            // 
            day.AutoSize = true;
            day.Font = new Font("Montserrat Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            day.ForeColor = Color.FromArgb(237, 242, 244);
            day.Location = new Point(203, 113);
            day.Margin = new Padding(4, 0, 4, 0);
            day.Name = "day";
            day.Size = new Size(139, 41);
            day.TabIndex = 0;
            day.Text = "Monday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(189, 224, 254);
            label7.Location = new Point(17, 113);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 41);
            label7.TabIndex = 0;
            label7.Text = "Day :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(237, 242, 244);
            label2.Location = new Point(17, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(197, 44);
            label2.TabIndex = 0;
            label2.Text = "Class Info";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(62, 67, 88);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(tpost);
            panel3.Controls.Add(tmail);
            panel3.Controls.Add(tname);
            panel3.Location = new Point(451, 260);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(354, 348);
            panel3.TabIndex = 1;
            panel3.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(237, 242, 244);
            label3.Location = new Point(19, 15);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(194, 37);
            label3.TabIndex = 0;
            label3.Text = "Faculty Info";
            // 
            // tpost
            // 
            tpost.AutoSize = true;
            tpost.Font = new Font("Montserrat", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tpost.ForeColor = Color.FromArgb(237, 242, 244);
            tpost.Location = new Point(33, 258);
            tpost.Margin = new Padding(4, 0, 4, 0);
            tpost.Name = "tpost";
            tpost.Size = new Size(269, 30);
            tpost.TabIndex = 0;
            tpost.Text = "Lecturer/Lab Instructor";
            // 
            // tmail
            // 
            tmail.AutoSize = true;
            tmail.Font = new Font("Montserrat", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tmail.ForeColor = Color.FromArgb(237, 242, 244);
            tmail.Location = new Point(33, 193);
            tmail.Margin = new Padding(4, 0, 4, 0);
            tmail.Name = "tmail";
            tmail.Size = new Size(316, 30);
            tmail.TabIndex = 0;
            tmail.Text = "yusramansoor@kiet.edu.pk";
            // 
            // tname
            // 
            tname.AutoSize = true;
            tname.Font = new Font("Montserrat", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tname.ForeColor = Color.FromArgb(237, 242, 244);
            tname.Location = new Point(33, 128);
            tname.Margin = new Padding(4, 0, 4, 0);
            tname.Name = "tname";
            tname.Size = new Size(177, 30);
            tname.TabIndex = 0;
            tname.Text = "Yusra Mansoor";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(62, 67, 88);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label23);
            panel4.Controls.Add(label22);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(824, 260);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(401, 793);
            panel4.TabIndex = 1;
            panel4.Paint += panel2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(237, 242, 244);
            label5.Location = new Point(157, 75);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 44);
            label5.TabIndex = 0;
            label5.Text = "Info";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(237, 242, 244);
            label4.Location = new Point(19, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(193, 44);
            label4.TabIndex = 0;
            label4.Text = "Sessional";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.FromArgb(189, 224, 254);
            label23.Location = new Point(283, 668);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(80, 40);
            label23.TabIndex = 0;
            label23.Text = "N/A";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.FromArgb(235, 139, 56);
            label22.Location = new Point(283, 428);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(48, 47);
            label22.TabIndex = 0;
            label22.Text = "P";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(189, 224, 254);
            label16.Location = new Point(34, 668);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(130, 39);
            label16.TabIndex = 0;
            label16.Text = "Project :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.FromArgb(249, 82, 82);
            label21.Location = new Point(283, 588);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(72, 47);
            label21.TabIndex = 0;
            label21.Text = "LS";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(189, 224, 254);
            label13.Location = new Point(34, 428);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(111, 39);
            label13.TabIndex = 0;
            label13.Text = "Quiz 1 :";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(189, 224, 254);
            label20.Location = new Point(283, 348);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(91, 47);
            label20.TabIndex = 0;
            label20.Text = "N/A";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(189, 224, 254);
            label15.Location = new Point(34, 588);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(117, 39);
            label15.TabIndex = 0;
            label15.Text = "Quiz 3 :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(189, 224, 254);
            label19.Location = new Point(283, 508);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(91, 47);
            label19.TabIndex = 0;
            label19.Text = "N/A";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(189, 224, 254);
            label12.Location = new Point(34, 348);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(231, 39);
            label12.TabIndex = 0;
            label12.Text = "Assignment 3 : ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(82, 199, 86);
            label18.Location = new Point(283, 268);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(48, 47);
            label18.TabIndex = 0;
            label18.Text = "S";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(189, 224, 254);
            label14.Location = new Point(34, 508);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(117, 39);
            label14.TabIndex = 0;
            label14.Text = "Quiz 2 :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(189, 224, 254);
            label17.Location = new Point(283, 188);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(91, 47);
            label17.TabIndex = 0;
            label17.Text = "N/A";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(189, 224, 254);
            label11.Location = new Point(34, 268);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(231, 39);
            label11.TabIndex = 0;
            label11.Text = "Assignment 2 : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(189, 224, 254);
            label10.Location = new Point(34, 188);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(225, 39);
            label10.TabIndex = 0;
            label10.Text = "Assignment 1 : ";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(62, 67, 88);
            panel5.Controls.Add(linkLabel1);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(30, 645);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(776, 408);
            panel5.TabIndex = 1;
            panel5.Paint += panel2_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(189, 224, 254);
            linkLabel1.Location = new Point(81, 108);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(260, 44);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Course Outline";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(237, 242, 244);
            label6.Location = new Point(17, 20);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 48);
            label6.TabIndex = 0;
            label6.Text = "Files";
            // 
            // CoursePageStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 45, 66);
            ClientSize = new Size(1256, 1106);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CoursePageStudent";
            Text = "CoursePageStudent";
            Load += CoursePageStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label courseAbr;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label room;
        private Label label9;
        private Label slot;
        private Label label8;
        private Label day;
        private Label label7;
        private Label tpost;
        private Label tmail;
        private Label tname;
        private Label label23;
        private Label label22;
        private Label label16;
        private Label label21;
        private Label label13;
        private Label label20;
        private Label label15;
        private Label label19;
        private Label label12;
        private Label label18;
        private Label label14;
        private Label label17;
        private Label label11;
        private Label label10;
        private LinkLabel linkLabel1;
    }
}