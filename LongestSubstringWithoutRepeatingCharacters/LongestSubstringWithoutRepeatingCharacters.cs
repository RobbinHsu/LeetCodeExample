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

        [Test]
        public void Test2()
        {
            var input = " ";

            var actual = _solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Test3()
        {
            var input = "";

            var actual = _solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Test4()
        {
            var input = "au";

            var actual = _solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(2, actual);
        }


        [Test]
        public void Test5()
        {
            var input = "dvdf";

            var actual = _solution.LengthOfLongestSubstring(input);

            Assert.AreEqual(3, actual);
        }

    }
}