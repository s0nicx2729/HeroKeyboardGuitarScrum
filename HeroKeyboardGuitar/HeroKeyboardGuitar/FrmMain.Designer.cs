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
            ((System.ComponentModel.ISupportInitialize)picTarget).BeginInit();
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
            picTarget.BackgroundImage = Properties.Resources.idle;
            picTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picTarget.Location = new System.Drawing.Point(877, 155);
            picTarget.Name = "picTarget";
            picTarget.Size = new System.Drawing.Size(182, 193);
            picTarget.TabIndex = 3;
            picTarget.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1764, 644);
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
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer tmrPlay;
        private System.Windows.Forms.PictureBox picTarget;
    }
}
