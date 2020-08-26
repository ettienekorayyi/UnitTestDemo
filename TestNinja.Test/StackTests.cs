using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Test
{
    [TestFixture]
    //[Ignore("Ignore the Math fixture")]
    public class StackTests
    {
        private Stack<string> _stack;

        [SetUp]
        public void SetUp()
        {
           _stack = new Stack<string>();
        }

        [Test]
        [TestCase(null)]
        public void Push_NullArgument_ShouldThrowArgumentNullException(string args)
        {
            Assert.That(() => _stack.Push(args), Throws.ArgumentNullException);
        }

        [Test]
        [TestCase("stv")]
        public void Push_StringArgument_ShouldAddToStack(string args)
        {
            _stack.Push(args);
            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_ListIsEmpty_ShouldThrowInvalidOperationException()
        {
            var result = Assert.Throws<InvalidOperationException>(() => _stack.Pop());
            Assert.That(result, Is.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Pop_StringArgument_ShouldRemoveItemToStack()
        {
            _stack.Push("stv");
            _stack.Push("o");

            var result = _stack.Pop();
            Assert.That(result, Is.EqualTo("o"));
        }

        [Test]
        public void Peek_WhenCalled_ShouldThrowInvalidOperationException()
        {
            var result = Assert.Throws<InvalidOperationException>(() => _stack.Peek());
            Assert.That(result, Is.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Peek_WhenCalled_ShouldReturnTheTopMostValueOfTheStack()
        {
            _stack.Push("stv");
            _stack.Push("o");

            var result = _stack.Peek();
            Assert.That(result, Is.EqualTo("o"));
        }
    }
}
