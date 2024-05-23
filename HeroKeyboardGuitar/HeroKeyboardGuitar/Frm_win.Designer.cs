namespace HeroKeyboardGuitar
{
    partial class Frm_win
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
            lbl_ending = new System.Windows.Forms.Label();
            btn_exit = new System.Windows.Forms.Button();
            btn_restart = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_ending
            // 
            lbl_ending.AutoSize = true;
            lbl_ending.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_ending.ForeColor = System.Drawing.Color.Black;
            lbl_ending.Location = new System.Drawing.Point(246, 37);
            lbl_ending.Name = "lbl_ending";
            lbl_ending.Size = new System.Drawing.Size(214, 25);
            lbl_ending.TabIndex = 3;
            lbl_ending.Text = "You are the Champion!";
            // 
            // btn_exit
            // 
            btn_exit.Location = new System.Drawing.Point(392, 298);
            btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new System.Drawing.Size(82, 22);
            btn_exit.TabIndex = 7;
            btn_exit.Text = "Quit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_restart
            // 
            btn_restart.Location = new System.Drawing.Point(230, 298);
            btn_restart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_restart.Name = "btn_restart";
            btn_restart.Size = new System.Drawing.Size(82, 22);
            btn_restart.TabIndex = 6;
            btn_restart.Text = "Play Again?";
            btn_restart.UseVisualStyleBackColor = true;
            btn_restart.Click += btn_restart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.winning;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(206, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(299, 164);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(320, 250);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(299, 265);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(70, 65);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 15);
            label3.TabIndex = 11;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(87, 95);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 15);
            label4.TabIndex = 12;
            label4.Text = "label4";
            // 
            // Frm_win
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            BackgroundImage = Properties.Resources.confetti_PNG86993;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(683, 354);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_exit);
            Controls.Add(btn_restart);
            Controls.Add(lbl_ending);
            DoubleBuffered = true;
            Name = "Frm_win";
            Text = "You Win!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_ending;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}