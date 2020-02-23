using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controleur;
using Modele;

namespace Vue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mgr = new Manager();
        }

        private  Manager mgr = null;
        private int choix = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

            refresh();

        }

        public void refresh()
        {
            this.listBox1.Items.Clear();
            this.tMontant.Clear();

            foreach (Compte cp in mgr.ListeComptes)
            {
                this.listBox1.Items.Add(cp);
            }
            if(this.listBox1.Items.Count > 0) { this.listBox1.SetSelected(0,true); }
           
        }

        private void créditerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
          
            if(this.tMontant.Text.Length==0)
            {
                MessageBox.Show("Veuillez indiquer un montant à créditer sur le compte avant de valider.");
                choix = 1;
            }
            else
            {
                choix = 1;
            }

        }

        private void débiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.tMontant.Text.Length == 0)
            {
                MessageBox.Show("Veuillez indiquer un montant à débiter sur le compte avant de valider.");
                choix = 2;
            }
            else
            {
                choix = 2;
            }
        }

        private void tMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            { MessageBox.Show("Veuillez indiquer un nombre entier positif! Merci.");
                e.Handled = true;
            }
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            
            switch (choix)
            {
                
                case 1:
                    // crediter
                     result= MessageBox.Show("Vous souhaitez créditer le compte de  Monsieur " + ((Compte)this.listBox1.SelectedItem).Monclient.NomClient + " d'un montant de " + this.tMontant.Text + " € ?"," Confirmation",MessageBoxButtons.OKCancel );
                    if(result==DialogResult.OK)
                    {
                        try
                        {
                            mgr.crediter(((Compte)this.listBox1.SelectedItem), Convert.ToInt32(this.tMontant.Text));
                            
                            refresh();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        
                    }
                    else
                    {
                        this.tMontant.Clear();
                        this.lMessage.Text = "Transaction Annulée...";
                        
                    }
                    this.choix = 0;
                    break;
                case 2:
                    //debiter
                    result = MessageBox.Show("Vous souhaitez débiter le compte de  Monsieur " + ((Compte)this.listBox1.SelectedItem).Monclient.NomClient + " d'un montant de " + this.tMontant.Text + " € ?", " Confirmation", MessageBoxButtons.OKCancel);
                    
                    if (result==DialogResult.OK)
                    {
                        try
                        {
                            mgr.debiter((Compte)this.listBox1.SelectedItem, Convert.ToInt32(this.tMontant.Text));
                            refresh();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            refresh();
                        }
                    }
                    else
                    {
                        this.tMontant.Clear();
                        this.lMessage.Text = "Transaction Annulée...";
                    }

                    this.choix = 0;
                    break;
                case 3:
                    //decouvert
                    result = MessageBox.Show("Vous souhaitez Modifier le ," +
                        "niveau du découvert  autorisé du compte de  Monsieur " + ((Compte)this.listBox1.SelectedItem).Monclient.NomClient + " pour un nouveau niveau de :  " + this.tMontant.Text + " € ?", " Confirmation", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            mgr.modifierDecouvert((Compte)this.listBox1.SelectedItem, Convert.ToInt32(this.tMontant.Text));
                            refresh();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            refresh();
                        }
                    }
                    else
                    {
                        this.tMontant.Clear();
                        this.lMessage.Text = "Transaction Annulée...";
                    }

                    this.choix = 0;
                    break;
                default:
                    MessageBox.Show("Votre choix n'a pas été compris. Veuillez sélectionner un compte et effectuer une opération ou une modification. Merci de réessayer.");
                    this.choix = 0;

                    break;

            }
        }

        private void découvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.tMontant.Text.Length == 0)
            {
                MessageBox.Show("Veuillez indiquer un montant du découvert à autoriser sur le compte avant de valider.");
                choix = 3;
            }
            else
            {
                choix = 3;
            }
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client c = ((Compte)this.listBox1.SelectedItem).Monclient;
            
            FormModificationClient f = new FormModificationClient(c,mgr,this);
            f.Activate();
            f.Show();   
        }

        private void oRMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
