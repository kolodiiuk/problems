#include <vector>

class Solution {
public:
    int arraySign(std::vector<int>& nums) {
        int c = 0;
        for (int i = 0; i < nums.size(); i++) {
            if (nums[i] < 0) c++;
            else if (nums[i] == 0) return 0;
        }
        return c % 2 == 0 ? 1 : -1;;
    }
};
