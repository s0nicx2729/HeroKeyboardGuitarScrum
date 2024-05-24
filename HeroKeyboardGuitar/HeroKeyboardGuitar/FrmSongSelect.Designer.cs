namespace HeroKeyboardGuitar {
    partial class FrmSongSelect {
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
            speedBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btn_ConfirmSpeed = new System.Windows.Forms.Button();
            lbl_speedCheck = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // speedBox
            // 
            speedBox.Location = new System.Drawing.Point(40, 361);
            speedBox.Name = "speedBox";
            speedBox.Size = new System.Drawing.Size(125, 27);
            speedBox.TabIndex = 0;
            speedBox.Text = ".7";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(40, 338);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 20);
            label1.TabIndex = 1;
            label1.Text = "Speed of Notes";
            // 
            // btn_ConfirmSpeed
            // 
            btn_ConfirmSpeed.Location = new System.Drawing.Point(58, 394);
            btn_ConfirmSpeed.Name = "btn_ConfirmSpeed";
            btn_ConfirmSpeed.Size = new System.Drawing.Size(94, 29);
            btn_ConfirmSpeed.TabIndex = 2;
            btn_ConfirmSpeed.Text = "Confirm";
            btn_ConfirmSpeed.UseVisualStyleBackColor = true;
            btn_ConfirmSpeed.Click += Btn_ConfirmSpeed_Click;
            // 
            // lbl_speedCheck
            // 
            lbl_speedCheck.AutoSize = true;
            lbl_speedCheck.Location = new System.Drawing.Point(40, 426);
            lbl_speedCheck.Name = "lbl_speedCheck";
            lbl_speedCheck.Size = new System.Drawing.Size(593, 20);
            lbl_speedCheck.TabIndex = 3;
            lbl_speedCheck.Text = "Invalid speed! No letters and input should resemble X.X with the X as any value you wish.";
            lbl_speedCheck.Visible = false;
            // 
            // FrmSongSelect
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(1211, 753);
            Controls.Add(lbl_speedCheck);
            Controls.Add(btn_ConfirmSpeed);
            Controls.Add(label1);
            Controls.Add(speedBox);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FrmSongSelect";
            Text = "Select Song";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FrmSongSelect_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox speedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ConfirmSpeed;
        private System.Windows.Forms.Label lbl_speedCheck;
    }
}