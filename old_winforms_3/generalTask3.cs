﻿using System;
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
    public partial class generalTask3 : Form
    {
        public generalTask3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            out_txt.Text = "Hello, World!";
        }
    }
}
