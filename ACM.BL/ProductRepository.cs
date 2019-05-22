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
            return product;
        }

        public bool save(Product product)
        {
            //code that saves the product
            return true;
        }
    }
}
