using MySql.Data.MySqlClient;
using Pharmalife.Classes;
using Pharmalife.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmalife.Controllers
{
    class ProductController
    {
        private readonly ProductListController productListController = new ProductListController();
        private readonly ProviderListController providerListController = new ProviderListController();

        public void AddProductToList(String name, String presentation, String providerName)
        {
            this.providerListController.GetAllProviders();
            Provider provider = this.providerListController.GetProvider(providerName);
            if (!String.IsNullOrEmpty(provider.Id.ToString()))
            {
                Product product = new Product
                {
                    Name = name,
                    Presentation = presentation,
                    Provider = provider
                };
                this.productListController.InsertIntoEnd(product);
            }
        }

        public void AddProductToList(String id, String name, String presentation, String providerName)
        {
            this.providerListController.GetAllProviders();
            Provider provider = this.providerListController.GetProvider(providerName);
            if (!String.IsNullOrEmpty(provider.Id.ToString()))
            {
                Product product = new Product
                {
                    Id = id,
                    Name = name,
                    Presentation = presentation,
                    Provider = provider
                };
                this.productListController.InsertIntoEnd(product);
            }
        }

        public void Save(DataGridView dgv)
        {
            this.productListController.Insert();
            this.productListController.GetAllProducts(dgv);
        }

        public void Update(DataGridView dgv)
        {
            this.productListController.Update();
            this.productListController.GetAllProducts(dgv);
        }

        public void Delete(DataGridView dgv)
        {
            this.productListController.Delete();
            this.productListController.GetAllProducts(dgv);
        }

        public void FillDataGridView(DataGridView dgv)
        {
            this.productListController.FillDataGridView(dgv);
        }

        public void FillComboBox(ComboBox cbo)
        {
            this.productListController.FillComboBox(cbo);
        }

        public void GetAllProducts(DataGridView dgv)
        {
            this.productListController.GetAllProducts(dgv);
        }
    }
}
