using NUnit.Framework;
using RomanToArabic;

namespace RomanToArabicTest
{
    [TestFixture]
    public class RomanToArabicTest
    {
        private Converter _converter;

        [SetUp]
        public void SetUp()
        {
            _converter = new Converter();
        }

        [Test]
        public void Converter_ConvertI_Returns1()
        {
            Assert.That(_converter.Convert("I"), Is.EqualTo(1));
        }

        [Test]
        public void Converter_ConvertII_Returns2()
        {
            Assert.That(_converter.Convert("II"), Is.EqualTo(2));
        }

        [Test]
        public void Converter_ConvertIII_Returns3()
        {
            Assert.That(_converter.Convert("III"), Is.EqualTo(3));
        }
    }
}
