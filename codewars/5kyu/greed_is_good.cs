using System;

public static class Kata
{
    public static int Score(int[] dice)
    {
        int[] freq = new int[6];
        for (int i = 0; i < dice.Length; ++i)
        {
            freq[dice[i] - 1]++;
        }

        int score = 0;
        if (freq[5] >= 3)
        {
            score += 600;
        }

        if (freq[3] >= 3)
        {
            score += 400;
        }

        if (freq[2] >= 3)
        {
            score += 300;
        }

        if (freq[1] >= 3)
        {
            score += 200;
        }

        if (freq[0] >= 3)
        {
            score += 1000;
            freq[0] -= 3;
        }

        if (freq[4] >= 3)
        {
            score += 500;
            freq[4] -= 3;
        }

        if (freq[0] >= 1)
        {
            score += 100 * freq[0];
        }

        if (freq[4] >= 1)
        {
            score += 50 * freq[4];
        }

        return score;
    }
}
