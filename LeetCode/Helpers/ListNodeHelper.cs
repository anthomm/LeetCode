using LeetCode.CustomTypes;
using System;
using System.Linq;
using System.Text;

namespace LeetCode.Helpers
{
    public static class ListNodeHelper
    {
        public static ListNode StringToListNode(string input)
        {
            if (input.Length == 0)
                return new ListNode();

            ListNode head = new ListNode();

            int[] ints = input.Split(" ").Select(n => Convert.ToInt32(n)).ToArray();

            ListNode current = head;
            current.Val = ints[0];

            for (int i = 1; i < ints.Length; i++)
            {
                ListNode next = new ListNode(ints[i]);
                current.Next = next;
                current = next;
            }

            return head;
        }

        public static string ListNodeToString(ListNode input)
        {
            StringBuilder sb = new StringBuilder();

            ListNode current = input;

            do
            {
                sb.Append(current.Val + " ");
                current = current.Next;
            } while (current != null);

            return sb.ToString().Trim();
        }
    }
}
