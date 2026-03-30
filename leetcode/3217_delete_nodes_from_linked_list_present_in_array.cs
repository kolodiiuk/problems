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

public class Solution 
{
    public ListNode ModifiedList(int[] nums, ListNode head) 
    {
        var set = nums.ToHashSet();
        var t = head;
        while (set.Contains(t.val) && t.next != null) 
        {
            t = t.next;
        }

        head = t;
        ListNode prev = t;
        while (t.next != null)
        {
            if (!set.Contains(t.val)) 
            {
                prev = t;
                t = t.next;
                continue;
            }

            prev.next = t.next;
            t = t.next;
        }

        if  (set.Contains(t.val))
        {
            prev.next = null;
        }

        return head;
    }
}
