using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele;

namespace DAOAccess
{
    public class DAOCompteLivret 
    {
        private string nomTable = "";
        private G_AccessConnexion maconx = null;

        public DAOCompteLivret(string nomDeLaTable)
        {
            this.nomTable = nomDeLaTable;
            maconx = G_AccessConnexion.getInstance();
        }

        public List<CompteLivret> selectAll()
        {

            string req = "select * from (comptelivret left outer join compte on compte.numCompte = comptelivret.numCompte) left outer join client on compte.numClient=client.numero;";
            List<CompteLivret> liste = new List<CompteLivret>();
            maconx.openCx();
            OleDbCommand cd = maconx.commande(req);
            OleDbDataReader reader = cd.ExecuteReader();
            CompteLivret comptelivret = null;
            Client c = null;
            while (reader.Read())
            {

                int numcompte = reader.GetInt32(0);
                double taux = reader.GetDouble(1);
                int solde = reader.GetInt32(3);
                int decouvert = reader.GetInt32(4);
                int numclient = reader.GetInt32(5);
                string nom = reader.GetString(7);
                string prenom = reader.GetString(8);
                string adresse = reader.GetString(9);


                c = new Client(numclient, nom, prenom, adresse);
                comptelivret = new CompteLivret(numcompte,solde, decouvert, numclient,taux, c);
                liste.Add(comptelivret);
            }
            reader.Close();
            maconx.closeCx();
            return liste;
        }



        public  void update(CompteLivret cl)
        {
            string req = "UPDATE compte SET numCompte=" + cl.Numero + " , solde=" + cl.Solde + " , decouvert=" + cl.Decouvert + " , numClient=" + cl.NumClient + " WHERE numCompte=" + cl.Numero + " ;";

            string req2 = "UPDATE compteLivret SET tauxInteret="+ cl.Taux.ToString(System.Globalization.CultureInfo.InvariantCulture) + "  WHERE numCompte=" + cl.Numero + " ;";
            
            maconx.openCx();
            OleDbCommand cd = maconx.commande(req);
            cd.ExecuteNonQuery();
            maconx.closeCx();

            maconx.openCx();
            OleDbCommand cd2 = maconx.commande(req2);
            cd2.ExecuteNonQuery();
            maconx.closeCx();
        }
    }
}
