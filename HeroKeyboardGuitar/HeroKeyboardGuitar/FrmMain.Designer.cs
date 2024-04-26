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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            plot = new ScottPlot.WinForms.FormsPlot();
            label1 = new System.Windows.Forms.Label();
            tmrPlay = new System.Windows.Forms.Timer(components);
            btnBeatPress = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            btnPlay = new System.Windows.Forms.Button();
            cmbSongChoice = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            nudThreshold = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)nudThreshold).BeginInit();
            SuspendLayout();
            // 
            // plot
            // 
            plot.DisplayScale = 1F;
            plot.Location = new System.Drawing.Point(10, 10);
            plot.Name = "plot";
            plot.Size = new System.Drawing.Size(1035, 205);
            plot.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(185, 218);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 37);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // tmrPlay
            // 
            tmrPlay.Interval = 5;
            tmrPlay.Tick += tmrPlay_Tick;
            // 
            // btnBeatPress
            // 
            btnBeatPress.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnBeatPress.Location = new System.Drawing.Point(170, 387);
            btnBeatPress.Name = "btnBeatPress";
            btnBeatPress.Size = new System.Drawing.Size(183, 169);
            btnBeatPress.TabIndex = 2;
            btnBeatPress.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            label2.Location = new System.Drawing.Point(1004, 442);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 34);
            label2.TabIndex = 3;
            // 
            // btnPlay
            // 
            btnPlay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnPlay.Location = new System.Drawing.Point(946, 218);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new System.Drawing.Size(98, 41);
            btnPlay.TabIndex = 4;
            btnPlay.Text = "Play";
            btnPlay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // cmbSongChoice
            // 
            cmbSongChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSongChoice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cmbSongChoice.FormattingEnabled = true;
            cmbSongChoice.Items.AddRange(new object[] { "Beat", "Mario" });
            cmbSongChoice.Location = new System.Drawing.Point(755, 222);
            cmbSongChoice.Name = "cmbSongChoice";
            cmbSongChoice.Size = new System.Drawing.Size(186, 33);
            cmbSongChoice.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(571, 218);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(182, 37);
            label3.TabIndex = 6;
            label3.Text = "Song Choice:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudThreshold
            // 
            nudThreshold.DecimalPlaces = 2;
            nudThreshold.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            nudThreshold.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            nudThreshold.Location = new System.Drawing.Point(755, 263);
            nudThreshold.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudThreshold.Name = "nudThreshold";
            nudThreshold.Size = new System.Drawing.Size(75, 33);
            nudThreshold.TabIndex = 7;
            nudThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudThreshold.Value = new decimal(new int[] { 7, 0, 0, 131072 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(539, 255);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(216, 37);
            label4.TabIndex = 8;
            label4.Text = "Freq Threshold:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(1057, 699);
            Controls.Add(label4);
            Controls.Add(nudThreshold);
            Controls.Add(label3);
            Controls.Add(cmbSongChoice);
            Controls.Add(btnPlay);
            Controls.Add(label2);
            Controls.Add(btnBeatPress);
            Controls.Add(label1);
            Controls.Add(plot);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "FrmMain";
            Text = "Form1";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)nudThreshold).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot plot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrPlay;
        private System.Windows.Forms.Button btnBeatPress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox cmbSongChoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudThreshold;
        private System.Windows.Forms.Label label4;
    }
}
