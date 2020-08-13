using NUnit.Framework;

namespace LongestSubstringWithoutRepeatingCharacters
{
    public class LongestSubstringWithoutRepeatingCharactersTest
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
            ShouldBeEqual("abcabcbb", 3);
        }

        [Test]
        public void Test3()
        {
            ShouldBeEqual("abcdcbb", 4);
        }

        [Test]
        public void Test2()
        {
            ShouldBeEqual("pwwkew", 3);
        }

        private void ShouldBeEqual(string input, int expected)
        {
            var actual = _solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(expected, actual);
        }
    }
}