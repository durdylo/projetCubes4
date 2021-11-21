using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Exceptions;

namespace WindowsFormsApp1.gestionSites
{
    public class GestionSites
    {
        List <Site> liste_sites = new List<Site>() ;
        private static int NombreSites;
        public int Ajouter(Site site)
        {
            if(site.Id != 0)
           
                throw new AjouterObjetExistantException("Vous essayez d'ajouter un objet déjà existant");
            else
            {
                site.Id = ++GestionSites.NombreSites;
                liste_sites.Add(site);
            }
            return site.Id;
        }

        internal static void Ajouter()
        {
            throw new NotImplementedException();
        }

        public void Supprimer(int Id)
        {
            Site site = this.SearchById(Id);
            liste_sites.Remove(site);
        } 

        public void Modifier(Site site)
        {
            if (site.Id == 0)
                throw new ModifierObjetInexistant("Vous essayez de mofier un objet inexistant");
            Site s = this.SearchById(site.Id);
            //Methode 1
            s.Id = site.Id;
            s.City = site.City;
            s.DateModif1 = site.DateModif1;
            s.DateCreate1 = site.DateCreate1;
            // Methode 2
            //liste_sites.Insert(liste_sites.IndexOf(s), site);
        }

        /// <summary>
        /// Rechercher un site par son Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Site SearchById(int Id)
        {
            foreach (Site site in liste_sites)
            {
                if(site.Id == Id)
                {
                    return site;
                }
            }
            return null;
        }
        public List<Site> GetSites()
        {
            return liste_sites;
        }

    }
}
