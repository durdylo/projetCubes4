using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.gestionServices;
using WindowsFormsApp1.gestionSalaries;
using WindowsFormsApp1.gestionServices.Présentation.GestionServices;
using WindowsFormsApp1.gestionSites;
using WindowsFormsApp1.Presentation.GestionSites;
using WindowsFormsApp1.gestionSalaries.Presentation.GestionSalaries;

namespace WindowsFormsApp1
{
    public partial class FormApplication : Form
    {
        static string connexionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=projet_4Ind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection cnx = new SqlConnection(connexionString);

        GestionnaireSites gestionSite = new GestionnaireSites(cnx);
        GestionnaireServices gestionServices = new GestionnaireServices(cnx);
        GestionnaireSalaries gestionSalaries = new GestionnaireSalaries(cnx);


        public FormApplication()
        {
            InitializeComponent();
        }

        private void gérerLesSitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGererSites form = new FormGererSites();
            form.gererSites = gestionSite;
            form.Show();
        }

        private void voirLesSitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Site site = new Site();
            site.City = "Paris";
            Console.WriteLine(gestionSite.Ajouter(site));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Site site in gestionSite.GetSites()) 
            {

                Console.WriteLine(site.City);

            }

           /* foreach (Service service in gestionServices.GetServices())
            {

                Console.WriteLine(service.Id);
                Console.WriteLine(service.ServiceName);

            }*/

        }

        private void sitesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gérerLesUtilsateursToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormGererSalaries form = new FormGererSalaries();
            form.gererSalaries = gestionSalaries;
            form.Show();
        }

        private void gererLesServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGererServices form = new FormGererServices();
            form.gererService = gestionServices;
            form.Show();
        }
    }
}
