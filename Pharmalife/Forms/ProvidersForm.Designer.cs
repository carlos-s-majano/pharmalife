namespace Pharmalife.forms
{
    partial class ProvidersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvidersForm));
            this.lblDgvTitle = new System.Windows.Forms.Label();
            this.dgvProvidersList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblProviders = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditProvider = new System.Windows.Forms.Button();
            this.btnSaveProviders = new System.Windows.Forms.Button();
            this.btnAddProvider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvidersList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDgvTitle
            // 
            this.lblDgvTitle.AutoSize = true;
            this.lblDgvTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDgvTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDgvTitle.Location = new System.Drawing.Point(339, 65);
            this.lblDgvTitle.Name = "lblDgvTitle";
            this.lblDgvTitle.Size = new System.Drawing.Size(149, 15);
            this.lblDgvTitle.TabIndex = 17;
            this.lblDgvTitle.Text = "Contactos de proveedores";
            // 
            // dgvProvidersList
            // 
            this.dgvProvidersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvidersList.Location = new System.Drawing.Point(342, 83);
            this.dgvProvidersList.Name = "dgvProvidersList";
            this.dgvProvidersList.Size = new System.Drawing.Size(584, 268);
            this.dgvProvidersList.TabIndex = 16;
            this.dgvProvidersList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProvidersList_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Direccion del proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre del proveedor";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtAddress.Location = new System.Drawing.Point(12, 150);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(287, 73);
            this.txtAddress.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtName.Location = new System.Drawing.Point(12, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 29);
            this.txtName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(9, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Numero de Teléfono";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtPhone.Location = new System.Drawing.Point(12, 257);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(287, 29);
            this.txtPhone.TabIndex = 19;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(28, 20);
            this.txtId.TabIndex = 20;
            this.txtId.Visible = false;
            // 
            // lblProviders
            // 
            this.lblProviders.AutoSize = true;
            this.lblProviders.Font = new System.Drawing.Font("ColorTube", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProviders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProviders.Image = global::Pharmalife.Properties.Resources.truck;
            this.lblProviders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProviders.Location = new System.Drawing.Point(336, 15);
            this.lblProviders.Name = "lblProviders";
            this.lblProviders.Size = new System.Drawing.Size(293, 32);
            this.lblProviders.TabIndex = 24;
            this.lblProviders.Text = "    PROVEEDORES";
            this.lblProviders.Click += new System.EventHandler(this.lblAddProducts_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("ColorTube", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Image = global::Pharmalife.Properties.Resources._return;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(639, 357);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(287, 45);
            this.btnReturn.TabIndex = 23;
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
            this.btnDelete.Font = new System.Drawing.Font("ColorTube", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Image = global::Pharmalife.Properties.Resources.close;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(12, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(287, 45);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "   Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditProvider
            // 
            this.btnEditProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnEditProvider.FlatAppearance.BorderSize = 0;
            this.btnEditProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProvider.Font = new System.Drawing.Font("ColorTube", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnEditProvider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditProvider.Image = global::Pharmalife.Properties.Resources.edit;
            this.btnEditProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProvider.Location = new System.Drawing.Point(12, 306);
            this.btnEditProvider.Name = "btnEditProvider";
            this.btnEditProvider.Size = new System.Drawing.Size(287, 45);
            this.btnEditProvider.TabIndex = 21;
            this.btnEditProvider.Text = "   Editar Proveedor";
            this.btnEditProvider.UseVisualStyleBackColor = false;
            this.btnEditProvider.Visible = false;
            this.btnEditProvider.Click += new System.EventHandler(this.btnEditProvider_Click);
            // 
            // btnSaveProviders
            // 
            this.btnSaveProviders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.btnSaveProviders.FlatAppearance.BorderSize = 0;
            this.btnSaveProviders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProviders.Font = new System.Drawing.Font("ColorTube", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProviders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveProviders.Image = global::Pharmalife.Properties.Resources.floppy_disk;
            this.btnSaveProviders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveProviders.Location = new System.Drawing.Point(639, 357);
            this.btnSaveProviders.Name = "btnSaveProviders";
            this.btnSaveProviders.Size = new System.Drawing.Size(287, 45);
            this.btnSaveProviders.TabIndex = 13;
            this.btnSaveProviders.Text = "   Guardar Proveedores";
            this.btnSaveProviders.UseVisualStyleBackColor = false;
            this.btnSaveProviders.Click += new System.EventHandler(this.btnSaveProviders_Click);
            // 
            // btnAddProvider
            // 
            this.btnAddProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btnAddProvider.FlatAppearance.BorderSize = 0;
            this.btnAddProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProvider.Font = new System.Drawing.Font("ColorTube", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnAddProvider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProvider.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProvider.Image")));
            this.btnAddProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProvider.Location = new System.Drawing.Point(12, 306);
            this.btnAddProvider.Name = "btnAddProvider";
            this.btnAddProvider.Size = new System.Drawing.Size(287, 45);
            this.btnAddProvider.TabIndex = 12;
            this.btnAddProvider.Text = "   Agregar Proveedor";
            this.btnAddProvider.UseVisualStyleBackColor = false;
            this.btnAddProvider.Click += new System.EventHandler(this.btnAddProvider_Click);
            // 
            // ProvidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(936, 427);
            this.Controls.Add(this.lblProviders);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditProvider);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDgvTitle);
            this.Controls.Add(this.dgvProvidersList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveProviders);
            this.Controls.Add(this.btnAddProvider);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Name = "ProvidersForm";
            this.Text = "Providers";
            this.Load += new System.EventHandler(this.ProvidersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvidersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDgvTitle;
        private System.Windows.Forms.DataGridView dgvProvidersList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveProviders;
        private System.Windows.Forms.Button btnAddProvider;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEditProvider;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblProviders;
    }
}