using System.Text;

public class Kata
{
  public static string Rot13(string message)
  {
      var sb = new StringBuilder();
      foreach (var c in message)
      {
          sb.Append(GetRotatedChar(c));
      }

      return sb.ToString();
  }

    private static char GetRotatedChar(char c)
    {
        const string lRotated = "nopqrstuvwxyzabcdefghijklm";
        const string uRotated = "NOPQRSTUVWXYZABCDEFGHIJKLM";
        if (c >= 97 && c <= 122)
        {
            return lRotated[c - 97];
        }

        if (c >= 65 && c <= 90)
        {
            return uRotated[c - 65];
        }

        return c;
    }
}
