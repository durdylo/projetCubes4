<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.gestionSites;
using static WindowsFormsApp1.gestionSites.GestionSites;
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
            GestionSites gestionSite = new GestionSites();
            Gestion
            site.City = "Paris";
            Application.EnableVisualStyles();
            gestionSite.Ajouter(site);
            Console.WriteLine("dcdscsdcsdcscscscsdcscscdsc");
            Console.WriteLine(gestionSite.GetSites());

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
=======
﻿using System;
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
>>>>>>> a89c970bb6f2fb999bda8841c5c5dc79ef856acd
