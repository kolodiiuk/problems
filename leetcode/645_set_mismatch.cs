namespace DefaultNamespace;

public class Solution {
    public int[] FindErrorNums(int[] nums) {
        var res = new int[2];
        var lookup = new bool[nums.Length + 1];
        lookup[nums[0]] = true;
        for (int i = 1; i < nums.Length; ++i) {
            if (lookup[nums[i]]) {
                res[0] = nums[i];
            }

            lookup[nums[i]] = true;
        }

        for (int i = 1; i < lookup.Length; ++i) {
            if (!lookup[i]) {
                res[1] = i;
                return res;
            }
        }

        return res;
    }
}
