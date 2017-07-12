using System.Collections.Generic;

namespace RomanToArabicTest
{
    public class Tokenizer
    {
        private List<string> _tokens;

        public Tokenizer(List<string> tokens)
        {
            this._tokens = tokens;
        }
        

        public List<string> Tokenize(string s)
        {
            foreach (var token in _tokens)
            {
                if (s.StartsWith(token))
                {
                    var result = Tokenize(s.Substring(token.Length));
                    result.Add(token);
                    return result;
                }
            }
            return new List<string>();
        }
    }
}