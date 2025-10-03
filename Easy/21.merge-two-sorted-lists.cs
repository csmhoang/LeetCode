/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

// public class ListNode(int val = 0, ListNode next = null!)
// {
//     public int val = val;
//     public ListNode next = next;
// }
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var list = new ListNode();
        var cur = list;
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                cur.next = list1;
                list1 = list1.next;
            }
            else
            {
                cur.next = list2;
                list2 = list2.next;
            }
            cur = cur.next;
        }
        cur.next = list1 ?? list2 ?? null!;
        return list.next;
    }
}
// @lc code=end

