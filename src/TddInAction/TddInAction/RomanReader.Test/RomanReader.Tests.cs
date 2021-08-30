using NUnit.Framework;
using At.Moerwald.RomanReader;

namespace RomanReaderTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.That(1.Equals(RomanReader.Parse("II")));
        }
    }
}