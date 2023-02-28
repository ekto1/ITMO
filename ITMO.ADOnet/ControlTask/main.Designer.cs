
namespace ControlTask
{
    partial class main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.связьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connecting = new System.Windows.Forms.ToolStripMenuItem();
            this.closing = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.addRow = new System.Windows.Forms.Button();
            this.deleteRow = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.связьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1524, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // связьToolStripMenuItem
            // 
            this.связьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connecting,
            this.closing});
            this.связьToolStripMenuItem.Name = "связьToolStripMenuItem";
            this.связьToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
            this.связьToolStripMenuItem.Text = "Связь";
            // 
            // connecting
            // 
            this.connecting.Name = "connecting";
            this.connecting.Size = new System.Drawing.Size(304, 44);
            this.connecting.Text = "Подключение";
            this.connecting.Click += new System.EventHandler(this.connecting_Click);
            // 
            // closing
            // 
            this.closing.Name = "closing";
            this.closing.Size = new System.Drawing.Size(304, 44);
            this.closing.Text = "Отключение";
            this.closing.Click += new System.EventHandler(this.closing_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 53);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1401, 472);
            this.dataGridView1.TabIndex = 1;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(1163, 556);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(264, 44);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Сохранить изменения";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(26, 556);
            this.addRow.Margin = new System.Windows.Forms.Padding(6);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(264, 44);
            this.addRow.TabIndex = 3;
            this.addRow.Text = "Добавить строку";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.Location = new System.Drawing.Point(348, 556);
            this.deleteRow.Margin = new System.Windows.Forms.Padding(6);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(264, 44);
            this.deleteRow.TabIndex = 4;
            this.deleteRow.Text = "Удалить строку";
            this.deleteRow.UseVisualStyleBackColor = true;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 629);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зачетное задание";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem связьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connecting;
        private System.Windows.Forms.ToolStripMenuItem closing;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button addRow;
        private System.Windows.Forms.Button deleteRow;
    }
}

