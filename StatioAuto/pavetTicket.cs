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

   
    public partial class pavetTicket : UserControl
    {

        public delegate void DelegateBtn(string button);
        public event DelegateBtn ClickAnnul;
        public event DelegateBtn ClickBouton;

        public pavetTicket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClickBouton != null)
            {
                ClickBouton(((Button)sender).Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ClickBouton != null)
            {
                ClickBouton(((Button)sender).Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ClickBouton != null)
            {
                ClickBouton(((Button)sender).Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ClickAnnul != null)
            {
                ClickAnnul(((Button)sender).Text);
            }
        }
    }
}
