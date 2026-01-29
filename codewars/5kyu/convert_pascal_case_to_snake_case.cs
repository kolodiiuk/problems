using System;
using System.Text;

public static class Kata
{
  public static string ToUnderscore(int str)
  {
      return str.ToString();
  }

  public static string ToUnderscore(string str)
  {
      bool notFirst = false;
      const int diff = 32;
      var sb = new StringBuilder();
      sb.Append((char)(str[0] + diff));

      for (int i = 1; i < str.Length; ++i)
      {
          if (char.IsUpper(str[i]))
          {
              var c = (char)(str[i] + diff);
              sb.Append($"_{c}");
          }
          else
          {
              sb.Append(str[i]);
          }
      }

      return sb.ToString();
  }
}
