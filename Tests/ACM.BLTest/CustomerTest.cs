using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer
            {
                FirstName = "Liam",
                LastName = "Wheeler"
            };
            string expected = "Wheeler, Liam";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            Customer customer = new Customer
            {
                LastName = "Wheeler"
            };
            string expected = "Wheeler";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer
            {
                FirstName = "Liam"
            };
            string expected = "Liam";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Liam";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Warren";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Dan";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);
        }

    }

}
