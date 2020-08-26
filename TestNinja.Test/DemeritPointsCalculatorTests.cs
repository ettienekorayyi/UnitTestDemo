using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Test
{
    [TestFixture]
    //[Ignore("Ignore the Math fixture")]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _demeritPointsCalculator;
        
        [SetUp]
        public void SetUp()
        {
           _demeritPointsCalculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(-1)]
        [TestCase(500)]
        public void CalculateDemeritPoints_WhenCalled_ReturnArgumentOutOfRangeException(int speed)
        {
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => _demeritPointsCalculator.CalculateDemeritPoints(speed));
            Assert.That(result, Is.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0)]
        public void CalculateDemeritPoints_SpeedLessThanSpeedLimit_ReturnZero(int speed)
        {
            var result =  _demeritPointsCalculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(speed));
        }

    }
}
