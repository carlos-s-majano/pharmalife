using Pharmalife.forms;
using Pharmalife.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmalife
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
        }

        private void btnAddProviders_Click(object sender, EventArgs e)
        {
            ProvidersForm providersForm = new ProvidersForm();
            providersForm.Show();
        }

        private void btnAddLots_Click(object sender, EventArgs e)
        {
            LotsForm lotsForm = new LotsForm();
            lotsForm.Show();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
