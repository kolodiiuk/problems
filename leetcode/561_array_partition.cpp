#include <vector>
#include <algorithm>
using namespace std;

class Solution {
public:
    int arrayPairSum(vector<int>& nums) {
        sort(nums.begin(), nums.end());
        int sum = 0;
        for (int i = nums.size() - 1; i > 0; i -= 2) {
            sum += nums[i - 1];
        }

        return sum;
    }
};
