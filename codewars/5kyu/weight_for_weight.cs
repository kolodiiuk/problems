using System;
using System.Collections.Generic;
using System.Text;

public class WeightSort 
{	
    public static string orderWeight(string strng) 
    {
        var splitted = new List<string>();
        var i = 0;
        while (i < strng.Length && strng[i] == ' ')
        {
            i++;
        }
        
        var currNum = new StringBuilder();
        for (; i < strng.Length; ++i)
        {
            if (strng[i] == ' ' && currNum.Length != 0)
            {
                splitted.Add(currNum.ToString());
                currNum = new StringBuilder();
            } 
            else if (strng[i] == ' ' && currNum.Length == 0)
            {
            }
            else 
            {
                currNum.Append(strng[i]);
            }
        }
        
        if (currNum.Length != 0)
        {
            splitted.Add(currNum.ToString());
        }
        
        splitted.Sort(new CustComparer());

        var res = new System.Text.StringBuilder();
        for (var j = 0; j < splitted.Count; ++j)
        {
            res.Append(splitted[j]).Append(' ');
        }

        return res.ToString().Trim();
    }
}

public class CustComparer : IComparer<string>
{
    public int Compare(string l, string r) 
    {
        int lInt = 0;
        for (int i = 0; i < l.Length; ++i)
        {
            lInt += l[i] - '0';
        }

        int rInt = 0;
        for (int i = 0; i < r.Length; ++i)
        {
            rInt += r[i] - '0';
        }

        if (lInt != rInt)
        {
            return lInt.CompareTo(rInt);
        }
        else
        {
            var cmp = lInt.CompareTo(rInt);
            if (cmp != 0)
            {
                return cmp;
            }

            return l.CompareTo(r);
        }
    }
}
