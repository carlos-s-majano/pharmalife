using Pharmalife.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmalife
{
    class Product
    {
        private String id;
        private String name;
        private String presentation;
        private Provider provider;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Presentation { get => presentation; set => presentation = value; }
        public Provider Provider { get => provider; set => provider = value; }
    }
}
