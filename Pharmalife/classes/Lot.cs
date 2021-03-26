using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmalife.Classes
{
    class Lot
    {
        private String id;
        private String lotCode;
        private String datamatrix;
        private float price;
        private DateTime expirationDate;
        private Product product;
        private Boolean status;

        public string Id { get => id; set => id = value; }
        public string LotCode { get => lotCode; set => lotCode = value; }
        public string Datamatrix { get => datamatrix; set => datamatrix = value; }
        public float Price { get => price; set => price = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }
        public bool Status { get => status; set => status = value; }
        internal Product Product { get => product; set => product = value; }
    }
}
