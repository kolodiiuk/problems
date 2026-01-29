using System.Text;

namespace Converter {
  public class Converter
  {
    public string dnaToRna(string dna)
    {
      var sb = new StringBuilder();
      foreach (var c in dna)
      {
        var nc = c;
        if (c == 'T') nc = 'U';
        sb.Append(nc);
      }

      return sb.ToString();
    }
  }
}
