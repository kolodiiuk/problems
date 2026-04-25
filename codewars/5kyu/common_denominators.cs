using System;

public class Fracts
{
    public static string convertFrac(long[,] lst)
    {
        var set = new System.Collections.Generic.HashSet<long>();
        for (int i = 0; i < lst.GetLength(0); i++)
        {
            long n = lst[i, 0];
            long num = lst[i, 0];
            long denom = lst[i, 1];
            while (n >= 1)
            {
                if (denom % n == 0 && num % n == 0)
                {
                    lst[i, 0] = num / n;
                    lst[i, 1] = denom / n;
                    break;
                }

                n--;
            }

            set.Add(lst[i, 1]);
        }

        var currLcm = 1L;
        foreach (var n in set)
        {
            currLcm = Math.Abs(currLcm / GCD(currLcm, n) * n);
        }

        var sb = new System.Text.StringBuilder();
        for (int i = 0; i < lst.GetLength(0); ++i)
        {
            var t = lst[i, 0] * (currLcm / lst[i, 1]);
            sb.Append($"({t},{currLcm})");
        }
        
        return sb.ToString();

        long GCD(long a, long b)
        {
            while (b != 0)
            {
                long t = b;
                b = a % b;
                a = t;
            }

            return a;
        }
    }
}
