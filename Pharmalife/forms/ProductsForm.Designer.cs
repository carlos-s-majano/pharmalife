
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
            this.btnSaveProducts = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProductsList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtName.Location = new System.Drawing.Point(12, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 29);
            this.txtName.TabIndex = 2;
            // 
            // txtPresentation
            // 
            this.txtPresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtPresentation.Location = new System.Drawing.Point(12, 105);
            this.txtPresentation.Name = "txtPresentation";
            this.txtPresentation.Size = new System.Drawing.Size(287, 29);
            this.txtPresentation.TabIndex = 3;
            // 
            // btnSaveProducts
            // 
            this.btnSaveProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.btnSaveProducts.FlatAppearance.BorderSize = 0;
            this.btnSaveProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProducts.Font = new System.Drawing.Font("ColorTube", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveProducts.Image = global::Pharmalife.Properties.Resources.floppy_disk;
            this.btnSaveProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveProducts.Location = new System.Drawing.Point(613, 232);
            this.btnSaveProducts.Name = "btnSaveProducts";
            this.btnSaveProducts.Size = new System.Drawing.Size(287, 45);
            this.btnSaveProducts.TabIndex = 5;
            this.btnSaveProducts.Text = "   Guardar Productos";
            this.btnSaveProducts.UseVisualStyleBackColor = false;
            this.btnSaveProducts.Click += new System.EventHandler(this.btnSaveProducts_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("ColorTube", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(12, 163);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(287, 45);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "   Agregar Producto";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Presentación del producto:";
            // 
            // dgvProductsList
            // 
            this.dgvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsList.Location = new System.Drawing.Point(340, 38);
            this.dgvProductsList.Name = "dgvProductsList";
            this.dgvProductsList.Size = new System.Drawing.Size(560, 170);
            this.dgvProductsList.TabIndex = 8;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(912, 289);
            this.Controls.Add(this.dgvProductsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveProducts);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtPresentation);
            this.Controls.Add(this.txtName);
            this.Name = "ProductsForm";
            this.Text = "Productos";
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
    }
}