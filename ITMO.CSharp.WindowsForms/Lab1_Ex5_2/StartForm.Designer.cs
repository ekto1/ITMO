﻿namespace Lab1_Ex5_2
{
    partial class StartForm
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
            this.OpenGreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenGreen
            // 
            this.OpenGreen.Location = new System.Drawing.Point(278, 182);
            this.OpenGreen.Name = "OpenGreen";
            this.OpenGreen.Size = new System.Drawing.Size(290, 46);
            this.OpenGreen.TabIndex = 0;
            this.OpenGreen.Text = "Open Greenpeace";
            this.OpenGreen.UseVisualStyleBackColor = true;
            this.OpenGreen.Click += new System.EventHandler(this.OpenGreen_Click);
            // 
            // StartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenGreen);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Button OpenGreen;
    }
}