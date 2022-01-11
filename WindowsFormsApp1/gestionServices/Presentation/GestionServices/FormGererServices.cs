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

namespace WindowsFormsApp1.gestionServices.Présentation.GestionServices
{
    public partial class FormGererServices : Form
    {
        static string connexionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\denis\OneDrive\Documents\cesi\projet_4\WindowsFormsApp1\projet_4Ind.mdf;Integrated Security=True;Connect Timeout=30";
        private int currentId;
        public static SqlConnection cnx = new SqlConnection(connexionString);
        GestionnaireServices gestionServices = new GestionnaireServices(cnx);
        public GestionnaireServices gererService;
        public FormGererServices()
        {
            InitializeComponent();
        }

        private void FormGererServices_Load(object sender, EventArgs e)
        {
            bt_sup.Enabled = false;
            GridFill();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            if (bt_new.Text == "Modifier")
            {
                gestionServices.Modifier(currentId, txt_name.Text);
                bt_sup.Enabled = false;
                bt_new.Text = "Ajouter";
                txt_name.Text = "";
                GridFill();
            }
            else
            {
                Service service = new Service();
                service.ServiceName = txt_name.Text;

                gestionServices.Ajouter(service);
                txt_name.Text = "";
                GridFill();
            }
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.ServiceName = txt_name.Text;

            gestionServices.Ajouter(service);
        }

        private void bt_start_Click(object sender, EventArgs e)
        {

        }

        private void bt_sup_Click(object sender, EventArgs e)
        {
            gestionServices.Supprimer(currentId);
            bt_sup.Enabled = false;
            bt_new.Text = "Ajouter";
            txt_name.Text = "";
            GridFill();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataSerciceView.CurrentRow.Index != -1)//Verifier si la ligne est dans la grid View
            {
                txt_name.Text = dataSerciceView.CurrentRow.Cells[1].Value.ToString();
                currentId = Convert.ToInt32(dataSerciceView.CurrentRow.Cells[0].Value.ToString());
                bt_sup.Enabled = true;
                bt_new.Text = "Modifier";

            }
        }

        void GridFill()
        {
            dataSerciceView.DataSource = gererService.GetServices();
        }

        private void dataSerciceView_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
