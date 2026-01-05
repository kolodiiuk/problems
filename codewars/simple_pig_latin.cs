public class Kata
{
    public static string PigIt(string str)
    {
        var splitted = str.Split(" ");
        if (splitted.Length == 0)
        {
            return str;
        }

        var res = new StringBuilder();
        for (int i = 0; i < splitted.Length - 1; i++)
        {
            if (char.IsLetter(splitted[i][0]))
            {
                var substr = $"{splitted[i][1..]}{splitted[i][0]}ay";
                res.Append(substr).Append(' ');
            }
            else
            {
                res.Append(splitted[i]).Append(' ');
            }
        }

        if (char.IsLetter(splitted[splitted.Length - 1][0]))
        {
            var substr = $"{splitted[splitted.Length - 1][1..]}{splitted[splitted.Length - 1][0]}ay";
            res.Append(substr);
        }
        else
        {
            res.Append(splitted[^1]);
        }

        return res.ToString();
    }
}
