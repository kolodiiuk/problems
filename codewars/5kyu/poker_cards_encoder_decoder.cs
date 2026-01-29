using System;
using System.Collections.Generic;

public static class Kata
{
    private const string Map = "A23456789TJQK";

    public static int[] Encode(string[] cards)
    {
        var res = new int[cards.Length];
        var map = new Dictionary<char, int>() {
          ['A'] = 0,
          ['2'] = 1,
          ['3'] = 2,
          ['4'] = 3,
          ['5'] = 4,
          ['6'] = 5,
          ['7'] = 6,
          ['8'] = 7,
          ['9'] = 8,
          ['T'] = 9,
          ['J'] = 10,
          ['Q'] = 11,
          ['K'] = 12
        };
        for (int i = 0; i < cards.Length; ++i)
        {
            var suit = cards[i][1] switch {
                'c' => 0,
                'd' => 13,
                'h' => 26,
                _ => 39
            };

            res[i] = map[cards[i][0]] + suit;
        }

        Array.Sort(res);

        return res;
    }

    public static string[] Decode(int[] cards)
    {
        Array.Sort(cards);
        var res = new string[cards.Length];

        for (int i = 0; i < cards.Length; ++i)
        {
            var card = Map[cards[i] % 13];
            var suit = cards[i] switch
            {
                >= 0  and < 13 => 'c',
                >= 13 and < 26 => 'd',
                >= 26 and < 39 => 'h',
                _ => 's'
            };

            res[i] = $"{card}{suit}";
        }

        return res;
    }
}
