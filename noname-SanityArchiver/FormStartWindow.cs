﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noname_SanityArchiver
{
    public partial class FormStartWindow : Form
    {
        public FormStartWindow()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formMain = new FormMain();
            formMain.FormClosed += (s, args) => Close();
            formMain.Show();
            Hide();
        }
    }
}
