using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanToArabic.Extensions
{
    public static class StringListExtensions
    {
        public static string GetLongestElement(this List<string> list)
        {
            return GetLongestElements(list).Single(); ;
        }

        public static List<string> GetLongestElements(this List<string> list)
        {
            var maxLength = 0;
            var longestStrings = new List<string>();
            list.ForEach(str =>
            {
                if (str.Length > maxLength)
                {
                    maxLength = str.Length;
                    longestStrings = new List<string> { str };
                }
                else if (str.Length == maxLength)
                {
                    longestStrings.Add(str);
                }
            });
            return longestStrings;
        }
    }
}