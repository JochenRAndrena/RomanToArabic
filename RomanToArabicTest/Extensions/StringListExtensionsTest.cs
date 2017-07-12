using System.Collections.Generic;
using NUnit.Framework;
using RomanToArabic.Extensions;

namespace RomanToArabicTest.Extensions
{
    [TestFixture()]
    public class StringListExtensionsTest
    {
        [Test]
        public void GetLongestElement_ListWithIAndIIAndIII_returnsIII()
        {
            var list = new List<string> {"I", "II", "III"};
            Assert.That(list.GetLongestElement(), Is.EqualTo("III"));
        }

        [Test]
        public void GetLongestElement_ListWithIAndX_ThrowsException()
        {
            var list = new List<string> { "I", "X" };
            Assert.That(() => list.GetLongestElement(), Throws.Exception);
        }

        [Test]
        public void GetLongestElement_EmplyList_ThrowsException()
        {
            var list = new List<string>();
            Assert.That(() => list.GetLongestElement(), Throws.Exception);
        }

        [Test]
        public void GetLongestElements_EmplyList_ReturnsEmptyList()
        {
            var list = new List<string>();
            Assert.That(list.GetLongestElements().Count, Is.EqualTo(0));
        }

        [Test]
        public void GetLongestElements_ListWithIIAndXXAndC_ReturnsListWithIIAndXX()
        {
            var list = new List<string> {"II", "XX", "C"};
            Assert.That(list.GetLongestElements(), Contains.Item("II"));
            Assert.That(list.GetLongestElements(), Contains.Item("XX"));
            Assert.That(list.GetLongestElements().Count, Is.EqualTo(2));
        }

        [Test]
        public void HasUniqueLongestElement_ListWithIIAndXXAndC_ReturnsFalse()
        {
            var list = new List<string> { "II", "XX", "C" };
            Assert.That(list.HasUniqueLongestElement, Is.EqualTo(false));
        }

        [Test]
        public void HasUniqueLongestElement_EmplyList_ReturnsFalse()
        {
            var list = new List<string>();
            Assert.That(list.HasUniqueLongestElement(), Is.EqualTo(false));
        }

        [Test]
        public void HasUniqueLongestElement_ListWithIAndIIAndIII_ReturnsTrue()
        {
            var list = new List<string> { "I", "II", "III" };
            Assert.That(list.HasUniqueLongestElement(), Is.EqualTo(true));
        }
    }
}