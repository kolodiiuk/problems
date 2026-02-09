public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        var dict = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; ++i)
        {
            if (!dict.ContainsKey(s[i]) && !dict.ContainsValue(t[i]))
            {
                dict.Add(s[i], t[i]);
            }

            var res = dict.TryGetValue(s[i], out var tEquivalent);
            if (!res || tEquivalent != t[i])
            {
                return false;
            }
        }

        return true;
    }
}
