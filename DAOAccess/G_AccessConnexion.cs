using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.OleDb;

namespace DAOAccess
{
    public class G_AccessConnexion
    {
        private static G_AccessConnexion instance = null;
        private string connexionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\GreatA\\Documents\\gestioncomptes.mdb";
        private OleDbConnection conx=null;

        private static readonly object mylock = new object();

        public static G_AccessConnexion getInstance()
        {
            {
                lock ((mylock))
                {
                    try
                    {
                        if (instance != null)
                        {
                            return instance;
                        }
                        else
                        {
                            instance = new G_AccessConnexion();
                            return instance;
                        }
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
        }

        public void openCx()
        {
            this.conx.Open();
        }

        public void closeCx()
        {
            this.conx.Close();
        }

        public OleDbCommand commande(string uneCommande)
        {
            OleDbCommand c = new OleDbCommand(uneCommande, this.conx);
            return c;
        }

        private G_AccessConnexion()
        {
            conx = new OleDbConnection(this.connexionString);
        }
    }
}
