using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Test
{
    [TestFixture]
    [Ignore("Ignore the Math fixture")]
    public class HtmlFormatterTests
    {
        
        [SetUp]
        public void SetUp()
        {
           
        }

        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("abc");
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.Contain("abc"));
            Assert.That(result, Does.EndWith("</strong>"));
        }

        

    }
}
