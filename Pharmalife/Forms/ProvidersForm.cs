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

namespace Pharmalife.forms
{
    public partial class ProvidersForm : Form
    {
        private readonly ProviderController providerController = new ProviderController();
        private readonly ProviderListController providerListController = new ProviderListController();
        public ProvidersForm()
        {
            InitializeComponent();
        }

        private void ProvidersForm_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            /*DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Editar";
            editButtonColumn.Text = "Editar";
            editButtonColumn.UseColumnTextForButtonValue = true;*/

            column1.HeaderText = "Id";
            column1.Width = 50;
            column1.ReadOnly = true;

            column2.HeaderText = "Nombre";
            column2.Width = 200;
            column2.ReadOnly = true;

            column3.HeaderText = "Direccion";
            column3.Width = 200;
            column3.ReadOnly = true;

            column4.HeaderText = "Telefono";
            column4.Width = 200;
            column4.ReadOnly = true;
          
            
            dgvProvidersList.Columns.Add(column1);
            dgvProvidersList.Columns.Add(column2);
            dgvProvidersList.Columns.Add(column3);
            dgvProvidersList.Columns.Add(column4);

            //dgvProvidersList.Columns.Insert(4, editButtonColumn);
            this.providerController.GetAllProviders(dgvProvidersList);
            dgvProvidersList.AllowUserToAddRows = false;
        }

        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            lblDgvTitle.Text = "Proveedores a registrar:";
            dgvProvidersList.Columns[0].Visible = false;
            this.providerController.AddProviderToList(txtName.Text, txtAddress.Text, txtPhone.Text);
            this.providerController.FillDataGridView(dgvProvidersList);
        }

        private void btnSaveProviders_Click(object sender, EventArgs e)
        {
            this.providerController.Save(dgvProvidersList);
            lblDgvTitle.Text = "Contactos de Proveedores";
            this.clearData();
        }

        private void dgvProvidersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnAddProvider.Visible = false;
                btnEditProvider.Visible = true;
                btnDelete.Visible = true;
                btnReturn.Visible = true;
                btnSaveProviders.Visible = false;
               
                DataGridViewRow row = dgvProvidersList.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que quiere eliminar el registro?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.providerController.AddProviderToList(txtId.Text, txtName.Text, txtAddress.Text, txtPhone.Text);
                this.providerController.Delete(dgvProvidersList);
                this.returnToAdd();
                
            }

            else if (result == DialogResult.No)
            {
            }


        }

        private void btnEditProvider_Click(object sender, EventArgs e)
        {
            this.providerController.AddProviderToList(txtId.Text, txtName.Text, txtAddress.Text, txtPhone.Text);
            this.providerController.Update(dgvProvidersList);
            this.returnToAdd();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            btnAddProvider.Visible = true;
            btnEditProvider.Visible = false;
            btnDelete.Visible = false;
            btnSaveProviders.Visible = true;
            btnReturn.Visible = false;
            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }

        private void returnToAdd()
        {
            btnAddProvider.Visible = true;
            btnEditProvider.Visible = false;
            btnDelete.Visible = false;
            btnSaveProviders.Visible = true;
            btnReturn.Visible = false;
            this.clearData();
        }

        private void lblAddProducts_Click(object sender, EventArgs e)
        {

        }


        private void clearData()
        {
            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }
    }
}
