using System.Collections.Generic;
using System.Threading;

namespace RomanToArabic
{
    public class Converter
    {
        private Dictionary<string, int> _tokens;

        public Converter()
        {
            _tokens = new Dictionary<string, int>
            {
                {"I", 1},
                {"IV", 4},
                {"V", 5 }
            };
        }


        public int Convert(string s)
        {
            if (_tokens.ContainsKey(s))
                return _tokens[s];
            return s.Length;
        }
    }
}