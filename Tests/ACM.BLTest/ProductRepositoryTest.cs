using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 9.99M,
                Description = "Set of four potted sunflowers",
                ProductName = "Sunflowers"
            };

            var actual = productRepository.Retrieve(2);

            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.ProductName, actual.ProductName);

        }
        [TestMethod()]
        public void SaveTestValid()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = 9.99M,
                Description = "Set of four potted sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //Act
            var actual = productRepository.Save(updateProduct);

            //Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void SaveTestMissingPrice()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = null,
                Description = "Set of four potted sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //Act
            var actual = productRepository.Save(updateProduct);

            //Assert
            Assert.AreEqual(false, actual);
        }
    }
}
