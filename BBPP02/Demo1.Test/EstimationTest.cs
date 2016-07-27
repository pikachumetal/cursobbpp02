using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Demo1.Test
{
    [TestClass]
    public class EstimationTest
    {
        [TestMethod]
        public void When_Line_Added_Should_Estimation_One_Line()
        {
            var estimation = new Estimation();
            var line = new EstimationLine();
            estimation.AddLines(line);

            Assert.AreEqual(1, estimation.Lines.Count());
        }

        [TestMethod]
        public void When_Estimation_Created_Should_Have_no_Lines()
        {
            var estimation = new Estimation();
            var line = new EstimationLine();

            Assert.IsFalse(estimation.Lines.Any());
        }

        [TestMethod]
        public void When_Line_Added_Should_Estimation_Contains_This_Line()
        {
            var estimation = new Estimation();
            var line = new EstimationLine();
            estimation.AddLines(line);

            Assert.IsTrue(estimation.Lines.Any(x=> x==line));
        }

        [TestMethod]
        public void When_Estimation_Created_Should_Have_Current_DateTime()
        {
            var estimation = new Estimation();
            Assert.AreEqual(DateTime.Now, estimation.Created);
        }
    }
}
