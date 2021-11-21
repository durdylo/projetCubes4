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
        int city;
        DateTime DateCreate;
        DateTime DateModif;
        public int Id { get => id; set => id = value; }
        public string City { get => city; set => city = value; }
        public DateTime DateCreate1 { get => DateCreate; set => DateCreate = value; }
        public DateTime DateModif1 { get => DateModif; set => DateModif = value; }
    }
}
