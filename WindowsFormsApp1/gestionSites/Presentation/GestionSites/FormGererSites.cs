using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.gestionSites;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Presentation.GestionSites
{
    public partial class FormGererSites : Form
    {

        static string connexionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=projet_4Ind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static SqlConnection cnx = new SqlConnection(connexionString);
        GestionnaireSites gestionSite = new GestionnaireSites(cnx);
        public GestionnaireSites gererSites;
        public FormGererSites()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormGererSites_Load(object sender, EventArgs e)
        {

        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            lbl_id.Text = "";
            txt_City.Text = "";
            lbl_create.Text = "";
            lbl_dateCreate.Text = DateTime.Now.ToString();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            Site site = new Site();
            site.City = txt_City.Text;
            Console.WriteLine(gestionSite.Ajouter(site));
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            Site site =  gererSites.Start();
            this.Afficher(site);
        }

        private void Afficher(Site site)
        {
            lbl_id.Text = site.Id.ToString();
            txt_City.Text = site.City;
            lbl_create.Text = site.DateCreate1.ToShortDateString();
            lbl_modif.Text = site.DateModif1.ToShortDateString();

        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            Site site = gererSites.Next(int.Parse(lbl_id.Text));
            this.Afficher(site);
        }

        private void bt_precede_Click(object sender, EventArgs e)
        {
            Site site = gererSites.Next(int.Parse(lbl_id.Text));
            this.Afficher(site);
        }

        private void bt_end_Click(object sender, EventArgs e)
        {
            Site site = gererSites.End();
            this.Afficher(site);
        }
    }
}
