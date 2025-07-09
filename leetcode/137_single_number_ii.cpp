#include <algorithm>
#include <vector>
using namespace std;
class Solution {
public:
    int singleNumber(vector<int>& nums) {
        sort(nums.begin(), nums.end());
        for (int i = 0, j = 1, k = 2; k < nums.size(); i += 3, j += 3, k += 3) {
            if (nums[i] ^ nums[j] | nums[i] ^ nums[k] | nums[j] ^ nums[k]) {
                if (nums[i] == nums[j] && nums[i] != nums[k]) {
                    return nums[k];
                }
                if (nums[i] == nums[k] && nums[i] != nums[j]) {
                    return nums[j];
                }
                else {
                    return nums[i];
                }
            }
        }
        
        return nums[nums.size() - 1];
    }
};
