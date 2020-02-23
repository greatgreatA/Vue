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
    public partial class FormModificationClient : Form
    {
        private Client monClient = null;
        private Manager monManager = null;
        private Form1 maform = null;

        public FormModificationClient(Client c,Manager m,Form1 form1)
        {
            InitializeComponent();
            monClient = c;
            monManager = m;
            maform = form1;

        }

        private void FormModificationClient_Load(object sender, EventArgs e)
        {
            this.textBoxNumeClient.Text = monClient.NumeroClient.ToString();
            this.textBoxNom.Text = monClient.NomClient.ToString();
            this.textBoxPrenom.Text = monClient.PrenomClient.ToString();
            this.textBoxAdresse.Text = monClient.Adresse.ToString();
        }

        private void bModifAnnulee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bModifValidee_Click(object sender, EventArgs e)
        {
             string adresse=this.textBoxAdresse.Text;
             string nom=this.textBoxNom.Text;
             string prenom=this.textBoxPrenom.Text;
            int numéro = this.monClient.NumeroClient;

            Client nouvClient = new Client(numéro, nom, prenom, adresse);

            try
            {
                this.monManager.modifierClient(nouvClient);
                this.maform.refresh();
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("La modification n'a pas pu être effectuée.");
                this.Close();
            }
        }
    }
}
