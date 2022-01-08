using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.Exceptions;
using System.Data.SqlClient;

namespace WindowsFormsApp1.gestionSalaries
{
    public class GestionnaireSalaries
    {
        List<Salaries> liste_salaries = new List<Salaries>();
        private static int NombreSalaries;
        private SqlConnection connect;

        public GestionnaireSalaries(SqlConnection cnx)
        {
            this.connect = cnx;
        }
        public int Ajouter(Salaries salaries)
        {
            if (salaries.Id != 0)

                throw new AjouterObjetExistantException("Vous essayez d'ajouter un objet déjà existant");
            else
            {
                salaries.Id = ++GestionnaireSalaries.NombreSalaries;
                liste_salaries.Add(salaries);
            }
            return salaries.Id;
        }

        public void Supprimer(int Id)
        {
            Salaries salaries = this.SearchById(Id);
            liste_salaries.Remove(salaries);
        }

        public List<Salaries> GetSalaries()
        {
            List<Salaries> services = new List<Salaries>();

            string cmdString = "SELECT * from Salaries";
            this.connect.Open();

            SqlCommand cmd = new SqlCommand(cmdString, this.connect);

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows == true)
            {
                while (rdr.Read())
                {
                    Salaries salaries = new Salaries();
                    salaries.Id = (int)rdr["Id"];
                    salaries.Nom = (string)rdr["name"];
                    salaries.Telephone_fixe = (string)rdr["tel_fix"];
                    salaries.Telephone_portable = (string)rdr["tel_port"];
                    salaries.Email = (string)rdr["email"];
                    services.Add(salaries);
                }
            }
            rdr.Close();
            this.connect.Close();
            return services;
        }
            public Salaries SearchById(int Id)
        {
            foreach (Salaries salaries in liste_salaries)
            {
                if (salaries.Id == Id)
                {
                    return salaries;
                }
            }
            return null;
        }

        public void Modifier(Salaries salaries)
        {
            if (salaries.Id == 0)
                throw new ModifierObjetInexistant("Vous essayez de mofier un objet inexistant");
            Salaries s = this.SearchById(salaries.Id);
            salaries.DateCreate1 = DateTime.Now;
            liste_salaries.Insert(liste_salaries.IndexOf(s), salaries); // 
            Console.WriteLine("register");
        }

        public Salaries Start()
        {
            if (liste_salaries.Count > 0)
                return liste_salaries[0];
            else
                return null;
        }

        public Salaries End()
        {
            if (liste_salaries.Count > 0)
                return liste_salaries[liste_salaries.Count - 1];
            else
                return null;
        }

        public Salaries Next(int id)
        {
            Salaries site = this.SearchById(id);
            int index = liste_salaries.IndexOf(site);
            if ((liste_salaries.Count - 1) >= (index + 1))
                return liste_salaries[index + 1];
            else
                return null;
        }
        public Salaries Preced(int id)
        {
            Salaries site = this.SearchById(id);
            int index = liste_salaries.IndexOf(site);
            if ((liste_salaries.Count - 1) >= (index - 1))
                return liste_salaries[index - 1];
            else
                return null;
        }

        public void PrintListSalaries(List<Salaries> sal)
        {
            int i;

            for (i = 0; i < sal.Count(); i++)
            {
                Console.WriteLine(sal[i].Nom);
                Console.WriteLine(i);
            }
        }
    }
}
