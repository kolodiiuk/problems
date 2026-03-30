public class Solution 
{
    public int[] Intersection(int[] nums1, int[] nums2) 
    {
        var countLookup = new int[1001];
        var arrayLookup = new bool[1001];
        for (int i = 0; i < nums1.Length; ++i)
        {
            if (countLookup[nums1[i]] == 0)
            {
                countLookup[nums1[i]]++;
                arrayLookup[nums1[i]] = true;
            }
        }

        var res = new HashSet<int>();
        for (int i = 0; i < nums2.Length; ++i)
        {
            if (arrayLookup[nums2[i]]) 
            {
                res.Add(nums2[i]);
            }
        }

        return res.ToArray();
    }
}
