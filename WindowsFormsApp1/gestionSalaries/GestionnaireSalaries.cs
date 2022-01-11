using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.Exceptions;
using System.Data.SqlClient;

namespace WindowsFormsApp1.gestionSalaries
{
    public class GestionnaireSalaries
    {
        List<Salarie> liste_salaries = new List<Salarie>();
        private static int NombreSalaries;
        private SqlConnection connect;

        public GestionnaireSalaries(SqlConnection cnx)
        {
            this.connect = cnx;
        }
        public int Ajouter(Salarie salarie)
        {
            string cmdString = "INSERT INTO Salary (name, firstname, tel_fix, tel_port, email, id_service, id_site) VALUES (@name, @firstname, @telFix, @telPort, @email, @idService, @idSite)";
            using (SqlCommand comm = new SqlCommand(cmdString, this.connect))
            {
                this.connect.Open();
                comm.Parameters.AddWithValue("@name", salarie.Nom);
                comm.Parameters.AddWithValue("@firstname", salarie.Prenom);
                comm.Parameters.AddWithValue("@telFix", salarie.Telephone_fixe);
                comm.Parameters.AddWithValue("@telPort", salarie.Telephone_portable);
                comm.Parameters.AddWithValue("@email", salarie.Email);
                comm.Parameters.AddWithValue("@idService", salarie.IdService);
                comm.Parameters.AddWithValue("@IdSite", salarie.IdSite);
                int res = comm.ExecuteNonQuery();
                this.connect.Close();
                return res;
            }
        }

