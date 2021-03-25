
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
            this.SuspendLayout();
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(213)))), ((int)(((byte)(157)))));
            this.btnAddProducts.FlatAppearance.BorderSize = 0;
            this.btnAddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProducts.Font = new System.Drawing.Font("ColorTube", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProducts.Location = new System.Drawing.Point(38, 87);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(244, 75);
            this.btnAddProducts.TabIndex = 1;
            this.btnAddProducts.Text = "Agregar Productos";
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // lblAddProducts
            // 
            this.lblAddProducts.AutoSize = true;
            this.lblAddProducts.Font = new System.Drawing.Font("ColorTube", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddProducts.Location = new System.Drawing.Point(32, 32);
            this.lblAddProducts.Name = "lblAddProducts";
            this.lblAddProducts.Size = new System.Drawing.Size(365, 32);
            this.lblAddProducts.TabIndex = 0;
            this.lblAddProducts.Text = "Seleccione una opción:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(89)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(811, 765);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.lblAddProducts);
            this.Name = "Home";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Label lblAddProducts;
    }
}