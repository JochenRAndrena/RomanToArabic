using System.Collections.Generic;
using System.Linq;

namespace RomanToArabic
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
            var possibleTokens = new List<string>();
            
            foreach (var token in _tokens)
            {
                if (s.StartsWith(token))
                {
                    possibleTokens.Add(token);
                }
            }
            var longestMatchingTokens = ComputeLongestTokens(possibleTokens);

            if (longestMatchingTokens.Count == 1)
            {
                var token = longestMatchingTokens.First();
                var result = Tokenize(s.Substring(token.Length));
                result.Add(token);
                return result;
            }
            
            return new List<string>();
        }

        private List<string> ComputeLongestTokens(List<string> tokens)
        {
            var maxLength = 0;
            var longestTokens = new List<string>();
            tokens.ForEach(token =>
            {
                if (token.Length > maxLength)
                {
                    maxLength = token.Length;
                    longestTokens = new List<string> {token};
                }
                else if (token.Length == maxLength)
                {
                    longestTokens.Add(token);
                }
            });
            return longestTokens;
        }
    }
}