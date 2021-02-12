using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace StatioAuto
{
    public partial class Form1 : Form
    {

        private string typeFuel = "";
        private string typeTicket = "";
        private string payer = "";
        private bool annulation = false;
        private string montant = "";
        Form2 f = new Form2();

        public Form1()
        {
            InitializeComponent();

            f.ClickButton += F_ClickButton;
            f.ClickRetirer += F_ClickRetirer;
            f.ClickDecrocher += F_ClickDecrocher;
            f.ClicRacrocher += F_ClicRacrocher;
            f.ClickTicket += F_ClickTicket;

            f.Show();

            typeEssence1.Clickbutton += TypeEssence1_Clickbutton;
            typeEssence1.ClickAnnul += TypeEssence1_ClickAnnul;
            

            pavetNum1.Clickbutton += PavetNum1_Clickbutton;
            pavetNum1.ClickAnnul += PavetNum1_ClickAnnul;
            pavetNum1.ClickCorrection += PavetNum1_ClickCorrection;
            pavetNum1.ClickValider += PavetNum1_ClickValider;

            pavetTicket1.ClickBouton += PavetTicket1_ClickBouton;    



        }

        private void F_ClickTicket(string button)
        {
            textBox1.Text = "NOUS VOUS REMERCIONS DE VOTRE VISITE ";
            pictureBox2.Visible = true;
        }

        private void F_ClicRacrocher(string button)
        {
            pictureBox1.Visible = false;
            montant = " Montant 54.35€";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Text = "DEBIT EN COURS " + montant ;
            textBox2.Visible = false;
            textBox1.Update();
            Thread.Sleep(2000);
            textBox1.Text = "MERCI D'ATTENDRE LA FIN D'IMPRESSION DE VOTRE" + typeTicket;
            textBox1.Update();
            Thread.Sleep(2000);
            textBox1.Text = "NOUS VOUS INVITONS A RETIRER VOTRE " + typeTicket + " " + montant;
        }

        private void F_ClickDecrocher(string button)
        {
            pictureBox1.Visible = true;
            textBox1.Text = "DEBIT EN COURS";
        }

        private void F_ClickRetirer(string button)
        {
            if (annulation == true) 
            {
                textBox1.Text = "MERCI DE VOTRE VISITE";
                Application.Exit();
            }
            else
            {
            label1.Visible = false;
            textBox1.Text = "Veuillez décrochez le pistolet";
            textBox2.Visible = true;
            textBox2.UseSystemPasswordChar = false;
            textBox2.Text = typeFuel;
            pavetTicket1.Visible = false;
            };
            
        }

        private void F_ClickButton(string button)
        {
            textBox1.Text = "PATIENTEZ";
            textBox1.Update();
            Thread.Sleep(2000);
            typeEssence1.Visible = true;
            textBox1.Text = "SELECTIONNER UN CARBURANT ";
        }

        private void PavetTicket1_ClickBouton(string button)

        {
            typeTicket = button;
            textBox1.Text = "ALLEZ VOUS SERVIR PAIEMENT COMPTANT MAX 150 € , retirer votre carte";
           
        }


        private void PavetNum1_ClickCorrection(string button)
        {
            if (textBox2.Text != null)
            {
                if (textBox2.Text.Length - 1 >= 0)
                {
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                }
            }
            else
            {
                textBox2.Text += button;
            }
        }

        private void PavetNum1_ClickValider(string button)
        {
            textBox2.Visible = false;
            payer = "ok";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Text = "CODE BON";
            textBox1.Update();
            Thread.Sleep(2000);
            label1.BackColor = Color.Green;
            label1.ForeColor = Color.Black;
            label1.Text = "Paiement Accepté";
            textBox1.Text = "Voulez vous un ticket";
            pavetTicket1.Visible = true;
            pavetNum1.Visible = false;
          
        }

        private void PavetNum1_ClickAnnul(string button)
        {
       
                textBox1.Text = "MERCI DE VOTRE VISITE";
                textBox1.Update();
                textBox1.Text = "Operation annuler, Veuillez reprendre votre carte";
                label1.Visible = false;
                pavetNum1.Visible = false;
                textBox2.Visible = false;
                annulation = true;

        }

        private void PavetNum1_Clickbutton(string button)
        {
            
            if(textBox2.Text == null)
            {
                textBox2.Text = button;
                textBox2.UseSystemPasswordChar = true;
                textBox2.MaxLength = 4;
            }
            else
            {
                textBox2.Text += button;
                textBox2.UseSystemPasswordChar = true;
            }
            
        }

        private void TypeEssence1_ClickAnnul(string button)
        {
            typeEssence1.Visible = false;
            pavetNum1.Visible = false;
            textBox1.Text = "Opération annulé, veuillez reprendre votre carte";
            annulation = true;
        }

        private void TypeEssence1_Clickbutton(string button)
        {
            typeFuel = button;
            label1.Text = button;
            label1.Visible = true;
            pavetNum1.Visible = true;
            typeEssence1.Visible = false;
            textBox1.Text = "Veuillez saisir votre code";
            textBox2.Visible = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
