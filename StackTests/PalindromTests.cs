using NUnit.Framework;
using Stack;

namespace PalindromTests
{
    public class PalindromTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Palindrom_ANNA_True()
        {
            Assert.IsTrue(Palindrom.CheckPalindrom("ANNA"));
        }

        [Test]
        public void Palindrom_OTTO_True()
        {
            Assert.IsTrue(Palindrom.CheckPalindrom("OTTO"));
        }

        [Test]
        public void Palindrom_LAGERREGAL_True()
        {
            Assert.IsTrue(Palindrom.CheckPalindrom("LAGERREGAL"));
        }

        [Test]
        public void Palindrom_AARON_False()
        {
            Assert.IsFalse(Palindrom.CheckPalindrom("AARON"));
        }
    }
}