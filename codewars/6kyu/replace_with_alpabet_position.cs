public static class Kata
{
  private const int _start = 'a' - 1; 
  
  public static string AlphabetPosition(string text)
  {
     var res = text.ToLowerInvariant();
     var sb = new System.Text.StringBuilder();
     foreach (var c in res) 
     {
       if (c >= 'a' && c <= 'z') 
       {
          sb.Append(c - _start).Append(' ');
       }
     }
    
      return sb.ToString().Trim();
  }
}
