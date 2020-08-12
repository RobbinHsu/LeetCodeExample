using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var charArray = s.ToCharArray();
            var stringLength = 0;
            var index = 0;
            var longestWord = new Dictionary<char, int>();

            while (index < charArray.Length)
            {
                var c = charArray[index];

                if (longestWord.ContainsKey(c))
                {
                    stringLength = Math.Max(stringLength, longestWord.Count);
                    index = longestWord[c];
                    longestWord.Clear();
                }
                else
                {
                    longestWord.Add(c, index);
                }

                index++;
            }

            return Math.Max(stringLength, longestWord.Count);
        }
    }
}