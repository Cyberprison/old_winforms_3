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
    public partial class individualTask2 : Form
    {
        private bool flagFormatComputing = false;

        public individualTask2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;

            textBox3.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            textBox3.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            flagFormatComputing = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result;

            label4.Visible = true;

            if (radioButton1.Checked == true)
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                result = 2 * Math.Cos(x - Math.PI / 6) / (0.5 + Math.Pow(Math.Sin(y), 2));

                if (flagFormatComputing == true)
                {
                    label4.Text = "Результат: a = " + String.Format("{0, 10:F3}", result);
                }
                else
                {
                    label4.Text = "Результат: a = " + result;
                }
            }
            else
            {
                double z = Convert.ToDouble(textBox3.Text);
                result = 1 + z*z/(3 + z*z/5);

                if (flagFormatComputing == true)
                {
                    label4.Text = "Результат: b = " + String.Format("{0, 10:F3}", result);
                }
                else
                {
                    label4.Text = "Результат: b = " + result;
                }
            }
        }
    }
}
