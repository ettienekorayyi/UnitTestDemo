using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Test
{
    [TestFixture]
    [Ignore("Ignore the FizzBuzz fixture")]
    public class FizzBuzzTests
    {
        private int _number;
        

        [SetUp]
        public void SetUp()
        {
            _number = 0;
        }

        [Test]
        public void GetOutput_ArgumentIsDivisibleBy3_ReturnsFizz()
        {
            _number = 3;
            string result = FizzBuzz.GetOutput(_number);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_ArgumentIsDivisibleBy5_ReturnsBuzz()
        {
            _number = 5;
            string result = FizzBuzz.GetOutput(_number);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_ArgumentIsDivisibleBy3And5_ReturnsFizzBuzz()
        {
            _number = 15;
            string result = FizzBuzz.GetOutput(_number);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_ArgumentIsNotDivisibleBy3And5_ReturnsNumberAsString()
        {
            _number = 1;
            string result = FizzBuzz.GetOutput(_number);
            Assert.That(result, Is.EqualTo("1"));
        }
    }
}