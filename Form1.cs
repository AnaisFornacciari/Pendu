using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace pendu
{
    public partial class frmPendu : Form
    {
        public Random r = new Random();
        public string LeMot = "";
        public int ligneALire;
        public List<Label> mesLabels;
        public List<TextBox> mesTextBox;
        public string chemin = @"mots.txt";
        public string leMotATrouver;
        public string[] lesLignesDuFic;
        public int nbSaisie = 0;
        public int nbErreur = 0;
        public int nbBonneRep = 0;

        public frmPendu()
        {
            mesLabels = new List<Label>();
            mesTextBox = new List<TextBox>();
            InitializeComponent();
            
            //Appel de la méthode de MAJ_Lable
            MAJ_Labels();

            //Chargement du fichier texte dans un tableau
            lesLignesDuFic = System.IO.File.ReadAllLines(chemin);

        }


        private void btnNouvMot_Click(object sender, EventArgs e)
        {
            pictPendu.SendToBack();
            ligneALire = r.Next(1, 68875);
            leMotATrouver = lesLignesDuFic[ligneALire - 1];
            MAJ_TextBox(leMotATrouver);
        }

       

        private void t_TextChanged(object sender, EventArgs e)
        {
            if (nbErreur<7){
                TextBox t = (TextBox)sender;
                if(verifSaisie(t))
                {
                    if (nbBonneRep == leMotATrouver.Length)
                    {
                        MessageBox.Show("Bravo ! Vous avez trouvé le mot recherché.");
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous avez perdu ! Le mot à trouver était " + leMotATrouver.ToString() + ".");
                nbErreur = 0;
            }
        }

        /**********************Fonction de vérification du caractère saisie*****************************/
        private bool verifSaisie(TextBox laSaisie)
        {
            bool drapeau = false;
            int nb = (int)laSaisie.Tag;
           
            if(laSaisie.Text==leMotATrouver[nb].ToString())
            {
                laSaisie.Enabled = false;
                laSaisie.BackColor = Color.LightGreen;
                drapeau = true;
                nbBonneRep++;
                nbSaisie++;
            }
            else
            {
                if (laSaisie.Text!="")
                {
                    laSaisie.BackColor = Color.Red;
                    mesLabels[nbErreur].SendToBack();
                    nbErreur++;
                    nbSaisie++;
                    LettresF.Text += "     " + laSaisie.Text;
                }
            }
            return drapeau;
        }/*******************************************************************************************/

        private void MAJ_Labels()
        {
            mesLabels.Add(this.lbl1);
            mesLabels.Add(this.lbl2);
            mesLabels.Add(this.lbl3);
            mesLabels.Add(this.lbl4);
            mesLabels.Add(this.lbl5);
            mesLabels.Add(this.lbl6);
            mesLabels.Add(this.lbl7);
        }

        private void MAJ_TextBox(string leMot)
        {
            if (mesTextBox.Count > 0)
            {
                foreach (TextBox t in mesTextBox)
                {
                    Controls.Remove(t);
                }
                mesTextBox.Clear();
            }

            /*-----------------Positionnement des zones de textes pour chaque lettre du mot--------*/
            int pointDepart = 400;
            int decalage = 0;
            int i;
            
            
            for (i = 0; i < leMotATrouver.Length; i++)
            {
                TextBox t = new TextBox();
                t.TextChanged += new System.EventHandler(t_TextChanged);
                t.Location = new System.Drawing.Point(pointDepart + decalage, 123);
                t.MinimumSize = new System.Drawing.Size(40, 40);
                t.Size = new System.Drawing.Size(40, 40);
                t.BackColor = Color.LavenderBlush;
                t.Text = "";
                t.Enabled = true;
                t.Font = new Font("Palatino Linotype", 20.0f);

                t.Tag = i;
                decalage = decalage + 40;
                mesTextBox.Add(t);
                this.Controls.Add(mesTextBox[i]);
            }
        }
    }
}