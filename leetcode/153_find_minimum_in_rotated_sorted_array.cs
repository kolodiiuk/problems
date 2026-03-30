public class Solution 
{
    public int FindMin(int[] nums) 
    {
        var min = nums[0];
        var left = 0;
        var right = nums.Length - 1;
        var mid = (right - left) /  2;
        while (left <= right) 
        {
            mid = left + (right - left) / 2;

            if (nums[mid] >= min) 
            {
                left = mid + 1;
            }
            else if (nums[mid] < min) 
            {
                min = nums[mid];
                right = mid - 1;
            }
            else 
            {
                return min;
            }
        }

        return min;
    }
}
