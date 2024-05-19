namespace KIET_LMS.Program_manager
{
    partial class ProgramManagerLMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramManagerLMS));
            showpanel = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // showpanel
            // 
            showpanel.BackColor = Color.FromArgb(43, 45, 66);
            showpanel.Location = new Point(315, 45);
            showpanel.Name = "showpanel";
            showpanel.Size = new Size(879, 701);
            showpanel.TabIndex = 6;
            showpanel.Paint += showpanel_Paint;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.FromArgb(61, 97, 164);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(237, 242, 244);
            button3.Image = Properties.Resources.Icon_ionic_ios_add_circle_outline;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(22, 190);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(279, 63);
            button3.TabIndex = 4;
            button3.Text = "    ID Creation";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(61, 97, 164);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(237, 242, 244);
            button2.Image = Properties.Resources.Icon_material_watch_later;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(22, 322);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(290, 63);
            button2.TabIndex = 4;
            button2.Text = "   Course Timings";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(61, 97, 164);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(237, 242, 244);
            button1.Image = Properties.Resources.Icon_material_group_add;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(22, 256);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(371, 63);
            button1.TabIndex = 4;
            button1.Text = "    Student Registration";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 97, 164);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 679);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(10);
            pictureBox1.Size = new Size(315, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(237, 242, 244);
            label2.Location = new Point(22, 73);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(380, 29);
            label2.TabIndex = 3;
            label2.Text = "The redesigned Learning Platform";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(237, 242, 244);
            label1.Location = new Point(0, -19);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(4);
            label1.Size = new Size(187, 81);
            label1.TabIndex = 2;
            label1.Text = "KIET";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(235, 134, 56);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(237, 242, 244);
            button4.Image = Properties.Resources.Icon_awesome_arrow_left;
            button4.Location = new Point(792, 6);
            button4.Name = "button4";
            button4.Size = new Size(36, 33);
            button4.TabIndex = 4;
            button4.TabStop = false;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(230, 42, 42);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(237, 242, 244);
            button5.Location = new Point(834, 6);
            button5.Name = "button5";
            button5.Size = new Size(36, 33);
            button5.TabIndex = 5;
            button5.TabStop = false;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(235, 134, 56);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(315, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(879, 45);
            panel2.TabIndex = 7;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.Icon_metro_switch;
            button6.Location = new Point(744, 7);
            button6.Name = "button6";
            button6.Size = new Size(42, 33);
            button6.TabIndex = 0;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // ProgramManagerLMS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 45, 66);
            ClientSize = new Size(1194, 679);
            Controls.Add(panel2);
            Controls.Add(showpanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProgramManagerLMS";
            Text = "ProgramManagerLMS";
            Load += ProgramManagerLMS_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel showpanel;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button5;
        private Panel panel2;
        private Button button6;
    }
}