namespace Lab2_Ex7_RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(22, 192); 
                lbl.Size = new System.Drawing.Size(120, 46); 
                lbl.Name = "labelll";
                lbl.TabIndex = 2;
                lbl.Text = "������2";
                groupBox1.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(152, 192); 
                txt.Size = new System.Drawing.Size(554, 40); 
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = ""; groupBox1.Controls.Add(txt);
            }
            else
            {
                int lcv;
                lcv = groupBox1.Controls.Count;// ������������ ���������� ���������
                while (lcv > 4)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1); lcv -= 1;
                }
            }
        }
    }
}