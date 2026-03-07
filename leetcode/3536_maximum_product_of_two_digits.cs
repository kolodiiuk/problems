public class Solution 
{
    public int MaxProduct(int n) 
    {
        var digits = new int[10];
        var t = n;
        while (t != 0) 
        {
            digits[t % 10]++; 
            t = t / 10;
        }

        var currMax = 128;
        for (int j = 9; j >= 1; j--) 
        {
            if (digits[j] == 0) continue;
            if (currMax == 128) 
            {
                if (digits[j] == 1) 
                {
                    currMax = j;
                    continue;
                }

                if (digits[j] >= 2) 
                {
                    return j * j;
                }
            }
            else 
            {
                return currMax * j;
            }
        }

        return 0;
    }
}
