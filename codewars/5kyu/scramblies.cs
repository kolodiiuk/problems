using System;
public class Scramblies
{

    public static bool Scramble(string str1, string str2)
    {
        int[] freq = new int[26];

        for (int i = 0; i < str1.Length; ++i)
        {
            freq[str1[i] - 97]++;
        }

        for (int i = 0; i < str2.Length; ++i)
        {
            freq[str2[i] - 97]--;
        }

        for (int i = 0; i < 26; ++i)
        {
            if (freq[i] < 0) return false;
        }

       return true;
    }

}
