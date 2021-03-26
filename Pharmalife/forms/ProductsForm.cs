using Pharmalife.Controllers;
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
            dgvProductsList.Columns[0].Visible = true;
            lblDgvTitle.Text = "Productos disponibles:";
            this.clearData();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            this.productController.AddProductToList(txtId.Text, txtName.Text, txtPresentation.Text, cboProviders.Text);
            this.productController.Update(dgvProductsList);
            this.returnToAdd();
        }

        private void returnToAdd()
        {
            btnAddProduct.Visible = true;
            btnEditProduct.Visible = false;
            btnDelete.Visible = false;
            btnSaveProducts.Visible = true;
            btnReturn.Visible = false;
            this.clearData();
        }
        private void dgvProductsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnAddProduct.Visible = false;
                btnEditProduct.Visible = true;
                btnDelete.Visible = true;
                btnReturn.Visible = true;
                btnSaveProducts.Visible = false;

                DataGridViewRow row = dgvProductsList.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtPresentation.Text = row.Cells[2].Value.ToString();
                cboProviders.SelectedIndex = cboProviders.FindStringExact(row.Cells[3].Value.ToString());
            }
        }
        private void clearData()
        {
            txtId.Clear();
            txtName.Clear();
            txtPresentation.Clear();
            cboProviders.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que quiere eliminar el registro?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.productController.AddProductToList(txtId.Text, txtName.Text, txtPresentation.Text, cboProviders.Text);
                this.productController.Delete(dgvProductsList);
                this.returnToAdd();

            }
            else if (result == DialogResult.No)
            {
                this.ResetAll();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.ResetAll();
        }

        private void ResetAll()
        {
            btnAddProduct.Visible = true;
            btnEditProduct.Visible = false;
            btnDelete.Visible = false;
            btnSaveProducts.Visible = true;
            btnReturn.Visible = false;
            txtId.Clear();
            txtName.Clear();
            txtPresentation.Clear();
            cboProviders.SelectedIndex = -1;
        }
    }
}
