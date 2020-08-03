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
            //��Cnode�����쩳�F
            if (l1 == null && l2 == null)
            {
                return null;
            }

            //�p�G���@��node�쩳
            //�N������u������node�������s�W�@�ӪŪ�node
            l1 ??= new ListNode(0);
            l2 ??= new ListNode(0);

            //node�ۥ[ �åB�O�d�l��
            var sum = l1.val + l2.val + addNumber;
            var resultNode = new ListNode(sum % 10);
            
            //���D��Cnode���쩳�~����
            if (l1.next != null || l2.next != null)
            {
                //��i�쪺��ƶǵ��U��node
                resultNode.next = AddListNodes(l1.next, l2.next, sum / 10);
            }

            //��Cnode���쩳�A���O�٦��i��
            if (sum >= 10 && resultNode.next == null)
            {
                resultNode.next = new ListNode(1);
            }

            return resultNode;
        }
    }
}