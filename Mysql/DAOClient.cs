using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Text;
using Modele;

namespace DAOMysql
{
    public class DAOClient : BaseDao<Client>
    {
        //constructeur
        public DAOClient(string nomDeLaTable) : base(nomDeLaTable)
        {

        }

        public List<Client> selectAll()
        {
            string req = "SELECT * FROM " + nomTable + " ;";
            List<Client> liste = new List<Client>();
            maconx.openCx();
            MySqlCommand cd = maconx.commande(req);
            MySqlDataReader reader = cd.ExecuteReader();
            Client client = null;
            while (reader.Read())
            {

                int numc = reader.GetInt32(0);
                string nom = reader.GetString(1);
                string prenom = reader.GetString(2);
                string adresse = reader.GetString(3);
                

                client = new Client(numc, nom, prenom, adresse);
                liste.Add(client);
            }
            reader.Close();
            maconx.closeCx();
            return liste;
        }

        public void update(Client c)
        {
            string req = "UPDATE " + nomTable + " SET numero=" + c.NumeroClient + ", nom=\"" + c.NomClient + "\", prenom= \"" + c.PrenomClient + "\",adresse=\"" + c.Adresse + "\" WHERE numero=" + c.NumeroClient + ";";
            maconx.openCx();
            MySqlCommand cd = maconx.commande(req);
            int i =cd.ExecuteNonQuery();
            maconx.closeCx();
        }

    }
}
