namespace HeroKeyboardGuitar {
    partial class FrmMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tmrPlay = new System.Windows.Forms.Timer(components);
            picTarget = new System.Windows.Forms.PictureBox();
            L_range = new System.Windows.Forms.PictureBox();
            R_range = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)picTarget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)L_range).BeginInit();
            ((System.ComponentModel.ISupportInitialize)R_range).BeginInit();
            SuspendLayout();
            // 
            // tmrPlay
            // 
            tmrPlay.Interval = 50;
            tmrPlay.Tick += tmrPlay_Tick;
            // 
            // picTarget
            // 
            picTarget.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            picTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picTarget.Image = Properties.Resources.idle2;
            picTarget.Location = new System.Drawing.Point(879, 230);
            picTarget.Name = "picTarget";
            picTarget.Size = new System.Drawing.Size(182, 193);
            picTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picTarget.TabIndex = 3;
            picTarget.TabStop = false;
            // 
            // L_range
            // 
            L_range.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            L_range.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            L_range.Location = new System.Drawing.Point(672, 429);
            L_range.Name = "L_range";
            L_range.Size = new System.Drawing.Size(209, 36);
            L_range.TabIndex = 4;
            L_range.TabStop = false;
            // 
            // R_range
            // 
            R_range.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            R_range.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            R_range.Location = new System.Drawing.Point(1061, 429);
            R_range.Name = "R_range";
            R_range.Size = new System.Drawing.Size(209, 36);
            R_range.TabIndex = 6;
            R_range.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1764, 644);
            Controls.Add(R_range);
            Controls.Add(L_range);
            Controls.Add(picTarget);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "FrmMain";
            Text = "Play Song";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            MouseDown += FrmMain_MouseDown;
            MouseUp += FrmMain_MouseUp;
            ((System.ComponentModel.ISupportInitialize)picTarget).EndInit();
            ((System.ComponentModel.ISupportInitialize)L_range).EndInit();
            ((System.ComponentModel.ISupportInitialize)R_range).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer tmrPlay;
        private System.Windows.Forms.PictureBox picTarget;
        private System.Windows.Forms.PictureBox L_range;
        private System.Windows.Forms.PictureBox R_range;
    }
}
