﻿namespace Lab4_Ex4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxF1 = new System.Windows.Forms.TextBox();
            this.buttonF1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxF1
            // 
            this.textBoxF1.Location = new System.Drawing.Point(51, 71);
            this.textBoxF1.Name = "textBoxF1";
            this.textBoxF1.Size = new System.Drawing.Size(394, 39);
            this.textBoxF1.TabIndex = 0;
            // 
            // buttonF1
            // 
            this.buttonF1.Location = new System.Drawing.Point(526, 67);
            this.buttonF1.Name = "buttonF1";
            this.buttonF1.Size = new System.Drawing.Size(228, 46);
            this.buttonF1.TabIndex = 1;
            this.buttonF1.Text = "button1";
            this.buttonF1.UseVisualStyleBackColor = true;
            this.buttonF1.Click += new System.EventHandler(this.buttonF1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 192);
            this.Controls.Add(this.buttonF1);
            this.Controls.Add(this.textBoxF1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxF1;
        private Button buttonF1;
    }
}