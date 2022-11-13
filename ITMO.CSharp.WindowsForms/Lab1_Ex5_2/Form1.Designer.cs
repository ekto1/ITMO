namespace Lab1_Ex5_2
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
            this.ClosingBbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClosingBbutton
            // 
            this.ClosingBbutton.Location = new System.Drawing.Point(387, 239);
            this.ClosingBbutton.Name = "ClosingBbutton";
            this.ClosingBbutton.Size = new System.Drawing.Size(200, 50);
            this.ClosingBbutton.TabIndex = 0;
            this.ClosingBbutton.Text = "GREENPEACE";
            this.ClosingBbutton.UseVisualStyleBackColor = true;
            this.ClosingBbutton.Click += new System.EventHandler(this.ClosingBbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(974, 529);
            this.Controls.Add(this.ClosingBbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ClosingBbutton;
    }
}