using System;
using System.Collections.Generic;


public static class Kata
{
    public static int DescendingOrder(int num)
    {
        var chars = new List<char>();
        int remainder = 0;
        while (num != 0)
        {
            remainder = num % 10;
            chars.Add((char)(remainder + 48));
            num /= 10;
        }

        chars.Sort((a, b) => {
            if (a > b)
            {
                return -1;
            } else if (a < b)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        });
        int res = 0;
        for (int i = chars.Count - 1, n = 0; i >= 0; i--, n++)
        {
            res += (chars[i] - 48) * (int)Math.Pow(10, n);
        }

        return res;
    }
}