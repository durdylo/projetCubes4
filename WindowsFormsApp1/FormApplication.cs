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
using WindowsFormsApp1.gestionSites;
using WindowsFormsApp1.Presentation.GestionSites;

namespace WindowsFormsApp1
{
    public partial class FormApplication : Form
    {
        static string connexionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=projet_4Ind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static SqlConnection cnx = new SqlConnection(connexionString);
        GestionnaireSites gestionSite = new GestionnaireSites(cnx);
     

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
            foreach (string site in gestionSite.GetSites()) 
            {

                Console.WriteLine(site);

            }

        }
    }
}
