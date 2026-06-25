using System;
using System.Text;

public static class Kata
{
  public static string ReverseWords(string str)
  {
    var sb = new StringBuilder();
    var split = str.Split(' ');
    var len = str.Length;
    int i = 0;
    while (i < len)
    {
      var temp = new StringBuilder();
      while (i < len && str[i] != ' ')
      {
        temp.Append(str[i]);
        i++;
      }
      
      var reversed = Reverse(temp.ToString());
      sb.Append(reversed);
      if (i < len && str[i] == ' ')
      {
        var spaces = new StringBuilder();
        while (i < len && str[i] == ' ')
        {
          spaces.Append(' ');
          i++;
        }
        
        sb.Append(spaces.ToString());
      }
    }
    
    return sb.ToString();
  }
  
  private static string Reverse(string str)
  {
    int i = 0;
    int j = str.Length - 1;
    char[] arr = str.ToCharArray();
    while (i < j)
    {
      (arr[i], arr[j]) = (arr[j], arr[i]);
      i++;
      j--;
    }
    
    return new string(arr);
  }
}
