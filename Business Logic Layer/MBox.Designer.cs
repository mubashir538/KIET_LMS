namespace KIET_LMS
{
    partial class MBox
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
            showpanel = new Panel();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            message = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(235, 134, 56);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(showpanel);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1007, 39);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(237, 242, 244);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(55, 24);
            label1.TabIndex = 1;
            label1.Text = "KIET";
            // 
            // showpanel
            // 
            showpanel.BackColor = Color.FromArgb(43, 45, 66);
            showpanel.Location = new Point(3, 45);
            showpanel.Name = "showpanel";
            showpanel.Size = new Size(879, 701);
            showpanel.TabIndex = 9;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(235, 134, 56);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(237, 242, 244);
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
            button5.Location = new Point(954, 3);
            button5.Name = "button5";
            button5.Size = new Size(36, 33);
            button5.TabIndex = 5;
            button5.TabStop = false;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 45, 66);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(message);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 219);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(235, 134, 56);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat Medium", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(43, 45, 66);
            button2.Location = new Point(835, 157);
            button2.Name = "button2";
            button2.Size = new Size(136, 36);
            button2.TabIndex = 2;
            button2.Text = "Okay!";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Font = new Font("Montserrat", 13F, FontStyle.Regular, GraphicsUnit.Point);
            message.ForeColor = Color.FromArgb(237, 242, 244);
            message.Location = new Point(163, 12);
            message.Name = "message";
            message.Size = new Size(63, 25);
            message.TabIndex = 1;
            message.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 134, 56);
            ClientSize = new Size(1013, 264);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MBox";
            Padding = new Padding(3);
            Text = "MessageBox";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel showpanel;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button2;
        public Label message;
        public Label label1;
    }
}