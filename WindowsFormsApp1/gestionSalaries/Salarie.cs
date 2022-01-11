using System;

namespace WindowsFormsApp1.gestionSalaries
{
    public class Salarie
    {
        // INT Attribute
        int id;

        // String Attribute
        String nom;
        String prenom;
        String telephone_fixe;
        String telephone_portable;
        String email; 
        String service;
        String site;
        // Object Attribute
        int idService;
        int idSite;



        // INT Accessor
        public int Id { get => id; set => id = value; }
        public int IdService { get => idService; set => idService = value; }
        public int IdSite { get => idSite; set => idSite = value; }

        // String Accessor
        public String Nom { get => nom; set => nom = value; }
        public String Prenom { get => prenom; set => prenom = value; }
        public String Telephone_fixe { get => telephone_fixe; set => telephone_fixe = value; }
        public String Telephone_portable { get => telephone_portable; set => telephone_portable = value; }
        public String Email { get => email; set => email = value; }
        public string Service { get => service; set => service = value; }
        public string Site { get => site; set => site = value; }
    }
}
