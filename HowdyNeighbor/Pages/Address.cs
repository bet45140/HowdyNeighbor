using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowdyNeighbor.Pages
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressString { get; set; }

        public Address()
        {

        }

        public Address(int id, string addressString)
        {
            this.Id = id;
            this.AddressString = addressString;
        }
    }
}
