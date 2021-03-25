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
        ProductController productController = new ProductController();
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            this.productController.addProductToList(txtName.Text, txtPresentation.Text);
            this.productController.fillDataGridView(dgvProductsList);
        }

        private void btnSaveProducts_Click(object sender, EventArgs e)
        {
            this.productController.save();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            /*DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();*/
            column1.HeaderText = "Nombre";
            column1.Width = 200;
            column1.ReadOnly = true;
            column2.HeaderText = "Presentación";
            column2.Width = 200;
            column2.ReadOnly = true;
            /*column3.HeaderText = "Presentación";
            column3.Width = 200;
            column3.ReadOnly = true;
            column4.HeaderText = "Nombre";
            column4.Width = 200;
            column4.ReadOnly = true;
            column5.HeaderText = "Nombre";
            column5.Width = 200;
            column5.ReadOnly = true;*/
            dgvProductsList.Columns.Add(column1);
            dgvProductsList.Columns.Add(column2);
            /*dgvProductsList.Columns.Add(column3);
            dgvProductsList.Columns.Add(column4);
            dgvProductsList.Columns.Add(column5);*/
        }
    }
}
