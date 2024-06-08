using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace old_win_forms_1
{
    public partial class individualTask1 : Form
    {
        public individualTask1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(Math.Sqrt(10 - 18*Math.Cos(x)) - 6*Math.Cos(x)-Math.Exp(x));
        }
    }
}
