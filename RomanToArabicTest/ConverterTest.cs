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

        [Test]
        public void Converter_ConvertIV_Returns4()
        {
            Assert.That(_converter.Convert("IV"), Is.EqualTo(4));
        }

        [Test]
        public void Converter_ConvertV_Returns5()
        {
            Assert.That(_converter.Convert("V"), Is.EqualTo(5));
        }

        [Test]
        public void Converter_ConvertVI_Returns6()
        {
            Assert.That(_converter.Convert("VI"), Is.EqualTo(6));
        }

        [Test]
        public void Converter_ConvertIX_Returns9()
        {
            Assert.That(_converter.Convert("IX"), Is.EqualTo(9));
        }

        [Test]
        public void Converter_ConvertX_Returns10()
        {
            Assert.That(_converter.Convert("X"), Is.EqualTo(10));
        }

        [Test]
        public void Converter_ConvertXXIV_Returns24()
        {
            Assert.That(_converter.Convert("XXIV"), Is.EqualTo(24));
        }

        [Test]
        public void Converter_ConvertXL_Returns40()
        {
            Assert.That(_converter.Convert("XL"), Is.EqualTo(40));
        }

        [Test]
        public void Converter_ConvertXLII_Returns42()
        {
            Assert.That(_converter.Convert("XLII"), Is.EqualTo(42));
        }

        [Test]
        public void Converter_ConvertL_Returns9()
        {
            Assert.That(_converter.Convert("L"), Is.EqualTo(50));
        }
    }
}
