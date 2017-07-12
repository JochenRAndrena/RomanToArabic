using System.Collections.Generic;
using NUnit.Framework;
using RomanToArabic;

namespace RomanToArabicTest
{
    [TestFixture]
    public class TokenizerTest
    {
        private Tokenizer _tokenizer;

        [SetUp]
        public void Setup()
        {
            var possibleTokens = new List<string> {"I", "IV", "V"};
            _tokenizer = new Tokenizer(possibleTokens);
        }
        [Test]
        public void TokenizerWithPossibleTokensIAndIVAndV_TokenizeI_ReturnsListContainingOneElementI()
        {
            var tokens = _tokenizer.Tokenize("I");
            Assert.That(tokens.Count, Is.EqualTo(1));
            Assert.That(tokens.Contains("I"));
        }

        [Test]
        public void TokenizerWithPossibleTokensIAndIVAndV_TokenizeII_ReturnsListContainingTwoElementsIAndI()
        {
            var tokens = _tokenizer.Tokenize("II");
            Assert.That(tokens.Count, Is.EqualTo(2));
            Assert.That(tokens.Contains("I"));
        }

        [Test]
        public void TokenizerWithPossibleTokensIAndIVAndV_TokenizeIV_ReturnsListContainingOneElementIV()
        {
            var tokens = _tokenizer.Tokenize("IV");
            Assert.That(tokens.Count, Is.EqualTo(1));
            Assert.That(tokens.Contains("IV"));
        }

        [Test]
        public void TokenizerWithPossibleTokensIAndIVAndV_TokenizeV_ReturnsListContainingOneElementV()
        {
            var tokens = _tokenizer.Tokenize("V");
            Assert.That(tokens.Count, Is.EqualTo(1));
            Assert.That(tokens.Contains("V"));
        }

        [Test]
        public void TokenizerWithPossibleTokensIAndIVAndV_TokenizeC_Throws()
        {
            Assert.That(() => _tokenizer.Tokenize("C"), Throws.Exception);
        }
    }
}