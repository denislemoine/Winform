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
    public partial class Form2 : Form
    {

        public delegate void DelegateBtn(string button);
        public event DelegateBtn ClickButton;
        public event DelegateBtn ClickRetirer;
        public event DelegateBtn ClickDecrocher;
        public event DelegateBtn ClicRacrocher;
        public event DelegateBtn ClickTicket;

        public Form2()
        {
            InitializeComponent();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClickButton != null)
            {
                ClickButton(((Button)sender).Text);
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ClickRetirer != null)
            {
                ClickRetirer(((Button)sender).Text);
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = true;
                button5.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ClickDecrocher != null)
            {
                ClickDecrocher(((Button)sender).Text);
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                button4.Enabled = false;
                button5.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ClicRacrocher != null)
            {
                ClicRacrocher(((Button)sender).Text);
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ClickTicket != null)
            {
                ClickTicket(((Button)sender).Text);
            }
        }
    }
}
