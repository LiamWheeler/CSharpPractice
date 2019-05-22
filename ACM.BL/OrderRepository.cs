using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {

        /// <summary>
        /// retrieve one order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            //creates an instance of the order class
            //pass in the requested id
            Order order = new Order(orderId);

            //code to retrieve the defined order

            //Temporary hard coded values to return
            //a populated order

            if (orderId == 10)
            {
                //use current year in hard coded data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 5, 22, 14, 00, 00,
                                                    new TimeSpan(7, 0, 0));
            }
            return order;
        }

        public bool Save(Order order)
        {
            //code that saves the order
            return true;
        }
    }
}
