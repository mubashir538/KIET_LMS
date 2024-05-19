namespace KIET_LMS
{
    partial class SelfRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelfRegistration));
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1088, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(141, 153, 174);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(879, 60);
            panel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(43, 45, 66);
            label3.Location = new Point(307, 9);
            label3.Name = "label3";
            label3.Size = new Size(253, 37);
            label3.TabIndex = 0;
            label3.Text = "Self Registration";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(237, 242, 244);
            label1.Location = new Point(21, 85);
            label1.Name = "label1";
            label1.Size = new Size(209, 22);
            label1.TabIndex = 11;
            label1.Text = "Credit Hours Available: 15";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(237, 242, 244);
            label2.Location = new Point(207, 140);
            label2.Name = "label2";
            label2.Size = new Size(373, 32);
            label2.TabIndex = 11;
            label2.Text = "Available Courses To Register";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(99, 199);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(666, 388);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Location = new Point(734, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(47, 447);
            panel1.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(235, 139, 56);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(43, 45, 66);
            button1.Location = new Point(624, 85);
            button1.Name = "button1";
            button1.Size = new Size(210, 48);
            button1.TabIndex = 15;
            button1.Text = "Done";
            button1.UseVisualStyleBackColor = false;
            // 
            // SelfRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 45, 66);
            ClientSize = new Size(879, 701);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelfRegistration";
            Text = "SelfRegistration";
            Load += SelfRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label3;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button button1;
    }
}