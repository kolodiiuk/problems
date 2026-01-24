using System.Text.RegularExpressions;

public static class Kata
{
  public static int CountSmileys(string[] smileys)
  {
    if (smileys.Length == 0)
    {
        return 0;
    }

    var count = 0;
    foreach (var s in smileys)
    {
        if (Regex.IsMatch(s, @"^(:|;)(-|~){0,1}(\)|D)$"))
        {
            count++;
        }
    }

    return count;
  }
}
