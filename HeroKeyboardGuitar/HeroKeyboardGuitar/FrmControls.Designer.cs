namespace HeroKeyboardGuitar
{
    partial class Controls
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Black;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(316, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(189, 41);
            label1.TabIndex = 0;
            label1.Text = "How To Play!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(12, 256);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(784, 20);
            label2.TabIndex = 1;
            label2.Text = "* The middle character is you! Use the left and right mouse buttons to attack incoming enemies. Left click for enemies";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(12, 304);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(681, 20);
            label3.TabIndex = 2;
            label3.Text = "* Your range of attack is represented by the red and blue region to the left and right of your character.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(12, 336);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(768, 20);
            label4.TabIndex = 3;
            label4.Text = "* Getting hit reduces your health by one. However, defeating enemies heals you one point. If your health reaches 0, ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(12, 356);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(334, 20);
            label5.TabIndex = 4;
            label5.Text = "you lose! You have a total maximum health of 10.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(12, 276);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(340, 20);
            label6.TabIndex = 5;
            label6.Text = "on the left and right click for enemies on the right.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(12, 385);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(590, 20);
            label7.TabIndex = 6;
            label7.Text = "* Click the red X in the top right of the screen to go back as well as to close this window.";
            // 
            // Controls
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Controls";
            Text = "How To Play!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}