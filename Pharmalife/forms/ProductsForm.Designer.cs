
namespace Pharmalife
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPresentation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProductsList = new System.Windows.Forms.DataGridView();
            this.lblDgvTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProviders = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnSaveProducts = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtName.Location = new System.Drawing.Point(12, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 29);
            this.txtName.TabIndex = 2;
            // 
            // txtPresentation
            // 
            this.txtPresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtPresentation.Location = new System.Drawing.Point(12, 145);
            this.txtPresentation.Name = "txtPresentation";
            this.txtPresentation.Size = new System.Drawing.Size(287, 29);
            this.txtPresentation.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 8.999999F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 8.999999F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Presentación del producto:";
            // 
            // dgvProductsList
            // 
            this.dgvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsList.Location = new System.Drawing.Point(340, 84);
            this.dgvProductsList.Name = "dgvProductsList";
            this.dgvProductsList.Size = new System.Drawing.Size(584, 239);
            this.dgvProductsList.TabIndex = 8;
            this.dgvProductsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsList_CellClick);
            // 
            // lblDgvTitle
            // 
            this.lblDgvTitle.AutoSize = true;
            this.lblDgvTitle.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDgvTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDgvTitle.Location = new System.Drawing.Point(337, 66);
            this.lblDgvTitle.Name = "lblDgvTitle";
            this.lblDgvTitle.Size = new System.Drawing.Size(143, 18);
            this.lblDgvTitle.TabIndex = 9;
            this.lblDgvTitle.Text = "Productos disponibles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 8.999999F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Proveedor:";
            // 
            // cboProviders
            // 
            this.cboProviders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboProviders.FormattingEnabled = true;
            this.cboProviders.Location = new System.Drawing.Point(12, 209);
            this.cboProviders.Name = "cboProviders";
            this.cboProviders.Size = new System.Drawing.Size(287, 32);
            this.cboProviders.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(20, 20);
            this.txtId.TabIndex = 26;
            this.txtId.Visible = false;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("ColorTube", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProducts.Image = global::Pharmalife.Properties.Resources.pill;
            this.lblProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProducts.Location = new System.Drawing.Point(334, 14);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(256, 32);
            this.lblProducts.TabIndex = 25;
            this.lblProducts.Text = "    PRODUCTOS";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Image = global::Pharmalife.Properties.Resources._return;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(637, 329);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(287, 45);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "   Regresar";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(12, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(287, 45);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "   Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEditProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditProduct.Image = global::Pharmalife.Properties.Resources.edit;
            this.btnEditProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProduct.Location = new System.Drawing.Point(12, 278);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(287, 45);
            this.btnEditProduct.TabIndex = 22;
            this.btnEditProduct.Text = "   Editar Producto";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Visible = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnSaveProducts
            // 
            this.btnSaveProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.btnSaveProducts.FlatAppearance.BorderSize = 0;
            this.btnSaveProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProducts.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveProducts.Image = global::Pharmalife.Properties.Resources.floppy_disk;
            this.btnSaveProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveProducts.Location = new System.Drawing.Point(637, 329);
            this.btnSaveProducts.Name = "btnSaveProducts";
            this.btnSaveProducts.Size = new System.Drawing.Size(287, 45);
            this.btnSaveProducts.TabIndex = 5;
            this.btnSaveProducts.Text = "   Guardar Productos";
            this.btnSaveProducts.UseVisualStyleBackColor = false;
            this.btnSaveProducts.Click += new System.EventHandler(this.BtnSaveProducts_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(12, 278);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(287, 45);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "   Agregar Producto";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(936, 427);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.cboProviders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDgvTitle);
            this.Controls.Add(this.dgvProductsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveProducts);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtPresentation);
            this.Controls.Add(this.txtName);
            this.Name = "ProductsForm";
            this.Text = "PHARMALIFE";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPresentation;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnSaveProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProductsList;
        private System.Windows.Forms.Label lblDgvTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboProviders;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.TextBox txtId;
    }
}