using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "Lwheeler@test.me",
                FirstName = "Liam",
                LastName = "Wheeler"
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);

        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {


                EmailAddress = "Lwheeler@test.me",
                FirstName = "Liam",
                LastName = "Wheeler",
                AddressList = new List<Address>()
                {
                     new Address()
                     {
                      AddressType = 1,
                      AddressLine1 = "First Street",
                      AddressLine2 = "First lane",
                      City = "Salford",
                      State = "Manchester",
                      Country = "England",
                      Postcode = "M1 1AA"
                     },
                     new Address()
                     {
                      AddressType = 2,
                      AddressLine1 = "Second Street",
                      AddressLine2 = "Second lane",
                      City = "Salford",
                      State = "Manchester",
                      Country = "England",
                      Postcode = "M1 1BB"
                     }
                }
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

        }
    }
}
