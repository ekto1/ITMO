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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.button3 = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(767, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBConnectionToolStripMenuItem,
            this.dBShutdownToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(132, 36);
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
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(71, 36);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // connectionListToolStripMenuItem
            // 
            this.connectionListToolStripMenuItem.Name = "connectionListToolStripMenuItem";
            this.connectionListToolStripMenuItem.Size = new System.Drawing.Size(305, 44);
            this.connectionListToolStripMenuItem.Text = "ConnectionList";
            this.connectionListToolStripMenuItem.Click += new System.EventHandler(this.connectionListToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сколько продуктов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сколько продуктов";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Список продуктов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(365, 203);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(360, 340);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название продукта";
            this.columnHeader1.Width = 360;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(66, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "Транзакция";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 584);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
        private Button button1;
        private Label label1;
        private Button button2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Button button3;
    }
}