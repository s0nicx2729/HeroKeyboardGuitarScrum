namespace HeroKeyboardGuitar
{
    partial class Frm_ending
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lbl_ending = new System.Windows.Forms.Label();
            btn_restart = new System.Windows.Forms.Button();
            btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hit;
            pictureBox1.Location = new System.Drawing.Point(268, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(278, 186);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_ending
            // 
            lbl_ending.AutoSize = true;
            lbl_ending.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_ending.ForeColor = System.Drawing.Color.White;
            lbl_ending.Location = new System.Drawing.Point(205, 110);
            lbl_ending.Name = "lbl_ending";
            lbl_ending.Size = new System.Drawing.Size(411, 31);
            lbl_ending.TabIndex = 1;
            lbl_ending.Text = "You were overwhelemed and defeated!";
            // 
            // btn_restart
            // 
            btn_restart.Location = new System.Drawing.Point(268, 336);
            btn_restart.Name = "btn_restart";
            btn_restart.Size = new System.Drawing.Size(94, 29);
            btn_restart.TabIndex = 2;
            btn_restart.Text = "Restart?";
            btn_restart.UseVisualStyleBackColor = true;
            btn_restart.Click += btn_restart_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new System.Drawing.Point(452, 336);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new System.Drawing.Size(94, 29);
            btn_exit.TabIndex = 3;
            btn_exit.Text = "Quit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Frm_ending
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btn_exit);
            Controls.Add(btn_restart);
            Controls.Add(lbl_ending);
            Controls.Add(pictureBox1);
            Name = "Frm_ending";
            Text = "Ending";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_ending;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_exit;
    }
}