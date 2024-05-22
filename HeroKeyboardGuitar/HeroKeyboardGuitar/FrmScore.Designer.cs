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
            label1 = new System.Windows.Forms.Label();
            MultiplierVal = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            healthVal = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblScoreB
            // 
            lblScoreB.AutoSize = true;
            lblScoreB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblScoreB.ForeColor = System.Drawing.Color.White;
            lblScoreB.Location = new System.Drawing.Point(3, 36);
            lblScoreB.Name = "lblScoreB";
            lblScoreB.Size = new System.Drawing.Size(93, 36);
            lblScoreB.TabIndex = 0;
            lblScoreB.Text = "Score";
            // 
            // lblStreakB
            // 
            lblStreakB.AutoSize = true;
            lblStreakB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblStreakB.ForeColor = System.Drawing.Color.White;
            lblStreakB.Location = new System.Drawing.Point(12, 144);
            lblStreakB.Name = "lblStreakB";
            lblStreakB.Size = new System.Drawing.Size(100, 36);
            lblStreakB.TabIndex = 1;
            lblStreakB.Text = "Streak";
            // 
            // streakVal
            // 
            streakVal.AutoSize = true;
            streakVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            streakVal.ForeColor = System.Drawing.Color.White;
            streakVal.Location = new System.Drawing.Point(31, 180);
            streakVal.Name = "streakVal";
            streakVal.Size = new System.Drawing.Size(32, 36);
            streakVal.TabIndex = 2;
            streakVal.Text = "0";
            // 
            // scoreVal
            // 
            scoreVal.AutoSize = true;
            scoreVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            scoreVal.ForeColor = System.Drawing.Color.White;
            scoreVal.Location = new System.Drawing.Point(31, 72);
            scoreVal.Name = "scoreVal";
            scoreVal.Size = new System.Drawing.Size(32, 36);
            scoreVal.TabIndex = 3;
            scoreVal.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(113, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(136, 36);
            label1.TabIndex = 4;
            label1.Text = "Multiplier";
            // 
            // MultiplierVal
            // 
            MultiplierVal.AutoSize = true;
            MultiplierVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MultiplierVal.ForeColor = System.Drawing.Color.White;
            MultiplierVal.Location = new System.Drawing.Point(168, 72);
            MultiplierVal.Name = "MultiplierVal";
            MultiplierVal.Size = new System.Drawing.Size(32, 36);
            MultiplierVal.TabIndex = 5;
            MultiplierVal.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(138, 144);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 36);
            label2.TabIndex = 6;
            label2.Text = "Heatlh";
            // 
            // healthVal
            // 
            healthVal.AutoSize = true;
            healthVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            healthVal.ForeColor = System.Drawing.Color.White;
            healthVal.Location = new System.Drawing.Point(151, 180);
            healthVal.Name = "healthVal";
            healthVal.Size = new System.Drawing.Size(49, 36);
            healthVal.TabIndex = 7;
            healthVal.Text = "10";
            // 
            // FrmScore
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(259, 242);
            ControlBox = false;
            Controls.Add(healthVal);
            Controls.Add(label2);
            Controls.Add(MultiplierVal);
            Controls.Add(label1);
            Controls.Add(scoreVal);
            Controls.Add(streakVal);
            Controls.Add(lblStreakB);
            Controls.Add(lblScoreB);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmScore";
            Text = "ScoreBoard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblScoreB;
        private System.Windows.Forms.Label lblStreakB;
        private System.Windows.Forms.Label streakVal;
        private System.Windows.Forms.Label scoreVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MultiplierVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label healthVal;
    }
}