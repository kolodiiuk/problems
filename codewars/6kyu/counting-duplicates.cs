using System;
using System.Collections.Generic;

public class Kata
{
    public static int DuplicateCount(string str)
    {
        var dict = new Dictionary<char, int>();
        var lowerStr = str.ToLower();
        var count = 0;
        foreach (var c in lowerStr)
        {
            if (dict.ContainsKey(c) && dict[c] == 1)
            {
                dict[c]++;
                count++;
            }
            else if (!dict.ContainsKey(c))
            {
                dict.TryAdd(c, 1);
            }
        }

        return count;
    }
}
