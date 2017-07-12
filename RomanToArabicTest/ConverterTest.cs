using NUnit.Framework;
using RomanToArabic;

namespace RomanToArabicTest
{
    [TestFixture]
    public class RomanToArabicTest
    {
        [Test]
        public void Converter_ConvertI_Returns1()
        {
            var converter = new Converter();
            Assert.That(converter.Convert("I"), Is.EqualTo(1));
        }

        [Test]
        public void Converter_ConvertII_Returns2()
        {
            var converter = new Converter();
            Assert.That(converter.Convert("II"), Is.EqualTo(2));
        }
    }
}
