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

        private static List<Site> liste_sites = new List<Site>() ;
        private static int NombreSites;


        public int Ajouter(Site site)
        {
         
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


        public void Supprimer(int idSite)
        {
            string cmdString = "DELETE FROM Site WHERE Id = " + idSite;
            if (idSite == 0)
                throw new ModifierObjetInexistant("Vous essayez de suprimer un objet inexistant");
            using (SqlCommand comm = new SqlCommand(cmdString, this.connect))
            {
                this.connect.Open();
                int res = comm.ExecuteNonQuery();
                this.connect.Close();
            }
        } 

        public Site Modifier(int idSite, string newName)
        {

            string cmdString = "UPDATE Site SET City = '"+newName+"' WHERE Id = " + idSite;
            if (idSite == 0)
                throw new ModifierObjetInexistant("Vous essayez de mofier un objet inexistant");
            using (SqlCommand comm = new SqlCommand(cmdString, this.connect))
            {
                this.connect.Open();
                int res = comm.ExecuteNonQuery();
                this.connect.Close();
            }
            Site s = this.SearchById(idSite);
            return s;
        }

        
        public Site SearchById(int id)
        {
            List<Site> sites = this.GetSites();

            foreach (Site site in sites)
            {
                if(site.Id == id)
                {
                    
                    return site;
                }
            }
            return null;
        }
        public List <Site> GetSites()
        {
            List <Site> sites = new List <Site>();

            string cmdString = "SELECT * from Site";
            this.connect.Open();

            SqlCommand cmd = new SqlCommand(cmdString, this.connect);

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows == true)
            {
                while (rdr.Read())
                {
                    Site site = new Site();
                    site.Id = (int)rdr["Id"];
                    site.City = rdr["City"].ToString();
                    sites.Add(site);
                }
            }
            rdr.Close();
            this.connect.Close();
            return sites;

        }

     

        public Site Start()
        {
            List<Site> sites = this.GetSites();
            if(sites.Count > 0)
                return sites[0];
            else
                return null;
        }

        public Site End()
        {
            List<Site> sites = this.GetSites();

            if (sites.Count > 0)
                return sites[sites.Count - 1];
            else
                return null;
        }

        public Site Next(int id)
        {
            List<Site> sites = this.GetSites();
            Site site = this.SearchById(id);
            int index = sites.IndexOf(site);
            Console.WriteLine(site);

            if ((sites.Count - 1) >= (index + 1))
            {
                Console.WriteLine("Jai trouvé");
                Console.WriteLine(sites[index + 1].Id.ToString());

                return sites[index + 1];
            }
              
            else
                return null;
        }
        public Site Preced(int id)
        {
            List<Site> sites = this.GetSites();

            Site site = this.SearchById(id);
            int index = sites.IndexOf(site);
            if ((sites.Count - 1) >= (index - 1))
                return sites[index - 1];
            else
                return null;
        }

    }
}
