class Solution {
    public int findMaxConsecutiveOnes(int[] nums) {
                int consCount = 0;
        int temp = 0;

        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == 1) {
                temp++;
            }
            else if (nums[i] == 0 && temp != 0) {
                if (temp > consCount) {
                    consCount = temp;
                    temp = 0;
                }
                else {
                    temp = 0;
                }
            }
        }

        return (temp > consCount) ? temp : consCount;
    }
}
