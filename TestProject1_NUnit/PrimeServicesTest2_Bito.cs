using ConsoleApp2.src;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeServicesTest2_Bito
    {
        private PrimeService _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnsFalse()
        {
            bool result = _primeService.IsPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
        }

        [Test]
        public void IsPrime_InputIs2_ReturnsTrue()
        {
            bool result = _primeService.IsPrime(2);
            Assert.IsTrue(result, "2 should be prime");
        }

        [Test]
        public void IsPrime_InputIs4_ReturnsFalse()
        {
            bool result = _primeService.IsPrime(4);
            Assert.IsFalse(result, "4 should not be prime");
        }

        // Add more test cases as needed

        [Test]
        public void IsPrime_InputIsNegativeNumber_ReturnsFalse()
        {
            bool result = _primeService.IsPrime(-5);
            Assert.IsFalse(result, "Negative numbers should not be prime");
        }
    }
}