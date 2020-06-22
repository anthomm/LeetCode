using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.CustomTypes;
using LeetCode.Helpers;

namespace LeetCode.Easy.MergeLinked
{
    public static class MergeLinkedNaive
    {
        public static string Run(string left = "1 3 5 7 9", string right = "0 2 4 6 8")
        {
            ListNode leftLink = ListNodeHelper.StringToListNode(left);
            ListNode rightLink = ListNodeHelper.StringToListNode(right);
            
            ListNode result = MergeTwoLists(leftLink, rightLink);

            return ListNodeHelper.ListNodeToString(result);
        }
        public static ListNode MergeTwoLists(ListNode left, ListNode right)
        {
            ListNode sortedListHead = new ListNode();

            ListNode currentLeft = left;
            ListNode currentRight = right;
            ListNode currentSorted = sortedListHead;

            do
            {
                int localLeft = currentLeft == null ? int.MaxValue : currentLeft.Val;
                int localRight = currentRight == null ? int.MaxValue : currentRight.Val;

                if (localLeft <= localRight)
                {
                    currentSorted.Val = localLeft;
                    currentLeft = currentLeft.Next;
                }
                else
                {
                    currentSorted.Val = currentRight.Val;
                    currentRight = currentRight.Next;
                }
                
                if((currentLeft != null || currentRight != null)){
                    currentSorted.Next = new ListNode();
                    currentSorted = currentSorted.Next;
                }
            } while (currentLeft != null || currentRight != null);
            
            return sortedListHead;
        }
    }
}
