using System;

namespace WindowsFormsApp1.gestionSalaries
{
    public class Salaries
    {
        // INT Attribute
        int id;

        // String Attribute
        String nom;
        String prenom;
        String telephone_fixe;
        String telephone_portable;
        String email;

        // Object Attribute
        Object services;
        Object sites;

 

        // INT Accessor
        public int Id { get => id; set => id = value; }

        // String Accessor
        public String Nom { get => nom; set => nom = value; }
        public String Prenom { get => prenom; set => prenom = value; }
        public String Telephone_fixe { get => telephone_fixe; set => telephone_fixe = value; }
        public String Telephone_portable { get => telephone_portable; set => telephone_portable = value; }
        public String Email { get => email; set => email = value; }

        //Object Accessor 
        public Object Services { get => services; set => services = value; }
        public Object Sites { get => sites; set => sites = value; }

      

    }
}
