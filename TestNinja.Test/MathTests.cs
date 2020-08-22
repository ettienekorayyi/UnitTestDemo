using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Test
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            var result = _math.Add(10, 30);
            Assert.That(result, Is.EqualTo(40));
        }

        [Test]
        public void Max_FirstArgumentIsHigherThanSecondArgument_ReturnFirstArgument()
        {
            var result = _math.Max(50, 30);
            Assert.That(result, Is.EqualTo(50));
        }

        [Test]
        public void Max_SecondArgumentIsHigherThanFirstArgument_ReturnFirstArgument()
        {
            var result = _math.Max(-50, -30);
            Assert.That(result, Is.EqualTo(-30));
        }

        [Test]
        public void GetOddNumbers_WhenCalled_ReturnOddNumbers()
        {
            int[] oddNumbers = new int[] { 1,3,5,7,9 };
            var result = _math.GetOddNumbers(10);
            Assert.That(result, Is.EquivalentTo(oddNumbers));
        }

    }
}
