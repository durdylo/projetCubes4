using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Exceptions;


namespace WindowsFormsApp1.gestionServices
{
    public class GestionServices
    {
        List<Services> liste_service = new List<Services>();
        private static int NombreSites;

        private SqlConnection connect;

        public GestionServices(SqlConnection cnx)
        {
            this.connect = cnx;
        }
        public int Ajouter(Services service)
        {
            if (service.Id != 0)

                throw new AjouterObjetExistantException("Vous essayez d'ajouter un objet déjà existant");
            else
            {
                service.Id = ++GestionServices.NombreSites;
                liste_service.Add(service);
            }
            return service.Id;
        }

        public void Supprimer(int Id)
        {
            Services service = this.SearchById(Id);
            liste_service.Remove(service);
        }

        public Services SearchById(int Id)
        {
            foreach (Services service in liste_service)
            {
                if (service.Id == Id)
                {
                    return service;
                }
            }
            return null;
        }

        public List<Services> GetSites()
        {
            return liste_service;
        }

        public void PrintServicesList()
        {
            Services services = new Services();

            for(int i = 0; i < services.ServiceName.Count(); i++)
            {
                Console.WriteLine(services.ServiceName);
            }
        }
    }
}
