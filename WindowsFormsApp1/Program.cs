using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.gestionSites;
using static WindowsFormsApp1.gestionSites.GestionnaireSites;
using static WindowsFormsApp1.gestionSites.Site;



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
            

            Console.WriteLine("coucou");
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormApplication());
        }
    }
}
