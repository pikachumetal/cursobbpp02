using Demo1.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Demo1.Test.Tests
{
    [TestClass]
    public class EstimationTest
    {
        [TestMethod]
        public void When_Estimation_Created_Should_Have_no_Lines()
        {
            var estimation = new Estimation();
            var line = new EstimationLine();

            Assert.IsFalse(estimation.Lines.Any());
        }

        [TestMethod]
        public void When_Line_Added_Should_Estimation_One_Line()
        {
            var estimation = new Estimation();
            var line = new EstimationLine();
            estimation.AddLines(line);

            Assert.AreEqual(1, estimation.Lines.Count());
        }

        [TestMethod]
        public void When_Line_Added_Should_Estimation_Contains_This_Line()
        {
            var estimation = new Estimation();
            var line = new EstimationLine();
            estimation.AddLines(line);

            Assert.IsTrue(estimation.Lines.Any(x => x == line));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_Null_Added_Should_ThrowException()
        {
            var estimation = new Estimation();
            estimation.AddLines(null);

            //Assert.Fail();
        }

        [TestMethod]
        public void When_Estimation_Created_Should_Have_Current_DateTime()
        {
            var estimation = new Estimation();
            Assert.AreEqual(DateTime.Now, estimation.Created);
        }

        [TestMethod]
        public void When_Two_lines_With_Same_Product_Are_Added_Should_Be_Convined()
        {
            var estimation = new Estimation();
            var product = new Product() { Id = 1, Name = "Product", Price = 1 };

            var line1 = new EstimationLine() { Product = product, Quantity = 100 };
            var line2 = new EstimationLine() { Product = product, Quantity = 200 };

            estimation.AddLines(line1);
            estimation.AddLines(line2);

            //! El singleme asegura que la linea es única
            //Assert.AreEqual(1, estimation.Lines.Count());
            Assert.AreEqual(100 + 200, estimation.Lines.Single().Quantity);
        }
    }
}
