public static class Kata
{
    public static long RowSumOddNumbers(long n)
    {
        var startNum = n * n - n + 1;
        var res = startNum;
        var next = startNum;

        for (int i = 0; i < n - 1; ++i)
        {
            next += 2;
            res += next;
        }

        return res;
    }
}
