

using NUnit.Framework;   // NUnit
using CA1Animals;        // your app project

namespace CA1Animals.Tests
{
    [TestFixture]
    public class ValidatorTests
    {
        [Test]
        public void IsYesNo_Y_ReturnsTrue()
        {
            var result = Validators.IsYesNo("y");
            Assert.That(result.HasValue && result.Value, Is.True);
        }

        [Test]
        public void IsYesNo_No_ReturnsFalse()
        {
            var result = Validators.IsYesNo("No");
            Assert.That(result.HasValue && result.Value, Is.False);
        }

        [Test]
        public void IsYesNo_Invalid_ReturnsNull()
        {
            var result = Validators.IsYesNo("maybe");
            Assert.That(result.HasValue, Is.False);
        }

        [Test]
        public void TryInt_WithDigits_ReturnsTrueAndNumber()
        {
            int n;
            bool ok = Validators.TryInt("123", out n);
            Assert.That(ok, Is.True);
            Assert.That(n, Is.EqualTo(123));
        }

        [Test]
        public void TryInt_WithLetters_ReturnsFalse()
        {
            int n;
            bool ok = Validators.TryInt("abc", out n);
            Assert.That(ok, Is.False);
        }
    }
}
