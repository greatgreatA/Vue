using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
     public class CompteLivret : Compte
    {
        private double taux;

        public double Taux { get => taux; set => taux = value; }

        public CompteLivret(int numC, int solde, int decouvert, int numClient,double taux, Client client):base(numC,solde,decouvert,numClient,client)
        { 
            this.taux = taux;
        }
        public CompteLivret(int numc, double taux)
        {
            this.NumClient = numc;
            this.Taux = taux;
        }

        public override string ToString()
        {
            return base.ToString() + " Taux : " + Taux + " ;";
        }
    }
}
