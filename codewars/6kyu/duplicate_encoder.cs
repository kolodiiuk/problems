public class Kata
{
  public static string DuplicateEncode(string word)
  {
    var freq = new System.Collections.Generic.Dictionary<char, int>();
    var normalized = word.ToUpper();

    for (int i = 0; i < normalized.Length; ++i)
    {
        if (!freq.ContainsKey(normalized[i])) {
            freq.Add(normalized[i], 1);
        }
        else
        {
             freq[normalized[i]]++;
        }
    }

    var sb = new System.Text.StringBuilder();
    for (int i = 0; i < normalized.Length; ++i)
    {
        if (freq[normalized[i]] == 1)
        {
            sb.Append('(');
        }
        else
        {
            sb.Append(')');
        }
    }

    return sb.ToString();
  }
}
