using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {

        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {

            //create an instance of the product class
            //pass in the requested id
            Product product = new Product(productId);

            //Code that retrieves the defined product

            //Temporary hard coded values


            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.Description = "Set of four potted sunflowers";
                product.CurrentPrice = 9.99M;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Object: {product.ToString()}");
            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //call an Insert Stored Procedure
                    }
                    else
                    {
                        //cal an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
