public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0 || nums.Length == 1 && nums[0] == val)
        {
            return 0;
        }

        int count = 0;
        for (int i = 0, j = nums.Length - 1; i < nums.Length && i <= j;)
        {
            if (nums[i] == val)
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                j--;
            }

            if (nums[i] != val)
            {
                i++;
                count++;
            }
        }

        return count;
    }
}
