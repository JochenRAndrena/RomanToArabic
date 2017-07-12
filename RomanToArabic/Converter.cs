using System.Collections.Generic;
using System.Threading;

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
                {"V", 5 }
            };
        }


        public int Convert(string romanNumber)
        {
            if (_romanDigits.ContainsKey(romanNumber))
                return _romanDigits[romanNumber];
            return romanNumber.Length;
        }
    }
}