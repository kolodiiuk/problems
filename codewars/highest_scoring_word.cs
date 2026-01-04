public class Kata
{
    public static string High(string s)
    {
        var splitted = s.Split(" ");
        var max = 0;
        var maxIndex = 0;
        for (int i = 0; i < splitted.Length; ++i)
        {
            var score = 0;
            for (int j = 0; j < splitted[i].Length; ++j)
            {
                score += splitted[i][j] - 96;
            }

            if (score > max)
            {
                max = score;
                maxIndex = i;
            }
        }

        return splitted[maxIndex];
    }
}