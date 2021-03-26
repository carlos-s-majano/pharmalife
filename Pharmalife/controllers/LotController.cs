using Pharmalife.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmalife.Controllers
{
    class LotController
    {
        private readonly LotListController lotListController = new LotListController();
        private readonly ProductListController productListController = new ProductListController();

        public void AddLotToList(String lotCode, String datamatrix, String price, DateTime expirationDate, String productName)
        {
            this.productListController.GetAllProducts();
            Product product = this.productListController.GetProduct(productName);
            if (!String.IsNullOrEmpty(product.Id.ToString()))
            {
                Lot lot = new Lot
                {
                    LotCode = lotCode,
                    Datamatrix = datamatrix,
                    Price = float.Parse(price),
                    ExpirationDate = expirationDate,
                    Product = product
                };
                this.lotListController.InsertIntoEnd(lot);
            }
        }

        public void AddLotToList(String id, String lotCode, String datamatrix, String price, DateTime expirationDate, String productName)
        {
            this.productListController.GetAllProducts();
            Product product = this.productListController.GetProduct(productName);
            if (!String.IsNullOrEmpty(product.Id.ToString()))
            {
                Lot lot = new Lot
                {
                    Id = id,
                    LotCode = lotCode,
                    Datamatrix = datamatrix,
                    Price = float.Parse(price),
                    ExpirationDate = expirationDate,
                    Product = product
                };
                this.lotListController.InsertIntoEnd(lot);
            }
        }

        public void Save(DataGridView dgv)
        {
            this.lotListController.Insert();
            this.lotListController.GetAllLots(dgv);
        }

        public void Update(DataGridView dgv)
        {
            this.lotListController.Update();
            this.lotListController.GetAllLots(dgv);
        }

        public void Delete(DataGridView dgv)
        {
            this.lotListController.Delete();
            this.lotListController.GetAllLots(dgv);
        }

        public void GetAllLots(DataGridView dgv)
        {
            this.lotListController.GetAllLots(dgv);
        }

        public void FillDataGridView(DataGridView dgv)
        {
            this.lotListController.FillDataGridView(dgv);
        }
    }
}
