using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatioAuto
{
    public partial class PavetNum : UserControl
    {

        public delegate void DelegateBtn(string button);
        public event DelegateBtn ClickAnnul;
        public event DelegateBtn Clickbutton;
        public event DelegateBtn ClickCorrection;
        public event DelegateBtn ClickValider;
        public PavetNum()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Clickbutton != null)
            {
                Clickbutton(((Button)sender).Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Clickbutton != null)
            {
                Clickbutton(((Button)sender).Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Clickbutton != null)
            {
                Clickbutton(((Button)sender).Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Clickbutton != null)
            {
                Clickbutton(((Button)sender).Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Clickbutton != null)
            {
                Clickbutton(((Button)sender).Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Clickbutton != null)
            {
                Clickbutton(((Button)sender).Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Clickbutton != null)
            {
                Clickbutton(((Button)sender).Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clickbutton != null)
            {
                Clickbutton(((Button)sender).Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Clickbutton != null)
            {
                Clickbutton(((Button)sender).Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Clickbutton != null)
            {
                Clickbutton(((Button)sender).Text);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (ClickValider != null)
            {
                ClickValider(((Button)sender).Text);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (ClickCorrection != null)
            {
                ClickCorrection(((Button)sender).Text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ClickAnnul != null)
            {
                ClickAnnul(((Button)sender).Text);
            }
        }
    }
}
