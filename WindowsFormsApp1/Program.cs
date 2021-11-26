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
using System.Data.SqlClient;
using System.Data;

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
            Application.EnableVisualStyles();

       

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormApplication());
        }
    }
}