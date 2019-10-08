using NUnit.Framework;
using Lab1;

namespace Tests
{
    [TestFixture]
    public class SingleOp_IsSingleOpShould
    {
        [Test]
        public void Sqrt_InputIs4_Return2()
        {
            SingleOp op = new SingleOp();
            var result = op.Sqrt(4);
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void Increment_InputIs4_Return5()
        {
            SingleOp op = new SingleOp();
            var result = op.Increment(4);
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void Decrement_InputIs4_Return3()
        {
            SingleOp op = new SingleOp();
            var result = op.Decrement(4);
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void Abs_InputIsMinus4_Return4()
        {
            SingleOp op = new SingleOp();
            var result = op.Abs(-4);
            Assert.AreEqual(result, 4);
        }
        [Test]
        public void Fact_InputIs4_Return24()
        {
            SingleOp op = new SingleOp();
            var result = op.Fact(4);
            Assert.AreEqual(result, 24);
        }
    }

}