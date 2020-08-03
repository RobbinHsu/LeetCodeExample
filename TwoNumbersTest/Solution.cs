namespace TwoNumbersTest
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var sumValue = 0;
            var carryValue = 0;

            //���и`�I
            var pointNode = new ListNode(0);
            //�N���и`�I���O����������G�`�I
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

                //���и`�I�s�W�`�I
                //���G�`�I�]���]�O�P�@�ӰO�����}  �ҥH�]�ۦP��b���G�`�I�W�s�W�`�I
                pointNode.next = new ListNode(sumValue % 10);

                //�p�G���i��  �N���x�s�����
                carryValue = (sumValue / 10);

                //���и`�I���ʨ�U�@�Ӹ`�I(���s�W������)
                pointNode = pointNode.next;
            }

            //�^�ǵ��G�`�I
            //�]����l�`�I��0  �ҥH�q�U�@�Ӷ}�l
            return resultNode.next;
        }
    }
}