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
        private int currentId;
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
            bt_sup.Enabled = false;
            GridFill();
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
           if(bt_new.Text == "Modifier")
            {
                Site s = gererSites.Modifier(currentId, txt_City.Text);
                txt_City.Text = s.City;
                bt_sup.Enabled = false;
                bt_new.Text = "Ajouter";
                txt_City.Text = "";
            }
            else
            {
                Site site = new Site();
                site.City = txt_City.Text;

                gestionSite.Ajouter(site);
                txt_City.Text = "";
            }
            GridFill();
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
/*            lbl_create.Text = site.DateCreate1.ToShortDateString();
            lbl_modif.Text = site.DateModif1.ToShortDateString();
*/
        }

        private void bt_end_Click(object sender, EventArgs e)
        {
            Site site = gererSites.End();
            this.Afficher(site);
        }

      

        private void lbl_dateCreate_Click(object sender, EventArgs e)
        {

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void bt_sup_Click(object sender, EventArgs e)
        {
            gererSites.Supprimer(currentId);
            bt_sup.Enabled = false;
            bt_new.Text = "Ajouter";
            txt_City.Text = "";
           GridFill();

        }

        private void txt_City_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridSites_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridSites.CurrentRow.Index != -1)//Verifier si la ligne est dans la grid View
            {
                txt_City.Text = dataGridSites.CurrentRow.Cells[1].Value.ToString();
                currentId = Convert.ToInt32(dataGridSites.CurrentRow.Cells[0].Value.ToString());
                bt_sup.Enabled = true;
                bt_new.Text = "Modifier";

            }
        }
        void GridFill()
        {      
            dataGridSites.DataSource = gererSites.GetSites();
        }

        private void dataGridSites_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        private void dataGridSites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
