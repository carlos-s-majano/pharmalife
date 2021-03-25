using MySql.Data.MySqlClient;
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

        public void AddProductToList(String name, String presentation)
        {
            Product product = new Product
            {
                Name = name,
                Presentation = presentation
            };
            this.productListController.InsertIntoEnd(product);
        }

        public void Save(DataGridView dgv)
        {
            this.productListController.Save();
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
