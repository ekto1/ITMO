namespace Lab4_Ex4
{
    partial class Form2
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
            this.textBoxF21 = new System.Windows.Forms.TextBox();
            this.textBoxF22 = new System.Windows.Forms.TextBox();
            this.textBoxF23 = new System.Windows.Forms.TextBox();
            this.buttonF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxF21
            // 
            this.textBoxF21.Location = new System.Drawing.Point(61, 45);
            this.textBoxF21.Name = "textBoxF21";
            this.textBoxF21.Size = new System.Drawing.Size(377, 39);
            this.textBoxF21.TabIndex = 0;
            // 
            // textBoxF22
            // 
            this.textBoxF22.Location = new System.Drawing.Point(61, 146);
            this.textBoxF22.Name = "textBoxF22";
            this.textBoxF22.Size = new System.Drawing.Size(377, 39);
            this.textBoxF22.TabIndex = 1;
            // 
            // textBoxF23
            // 
            this.textBoxF23.Location = new System.Drawing.Point(61, 261);
            this.textBoxF23.Name = "textBoxF23";
            this.textBoxF23.Size = new System.Drawing.Size(377, 39);
            this.textBoxF23.TabIndex = 2;
            // 
            // buttonF2
            // 
            this.buttonF2.Location = new System.Drawing.Point(396, 361);
            this.buttonF2.Name = "buttonF2";
            this.buttonF2.Size = new System.Drawing.Size(150, 46);
            this.buttonF2.TabIndex = 3;
            this.buttonF2.Text = "button1";
            this.buttonF2.UseVisualStyleBackColor = true;
            this.buttonF2.Click += new System.EventHandler(this.buttonF2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.buttonF2);
            this.Controls.Add(this.textBoxF23);
            this.Controls.Add(this.textBoxF22);
            this.Controls.Add(this.textBoxF21);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxF21;
        private TextBox textBoxF22;
        private TextBox textBoxF23;
        private Button buttonF2;
    }
}