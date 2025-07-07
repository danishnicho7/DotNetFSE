using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Init()
        {
            _calculator = new Calculator();
        }

        [TearDown]
        public void Cleanup()
        {
            _calculator = null;
        }

        [TestCase(2, 3, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, -2, -3)]
        public void Add_WhenCalled_ReturnsExpectedSum(int a, int b, int expected)
        {
            var result = _calculator.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
