using NUnit.Framework;
using Lab1;

namespace Tests
{
    [TestFixture]
    public class Program_IsProgramShould
    {
        [Test]
        public void Check_InputIs5_ReturnTrue()
        {
            var result = Program.Check("5");
            Assert.AreEqual(result, true);
        }
        
    }
}