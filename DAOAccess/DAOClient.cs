using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele;

namespace DAOAccess
{
    public class DAOClient 
    {
        private string nomTable = "";
        private G_AccessConnexion maconx = null;

        public DAOClient(string nomDeLaTable)
        {
            this.nomTable = nomDeLaTable;
            maconx = G_AccessConnexion.getInstance();
        }

        public List<Client> selectAll()
        {
            string req = "SELECT * FROM " + nomTable + " ;";
            List<Client> liste = new List<Client>();
            maconx.openCx();
            OleDbCommand cd = maconx.commande(req);
            OleDbDataReader reader = cd.ExecuteReader();
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
            OleDbCommand cd = maconx.commande(req);
            int i =cd.ExecuteNonQuery();
            maconx.closeCx();
        }

    }
}
