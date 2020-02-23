using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Client
    {
        private int numeroClient;

        public int NumeroClient { get => numeroClient; set => numeroClient = value; }
        public  string NomClient { get => nomClient; set => nomClient = value; }
        public  string PrenomClient { get => prenomClient; set => prenomClient = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public List<Compte> Mescomptes { get => mescomptes; set => mescomptes = value; }

        private List<Compte> mescomptes;
        private string nomClient;
        private string prenomClient;
        private string adresse;

        public Client() { }

        public Client(int numeroClient, string nomClient, string prenomClient, string adresse)
        {
            NumeroClient = numeroClient;
            NomClient = nomClient;
            PrenomClient = prenomClient;
            Adresse = adresse;
        }

        public override string ToString()
        {
            return NumeroClient+"\t"+NomClient+ "\t"+ PrenomClient + "\t"+ Adresse+"\t" ;
        }
    }
}
