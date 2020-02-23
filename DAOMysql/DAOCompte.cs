using System;
using System.Collections.Generic;
using System.Text;
using Modele;
using MySql.Data.MySqlClient;

namespace DAOMysql
{
    public class DAOCompte : BaseDao<Compte>
    {

        //constructeur
        public DAOCompte(string nomDeLaTable):base(nomDeLaTable)
        {
        }

        public List<Compte> selectAll()
        {

            string req = "select * from compte left join comptelivret on compte.numCompte = comptelivret.numCompte left join client on compte.numClient=client.numero;"; 
            List<Compte> liste = new List<Compte>();
            maconx.openCx();
            MySqlCommand cd = maconx.uneCommande(req);
            MySqlDataReader reader = cd.ExecuteReader();
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
                    compte=new CompteLivret(numcompte, solde, decouvert, numclient, taux, client);
                }
                else
                {
                    client = new Client(numclient, nom, prenom, adresse);
                    compte = new Compte(numcompte,solde, decouvert, numclient, client);
                        
                }
                liste.Add(compte);
            }
            reader.Close();
            maconx.closeCx();
            return liste;
        }

        public void update(Compte c)
        {
            string req = "UPDATE " + nomTable + " SET numCompte=" + c.Numero + " , solde=" + c.Solde + " , decouvert=" + c.Decouvert + " , numClient=" + c.NumClient + " WHERE numCompte="+c.Numero+" ;";
            maconx.openCx();
            MySqlCommand cd = maconx.uneCommande(req);
            int i = cd.ExecuteNonQuery();
            
            maconx.closeCx();
        }
    }
}
