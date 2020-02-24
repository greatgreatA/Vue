﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.OleDb;

namespace DAOmysql
{
    public class G_mysqlConnexion
    {
        private string server = "localhost";
        private string port = "3308";
        private string userId = "root";
        private string passwd = "";
        private string database = "gestioncomptes";
        private string connexionString="";

        private OleDbConnection conx = null;

        private static readonly object mylock = new object();

        private static G_mysqlConnexion instance=null;
        
        //Singleton de la classe G_mysqlConnexion
        public static G_mysqlConnexion getInstance()
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
                        instance = new G_mysqlConnexion();
                        return instance;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public void openCx()
        {
            try
            {
                this.conx.Open();
            }
            catch (OleDbException ex)
            {

                throw ex;
            }
        }

        public void closeCx()
        {
            try
            {
                this.conx.Close();
            }
            catch (OleDbException ex)
            {

                throw;
            }
        }

        public OleDbCommand uneCommande(string requete)
        {
            try
            {
                OleDbCommand c = new OleDbCommand(requete, conx);
                
                return c;
            }
            catch (OleDbException e)
            {
                throw e;
            }
        }
         public void commitCx()
        {
            conx.BeginTransaction();
            
        }


        //Constructeur privé qui initialise la chaine de connexion ainsi que la connexion elle-même
        private G_mysqlConnexion()
        {
            this.connexionString= "server="+this.server+";port="+this.port+";user id="+this.userId+";database="+this.database+";";
            try
            {
                conx = new OleDbConnection(this.connexionString);
            }
            catch (OleDbException ex)
            {

                throw ex;
            }
        }
       

    }
}
