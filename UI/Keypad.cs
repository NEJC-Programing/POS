using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Keypad : UserControl
    {
        public Keypad()
        {
            InitializeComponent();
        }
    #region Events

        public event KeyPressEventHandler ButtonPressed;

        #endregion Events

 

        #region Methods

        public void RaiseButtonPressed(char WhatToSend)
        {
            KeyPressEventHandler handler = ButtonPressed;
            if (handler != null)

            {

                handler(this, new KeyPressEventArgs(WhatToSend));

            }
        }

        #endregion Methods

        private void btn7_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('7');
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('8');
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('9');
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonEner_Click(object sender, EventArgs e)
        {
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('6');
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('5');
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('4');
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('1');
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('2');
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('3');
        }

        private void button0_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('0');
        }

        private void button00_Click(object sender, EventArgs e)
        {
            
        }
    }
}
