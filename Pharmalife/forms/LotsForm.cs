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

namespace Pharmalife.Forms
{
    public partial class LotsForm : Form
    {
        private readonly LotController lotController = new LotController();
        private readonly LotListController lotListController = new LotListController();
        private readonly ProductController productController = new ProductController();

        public LotsForm()
        {
            InitializeComponent();
        }

        private void LotsForm_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Id";
            column1.Width = 50;
            column1.ReadOnly = true;
            column2.HeaderText = "Lote";
            column2.Width = 200;
            column2.ReadOnly = true;
            column3.HeaderText = "Datamatrix";
            column3.Width = 250;
            column3.ReadOnly = true;
            column4.HeaderText = "Precio";
            column4.Width = 200;
            column4.ReadOnly = true;
            column5.HeaderText = "Fecha de vencimiento";
            column5.Width = 200;
            column5.ReadOnly = true;
            column6.HeaderText = "Producto";
            column6.Width = 200;
            column6.ReadOnly = true;
            dgvLotsList.Columns.Add(column1);
            dgvLotsList.Columns.Add(column2);
            dgvLotsList.Columns.Add(column3);
            dgvLotsList.Columns.Add(column4);
            dgvLotsList.Columns.Add(column5);
            dgvLotsList.Columns.Add(column6);
            this.lotController.GetAllLots(dgvLotsList);
            this.productController.FillComboBox(cboProducts);
            dgvLotsList.AllowUserToAddRows = false;
        }

        private void btnAddLot_Click(object sender, EventArgs e)
        {
            lblDgvTitle.Text = "Lotes por agregar:";
            dgvLotsList.Columns[0].Visible = false;
            this.lotController.AddLotToList(txtLoteCode.Text, txtDatamatrix.Text, txtPrice.Text, dtpExpirationDate.Value, cboProducts.Text);
            this.lotController.FillDataGridView(dgvLotsList);
        }

        private void btnSaveLots_Click(object sender, EventArgs e)
        {
            this.lotController.Save(dgvLotsList);
            lblDgvTitle.Text = "Lotes disponibles:";
            dgvLotsList.Columns[0].Visible = true;
            this.clearData();
        }

        private void btnEditLot_Click(object sender, EventArgs e)
        {
            this.lotController.AddLotToList(txtId.Text, txtLoteCode.Text, txtDatamatrix.Text, txtPrice.Text, dtpExpirationDate.Value, cboProducts.Text);
            this.lotController.Update(dgvLotsList);
            this.returnToAdd();
        }

        private void returnToAdd()
        {
            btnAddLot.Visible = true;
            btnEditLot.Visible = false;
            btnDelete.Visible = false;
            btnSaveLots.Visible = true;
            btnReturn.Visible = false;
            this.clearData();
        }

        private void clearData()
        {
            txtId.Clear();
            txtLoteCode.Clear();
            txtDatamatrix.Clear();
            txtPrice.Clear();
            dtpExpirationDate.Value = DateTime.Now;
            cboProducts.SelectedIndex = -1;
        }

        private void dgvLotsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnAddLot.Visible = false;
                btnEditLot.Visible = true;
                btnDelete.Visible = true;
                btnReturn.Visible = true;
                btnSaveLots.Visible = false;

                DataGridViewRow row = dgvLotsList.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtLoteCode.Text = row.Cells[1].Value.ToString();
                txtDatamatrix.Text = row.Cells[2].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();
                dtpExpirationDate.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                cboProducts.SelectedIndex = cboProducts.FindStringExact(row.Cells[5].Value.ToString());
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.ResetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que quiere eliminar el registro?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.lotController.AddLotToList(txtId.Text, txtLoteCode.Text, txtDatamatrix.Text, txtPrice.Text, dtpExpirationDate.Value, cboProducts.Text);
                this.lotController.Delete(dgvLotsList);
                this.returnToAdd();

            }
            else if (result == DialogResult.No)
            {
                this.ResetAll();
            }
        }

        private void ResetAll()
        {
            btnAddLot.Visible = true;
            btnEditLot.Visible = false;
            btnDelete.Visible = false;
            btnSaveLots.Visible = true;
            btnReturn.Visible = false;
            txtId.Clear();
            txtLoteCode.Clear();
            txtDatamatrix.Clear();
            txtPrice.Clear();
            dtpExpirationDate.Value = DateTime.Now;
            cboProducts.SelectedIndex = -1;
        }
    }
}
