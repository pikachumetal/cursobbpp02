using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Test
{
    [TestClass]
    public class MedyStackTests
    {
        [TestMethod]
        public void When_Add_item_On_Empty_Stack_Should_Be_One_Item()
        {
            var stack = new MedyStack();
            stack.Add("hello");
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void When_Stack_Is_Created_Should_Be_Empty()
        {
            var stack = new MedyStack();
            Assert.IsTrue(stack.IsEmpty);
        }
        
        [TestMethod]
        public void When_Add_item_On_Empty_Stack_Should_Not_Be_Empty()
        {
            var stack = new MedyStack();
            stack.Add("hello");
            Assert.IsFalse(stack.IsEmpty);
        }

        [TestMethod]
        public void When_Remove_Element_on_Empty_Stack_Should_Do_Nothing()
        {
            var stack = new MedyStack();
            stack.Remove();
            Assert.IsTrue(true);
        }


        [TestMethod]
        public void When_Top_Stack_Should_Top_Return_Last_Element()
        {
            var stack = new MedyStack();
            stack.Add("hello");
            stack.Add("world");
            var item = stack.Top();
            Assert.AreEqual("world", item);
        }

        [TestMethod]
        public void When_Stack_Empty_Should_Top_Return_Null()
        {
            var stack = new MedyStack();
            Assert.IsNull(stack.Top());
        }

        [TestMethod()]
        public void When_Remove_Element_on_Stack_Should_Do_Nothing()
        {
            var stack = new MedyStack();
            stack.Add("hello");
            stack.Remove();
            Assert.IsTrue(true);
        }
    }
}
