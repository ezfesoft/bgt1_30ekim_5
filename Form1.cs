using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt1_30ekim_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {











            double f, c;
            f = Convert.ToDouble(textBox1.Text);
            c = (f - 32) / 1.8;
            textBox2.Text = c.ToString();   





















        }
    }
}
