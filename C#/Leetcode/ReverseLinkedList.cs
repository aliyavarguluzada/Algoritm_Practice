﻿namespace C_.Leetcode
{
    public static class ReverseLinkedList
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
        public static ListNode ReverseList(ListNode head)
        {
            if (head is null) return head;

            ListNode curr = head;
            ListNode prev = null;
            ListNode next = null;

            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;

                prev = curr;
                curr = next;

            }
            return prev;
        }
    }
}

