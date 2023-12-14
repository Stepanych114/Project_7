using Fibonacci;
using NUnit.Framework;
namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(Program.Fib(1)==1);
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(Program.Fib(6) == 8);
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(Program.Fib(12) == 144);
        }
    }
}