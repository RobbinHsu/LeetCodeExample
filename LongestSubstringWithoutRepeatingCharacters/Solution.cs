using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var characters = new HashSet<char>();

            foreach (var character in s)
            {
                characters.Add(character);
            }

            return characters.Count;
        }
    }
}