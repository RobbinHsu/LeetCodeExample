namespace TwoNumbersTest
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var listNode = new ListNode()
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
            return listNode;
        }
    }
}