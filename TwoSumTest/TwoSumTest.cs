using NUnit.Framework;

namespace TwoSumTest
{
    public class TwoSumTest
    {
        private int[] _actual;
        private int[] _nums;
        private int _target;
        private TwoSum _twoSum;

        [SetUp]
        public void Setup()
        {
            _twoSum = new TwoSum();
        }


        [Test]
        public void Test1()
        {
            GivenInput(new[] {2, 7, 11, 15}, 9);

            GetTwoSum();

            ShouldBeEqual(new[] {0, 1});
        }


        [Test]
        public void Test2()
        {
            GivenInput(new[] {3, 2, 4}, 6);

            GetTwoSum();

            ShouldBeEqual(new[] {1, 2});
        }

        private void ShouldBeEqual(int[] expected)
        {
            Assert.AreEqual(expected, _actual);
        }

        private void GivenInput(int[] nums, int target)
        {
            _nums = nums;
            _target = target;
        }

        private void GetTwoSum()
        {
            _actual = _twoSum.GetResult(_nums, _target);
        }
    }
}