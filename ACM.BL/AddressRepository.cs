using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepository
    {
        /// <summary>
        /// Retrieve one Address
        /// </summary>
        /// <param name="adressId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            //Create the instance of the Address class
            //Pass in the requested Id
            Address address = new Address(addressId);

            //Code that retrieves the defined address

            //Temporary hard coded values
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.AddressLine1 = "First Street";
                address.AddressLine2 = "First lane";
                address.City = "Salford";
                address.State = "Manchester";
                address.Country = "England";
                address.Postcode = "M1 1AA";

            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            //Code that retrieves the defined address

            //Temporary hard coded values
            //to return a set of addresses
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                AddressLine1 = "First Street",
                AddressLine2 = "First lane",
                City = "Salford",
                State = "Manchester",
                Country = "England",
                Postcode = "M1 1AA"

            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                AddressLine1 = "Second Street",
                AddressLine2 = "Second lane",
                City = "Salford",
                State = "Manchester",
                Country = "England",
                Postcode = "M1 1BB"
            };
            addressList.Add(address);

            return addressList;

        }

        public bool Save(Address address)
        {
            //Code that saves the passed in address
            return true;
        }
    }
}
