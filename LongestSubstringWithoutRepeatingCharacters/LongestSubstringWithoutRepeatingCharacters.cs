using NUnit.Framework;

namespace LongestSubstringWithoutRepeatingCharacters
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        private Solution _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new Solution();
        }

        [Test]
        public void Test1()
        {
            var input = "abcabcbb";

            var actual = _solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(3, actual);
        }
    }
}