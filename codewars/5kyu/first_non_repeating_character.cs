using System.Text;
using System.Collections.Generic;

public record Data
{
    public Data(bool isUpper, int count)
    {
        IsUpper = isUpper;
        Count = count;
    }

    public bool IsUpper { get; set; }
    public int Count { get; set; }
}

public class Kata
{


    public static string FirstNonRepeatingLetter(string s)
    {
        var map = new Dictionary<Rune, Data>();
        var runes = s.EnumerateRunes();
        foreach (var rune in runes)
        {
            var lower = Rune.ToLowerInvariant(rune);
            if (map.TryGetValue(lower, out _))
            {
                map[lower].Count++;
            }
            else
            {
                map.Add(lower, new Data(Rune.IsUpper(rune), 1));
            }
        }

        foreach (var rune in runes)
        {
            var lower = Rune.ToLowerInvariant(rune);
            if (map[lower].Count == 1)
            {
                return map[lower].IsUpper 
                  ? rune.ToString().ToUpperInvariant() 
                  : rune.ToString();
            }
        }

        return "";
    }
}
