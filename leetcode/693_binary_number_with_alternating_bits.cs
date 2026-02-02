public class Solution
{
    public bool HasAlternatingBits(int n)
    {
        var xor = n ^ (n >> 1);
        var f = xor & (xor + 1);

        return f == 0;
    }
}
