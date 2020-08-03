namespace TwoNumbersTest
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return AddListNodes(l1, l2, 0);
        }

        private ListNode AddListNodes(ListNode l1, ListNode l2, int addNumber = 0)
        {
            //兩列node都走到底了
            if (l1 == null && l2 == null)
            {
                return null;
            }

            //如果有一個node到底
            //就給比較短的那個node的底部新增一個空的node
            l1 ??= new ListNode(0);
            l2 ??= new ListNode(0);

            //node相加 並且保留餘數
            var sum = l1.val + l2.val + addNumber;
            var resultNode = new ListNode(sum % 10);
            
            //除非兩列node都到底才停止
            if (l1.next != null || l2.next != null)
            {
                //把進位的位數傳給下個node
                resultNode.next = AddListNodes(l1.next, l2.next, sum / 10);
            }

            //兩列node都到底，但是還有進位
            if (sum >= 10 && resultNode.next == null)
            {
                resultNode.next = new ListNode(1);
            }

            return resultNode;
        }
    }
}