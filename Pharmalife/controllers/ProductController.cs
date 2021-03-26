using MySql.Data.MySqlClient;
using Pharmalife.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmalife.controllers
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

        public void Save(DataGridView dgv)
        {
            this.productListController.Insert();
            this.productListController.GetAllProducts(dgv);
        }

        public void FillDataGridView(DataGridView dgv)
        {
            this.productListController.FillDataGridView(dgv);
        }

        public void GetAllProducts(DataGridView dgv)
        {
            this.productListController.GetAllProducts(dgv);
        }
    }
}
