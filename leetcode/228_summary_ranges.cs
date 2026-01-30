public class Solution {
    public IList<string> SummaryRanges(int[] nums)
    {
        var list = new List<string>();
        if (nums.Length == 0)
        {
            return list;
        }

        int start = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i + 1 == nums.Length || nums[i] + 1 != nums[i + 1])
            {
                if (start == i)
                {
                    list.Add(nums[start].ToString());
                }
                else
                {
                    list.Add($"{nums[start]}->{nums[i]}");
                }
                start = i + 1;
            }
        }

        return list;
    }
}
