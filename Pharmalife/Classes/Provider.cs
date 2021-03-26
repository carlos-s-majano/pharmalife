using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmalife.classes
{
    class Provider
    {
        string id;
        string name;
        string address;
        string phone;
        Boolean status;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public bool Status { get => status; set => status = value; }
    }
}
