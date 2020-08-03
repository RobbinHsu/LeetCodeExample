namespace TwoNumbersTest
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var sumValue = 0;
            var carryValue = 0;

            //指標節點
            var pointNode = new ListNode(0);
            //將指標節點的記憶體指給結果節點
            var resultNode = pointNode;

            while (l1 != null || l2 != null || carryValue > 0)
            {
                sumValue = 0;

                if (l1 != null)
                {
                    sumValue += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sumValue += l2.val;
                    l2 = l2.next;
                }

                sumValue += carryValue;

                //指標節點新增節點
                //結果節點因為也是同一個記憶體位址  所以也相同於在結果節點上新增節點
                pointNode.next = new ListNode(sumValue % 10);

                //如果有進位  就先儲存於欄位
                carryValue = (sumValue / 10);

                //指標節點移動到下一個節點(剛剛新增的那個)
                pointNode = pointNode.next;
            }

            //回傳結果節點
            //因為初始節點為0  所以從下一個開始
            return resultNode.next;
        }
    }
}