using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address (int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }
        public string AddressLine1 { get; set; }
        public string  AddressLine2 { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (Postcode == null) isValid = false;
            return isValid;

        }
    }
}
