public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var lookup = new Dictionary<int, int>();
        for (int i = 0; i < nums2.Length; ++i)
        {
            lookup.Add(nums2[i], i);
        }

        int[] res = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; ++i)
        {
            lookup.TryGetValue(nums1[i], out var index);
            var nums1i = nums1[i];
            for (int j = index + 1; j < nums2.Length; ++j)
            {
                if (nums2[j] > nums1i)
                {
                    res[i] = nums2[j];
                    break;
                }
            }

            if (res[i] == 0)
            {
                res[i] = -1;
            }
        }

        return res;
    }
}
