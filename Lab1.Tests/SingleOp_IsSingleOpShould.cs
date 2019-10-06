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