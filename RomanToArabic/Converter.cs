using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanToArabic
{
    public class Converter
    {
        private readonly Dictionary<string, int> _romanDigits = new Dictionary<string, int>
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
            {"M", 1000 }
        };

        private Dictionary<string, int> RomanDigits
        {
            get { return _romanDigits; }
        }


        public int Convert(string romanNumber)
        {
            var tokenizer = new Tokenizer(RomanDigits.Keys.ToList());
            try
            {
                var tokens = tokenizer.Tokenize(romanNumber.Trim());
                var arabicNumber = 0;
                tokens.ForEach(token => arabicNumber += RomanDigits[token]);
                return arabicNumber;
            }
            catch (Exception)
            {
                throw new ArgumentException("Can not convert " + romanNumber + " to an arabic number");
            }

            
        }

    }
}