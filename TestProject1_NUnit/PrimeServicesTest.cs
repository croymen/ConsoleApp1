using ConsoleApp2;
using ConsoleApp2.src;
using NUnit.Framework;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeServicesTest
    {
        private PrimeService _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService?.IsPrime(value);

            Assert.That(result, Is.False, $"{value} should not be prime");
        }

        [TestCase(7)]
        [TestCase(11)]
        [TestCase(17)]
        public void IsPrime_ReturnTrue(int value)
        {
            var result = _primeService?.IsPrime(value);

            Assert.That(result, Is.True, $"{value} should not be prime");
        }
    }
}