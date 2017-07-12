using System;
using System.Collections.Generic;
using System.Linq;
using RomanToArabic.Extensions;

namespace RomanToArabic
{
    public class Tokenizer
    {
        private readonly List<string> _tokens;

        public Tokenizer(List<string> tokens)
        {
            _tokens = tokens;
        }

        private List<string> Tokens
        {
            get { return _tokens; }
        }


        public List<string> Tokenize(string s)
        {
            if (s.Length == 0)
            {
                return new List<string>();
            }
            var matchingTokens = ComputeMatchingTokens(s);
            if (!matchingTokens.HasUniqueLongestElement())
                throw new ArgumentException("can not tokenize " + s);

            var longestMatch = matchingTokens.GetLongestElement();
            return new List<string> {longestMatch}.Concat(TokenizeRemainingString(s, longestMatch)).ToList();
        }

        private List<string> TokenizeRemainingString(string s, string longestMatchingToken)
        {
            return Tokenize(s.Substring(longestMatchingToken.Length));
        }

        private List<string> ComputeMatchingTokens(string s)
        {
            var matchingTokens = new List<string>();

            foreach (var token in Tokens)
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