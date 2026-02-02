public class Solution
{
    public int Search(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length - 1;
        int mid = r / 2;
        while (l <= r)
        {
            if (nums[mid] < target)
            {
                l = mid + 1;
                mid = (r + l) / 2;
            }
            else if (nums[mid] > target)
            {
                r = mid -1;
                mid = (r + l) / 2;
            }
            else
            {
                return mid;
            }
        }

        return -1;
    }
}
