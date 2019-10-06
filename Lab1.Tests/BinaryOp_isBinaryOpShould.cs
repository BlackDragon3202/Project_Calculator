using NUnit.Framework;
using Lab1;

namespace Tests
{
    [TestFixture]
    public class SingleOp_IsBinaryOpOpShould
    {
        [Test]
        public void Add_InputIs3And2_Return5()
        {
            BinaryOp op = new BinaryOp();
            var result = op.Add(3, 2);
            Assert.AreEqual(result, 5);
        }
        [Test]
        public void Div_InputIs6And2_Return3()
        {
            BinaryOp op = new BinaryOp();
            var result = op.Div(6, 2);
            Assert.AreEqual(result, 3);
        }
        
        [Test]
        public void Minus_InputIs5And2_Return3()
        {
            BinaryOp op = new BinaryOp();
            var result = op.Minus(5, 2);
            Assert.AreEqual(result, 3);
        }
        [Test]
        public void Mult_InputIs55And20_Return1100()
        {
            BinaryOp op = new BinaryOp();
            var result = op.Mult(55, 20);
            Assert.AreEqual(result, 1100);
        }
        /*
        More tests
        */
    }
}