using Pharmalife.controllers;
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
    public partial class ProductsForm : Form
    {
        private readonly ProductController productController = new ProductController();
        private readonly ProductListController productListController = new ProductListController();
        private readonly ProviderController providerController = new ProviderController();

        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Id";
            column1.Width = 50;
            column1.ReadOnly = true;
            column2.HeaderText = "Nombre";
            column2.Width = 200;
            column2.ReadOnly = true;
            column3.HeaderText = "Presentación";
            column3.Width = 200;
            column3.ReadOnly = true;
            column4.HeaderText = "Proveedor";
            column4.Width = 200;
            column4.ReadOnly = true;
            dgvProductsList.Columns.Add(column1);
            dgvProductsList.Columns.Add(column2);
            dgvProductsList.Columns.Add(column3);
            dgvProductsList.Columns.Add(column4);
            this.productController.GetAllProducts(dgvProductsList);
            this.providerController.FillComboBox(cboProviders);
            dgvProductsList.AllowUserToAddRows = false;
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            lblDgvTitle.Text = "Productos por agregar:";
            dgvProductsList.Columns[0].Visible = false;
            this.productController.AddProductToList(txtName.Text, txtPresentation.Text, cboProviders.Text);
            this.productController.FillDataGridView(dgvProductsList);
        }

        private void BtnSaveProducts_Click(object sender, EventArgs e)
        {
            this.productController.Save(dgvProductsList);
            lblDgvTitle.Text = "Productos disponibles:";
        }
    }
}
