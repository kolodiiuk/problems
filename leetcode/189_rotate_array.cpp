#include <algorithm>
#include <vector>

using namespace std;

class Solution {
public:
    void rotate(vector<int>& nums, int k) {
        k = k % nums.size();
        reverse(nums.end() - k, nums.end());
        reverse(nums.begin(), nums.end() - k);
        reverse(nums.begin(), nums.end());
        // for (int t = 0; k > 0; k--) {
        //     t = nums[nums.size() - 1];
        //     for (int j = nums.size() - 1; j > 0; j--) {
        //         nums[j] = nums[j - 1];
        //     }
        //     nums[0] = t;
        // }
    }
};
