using System;
using System.Collections.Generic;

namespace LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var longestString = new HashSet<char>();
            var charArray = s.ToCharArray();
            var leftBound = 0;
            var rightBound = 0;
            var maxStringLength = 0;
            var stringLength = 0;

            while (rightBound < s.Length)
            {
                var c = charArray[rightBound];

                if (longestString.Add(c))
                {
                    stringLength++;
                    maxStringLength = Math.Max(maxStringLength, stringLength);
                }
                else
                {
                    while (charArray[leftBound]!=charArray[rightBound])
                    {
                        longestString.Remove(charArray[leftBound]);
                        leftBound++;
                        stringLength--;
                    }

                    //���䪺�r���w�g����k�䪺�r��
                    //������Эn���k1��
                    leftBound++;
                }

                rightBound++;
            }

            return maxStringLength;
        }
    }
}