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
            var possibleTokens = new List<string> {"I", "IV"};
            _tokenizer = new Tokenizer(possibleTokens);
        }
        [Test]
        public void TokenizerWithPossibleTokensIAndIV_TokenizeI_ReturnsListContainingOneElementI()
        {
            var tokens = _tokenizer.Tokenize("I");
            Assert.That(tokens.Count, Is.EqualTo(1));
            Assert.That(tokens.Contains("I"));
        }

        [Test]
        public void TokenizerWithPossibleTokensIAndIV_TokenizeII_ReturnsListContainingTwoElementsIAndI()
        {
            var tokens = _tokenizer.Tokenize("II");
            Assert.That(tokens.Count, Is.EqualTo(2));
            Assert.That(tokens.Contains("I"));
        }

        [Test]
        public void TokenizerWithPossibleTokensIAndIV_TokenizeIV_ReturnsListContainingOneElementIV()
        {
            var tokens = _tokenizer.Tokenize("IV");
            Assert.That(tokens.Count, Is.EqualTo(1));
            Assert.That(tokens.Contains("IV"));
        }
    }
}