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
        static string connexionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\denis\OneDrive\Documents\cesi\projet_4\WindowsFormsApp1\projet_4Ind.mdf;Integrated Security=True;Connect Timeout=30";
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

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormApplication_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projet_4IndDataSet.Site'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.siteTableAdapter.Fill(this.projet_4IndDataSet.Site);
            // TODO: cette ligne de code charge les données dans la table 'projet_4IndDataSet2.Service'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.serviceTableAdapter.Fill(this.projet_4IndDataSet2.Service);
            // TODO: cette ligne de code charge les données dans la table 'projet_4IndDataSet3.Salary'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.salaryTableAdapter.Fill(this.projet_4IndDataSet3.Salary);
            menuStrip1.Visible = false;
            GridFill(gestionSalaries.GetSalaries());
        }

        private void FormApplication_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.G)
            {
                adminPassword form = new adminPassword();
                this.Hide();
                form.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void GridFill(List<Salarie> salaries)
        {
            dataGridView1.DataSource = salaries;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Salarie> salaries = new List<Salarie>();
            salaries = gestionSalaries.GetSalariesByService(Convert.ToInt32(comboBox1.SelectedValue));
            GridFill(salaries);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Salarie> salaries = new List<Salarie>();
            salaries = gestionSalaries.GetSalariesBySite(Convert.ToInt32(comboBox2.SelectedValue));
            GridFill(salaries);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GridFill(gestionSalaries.GetSalaries());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            List<Salarie> salaries = new List<Salarie>();
            salaries = gestionSalaries.GetSalariesByName((textBox2.Text));
            GridFill(salaries);
        }
    }
}
