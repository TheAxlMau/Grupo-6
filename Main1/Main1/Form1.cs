﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnCambiarTexto_Click(object sender, EventArgs e)
        {
            label1.Text = "uwu";
        }

        private void bttnCambiarTexto2_Click(object sender, EventArgs e)
        {
            label2.Text = "hola";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "hola";
        }
    }
}
