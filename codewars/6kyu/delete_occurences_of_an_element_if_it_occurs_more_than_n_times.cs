using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] DeleteNth(int[] arr, int x)
    {
        var map = new Dictionary<int, int>();
        var lst = new List<int>();
        for (int i = 0; i < arr.Length; ++i)
        {
            if (map.TryGetValue(arr[i], out var val))
            {
                if (val >= x) continue;
                lst.Add(arr[i]);
                map[arr[i]]++;
            }
            else
            {
                map.Add(arr[i], 1);
                lst.Add(arr[i]);
            }
        }

        return lst.ToArray();
    }
}
