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

namespace WindowsFormsApp1.Presentation.GestionSites
{
    public partial class FormGererSites : Form
    {
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
            txt_City.Text = "";
            lbl_create.Text = "";
            lbl_dateCreate.Text = DateTime.Now.ToString();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            Site site = new Site();
            site.City = txt_City.Text;
            new GestionnaireSites().Ajouter(site);
        }
    }
}
