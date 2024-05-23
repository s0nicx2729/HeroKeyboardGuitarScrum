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
            SuspendLayout();
            // 
            // LeftPunch
            // 
            LeftPunch.Location = new System.Drawing.Point(209, 179);
            LeftPunch.MaxLength = 1;
            LeftPunch.Name = "LeftPunch";
            LeftPunch.Size = new System.Drawing.Size(100, 23);
            LeftPunch.TabIndex = 0;
            LeftPunch.Text = "a";
            LeftPunch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RightPunch
            // 
            RightPunch.Location = new System.Drawing.Point(209, 221);
            RightPunch.MaxLength = 1;
            RightPunch.Name = "RightPunch";
            RightPunch.Size = new System.Drawing.Size(100, 23);
            RightPunch.TabIndex = 1;
            RightPunch.Text = "d";
            RightPunch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubmitLeft
            // 
            SubmitLeft.Location = new System.Drawing.Point(336, 178);
            SubmitLeft.Name = "SubmitLeft";
            SubmitLeft.Size = new System.Drawing.Size(90, 23);
            SubmitLeft.TabIndex = 2;
            SubmitLeft.Text = "Submit Left";
            SubmitLeft.UseVisualStyleBackColor = true;
            SubmitLeft.Click += SubmitLeft_Click;
            // 
            // SubmitRight
            // 
            SubmitRight.Location = new System.Drawing.Point(336, 221);
            SubmitRight.Name = "SubmitRight";
            SubmitRight.Size = new System.Drawing.Size(90, 23);
            SubmitRight.TabIndex = 3;
            SubmitRight.Text = "Submit Right";
            SubmitRight.UseVisualStyleBackColor = true;
            SubmitRight.Click += SubmitRight_Click;
            // 
            // FrmKeyboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(SubmitRight);
            Controls.Add(SubmitLeft);
            Controls.Add(RightPunch);
            Controls.Add(LeftPunch);
            Name = "FrmKeyboard";
            Text = "Keyboard Controls";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox LeftPunch;
        private System.Windows.Forms.TextBox RightPunch;
        private System.Windows.Forms.Button SubmitLeft;
        private System.Windows.Forms.Button SubmitRight;
    }
}