using System.Text;

namespace Lab4_Ex5_sin_x_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 enterForm = new Form2();
            if (enterForm.ShowDialog() != DialogResult.OK) return;
            
            label2.Text = "Левая граница: " + enterForm.a + " Правая граница: " + enterForm.b;

            StringBuilder sb = new StringBuilder();
            for (double i = enterForm.a; i <= enterForm.b; i = i + 0.1)
            {
                sb.Append(Math.Round(i, 2) + " : " + Math.Round(Math.Sin(i), 2) + "\n");
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}