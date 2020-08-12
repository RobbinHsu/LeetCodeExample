using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var characters = new StringBuilder();
            var maxString = string.Empty;

            foreach (var character in s)
            {
                if (characters.ToString().Contains(character))
                {
                    if (characters.Length>maxString.Length)
                    {
                        maxString = characters.ToString();
                    }

                    characters.Clear();
                    characters.Append(character);
                }
                else
                {
                    characters.Append(character);
                }
            }

            return maxString.Length;
        }
    }
}