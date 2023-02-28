using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlTask
{
    public partial class connect : Form
    {
        public string userName
        {
            get { return textBox1.Text; }

        }
        public string userPassword
        {
            get { return textBox2.Text; }
        }

        public connect()
        {
            InitializeComponent();
        }
    }
}
