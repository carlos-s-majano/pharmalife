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

        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Nombre";
            column1.Width = 200;
            column1.ReadOnly = true;
            column2.HeaderText = "Presentación";
            column2.Width = 200;
            column2.ReadOnly = true;
            dgvProductsList.Columns.Add(column1);
            dgvProductsList.Columns.Add(column2);
            this.productController.GetAllProducts(dgvProductsList);
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            lblDgvTitle.Text = "Productos por agregar:";
            this.productController.AddProductToList(txtName.Text, txtPresentation.Text);
            this.productController.FillDataGridView(dgvProductsList);
        }

        private void BtnSaveProducts_Click(object sender, EventArgs e)
        {
            this.productController.Save(dgvProductsList);
            lblDgvTitle.Text = "Productos disponibles:";
        }
    }
}
