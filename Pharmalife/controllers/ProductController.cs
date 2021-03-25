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
        MySqlConnection mySqlConnection = new MySqlConnection();
        ProductListController productListController = new ProductListController();

        /**
         *  Method to add product to list
         */
        public void addProductToList(String name, String presentation)
        {
            Product product = new Product();
            product.Name = name;
            product.Presentation = presentation;
            this.productListController.insertIntoEnd(product);
        }

        /**
         *  Method to save product list into database
         */
        public void save()
        {
            this.productListController.save();
        }

        public void fillDataGridView(DataGridView dgv)
        {
            this.productListController.fillDataGridView(dgv);
        }
    }
}
