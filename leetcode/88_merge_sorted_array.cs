public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (m == 0)
        {
            Array.Copy(nums2, 0, nums1, 0, n);
            return;
        }

        int insPos = nums1.Length - 1;
        int nums2Largest = n - 1;
        for (int nums1Largest = m - 1;
             insPos >= 0 && nums1Largest >= 0 && nums2Largest >= 0;
             --insPos)
        {
            if (nums2[nums2Largest] > nums1[nums1Largest])
            {
                nums1[insPos] = nums2[nums2Largest--];
            }
            else if (nums2[nums2Largest] < nums1[nums1Largest])
            {
                nums1[insPos] = nums1[nums1Largest--];
            }
            else
            {
                nums1[insPos] = nums1[nums1Largest--];
            }
        }

        while (insPos >= 0 && nums2Largest >= 0)
        {
            nums1[insPos--] = nums2[nums2Largest--];
        }
    }
}
