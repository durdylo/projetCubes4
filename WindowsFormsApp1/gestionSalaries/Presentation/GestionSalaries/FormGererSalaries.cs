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

namespace WindowsFormsApp1.gestionSalaries.Presentation.GestionSalaries
{
    public partial class FormGererSalaries : Form
    {
        static string connexionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\denis\OneDrive\Documents\cesi\projet_4\WindowsFormsApp1\projet_4Ind.mdf;Integrated Security=True;Connect Timeout=30";
        private int currentId;
        public static SqlConnection cnx = new SqlConnection(connexionString);
        GestionnaireSalaries gestionSalaries = new GestionnaireSalaries(cnx);
        public GestionnaireSalaries gererSalaries;

        public FormGererSalaries()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormGererSalaries_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projet_4IndDataSet2.Service'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.serviceTableAdapter1.Fill(this.projet_4IndDataSet2.Service);
            // TODO: cette ligne de code charge les données dans la table 'projet_4IndDataSet1.Service'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.serviceTableAdapter.Fill(this.projet_4IndDataSet1.Service);
            // TODO: cette ligne de code charge les données dans la table 'projet_4IndDataSet.Site'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.siteTableAdapter.Fill(this.projet_4IndDataSet.Site);
            GridFill();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void input_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.siteTableAdapter.FillBy(this.projet_4IndDataSet.Site);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void input_telPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        void GridFill()
        {
            dataSalaries.DataSource = gererSalaries.GetSalaries();
        }
        private void bt_sup_Click(object sender, EventArgs e)
        {
            gestionSalaries.Supprimer(currentId);
            bt_sup.Enabled = false;
            bt_new.Text = "Ajouter";
         
            input_name.Text = "";
            input_firstName.Text = "";
            input_telFix.Text = "";
            input_telPort.Text = "";
            input_email.Text = "";
            GridFill();
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            Salarie salarie = new Salarie();
            salarie.Nom = input_name.Text;
            salarie.Prenom = input_firstName.Text;
            salarie.Telephone_fixe = input_telFix.Text;
            salarie.Telephone_portable = input_telPort.Text;
            salarie.Email = input_email.Text;
            salarie.IdSite = (int)input_site.SelectedValue;
            salarie.IdService = (int)input_service.SelectedValue;
            if (bt_new.Text == "Modifier")
            {
                gestionSalaries.Modifier(currentId, salarie);
                bt_sup.Enabled = false;
                bt_new.Text = "Ajouter";
                GridFill();
            }
            else
            {
                gestionSalaries.Ajouter(salarie);
                GridFill();
            }
        }

        private void input_site_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataSalaries_DoubleClick(object sender, EventArgs e)
        {
            if (dataSalaries.CurrentRow.Index != -1)//Verifier si la ligne est dans la grid View
            {
                input_site.SelectedValue = dataSalaries.CurrentRow.Cells[1].Value;
                input_service.SelectedValue = dataSalaries.CurrentRow.Cells[2].Value;
                input_name.Text = dataSalaries.CurrentRow.Cells[3].Value.ToString();
                input_firstName.Text = dataSalaries.CurrentRow.Cells[4].Value.ToString();
                input_telFix.Text = dataSalaries.CurrentRow.Cells[5].Value.ToString(); 
                input_telPort.Text = dataSalaries.CurrentRow.Cells[6].Value.ToString();
                input_email.Text = dataSalaries.CurrentRow.Cells[7].Value.ToString();
                currentId = Convert.ToInt32(dataSalaries.CurrentRow.Cells[0].Value.ToString());
                bt_sup.Enabled = true;
                bt_new.Text = "Modifier";

            }
        }

        private void input_firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_service_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
