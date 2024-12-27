using NUnit.Framework.Interfaces;

namespace TestProjectt
{
    [TestFixture]
    public class TaskTests
    {
        [Test]
        public void TestAbs()
        {
            AssertionResult.Equals(0, Task.Abs(0));
            AssertionResult.Equals(1, Task.Abs(-1));
        }

        [Test]
        public void TestSqrt()
        {
            AssertionResult.Equals(0, Task.Sqrt(0));
            AssertionResult.Equals(1, Task.Sqrt(1));
        }
        [Test]
        public void TestSqrtArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Task.Sqrt(-1));
        }

        [Test]
        public void TestTaylorSin()
        {
            AssertionResult.Equals(0.0, Task.TaylorSin(0));
            AssertionResult.Equals(1.0, Task.TaylorSin(Math.PI / 2));
        }

        [Test]
        public void TestTaylorCos()
        {
            AssertionResult.Equals(1.0, Task.TaylorCos(0));
            AssertionResult.Equals(0.0, Task.TaylorCos(Math.PI / 2));
        }

        [Test]
        public void TestTaylorLn()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Task.TaylorLn(0));
            Assert.Throws<ArgumentOutOfRangeException>(() => Task.TaylorLn(-1));
            Assert.That(Task.TaylorLn(1), Is.EqualTo(0.0));
        }

        [Test]
        public void TestMyFunctionForNonPositiveX()
        {
            AssertionResult.Equals(0.0, Task.MyFunction(0.2));
            double result = Task.MyFunction(-4);
            Assert.IsTrue(result > 0);
        }

        [Test]
        public void TestMyFunctionForPositiveX()
        {
            AssertionResult.Equals(double.NaN, Task.MyFunction(1)); 
            AssertionResult.Equals(double.NaN, Task.MyFunction(Math.PI)); 
        }
    }
}
