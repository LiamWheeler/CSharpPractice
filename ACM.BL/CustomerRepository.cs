using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {

        /// <summary>
        /// Retrieve one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            //create the instance for the customer class
            //pass in the requested id
            Customer customer = new Customer(customerId);

            //Code that retrieves the defined customer

            //Temporary hardcoded values to return
            //a populated customer

            if (customerId == 1)
            {
                customer.EmailAddress = "Lwheeler@test.me";
                customer.FirstName = "Liam";
                customer.LastName = "Wheeler";
            }
            return customer;
        }

        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            //Code that saves the passed in customer
            return true;
        }
        
    }
}
