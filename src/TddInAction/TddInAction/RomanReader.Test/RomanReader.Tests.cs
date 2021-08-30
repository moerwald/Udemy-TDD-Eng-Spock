using NUnit.Framework;
using At.Moerwald.RomanReader;

namespace RomanReaderTest
{
    public class Tests
    {
        [Test]
        [TestCase(1, "I")]
        [TestCase(5, "V")]
        [TestCase(10, "X")]
        [TestCase(50, "L")]
        [TestCase(100, "C")]
        [TestCase(500, "D")]
        [TestCase(1000, "M")]
        [TestCase(2, "II")]
        [TestCase(20, "XX")]
        [TestCase(4, "IV")]
        [TestCase(9, "IX")]
        [TestCase(14, "XIV")]
        public void Test(int expected, string roman) =>
            Assert.AreEqual(expected, RomanReader.Parse(roman));
    }
}