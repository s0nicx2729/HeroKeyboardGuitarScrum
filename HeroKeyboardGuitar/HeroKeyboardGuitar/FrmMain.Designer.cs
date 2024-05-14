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
            lblScore = new System.Windows.Forms.Label();
            tmrScoreShrink = new System.Windows.Forms.Timer(components);
            panBg = new System.Windows.Forms.Panel();
            Ending = new System.Windows.Forms.Label();
            Lscore = new System.Windows.Forms.Label();
            Lstreak = new System.Windows.Forms.Label();
            streakVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)picTarget).BeginInit();
            panBg.SuspendLayout();
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
            picTarget.BackgroundImage = Properties.Resources._default;
            picTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picTarget.Location = new System.Drawing.Point(372, 498);
            picTarget.Name = "picTarget";
            picTarget.Size = new System.Drawing.Size(120, 120);
            picTarget.TabIndex = 3;
            picTarget.TabStop = false;
            // 
            // lblScore
            // 
            lblScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblScore.BackColor = System.Drawing.Color.Transparent;
            lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblScore.ForeColor = System.Drawing.Color.White;
            lblScore.Location = new System.Drawing.Point(1028, 379);
            lblScore.Name = "lblScore";
            lblScore.Size = new System.Drawing.Size(177, 79);
            lblScore.TabIndex = 5;
            lblScore.Text = "0";
            lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panBg
            // 
            panBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panBg.Controls.Add(Ending);
            panBg.Controls.Add(Lscore);
            panBg.Controls.Add(Lstreak);
            panBg.Controls.Add(streakVal);
            panBg.Controls.Add(lblScore);
            panBg.Dock = System.Windows.Forms.DockStyle.Top;
            panBg.Location = new System.Drawing.Point(0, 0);
            panBg.Name = "panBg";
            panBg.Size = new System.Drawing.Size(1237, 480);
            panBg.TabIndex = 6;
            // 
            // Ending
            // 
            Ending.Anchor = System.Windows.Forms.AnchorStyles.None;
            Ending.BackColor = System.Drawing.Color.Transparent;
            Ending.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            Ending.ForeColor = System.Drawing.Color.White;
            Ending.Location = new System.Drawing.Point(315, 9);
            Ending.Name = "Ending";
            Ending.Size = new System.Drawing.Size(697, 471);
            Ending.TabIndex = 9;
            Ending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Ending.Visible = false;
            // 
            // Lscore
            // 
            Lscore.Anchor = System.Windows.Forms.AnchorStyles.None;
            Lscore.BackColor = System.Drawing.Color.Transparent;
            Lscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            Lscore.ForeColor = System.Drawing.Color.White;
            Lscore.Location = new System.Drawing.Point(1028, 343);
            Lscore.Name = "Lscore";
            Lscore.Size = new System.Drawing.Size(177, 36);
            Lscore.TabIndex = 8;
            Lscore.Text = "SCORE";
            Lscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lstreak
            // 
            Lstreak.Anchor = System.Windows.Forms.AnchorStyles.None;
            Lstreak.BackColor = System.Drawing.Color.Transparent;
            Lstreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            Lstreak.ForeColor = System.Drawing.Color.White;
            Lstreak.Location = new System.Drawing.Point(1028, 213);
            Lstreak.Name = "Lstreak";
            Lstreak.Size = new System.Drawing.Size(177, 36);
            Lstreak.TabIndex = 7;
            Lstreak.Text = "STREAK";
            Lstreak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // streakVal
            // 
            streakVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            streakVal.BackColor = System.Drawing.Color.Transparent;
            streakVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            streakVal.ForeColor = System.Drawing.Color.White;
            streakVal.Location = new System.Drawing.Point(1087, 249);
            streakVal.Name = "streakVal";
            streakVal.Size = new System.Drawing.Size(61, 79);
            streakVal.TabIndex = 6;
            streakVal.Text = "0";
            streakVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1237, 644);
            Controls.Add(panBg);
            Controls.Add(picTarget);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "FrmMain";
            Text = "Play Song";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            KeyDown += FrmMain_KeyDown;
            KeyPress += FrmMain_KeyPress;
            KeyUp += FrmMain_KeyUp;
            ((System.ComponentModel.ISupportInitialize)picTarget).EndInit();
            panBg.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer tmrPlay;
        private System.Windows.Forms.PictureBox picTarget;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrScoreShrink;
        private System.Windows.Forms.Panel panBg;
        private System.Windows.Forms.Label streakVal;
        private System.Windows.Forms.Label Lstreak;
        private System.Windows.Forms.Label Lscore;
        private System.Windows.Forms.Label Ending;
    }
}
