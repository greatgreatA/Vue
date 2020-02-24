using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Modele;


namespace DAOMysql

{
    public class DAOCompteLivret : BaseDao<CompteLivret>
    {
        //constructeur
        public DAOCompteLivret(string nomDeLaTable) : base(nomDeLaTable)
        {
        }

        public List<CompteLivret> selectAll()
        {

            string req = "select * from comptelivret left join compte on compte.numCompte = comptelivret.numCompte left join client on compte.numClient=client.numero;";
            List<CompteLivret> liste = new List<CompteLivret>();
            maconx.openCx();
            MySqlCommand cd = maconx.commande(req);
            MySqlDataReader reader = cd.ExecuteReader();
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
            MySqlCommand cd = maconx.commande(req);
            cd.ExecuteNonQuery();
            maconx.closeCx();

            maconx.openCx();
            MySqlCommand cd2 = maconx.commande(req2);
            cd2.ExecuteNonQuery();
            maconx.closeCx();
        }
    }
}
