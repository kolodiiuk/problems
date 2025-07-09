#include <limits>
#include <vector>
using namespace std;
class Solution {
public:
    int thirdMax(vector<int>& nums) {
        int maxA[3];
        for (int i = 0; i < 3; i++) {
            maxA[i] = std::numeric_limits<int>::min();
        }
        if (nums.size() == 2) {
            return max(nums[0], nums[1]);
        }
        if (nums.size() == 1) {
            return nums[0];
        }
        int f = 0;
        for (int i = 0; i < nums.size(); i++) {
            if (nums[i] == std::numeric_limits<int>::min()) f = 1;
            if (nums[i] > maxA[0]) {
                maxA[2] = maxA[1];
                maxA[1] = maxA[0];
                maxA[0] = nums[i];
            }
            else if (nums[i] > maxA[1] & nums[i] != maxA[0]) {
                maxA[2] = maxA[1];
                maxA[1] = nums[i];
            }
            else if (nums[i] > maxA[2] & nums[i] != maxA[1] & nums[i] != maxA[0]) {
                maxA[2] = nums[i];
            }
        }
        if (f) {
            if (maxA[2] == maxA[1]) return maxA[0];
            if (maxA[2] == std::numeric_limits<int>::min()) return maxA[2];
        }
        if (maxA[2] == std::numeric_limits<int>::min()) {
            return maxA[0];
        }
        
        return maxA[2];
    }
};
