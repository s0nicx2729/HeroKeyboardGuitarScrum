﻿namespace HeroKeyboardGuitar {
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
            SuspendLayout();
            // 
            // FrmSongSelect
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(1211, 753);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FrmSongSelect";
            Text = "Select Song";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FrmSongSelect_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}