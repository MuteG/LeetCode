/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode mergedNode = null;
        ListNode currentNode = null;
        while (l1 != null || l2 != null)
        {
            if (l1 == null)
            {
                if (currentNode == null)
                {
                    mergedNode = l2;
                }
                else
                {
                    currentNode.next = l2;
                }
                break;
            }
            if (l2 == null)
            {
                if (currentNode == null)
                {
                    mergedNode = l1;
                }
                else
                {
                    currentNode.next = l1;
                }
                break;
            }
            int val;
            if (l1.val <= l2.val)
            {
                val = l1.val;
                l1 = l1.next;
            }
            else
            {
                val = l2.val;
                l2 = l2.next;
            }
            if (mergedNode == null)
            {
                mergedNode = new ListNode(val);
                currentNode = mergedNode;
            }
            else
            {
                currentNode.next = new ListNode(val);
                currentNode = currentNode.next;
            }
        }
        return mergedNode;
    }
}

