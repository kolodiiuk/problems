using System.Linq;
using System.Collections.Generic;

public class HumanTimeFormat
{
    private const int SecondsMinutes = 60;

    private const int SecondsHours = SecondsMinutes * 60;

    private const int SecondsDays = SecondsHours * 24;

    private const int SecondsYear = SecondsDays * 365;

    public static string formatDuration(int seconds)
    {
        if (seconds == 0)
        {
            return "now";
        }

        var res1 = "";

        var yearCount = seconds / SecondsYear;
        var dayCountInS = seconds % SecondsYear;

        var dayCount = dayCountInS / SecondsDays;
        var hourCountInS = dayCountInS % SecondsDays;

        var hourCount = hourCountInS / SecondsHours;
        var minCountInS = hourCountInS % SecondsHours;

        var minCount = minCountInS / SecondsMinutes;
        var secCount = minCountInS % SecondsMinutes;

        var resDic = new Dictionary<int, string>();
        if (yearCount != 0)
        {
            var plural = yearCount == 1 ? "year" : "years";
            resDic.Add(0, $"{yearCount} {plural}");
        }

        if (dayCount != 0)
        {
            var plural = dayCount == 1 ? "day" : "days";
            resDic.Add(1, $"{dayCount} {plural}");
        }

        if (hourCount != 0)
        {
            var plural = hourCount == 1 ? "hour" : "hours";
            resDic.Add(2, $"{hourCount} {plural}");
        }

        if (minCount != 0)
        {
            var plural = minCount == 1 ? "minute" : "minutes";
            resDic.Add(3, $"{minCount} {plural}");
        }

        if (secCount != 0)
        {
            var plural = secCount == 1 ? "second" : "seconds";
            resDic.Add(4, $"{secCount} {plural}");
        }

        if (resDic.Count == 1) return resDic.Values.FirstOrDefault();
        int i = 4;
        for (; i >= 0; i--)
        {
            if (resDic.ContainsKey(i))
            {
                resDic[i] = $" and {resDic[i]}";
                break;
            }
        }

        bool isFirstConcatenated = false;
        for (int j = 0; j < 5; j++)
        {
            if (resDic.ContainsKey(j) && j != i && !isFirstConcatenated)
            {
                res1 += $"{resDic[j]}";
                isFirstConcatenated = true;
            }
            else if (resDic.ContainsKey(j) && j != i)
            {
                res1 += $", {resDic[j]}";
            }
        }

        res1 += resDic[i];

        return res1;
    }
}
