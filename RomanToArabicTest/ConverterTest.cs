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
        public void Convert_I_Returns1()
        {
            Assert.That(_converter.Convert("I"), Is.EqualTo(1));
        }

        [Test]
        public void Convert_II_Returns2()
        {
            Assert.That(_converter.Convert("II"), Is.EqualTo(2));
        }

        [Test]
        public void Convert_III_Returns3()
        {
            Assert.That(_converter.Convert("III"), Is.EqualTo(3));
        }

        [Test]
        public void Convert_IV_Returns4()
        {
            Assert.That(_converter.Convert("IV"), Is.EqualTo(4));
        }

        [Test]
        public void Convert_V_Returns5()
        {
            Assert.That(_converter.Convert("V"), Is.EqualTo(5));
        }

        [Test]
        public void Convert_VI_Returns6()
        {
            Assert.That(_converter.Convert("VI"), Is.EqualTo(6));
        }

        [Test]
        public void Convert_IX_Returns9()
        {
            Assert.That(_converter.Convert("IX"), Is.EqualTo(9));
        }

        [Test]
        public void Convert_X_Returns10()
        {
            Assert.That(_converter.Convert("X"), Is.EqualTo(10));
        }

        [Test]
        public void Convert_XXIV_Returns24()
        {
            Assert.That(_converter.Convert("XXIV"), Is.EqualTo(24));
        }

        [Test]
        public void Convert_XL_Returns40()
        {
            Assert.That(_converter.Convert("XL"), Is.EqualTo(40));
        }

        [Test]
        public void Convert_XLII_Returns42()
        {
            Assert.That(_converter.Convert("XLII"), Is.EqualTo(42));
        }

        [Test]
        public void Convert_L_Returns9()
        {
            Assert.That(_converter.Convert("L"), Is.EqualTo(50));
        }

        [Test]
        public void Convert_XC_Returns90()
        {
            Assert.That(_converter.Convert("XC"), Is.EqualTo(90));
        }

        [Test]
        public void Convert_C_Returns100()
        {
            Assert.That(_converter.Convert("C"), Is.EqualTo(100));
        }

        [Test]
        public void Convert_CD_Returns400()
        {
            Assert.That(_converter.Convert("CD"), Is.EqualTo(400));
        }

        [Test]
        public void Convert_D_Returns500()
        {
            Assert.That(_converter.Convert("D"), Is.EqualTo(500));
        }

        [Test]
        public void Convert_CM_Returns900()
        {
            Assert.That(_converter.Convert("CM"), Is.EqualTo(900));
        }

        [Test]
        public void Convert_M_Returns1000()
        {
            Assert.That(_converter.Convert("M"), Is.EqualTo(1000));
        }

        [Test]
        public void Convert_MCMLXXXVII_Returns1987()
        {
            Assert.That(_converter.Convert("MCMLXXXVII "), Is.EqualTo(1987));
        }

        [Test]
        public void Convert_InvalidNumber_ThrowsException()
        {
            Assert.That(() => _converter.Convert("XG"), Throws.Exception);
        }
    }
}
