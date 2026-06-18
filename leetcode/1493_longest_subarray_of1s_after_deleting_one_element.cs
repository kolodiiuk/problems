public class Solution {
    public int LongestSubarray(int[] nums) {
        var subarraysCounts = new List<int>();
        var windowL = 0;
        while (windowL < nums.Length && nums[windowL] == 0) {
            windowL++;
        }
Console.WriteLine("hello");
        for (int i = 0; i < nums.Length;) {
            while (i < nums.Length && nums[i] == 1) {
                i++;
                continue;
            }
            if (i == nums.Length) break;

            int j = windowL;
            for (; j < nums.Length; ++j) {
                if (j == i) continue;
                if (nums[j] == 0) break;
            }

            int count = j - windowL;
            subarraysCounts.Add(count);
            Console.WriteLine(i);
            i++;
        }

        if (subarraysCounts.Count == 0) {
            return nums.Length - 1;
        }

        return subarraysCounts.Max();
    }
}