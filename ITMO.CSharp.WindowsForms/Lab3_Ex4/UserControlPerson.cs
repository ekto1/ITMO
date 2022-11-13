using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Ex4
{
    public partial class UserControlPerson : UserControl
    {
        public UserControlPerson()
        {
            InitializeComponent();
        }
        public List<Person> its = new List<Person>();

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                foreach (char c in textBox1.Text)
                {
                    if (char.IsDigit(c))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Поле не может содержать цифры");
                        break;
                    }
                }
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    int.Parse(textBox2.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле не может содержать буквы");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person(textBox1.Text, int.Parse(textBox2.Text));

            its.Add(p);

            textBox1.Text = textBox2.Text = "";
        }
    }
}
