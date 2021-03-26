
namespace Pharmalife.Forms
{
    partial class LotsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LotsForm));
            this.txtLoteCode = new System.Windows.Forms.TextBox();
            this.txtDatamatrix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvLotsList = new System.Windows.Forms.DataGridView();
            this.lblDgvTitle = new System.Windows.Forms.Label();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSaveLots = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditLot = new System.Windows.Forms.Button();
            this.btnAddLot = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotsList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoteCode
            // 
            this.txtLoteCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtLoteCode.Location = new System.Drawing.Point(12, 92);
            this.txtLoteCode.Name = "txtLoteCode";
            this.txtLoteCode.Size = new System.Drawing.Size(287, 29);
            this.txtLoteCode.TabIndex = 3;
            // 
            // txtDatamatrix
            // 
            this.txtDatamatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDatamatrix.Location = new System.Drawing.Point(12, 151);
            this.txtDatamatrix.Name = "txtDatamatrix";
            this.txtDatamatrix.Size = new System.Drawing.Size(287, 29);
            this.txtDatamatrix.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 8.999999F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código de lote:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 8.999999F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código datamatrix:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 8.999999F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtPrice.Location = new System.Drawing.Point(12, 209);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(287, 29);
            this.txtPrice.TabIndex = 10;
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpirationDate.Location = new System.Drawing.Point(12, 269);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(287, 20);
            this.dtpExpirationDate.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 8.999999F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha de vencimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comfortaa", 8.999999F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Producto:";
            // 
            // dgvLotsList
            // 
            this.dgvLotsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLotsList.Location = new System.Drawing.Point(340, 92);
            this.dgvLotsList.Name = "dgvLotsList";
            this.dgvLotsList.Size = new System.Drawing.Size(584, 341);
            this.dgvLotsList.TabIndex = 25;
            this.dgvLotsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLotsList_CellClick);
            // 
            // lblDgvTitle
            // 
            this.lblDgvTitle.AutoSize = true;
            this.lblDgvTitle.Font = new System.Drawing.Font("Comfortaa", 8.999999F);
            this.lblDgvTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDgvTitle.Location = new System.Drawing.Point(337, 74);
            this.lblDgvTitle.Name = "lblDgvTitle";
            this.lblDgvTitle.Size = new System.Drawing.Size(116, 18);
            this.lblDgvTitle.TabIndex = 28;
            this.lblDgvTitle.Text = "Lotes disponibles:";
            // 
            // cboProducts
            // 
            this.cboProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(12, 324);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(287, 32);
            this.cboProducts.TabIndex = 30;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("ColorTube", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProducts.Image = global::Pharmalife.Properties.Resources.boxes;
            this.lblProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProducts.Location = new System.Drawing.Point(334, 15);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(163, 32);
            this.lblProducts.TabIndex = 29;
            this.lblProducts.Text = "    LOTES";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Image = global::Pharmalife.Properties.Resources._return;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(637, 439);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(287, 45);
            this.btnReturn.TabIndex = 27;
            this.btnReturn.Text = "   Regresar";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSaveLots
            // 
            this.btnSaveLots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.btnSaveLots.FlatAppearance.BorderSize = 0;
            this.btnSaveLots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLots.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveLots.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveLots.Image = global::Pharmalife.Properties.Resources.floppy_disk;
            this.btnSaveLots.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveLots.Location = new System.Drawing.Point(637, 439);
            this.btnSaveLots.Name = "btnSaveLots";
            this.btnSaveLots.Size = new System.Drawing.Size(287, 45);
            this.btnSaveLots.TabIndex = 26;
            this.btnSaveLots.Text = "   Guardar Lotes";
            this.btnSaveLots.UseVisualStyleBackColor = false;
            this.btnSaveLots.Click += new System.EventHandler(this.btnSaveLots_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Image = global::Pharmalife.Properties.Resources.close;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(12, 439);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(287, 45);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "   Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditLot
            // 
            this.btnEditLot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnEditLot.FlatAppearance.BorderSize = 0;
            this.btnEditLot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLot.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEditLot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditLot.Image = global::Pharmalife.Properties.Resources.edit;
            this.btnEditLot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditLot.Location = new System.Drawing.Point(12, 388);
            this.btnEditLot.Name = "btnEditLot";
            this.btnEditLot.Size = new System.Drawing.Size(287, 45);
            this.btnEditLot.TabIndex = 23;
            this.btnEditLot.Text = " Editar Lote";
            this.btnEditLot.UseVisualStyleBackColor = false;
            this.btnEditLot.Visible = false;
            this.btnEditLot.Click += new System.EventHandler(this.btnEditLot_Click);
            // 
            // btnAddLot
            // 
            this.btnAddLot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btnAddLot.FlatAppearance.BorderSize = 0;
            this.btnAddLot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLot.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAddLot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddLot.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLot.Image")));
            this.btnAddLot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddLot.Location = new System.Drawing.Point(12, 388);
            this.btnAddLot.Name = "btnAddLot";
            this.btnAddLot.Size = new System.Drawing.Size(287, 45);
            this.btnAddLot.TabIndex = 16;
            this.btnAddLot.Text = " Agregar Lote";
            this.btnAddLot.UseVisualStyleBackColor = false;
            this.btnAddLot.Click += new System.EventHandler(this.btnAddLot_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 51);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(20, 20);
            this.txtId.TabIndex = 31;
            this.txtId.Visible = false;
            // 
            // LotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(936, 520);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cboProducts);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblDgvTitle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSaveLots);
            this.Controls.Add(this.dgvLotsList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditLot);
            this.Controls.Add(this.btnAddLot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpExpirationDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatamatrix);
            this.Controls.Add(this.txtLoteCode);
            this.Name = "LotsForm";
            this.Text = "PHARMALIFE";
            this.Load += new System.EventHandler(this.LotsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoteCode;
        private System.Windows.Forms.TextBox txtDatamatrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddLot;
        private System.Windows.Forms.Button btnEditLot;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvLotsList;
        private System.Windows.Forms.Button btnSaveLots;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDgvTitle;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.TextBox txtId;
    }
}