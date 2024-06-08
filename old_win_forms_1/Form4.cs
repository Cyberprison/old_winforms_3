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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Нас обычно используют для комментариев";

            radioButton1.Text = "... для выбора одной";
            radioButton2.Checked = true;
            radioButton2.Text = "опций из нескольких";

            checkBox1.Text = "... для включений какой-то опции";
            checkBox1.Checked = true;

            textBox1.Text = "... для ввода и вывода данных";

            button1.Text = "... для запуска вычислений";
        }
    }
}
