using Modele;
using System;
using System.Collections.Generic;
using DAOMysql;
namespace Controleur
{
    public class Manager
    {
        /******Liste de tous les objets à gerer ***/
        private List<Compte> listeComptes = new List<Compte>();
        private List<Client> listeClients = new List<Client>();
     
        
        public List<Compte> ListeComptes { get => listeComptes; set => listeComptes = value; }
        public List<Client> ListeClients { get => listeClients; set => listeClients = value; }
        
        

        /********Initialise toutes les classes DAO qui sont utiles********/

        DAOCompte compteDao = new DAOCompte("compte");
        DAOClient clientDao = new DAOClient("client");
        DAOCompteLivret compteLivretDao = new DAOCompteLivret ("compteLivret");

        public Manager()
        {
            ListeComptes = compteDao.selectAll();
            ListeClients = clientDao.selectAll();         
        }


        public void crediter(Compte cp,int montant)
        {
            try
            {
                cp.crediter(montant);
                updateCompte(cp);
                ListeComptes = compteDao.selectAll();
            }
            catch (Exception ex)
            {
                throw ex;//new Exception("Le montant doit être positif.");
            }
        }

        public void debiter( Compte cp, int montant)
        {
            if(!cp.debiter(montant))
            {
                throw (new Exception("Le compte ne peut pas être débité. Le découvert autorisé est de : "+cp.Decouvert+"€.")); ;
            }
            else
            {
                updateCompte(cp);
                ListeComptes = compteDao.selectAll();
            }
        }

        public void modifierDecouvert(Compte cp , int niveauDecouvert)
        {

            if (niveauDecouvert >= 0 && niveauDecouvert < 10000)
            {
                cp.Decouvert = niveauDecouvert;
                updateCompte(cp);
                ListeComptes = compteDao.selectAll();
            }
            else
                throw new Exception("Le montant du découvert doit être positif et inférieur à 10 000€. Transaction impossible.");
        }

        public void modifierClient(Client client)
        {
            try
            {
                clientDao.update(client);
                refresh();
            }
            catch (Exception)
            {

                throw new Exception(" From Manager :la mise à jour n'a pas été effectuée...");
            }
        }

        public void refresh()
        {
            ListeComptes = compteDao.selectAll();
            ListeClients = clientDao.selectAll();
        }

        public void updateCompte(Compte cpt)
        {
            if(!cpt.GetType().Name.Equals("Compte"))
            {
                compteLivretDao.update((CompteLivret)cpt);
            }
            else
            {
                compteDao.update(cpt);
            }
        }


    }
}
