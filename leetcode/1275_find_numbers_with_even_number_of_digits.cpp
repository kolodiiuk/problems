#include <vector>

using namespace std;

class Solution {
public:
    int findNumbers(vector<int>& nums) {
        int res = 0;
        for (size_t i = 0; i < nums.size(); ++i) {
            int lc = 0;
            int currNum = nums[i];
            while (currNum >= 1) {
                currNum /= 10;
                lc++;
            }

            res += lc % 2 == 0;
        }

        return res;
    }
};
