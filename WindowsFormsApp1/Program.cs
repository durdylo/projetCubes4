using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.gestionSites;
using static WindowsFormsApp1.gestionSites.GestionnaireSites;
using static WindowsFormsApp1.gestionSites.Site;
using static WindowsFormsApp1.gestionServices.GestionServices;
using static WindowsFormsApp1.gestionServices.Services;



namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Site site = new Site();
            GestionnaireSites gestionSite = new GestionnaireSites();
            
            site.City = "Paris";
            Application.EnableVisualStyles();
            gestionSite.Ajouter(site);
            Console.WriteLine("dcdscsdcsdcscscscsdcscscdsc");
            Console.WriteLine(gestionSite.GetSites());

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormApplication());
        }
    }
}