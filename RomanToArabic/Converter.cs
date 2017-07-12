using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Xml;

namespace RomanToArabic
{
    public class Converter
    {
        private readonly Dictionary<string, int> _romanDigits;

        public Converter()
        {
            _romanDigits = new Dictionary<string, int>
            {
                {"I", 1},
                {"IV", 4},
                {"V", 5 },
                {"IX", 9 },
                {"X", 10 },
                {"XL", 40 },
                {"L", 50 },
                {"XC", 90 },
                {"C", 100 },
                {"CD", 400 },
                {"D", 500 },
                {"CM", 900 },
                {"M", 1000 },
            };
        }


        public int Convert(string romanNumber)
        {
            var tokenizer = new Tokenizer(_romanDigits.Keys.ToList());
            var tokens = tokenizer.Tokenize(romanNumber);

            var arabicNumber = 0;
            tokens.ForEach(token => arabicNumber+= _romanDigits[token]);
            return arabicNumber;
        }

    }
}