using Demo1.Logic;
using Demo1.Model;
using Demo1.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;

namespace Demo1.Test.Tests
{
    [TestClass]
    public class ProductChooserTests
    {
        [TestMethod]
        public void When_Price_Is_higher_Than_10_Should_Return_Only_Products_Higher_than_10()
        {
            var mock = new Mock<IProductService>();

            mock.Setup(m => m.GetAll())
                .Returns(new[] {
                    new Product() { Id = 1, Name = "ProductStub01", Price = 1 },
                    new Product() { Id = 2, Name = "ProductStub02", Price = 1 },
                    new Product() { Id = 3, Name = "ProductStub03", Price = 10 }
                });

            var chooser = new ProductChooser(mock.Object);
            var selected = chooser.FilterByPrice(10);
            Assert.AreEqual(1, selected.Count());
        }

        //[TestMethod]
        //public void When_Add_two_products_Should_Be_Called_Two_Times()
        //{
        //    //var stub = new ProductServiceStub();
        //    //var chooser = new ProductChooser(stub);
        //    //chooser.Add(new Product());
        //    //chooser.Add(new Product());
        //    //Assert.AreEqual(2, stub.AddProduct_Called);

        //    var mock = new Mock<IProductService>();
        //    var product = new Product();
        //    mock.Setup(m => m.AddProduct(product));

        //    var chooser = new ProductChooser(mock.Object);
        //    //chooser.Add(new[] { new Product(), new Product() });
        //    chooser.Add(new Product());
        //    chooser.Add(new Product());

        //    mock.Verify(m => m.AddProduct(product), Times.Exactly(2));

        //    Assert.IsTrue(true);
        //}
    }
}