using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Presentation.GestionSites;

namespace WindowsFormsApp1
{
    public partial class FormApplication : Form
    {
        public FormApplication()
        {
            InitializeComponent();
        }

        private void gérerLesSitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGererSites form = new FormGererSites();
            form.Show();
        }
    }
}
