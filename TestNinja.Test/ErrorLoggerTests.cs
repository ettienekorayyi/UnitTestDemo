using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Test
{
    [TestFixture]
    [Ignore("Ignore the Math fixture")]
    public class ErrorLoggerTests
    {
        
        [SetUp]
        public void SetUp()
        {
           
        }

        [Test]
        public void Log_WhenCalled_ShouldSetLogErrorProperty()
        {
            var logger = new ErrorLogger();
            logger.Log("a");
            
            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_WhenCalled_ShouldThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();

            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }
        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();
            var id = Guid.Empty;

            logger.ErrorLogged += (sender, args) => { id = args; };
            logger.Log("a");
            
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
