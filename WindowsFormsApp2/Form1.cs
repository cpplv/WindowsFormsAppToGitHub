﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Yo yo yo!";
        }

        private void ps_btn_Click(object sender, EventArgs e)
        {
            ps_lbl.Text = "Howdy";
        }

        private void buttonbertule_Click(object sender, EventArgs e)
        {
            label1.Text = "Sveiks no Beatrises!";
        }
    }
}
