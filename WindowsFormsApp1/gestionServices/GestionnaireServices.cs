using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Exceptions;


namespace WindowsFormsApp1.gestionServices
{
    public class GestionnaireServices
    {
        List<Service> liste_service = new List<Service>();
        private static int NombreSites;

        private SqlConnection connect;

        public GestionnaireServices(SqlConnection cnx)
        {
            this.connect = cnx;
        }
        public int Ajouter(Service service)
        {
            string cmdString = "INSERT INTO Service (Name) VALUES (@val1)";
            using (SqlCommand comm = new SqlCommand(cmdString, this.connect))
            {
                this.connect.Open();
                comm.Parameters.AddWithValue("@val1", service.ServiceName);
                int res = comm.ExecuteNonQuery();
                this.connect.Close();
                return res;
            }
        }
        public Service Modifier(int idService, string newName)
        {

            string cmdString = "UPDATE Service SET Name = '" + newName + "' WHERE Id = " + idService;
            if (idService == 0)
                throw new ModifierObjetInexistant("Vous essayez de mofier un objet inexistant");
            using (SqlCommand comm = new SqlCommand(cmdString, this.connect))
            {
                this.connect.Open();
                int res = comm.ExecuteNonQuery();
                this.connect.Close();
            }
            Service s = this.SearchById(idService);
            return s;
        }
        public void Supprimer(int idService)
        {
            string cmdString = "DELETE FROM Service WHERE Id = " + idService;
            if (idService == 0)
                throw new ModifierObjetInexistant("Vous essayez de suprimer un objet inexistant");
            using (SqlCommand comm = new SqlCommand(cmdString, this.connect))
            {
                this.connect.Open();
                int res = comm.ExecuteNonQuery();
                this.connect.Close();
            }
        }

        public Service SearchById(int Id)
        {
            foreach (Service service in liste_service)
            {
                if (service.Id == Id)
                {
                    return service;
                }
            }
            return null;
        }

        public List<Service> GetServices()
        {
            List<Service> services = new List<Service>();

            string cmdString = "SELECT * from Service";
            this.connect.Open();

            SqlCommand cmd = new SqlCommand(cmdString, this.connect);

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows == true)
            {
                while (rdr.Read())
                {
                    Service service = new Service();
                    service.Id = (int)rdr["Id"];
                    service.ServiceName = (string)rdr["Name"];
                    services.Add(service);
                }
            }
            rdr.Close();
            this.connect.Close();
            return services;
        }

        public void PrintServicesList()
        {
            Service services = new Service();

            for(int i = 0; i < services.ServiceName.Count(); i++)
            {
                Console.WriteLine(services.ServiceName);
            }
        }
    }
}
