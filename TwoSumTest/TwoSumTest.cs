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


        [Test]
        public void Test2()
        {
            int[] nums = {3, 2, 4};
            var target = 6;

            var twoSum = new TwoSum();
            var sum = twoSum.GetResult(nums, target);

            int[] expected = {1, 2};

            Assert.AreEqual(expected, sum);
        }
    }
}