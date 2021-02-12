
namespace StatioAuto
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pavetTicket1 = new StatioAuto.pavetTicket();
            this.pavetNum1 = new StatioAuto.PavetNum();
            this.typeEssence1 = new StatioAuto.TypeEssence();
            this.drapeau1 = new StatioAuto.drapeau();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(48, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 96);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "EN SERVICE INSERER VOTRE CARTE JUSQU\'A LA BUTEE";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 158);
            this.textBox2.MaxLength = 4;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StatioAuto.Properties.Resources._200_d;
            this.pictureBox2.Location = new System.Drawing.Point(22, 193);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 233);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::StatioAuto.Properties.Resources.chargement;
            this.pictureBox1.Location = new System.Drawing.Point(71, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pavetTicket1
            // 
            this.pavetTicket1.BackColor = System.Drawing.Color.Black;
            this.pavetTicket1.Location = new System.Drawing.Point(62, 193);
            this.pavetTicket1.Name = "pavetTicket1";
            this.pavetTicket1.Size = new System.Drawing.Size(180, 126);
            this.pavetTicket1.TabIndex = 6;
            this.pavetTicket1.Visible = false;
            // 
            // pavetNum1
            // 
            this.pavetNum1.BackColor = System.Drawing.Color.Black;
            this.pavetNum1.Location = new System.Drawing.Point(73, 213);
            this.pavetNum1.Name = "pavetNum1";
            this.pavetNum1.Size = new System.Drawing.Size(184, 118);
            this.pavetNum1.TabIndex = 4;
            this.pavetNum1.Visible = false;
            // 
            // typeEssence1
            // 
            this.typeEssence1.BackColor = System.Drawing.Color.Black;
            this.typeEssence1.Location = new System.Drawing.Point(62, 193);
            this.typeEssence1.Name = "typeEssence1";
            this.typeEssence1.Size = new System.Drawing.Size(206, 150);
            this.typeEssence1.TabIndex = 2;
            this.typeEssence1.Visible = false;
            // 
            // drapeau1
            // 
            this.drapeau1.BackColor = System.Drawing.Color.Black;
            this.drapeau1.Location = new System.Drawing.Point(62, 39);
            this.drapeau1.Name = "drapeau1";
            this.drapeau1.Size = new System.Drawing.Size(201, 46);
            this.drapeau1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(332, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pavetTicket1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pavetNum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeEssence1);
            this.Controls.Add(this.drapeau1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Carburant";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private drapeau drapeau1;
        private TypeEssence typeEssence1;
        private System.Windows.Forms.Label label1;
        private PavetNum pavetNum1;
        private System.Windows.Forms.TextBox textBox2;
        private pavetTicket pavetTicket1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

