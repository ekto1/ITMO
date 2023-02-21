namespace PW1_Ex2_DBConnection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBShutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBConnectionToolStripMenuItem,
            this.dBShutdownToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(132, 38);
            this.fileToolStripMenuItem.Text = "DataBase";
            // 
            // dBConnectionToolStripMenuItem
            // 
            this.dBConnectionToolStripMenuItem.Name = "dBConnectionToolStripMenuItem";
            this.dBConnectionToolStripMenuItem.Size = new System.Drawing.Size(301, 44);
            this.dBConnectionToolStripMenuItem.Text = "DBConnection";
            this.dBConnectionToolStripMenuItem.Click += new System.EventHandler(this.dBConnectionToolStripMenuItem_Click);
            // 
            // dBShutdownToolStripMenuItem
            // 
            this.dBShutdownToolStripMenuItem.Name = "dBShutdownToolStripMenuItem";
            this.dBShutdownToolStripMenuItem.Size = new System.Drawing.Size(301, 44);
            this.dBShutdownToolStripMenuItem.Text = "DBShutdown";
            this.dBShutdownToolStripMenuItem.Click += new System.EventHandler(this.dBShutdownToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionListToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(71, 38);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // connectionListToolStripMenuItem
            // 
            this.connectionListToolStripMenuItem.Name = "connectionListToolStripMenuItem";
            this.connectionListToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.connectionListToolStripMenuItem.Text = "ConnectionList";
            this.connectionListToolStripMenuItem.Click += new System.EventHandler(this.connectionListToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem dBConnectionToolStripMenuItem;
        private ToolStripMenuItem dBShutdownToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem connectionListToolStripMenuItem;
    }
}