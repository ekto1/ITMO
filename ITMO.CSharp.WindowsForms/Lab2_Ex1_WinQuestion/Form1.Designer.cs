﻿namespace Lab2_Ex1_WinQuestion
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
            this.btnyes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(25, 67);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(69, 46);
            this.btnyes.TabIndex = 0;
            this.btnyes.Text = "Да";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вы довольны своей зарплатой?";
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(228, 67);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(66, 46);
            this.btnno.TabIndex = 2;
            this.btnno.TabStop = false;
            this.btnno.Text = "Нет";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnno_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 125);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnyes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Насущный вопрос";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnyes;
        private Label label1;
        private Button btnno;
    }
}