public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null) return null;

        var stack = new Stack<ListNode>();
        var currNode = head;
        while (currNode != null)
        {
            stack.Push(currNode);
            currNode = currNode.next;
        }

        var res = stack.Pop();
        var ptr = res;
        while (stack.Count != 0)
        {
            var node = stack.Pop();
            ptr.next = node;
            ptr = node;
        }

        ptr.next = null;

        return res;
    }
}
