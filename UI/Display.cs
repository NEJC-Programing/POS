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
    public partial class Display : UserControl
    {
        public Display()
        {
            InitializeComponent();
        }
        public virtual void SetDisplay(string TheText)
        {
            textBox1.Text = TheText;
        }
        public virtual void SetDisplay(decimal TheAmount)
        {
            string temp = string.Format("{0:C}", TheAmount);
            SetDisplay(temp);

        }

    }
}
