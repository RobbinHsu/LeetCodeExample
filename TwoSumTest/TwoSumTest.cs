using NUnit.Framework;

namespace TwoSumTest
{
    public class TwoSumTest
    {
        [Test]
        public void Test1()
        {
            int[] nums = {2, 7, 11, 15};
            var target = 9;

            var twoSum = new TwoSum();
            var sum = twoSum.GetResult(nums, target);

            int[] expected = {0, 1};

            Assert.AreEqual(expected, sum);
        }
    }
}