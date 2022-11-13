using System.Text;

namespace Lab3_Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Person p in userControlPerson1.its)
            {
                sb.Append("\n" + p.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}