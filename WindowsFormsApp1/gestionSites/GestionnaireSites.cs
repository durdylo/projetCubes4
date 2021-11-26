using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Exceptions;

namespace WindowsFormsApp1.gestionSites
{
    public class GestionnaireSites
    {
        private SqlConnection connect;

        public GestionnaireSites(SqlConnection cnx)
        {
            this.connect = cnx;
        }

        static List<Site> liste_sites = new List<Site>() ;
        private static int NombreSites;


        public int Ajouter(Site site)
        {
            /*  if(site.Id != 0)

                  throw new AjouterObjetExistantException("Vous essayez d'ajouter un objet déjà existant");
              else
              {
                  site.Id = ++GestionnaireSites.NombreSites;
                  site.DateCreate1 = DateTime.Now;    

                  liste_sites.Add(site);
              }
              return site.Id;*/

            string cmdString = "INSERT INTO Site (City) VALUES (@val1)";
            using (SqlCommand comm = new SqlCommand(cmdString, this.connect))
            {
                this.connect.Open();
                comm.Parameters.AddWithValue("@val1", site.City);
                int res = comm.ExecuteNonQuery();
                this.connect.Close();
                return res;
            }
            
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
            /* s.Id = site.Id;
             s.City = site.City;
             s.DateModif1 = site.DateModif1;
             s.DateCreate1 = site.DateCreate1;*/
            // Methode 2
            site.DateCreate1 = DateTime.Now;
            liste_sites.Insert(liste_sites.IndexOf(s), site);
            Console.WriteLine("register");
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
        public List <String> GetSites()
        {
            List <String> sites = new List <String>();

            string cmdString = "SELECT * from Site";
            this.connect.Open();

            SqlCommand cmd = new SqlCommand(cmdString, this.connect);

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows == true)
            {
                while (rdr.Read())
                {
                    sites.Add(rdr["City"].ToString());
                }
            }
            rdr.Close();
            this.connect.Close();
            return sites;

        }

     

        public Site Start()
        {
            if(liste_sites.Count > 0)
                return liste_sites[0];
            else
                return null;
        }

        public Site End()
        {
            if (liste_sites.Count > 0)
                return liste_sites[liste_sites.Count - 1];
            else
                return null;
        }

        public Site Next(int id)
        {
            Site site = this.SearchById(id);
            int index = liste_sites.IndexOf(site);
            if ((liste_sites.Count - 1) >= (index + 1))
                return liste_sites[index + 1];
            else
                return null;
        }
        public Site Preced(int id)
        {
            Site site = this.SearchById(id);
            int index = liste_sites.IndexOf(site);
            if ((liste_sites.Count - 1) >= (index - 1))
                return liste_sites[index - 1];
            else
                return null;
        }

    }
}
