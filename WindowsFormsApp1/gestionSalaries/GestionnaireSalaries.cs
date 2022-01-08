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
            Salarie salarie = this.SearchById(Id);
            liste_salaries.Remove(salarie);
        }

        public List<Salarie> GetSalaries()
        {
            List<Salarie> salaries = new List<Salarie>();

            string cmdString = "SELECT * from Salaries";
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
                    salarie.Telephone_fixe = (string)rdr["tel_fix"];
                    salarie.Telephone_portable = (string)rdr["tel_port"];
                    salarie.Email = (string)rdr["email"];
                    salaries.Add(salarie);
                }
            }
            rdr.Close();
            this.connect.Close();
            return salaries;
        }
            public Salarie SearchById(int Id)
        {
            foreach (Salarie salaries in liste_salaries)
            {
                if (salaries.Id == Id)
                {
                    return salaries;
                }
            }
            return null;
        }

        public void Modifier(Salarie salaries)
        {
            if (salaries.Id == 0)
                throw new ModifierObjetInexistant("Vous essayez de mofier un objet inexistant");
            Salarie s = this.SearchById(salaries.Id);
            liste_salaries.Insert(liste_salaries.IndexOf(s), salaries); // 
            Console.WriteLine("register");
        }
    }
}
