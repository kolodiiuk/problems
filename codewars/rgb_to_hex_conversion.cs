using System;

public class Kata
{
    public static string Rgb(int r, int g, int b)
    {
        var rStr = r switch
        {
            < 0 => "00",
            > 255 => "FF",
            _ => DecimalToHex(r)
        };

        var gStr = g switch
        {
            < 0 => "00",
            > 255 => "FF",
            _ => DecimalToHex(g)
        };

        var bStr = b switch
        {
            < 0 => "00",
            > 255 => "FF",
            _ => DecimalToHex(b)
        };

        return rStr + gStr + bStr;

        string DecimalToHex(int n)
        {
            Span<int> resInt = stackalloc int[2];
            resInt[0] = n / 16;
            resInt[1] = n % 16;
            var res = "";
            res += resInt[0] switch
            {
                15 => "F",
                14 => "E",
                13 => "D",
                12 => "C",
                11 => "B",
                10 => "A",
                _ => resInt[0].ToString()
            };

            res += resInt[1] switch
            {
                15 => "F",
                14 => "E",
                13 => "D",
                12 => "C",
                11 => "B",
                10 => "A",
                _ => resInt[1].ToString()
            };

            return res;
        }
    }
}
