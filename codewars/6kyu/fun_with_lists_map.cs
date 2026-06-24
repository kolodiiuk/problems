using System;

class Kata
{
    public static Node<T2> Map<T, T2>(Node<T> head, Func<T, T2> f)
    {
        if (head == null)
        {
            return null;
        }

        var nHead = new Node<T2>(f(head.data));
        var oHead = head;
        var res = nHead;
        while (oHead.next != null)
        {
            oHead = oHead.next;
            var node = new Node<T2>(f(oHead.data));
            nHead.next = node;
            nHead = node;
        }

        return res;
    }
}
