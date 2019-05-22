using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        /// <summary>
        /// Retrieves an order
        /// </summary>
        /// <returns></returns>
        public Order Retrieve()
        {
            //Code to retrieve the order
            return new Order();
        }

        public bool save()
        {
            //Code to save the order
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;

            return isValid;
        }

    }
}
