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
            var firstInput = new ListNode()
            {
                val = 2,
                next = new ListNode()
                {
                    val = 4,
                    next = new ListNode()
                    {
                        val = 3,
                        next = null
                    }
                }
            };

            var secondInput = new ListNode()
            {
                val = 5,
                next = new ListNode()
                {
                    val = 6,
                    next = new ListNode()
                    {
                        val = 4,
                        next = null
                    }
                }
            };

            var actual = _solution.AddTwoNumbers(firstInput, secondInput);


            var expected = new ListNode()
            {
                val = 7,
                next = new ListNode()
                {
                    val = 0,
                    next = new ListNode()
                    {
                        val = 8,
                        next = null
                    }
                }
            };

            expected.ToExpectedObject().ShouldMatch(actual);
        }
    }
}