namespace HeroKeyboardGuitar {
    partial class FrmTitle {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new System.Windows.Forms.Button();
            HowTo = new System.Windows.Forms.Button();
            btnControls = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnStart.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnStart.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnStart.ForeColor = System.Drawing.Color.Black;
            btnStart.Location = new System.Drawing.Point(433, 396);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(422, 65);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // HowTo
            // 
            HowTo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            HowTo.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            HowTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            HowTo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            HowTo.ForeColor = System.Drawing.Color.Black;
            HowTo.Location = new System.Drawing.Point(433, 538);
            HowTo.Name = "HowTo";
            HowTo.Size = new System.Drawing.Size(422, 65);
            HowTo.TabIndex = 1;
            HowTo.Text = "How To Play";
            HowTo.UseVisualStyleBackColor = false;
            HowTo.Click += HowTo_Click;
            // 
            // btnControls
            // 
            btnControls.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnControls.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            btnControls.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnControls.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnControls.ForeColor = System.Drawing.Color.Black;
            btnControls.Location = new System.Drawing.Point(433, 467);
            btnControls.Name = "btnControls";
            btnControls.Size = new System.Drawing.Size(422, 65);
            btnControls.TabIndex = 2;
            btnControls.Text = "Controls";
            btnControls.UseVisualStyleBackColor = false;
            btnControls.Click += btnControls_Click;
            // 
            // FrmTitle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.title6;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1229, 664);
            Controls.Add(btnControls);
            Controls.Add(HowTo);
            Controls.Add(btnStart);
            DoubleBuffered = true;
            Name = "FrmTitle";
            Text = "Hero Keyboard Guitar";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FrmTitle_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button HowTo;
        private System.Windows.Forms.Button btnControls;
    }
}