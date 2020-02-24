using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele;


namespace DAOAccess
{
    public class DAOCompte
    {
        private string nomTable = "";
        private G_AccessConnexion maconx = null;
        
        public DAOCompte(string nomDeLaTable)
        {
            this.nomTable = nomDeLaTable;
            maconx = G_AccessConnexion.getInstance();
        }

        public List<Compte> selectAll()
        {

            string req = "select * from (compte left outer join comptelivret on compte.numCompte = comptelivret.numCompte ) left outer join client on compte.numClient=client.numero;";
            List<Compte> liste = new List<Compte>();
            maconx.openCx();
            OleDbCommand cd = maconx.commande(req);
            OleDbDataReader reader = cd.ExecuteReader();
            Compte compte = null;
            Client client = null;

            while (reader.Read())
            {

                int numcompte = reader.GetInt32(0);
                int solde = reader.GetInt32(1);
                int decouvert = reader.GetInt32(2);
                int numclient = reader.GetInt32(3);
                string nom = reader.GetString(7);
                string prenom = reader.GetString(8);
                string adresse = reader.GetString(9);

                if (!reader.IsDBNull(5))
                {
                    double taux = reader.GetDouble(5);
                    client = new Client(numclient, nom, prenom, adresse);
                    compte = new CompteLivret(numcompte, solde, decouvert, numclient, taux, client);
                }
                else
                {
                    client = new Client(numclient, nom, prenom, adresse);
                    compte = new Compte(numcompte, solde, decouvert, numclient, client);

                }
                liste.Add(compte);
            }
            reader.Close();
            maconx.closeCx();
            return liste;
        }

        public void update(Compte c)
        {
            string req = "UPDATE " + nomTable + " SET numCompte=" + c.Numero + " , solde=" + c.Solde + " , decouvert=" + c.Decouvert + " , numClient=" + c.NumClient + " WHERE numCompte=" + c.Numero + " ;";
            maconx.openCx();
            OleDbCommand cd = maconx.commande(req);
            int i = cd.ExecuteNonQuery();
            maconx.closeCx();
        }
    }
}
