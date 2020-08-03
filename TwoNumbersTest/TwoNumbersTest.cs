using ExpectedObjects;
using NUnit.Framework;

namespace TwoNumbersTest
{
    public class TwoNumbers
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
            var firstInput = new ListNode(2, new ListNode(4, new ListNode(3)));

            var secondInput = new ListNode(5, new ListNode(6, new ListNode(4)));

            var actual = _solution.AddTwoNumbers(firstInput, secondInput);


            var expected = new ListNode(7, new ListNode(0, new ListNode(8)));

            expected.ToExpectedObject().ShouldMatch(actual);
        }
    }
}