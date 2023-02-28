using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class QuadEquation : Form
    {
        public double x1, x2;
        public bool HasRoots = true;
        public QuadEquation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);

                double discriminant = Math.Pow(b, 2) - 4 * a * c;

                if (discriminant < 0)
                {
                    HasRoots = false;
                }
                else
                {
                    if (discriminant == 0)
                    {
                        x1 = -b / (2 * a);
                        x2 = x1;
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                        x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные значения");
            }
        }
    }
}
