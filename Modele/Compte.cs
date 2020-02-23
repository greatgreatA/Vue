using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Compte
    {
        
        public int Numero { get => numero; set => numero = value; }
        public int Solde { get => solde; set => solde = value; }
        public int Decouvert { get => decouvert; set => decouvert = value; }
        public int NumClient { get => numClient; set => numClient = value; }
        public Client Monclient { get => monclient; set => monclient = value; }

        private Client monclient;
        private int numClient;
        private int decouvert=0;
        private int solde;
        private int numero;

        public Compte(int numero, int solde, int decouvert, int numClient,Client client)
        {
            this.numClient = numClient;
            this.decouvert = decouvert;
            this.solde = solde;
            this.numero = numero;
            this.Monclient = client;
            
        }

        public Compte() { }

        public void crediter(int montant)
        {
            Solde += montant;
        }

        public bool debiter(int montant)
        {
            if((Solde-montant)>=(-Decouvert))
            {
                Solde -= montant;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
                return this.GetType().Name + "\t"+Monclient.ToString()+"\tSolde: "+Solde+ "€ \tDecouvert : "+Decouvert+" €";
        }
    }

}
