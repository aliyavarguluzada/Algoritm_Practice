namespace C_.Leetcode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public static class MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode newList = new ListNode();
            ListNode tail = newList;

            while (list1 != null && list2 != null)
            {

                if (list1.val <= list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list2;
                    list2 = list2.next;
                }
                tail = tail.next;
            }
            if (list1 is null)
            {
                tail.next = list2;
            }
            else
            {
                tail.next = list1;
            }
            return newList.next;
        }
    }
}
