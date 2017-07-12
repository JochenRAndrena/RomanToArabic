using System;
using System.Collections.Generic;
using System.Linq;
using RomanToArabic.Extensions;

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
            try
            {
                if (s.Length == 0)
                {
                    return new List<string>();
                }
                var matchingTokens = ComputeMatchingTokens(s);
                var longestMatch = matchingTokens.GetLongestElement();

                return new List<string> {longestMatch}.Concat(TokenizeRemainingString(s, longestMatch)).ToList();
            }
            catch (Exception)
            {
                throw new ArgumentException("can not tokenize " + s);
            }
        }

        private List<string> TokenizeRemainingString(string s, string longestMatchingToken)
        {
            return Tokenize(s.Substring(longestMatchingToken.Length));
        }

        private List<string> ComputeMatchingTokens(string s)
        {
            var matchingTokens = new List<string>();

            foreach (var token in _tokens)
            {
                if (s.StartsWith(token))
                {
                    matchingTokens.Add(token);
                }
            }
            return matchingTokens;
        }
    }
}