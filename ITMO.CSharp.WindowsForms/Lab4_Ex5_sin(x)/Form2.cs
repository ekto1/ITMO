using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Ex5_sin_x_
{
    public partial class Form2 : Form
    {
        public double a = 0;
        public double b = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonSent_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            
        }
    }
}
