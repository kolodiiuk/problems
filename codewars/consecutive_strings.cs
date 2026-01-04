using System.Text;

public class LongestConsecutives
{
    public static string LongestConsec(string[] strarr, int k)
    {
        if (k <= 0 || strarr.Length == 0 || k > strarr.Length) return "";

        var res = new StringBuilder();
        var curr = 0;
        var currFirstIndex = 0;
        for (int i = 0; i <= strarr.Length - k; ++i)
        {
            var consecLength = 0;
            for (int j = i; j < i + k; j++)
            {
                consecLength += strarr[j].Length;
            }

            if (consecLength > curr)
            {
                curr = consecLength;
                currFirstIndex = i;
            }
        }

        for (int i = currFirstIndex; i < currFirstIndex + k; i++)
        {
            res.Append(strarr[i]);
        }

        return res.ToString();
    }
}
