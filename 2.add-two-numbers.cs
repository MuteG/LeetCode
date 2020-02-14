/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode result = null;
        ListNode currentNode = null;
        while (l1 != null || l2 != null)
        {
            int val = 0;
            if (l1 != null)
            {
                val += l1.val;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                val += l2.val;
                l2 = l2.next;
            }

            if (currentNode == null)
            {
                currentNode = new ListNode(val);
                result = currentNode;
            }
            else
            {
                if (currentNode.val >= 10)
                {
                    currentNode.val -= 10;
                    currentNode.next = new ListNode(val + 1);
                }
                else
                {
                    currentNode.next = new ListNode(val);
                }

                currentNode = currentNode.next;
            }
        }

        if (currentNode.val >= 10)
        {
            currentNode.val -= 10;
            currentNode.next = new ListNode(1);
        }

        return result;
    }
}

