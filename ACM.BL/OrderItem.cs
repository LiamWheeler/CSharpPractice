using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Retrieve one order item
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            //Code to retrieve an order
            return new OrderItem();
        }

        /// <summary>
        /// Saves an order
        /// </summary>
        /// <returns></returns>
        public bool save()
        {
            //Code that saves the order
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (PurchasePrice == null) isValid = false;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;


            return isValid;

        }


    }
}
