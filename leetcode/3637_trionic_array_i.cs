public class Solution
{
    public bool IsTrionic(int[] nums)
    {
        if (nums.Length == 3) return false;
        int p = 0;
        for (; p < nums.Length - 1; ++p)
        {
            if (!(nums[p] < nums[p + 1]))
            {
                break;
            }
        }

        if (p == 0)
        {
            return false;
        }

        int q = p;
        for (; q < nums.Length - 1; ++q)
        {
            if (!(nums[q] > nums[q + 1]))
            {
                break;
            }
        }

        if (q == nums.Length - 1)
        {
            return false;
        }

        for (; q < nums.Length - 1; ++q)
        {
            if (!(nums[q] < nums[q + 1]))
            {
                break;
            }
        }

        return q == nums.Length - 1;
    }
}
