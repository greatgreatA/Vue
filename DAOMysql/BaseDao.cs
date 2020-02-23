using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace DAOMysql
{
    public class BaseDao<T>
    {
        protected G_mysqlConnexion maconx = G_mysqlConnexion.getInstance();
        protected string nomTable;
      

        public BaseDao(string name)
        {
            this.nomTable = name;
        }
   
        public void delete(int id)
        {
            string req = "DELETE FROM "+nomTable+" WHERE id="+id+";";
            maconx.openCx();
            MySqlCommand cd = maconx.uneCommande(req);
            cd.ExecuteNonQuery();
            maconx.closeCx();
        }
       

    }
}
