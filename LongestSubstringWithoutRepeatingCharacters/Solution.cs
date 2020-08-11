using System.Collections.Generic;
using System.Linq;

namespace LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var characters = new List<char>();
            
            foreach (var character in s)
            {
                var find = characters.Find(x => x == character);
                if (find != character)
                {
                    characters.Add(character);
                }
            }

            return characters.Count;
        }
    }
}