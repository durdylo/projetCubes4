using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.gestionSites
{
    public class Site
    {
        int id;
<<<<<<< HEAD
        String city;

        DateTime DateCreate;
        DateTime DateModif;
        public int Id { get => id; set => id = value; }
        public String City { get => city; set => city = value; }
=======
        string city;
        DateTime DateCreate;
        DateTime DateModif;
        public int Id { get => id; set => id = value; }
        public string City { get => city; set => city = value; }
>>>>>>> a89c970bb6f2fb999bda8841c5c5dc79ef856acd
        public DateTime DateCreate1 { get => DateCreate; set => DateCreate = value; }
        public DateTime DateModif1 { get => DateModif; set => DateModif = value; }
    }
}