        public void Supprimer(int Id)
        {
            string cmdString = "DELETE FROM Salary WHERE Id = " + Id;
            if (Id == 0)
                throw new ModifierObjetInexistant("Vous essayez de suprimer un objet inexistant");
            using (SqlCommand comm = new SqlCommand(cmdString, this.connect))
            {
                this.connect.Open();
                int res = comm.ExecuteNonQuery();
                this.connect.Close();
            }
        }
        public List<Salarie> GetSalariesBySite(int idCity)
        {
            List<Salarie> salaries = new List<Salarie>();

            string cmdString = "SELECT Salary.*, Site.city as villeSite, Service.name as nomService from Salary LEFT JOIN Site on Site.id = Salary.id_site LEFT JOIN Service on Service.id = Salary.id_service WHERE Salary.id_site = " + idCity;
            this.connect.Open();
            SqlCommand cmd = new SqlCommand(cmdString, this.connect);

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows == true)
            {
                while (rdr.Read())
                {
                    Salarie salarie = new Salarie();
                    salarie.Id = (int)rdr["Id"];
                    salarie.Nom = (string)rdr["name"];
                    salarie.Prenom = (string)rdr["firstname"];
                    salarie.Telephone_fixe = (string)rdr["tel_fix"];
                    salarie.Telephone_portable = (string)rdr["tel_port"];
                    salarie.Email = (string)rdr["email"];
                    salarie.Service = (string)rdr["nomService"];
                    salarie.Site = (string)rdr["villeSite"];
                    salarie.IdService = (int)rdr["id_service"];
                    salarie.IdSite = (int)rdr["id_site"];
                    salaries.Add(salarie);
                }
            }
            rdr.Close();
            this.connect.Close();
            return salaries;
        }
        public List<Salarie> GetSalariesByName(String stringName)
        {
            List<Salarie> salaries = new List<Salarie>();

            string cmdString = "SELECT Salary.*, Site.city as villeSite, Service.name as nomService from Salary LEFT JOIN Site on Site.id = Salary.id_site LEFT JOIN Service on Service.id = Salary.id_service WHERE Salary.name LIKE '%" + stringName + "%' OR Salary.firstname LIKE '%" + stringName + "%' ";
            this.connect.Open();
            SqlCommand cmd = new SqlCommand(cmdString, this.connect);

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows == true)
            {
                while (rdr.Read())
                {
                    Salarie salarie = new Salarie();
                    salarie.Id = (int)rdr["Id"];
                    salarie.Nom = (string)rdr["name"];
                    salarie.Prenom = (string)rdr["firstname"];
                    salarie.Telephone_fixe = (string)rdr["tel_fix"];
                    salarie.Telephone_portable = (string)rdr["tel_port"];
                    salarie.Email = (string)rdr["email"];
                    salarie.Service = (string)rdr["nomService"];
                    salarie.Site = (string)rdr["villeSite"];
                    salarie.IdService = (int)rdr["id_service"];
                    salarie.IdSite = (int)rdr["id_site"];
                    salaries.Add(salarie);
                }
            }
            rdr.Close();
            this.connect.Close();
            return salaries;
        }
        public List<Salarie> GetSalariesByService(int idService)
        {
            List<Salarie> salaries = new List<Salarie>();

            string cmdString = "SELECT Salary.*, Site.city as villeSite, Service.name as nomService from Salary LEFT JOIN Site on Site.id = Salary.id_site LEFT JOIN Service on Service.id = Salary.id_service WHERE Salary.id_service = " + idService;
            this.connect.Open();
            SqlCommand cmd = new SqlCommand(cmdString, this.connect);

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows == true)
            {
                while (rdr.Read())
                {
                    Salarie salarie = new Salarie();
                    salarie.Id = (int)rdr["Id"];
                    salarie.Nom = (string)rdr["name"];
                    salarie.Prenom = (string)rdr["firstname"];
                    salarie.Telephone_fixe = (string)rdr["tel_fix"];
                    salarie.Telephone_portable = (string)rdr["tel_port"];
                    salarie.Email = (string)rdr["email"];
                    salarie.Service = (string)rdr["nomService"];
                    salarie.Site = (string)rdr["villeSite"];
                    salarie.IdService = (int)rdr["id_service"];
                    salarie.IdSite = (int)rdr["id_site"];
                    salaries.Add(salarie);
                }
            }
            rdr.Close();
            this.connect.Close();
            return salaries;
        }
        public List<Salarie> GetSalaries()
        {
            List<Salarie> salaries = new List<Salarie>();

            string cmdString = "SELECT Salary.*, Site.city as villeSite, Service.name as nomService from Salary LEFT JOIN Site on Site.id = Salary.id_site LEFT JOIN Service on Service.id = Salary.id_service";
            this.connect.Open();

            SqlCommand cmd = new SqlCommand(cmdString, this.connect);

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows == true)
            {
                while (rdr.Read())
                {
                    Salarie salarie = new Salarie();
                    salarie.Id = (int)rdr["Id"];
                    salarie.Nom = (string)rdr["name"];
                    salarie.Prenom = (string)rdr["firstname"];
                    salarie.Telephone_fixe = (string)rdr["tel_fix"];
                    salarie.Telephone_portable = (string)rdr["tel_port"];
                    salarie.Email = (string)rdr["email"];
                    salarie.Service = (string)rdr["nomService"];
                    salarie.Site = (string)rdr["villeSite"];
                    salarie.IdService = (int)rdr["id_service"];
                    salarie.IdSite = (int)rdr["id_site"];
                    salaries.Add(salarie);
                }
            }
            rdr.Close();
            this.connect.Close();
            return salaries;
        }
            public Salarie SearchById(int Id)
            {
            List<Salarie> salaries = this.GetSalaries();

            foreach (Salarie salarie in salaries)
            {
                if (salarie.Id == Id)
                {
                    return salarie;
                }
            }
            return null;
        }

        public Salarie Modifier(int idSalary, Salarie salarie)
        {

            string cmdString = "UPDATE Salary SET name ='" + salarie.Nom + "', firstname = '" + salarie.Prenom + "', tel_fix ='" + salarie.Telephone_fixe + "', tel_port = '" + salarie.Telephone_portable + "', email = '" + salarie.Email + "', id_service = " + salarie.IdService + ", id_site = " + salarie.IdSite + " WHERE Id =  " + idSalary;
            if (idSalary == 0)
                throw new ModifierObjetInexistant("Vous essayez de mofier un objet inexistant");
            using (SqlCommand comm = new SqlCommand(cmdString, this.connect))
            {
                this.connect.Open();
            
                int res = comm.ExecuteNonQuery();
                this.connect.Close();
            }
            Salarie s = this.SearchById(idSalary);
            return s;
        }
    }
}
