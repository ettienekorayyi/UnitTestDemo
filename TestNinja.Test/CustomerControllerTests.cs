using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Test
{
    [TestFixture]
    [Ignore("Ignore the Math fixture")]
    public class CustomerControllerTests
    {
        private CustomerController _customerController;

        [SetUp]
        public void SetUp()
        {
           _customerController = new CustomerController();
           //_id = 1;
        }

        [Test]
        public void GetCustomer_WhenCalled_ReturnNotFound()
        {
            var result = _customerController.GetCustomer(0);
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_WhenCalled_ReturnOk()
        {
            var result = _customerController.GetCustomer(1).GetType();
            Assert.That(result, Is.EqualTo(typeof(Ok)));
        }

    }
}
