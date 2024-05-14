namespace HeroKeyboardGuitar
{
    partial class FrmScore
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
            lblScoreB = new System.Windows.Forms.Label();
            lblStreakB = new System.Windows.Forms.Label();
            streakVal = new System.Windows.Forms.Label();
            scoreVal = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblScoreB
            // 
            lblScoreB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            lblScoreB.AutoSize = true;
            lblScoreB.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblScoreB.ForeColor = System.Drawing.Color.White;
            lblScoreB.Location = new System.Drawing.Point(20, 23);
            lblScoreB.Name = "lblScoreB";
            lblScoreB.Size = new System.Drawing.Size(92, 31);
            lblScoreB.TabIndex = 0;
            lblScoreB.Text = "Score";
            // 
            // lblStreakB
            // 
            lblStreakB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            lblStreakB.AutoSize = true;
            lblStreakB.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblStreakB.ForeColor = System.Drawing.Color.White;
            lblStreakB.Location = new System.Drawing.Point(20, 115);
            lblStreakB.Name = "lblStreakB";
            lblStreakB.Size = new System.Drawing.Size(109, 31);
            lblStreakB.TabIndex = 1;
            lblStreakB.Text = "Streak";
            // 
            // streakVal
            // 
            streakVal.AutoSize = true;
            streakVal.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            streakVal.ForeColor = System.Drawing.Color.White;
            streakVal.Location = new System.Drawing.Point(47, 146);
            streakVal.Name = "streakVal";
            streakVal.Size = new System.Drawing.Size(34, 31);
            streakVal.TabIndex = 2;
            streakVal.Text = "0";
            // 
            // scoreVal
            // 
            scoreVal.AutoSize = true;
            scoreVal.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            scoreVal.ForeColor = System.Drawing.Color.White;
            scoreVal.Location = new System.Drawing.Point(47, 54);
            scoreVal.Name = "scoreVal";
            scoreVal.Size = new System.Drawing.Size(34, 31);
            scoreVal.TabIndex = 3;
            scoreVal.Text = "0";
            // 
            // FrmScore
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(141, 195);
            ControlBox = false;
            Controls.Add(scoreVal);
            Controls.Add(streakVal);
            Controls.Add(lblStreakB);
            Controls.Add(lblScoreB);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmScore";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblScoreB;
        private System.Windows.Forms.Label lblStreakB;
        private System.Windows.Forms.Label streakVal;
        private System.Windows.Forms.Label scoreVal;
    }
}