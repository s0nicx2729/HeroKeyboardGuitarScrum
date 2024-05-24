namespace HeroKeyboardGuitar
{
    partial class FrmKeyboard
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
            LeftPunch = new System.Windows.Forms.TextBox();
            RightPunch = new System.Windows.Forms.TextBox();
            SubmitLeft = new System.Windows.Forms.Button();
            SubmitRight = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LeftPunch
            // 
            LeftPunch.Location = new System.Drawing.Point(293, 192);
            LeftPunch.MaxLength = 1;
            LeftPunch.Name = "LeftPunch";
            LeftPunch.Size = new System.Drawing.Size(100, 23);
            LeftPunch.TabIndex = 0;
            LeftPunch.Text = "a";
            LeftPunch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RightPunch
            // 
            RightPunch.Location = new System.Drawing.Point(293, 221);
            RightPunch.MaxLength = 1;
            RightPunch.Name = "RightPunch";
            RightPunch.Size = new System.Drawing.Size(100, 23);
            RightPunch.TabIndex = 1;
            RightPunch.Text = "d";
            RightPunch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubmitLeft
            // 
            SubmitLeft.Location = new System.Drawing.Point(399, 192);
            SubmitLeft.Name = "SubmitLeft";
            SubmitLeft.Size = new System.Drawing.Size(90, 23);
            SubmitLeft.TabIndex = 2;
            SubmitLeft.Text = "Submit Left";
            SubmitLeft.UseVisualStyleBackColor = true;
            SubmitLeft.Click += SubmitLeft_Click;
            // 
            // SubmitRight
            // 
            SubmitRight.Location = new System.Drawing.Point(399, 221);
            SubmitRight.Name = "SubmitRight";
            SubmitRight.Size = new System.Drawing.Size(90, 23);
            SubmitRight.TabIndex = 3;
            SubmitRight.Text = "Submit Right";
            SubmitRight.UseVisualStyleBackColor = true;
            SubmitRight.Click += SubmitRight_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(283, 174);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(240, 15);
            label1.TabIndex = 4;
            label1.Text = "Enter the key you wish to use for left or right";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(192, 195);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 15);
            label2.TabIndex = 5;
            label2.Text = "Left Punch";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(184, 224);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 15);
            label3.TabIndex = 6;
            label3.Text = "Right Punch";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.enemy_L;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.InitialImage = Properties.Resources.enemy_L;
            pictureBox1.Location = new System.Drawing.Point(184, 250);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(139, 138);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.enemy_R;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Location = new System.Drawing.Point(404, 250);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(119, 138);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(202, 98);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "None";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(283, 98);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Protanopia";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(364, 98);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Deuteranopia";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(445, 98);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(75, 23);
            button4.TabIndex = 12;
            button4.Text = "Tritanopia";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(268, 80);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(198, 15);
            label4.TabIndex = 13;
            label4.Text = "Colorblind Options for Health Meter";
            // 
            // FrmKeyboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SubmitRight);
            Controls.Add(SubmitLeft);
            Controls.Add(RightPunch);
            Controls.Add(LeftPunch);
            ForeColor = System.Drawing.SystemColors.ControlText;
            Name = "FrmKeyboard";
            Text = "Keyboard Controls";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox LeftPunch;
        private System.Windows.Forms.TextBox RightPunch;
        private System.Windows.Forms.Button SubmitLeft;
        private System.Windows.Forms.Button SubmitRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
    }
}