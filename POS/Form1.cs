﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void keypad1_ButtonPressed(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar;
            display1.SetDisplay(Convert.ToDecimal(textBox1.Text));

        }
    }
}
