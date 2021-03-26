using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmalife.Classes
{
    class Product
    {
        private String id;
        private String name;
        private String presentation;
        private Provider provider;
        private Boolean status;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Presentation { get => presentation; set => presentation = value; }
        public Provider Provider { get => provider; set => provider = value; }
        public bool Status { get => status; set => status = value; }
    }
}
