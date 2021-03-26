
namespace Pharmalife
{
    partial class HomeForm
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
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.lblAddProducts = new System.Windows.Forms.Label();
            this.btnAddProviders = new System.Windows.Forms.Button();
            this.btnAddLots = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btnAddProducts.FlatAppearance.BorderSize = 0;
            this.btnAddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProducts.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProducts.Location = new System.Drawing.Point(315, 89);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(244, 75);
            this.btnAddProducts.TabIndex = 1;
            this.btnAddProducts.Text = "2. Productos";
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // lblAddProducts
            // 
            this.lblAddProducts.AutoSize = true;
            this.lblAddProducts.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddProducts.Location = new System.Drawing.Point(6, 28);
            this.lblAddProducts.Name = "lblAddProducts";
            this.lblAddProducts.Size = new System.Drawing.Size(267, 33);
            this.lblAddProducts.TabIndex = 0;
            this.lblAddProducts.Text = "Seleccione una opción:";
            // 
            // btnAddProviders
            // 
            this.btnAddProviders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btnAddProviders.FlatAppearance.BorderSize = 0;
            this.btnAddProviders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProviders.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAddProviders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProviders.Location = new System.Drawing.Point(12, 89);
            this.btnAddProviders.Name = "btnAddProviders";
            this.btnAddProviders.Size = new System.Drawing.Size(244, 75);
            this.btnAddProviders.TabIndex = 2;
            this.btnAddProviders.Text = "1. Proveedores";
            this.btnAddProviders.UseVisualStyleBackColor = false;
            this.btnAddProviders.Click += new System.EventHandler(this.btnAddProviders_Click);
            // 
            // btnAddLots
            // 
            this.btnAddLots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btnAddLots.FlatAppearance.BorderSize = 0;
            this.btnAddLots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLots.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAddLots.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddLots.Location = new System.Drawing.Point(608, 89);
            this.btnAddLots.Name = "btnAddLots";
            this.btnAddLots.Size = new System.Drawing.Size(244, 75);
            this.btnAddLots.TabIndex = 3;
            this.btnAddLots.Text = "3. Lotes";
            this.btnAddLots.UseVisualStyleBackColor = false;
            this.btnAddLots.Click += new System.EventHandler(this.btnAddLots_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(864, 211);
            this.Controls.Add(this.btnAddLots);
            this.Controls.Add(this.btnAddProviders);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.lblAddProducts);
            this.Name = "HomeForm";
            this.Text = "PHARMALIFE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Label lblAddProducts;
        private System.Windows.Forms.Button btnAddProviders;
        private System.Windows.Forms.Button btnAddLots;
    }
}