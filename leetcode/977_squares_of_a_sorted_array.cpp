#include <vector>

class Solution
{
public:
    std::vector<int> sortedSquares(std::vector<int> &nums)
    {
        int nonNegativeIndex = 0;
        while (nums[nonNegativeIndex] < 0 && nonNegativeIndex < nums.size() - 1) nonNegativeIndex++;

        std::vector<int> res = {};
        int negativeIndex = nonNegativeIndex - 1;
        for (negativeIndex; negativeIndex >= 0 && nonNegativeIndex < nums.size();)
        {
            int neg = nums[negativeIndex];
            int pos = nums[nonNegativeIndex];
            if (-neg < pos)
            {
                res.emplace_back(neg * neg);
                negativeIndex--;
            } else
            {
                res.emplace_back(pos * pos);
                nonNegativeIndex++;
            }
        }

        if (nums.size() != res.size())
        {
            if (nonNegativeIndex == nums.size())
            {
                while (negativeIndex >= 0)
                {
                    res.emplace_back(nums[negativeIndex] * nums[negativeIndex]);
                    negativeIndex--;
                }
            }
            else
            {
                while (nonNegativeIndex < nums.size())
                {
                    res.emplace_back(nums[nonNegativeIndex] * nums[nonNegativeIndex]);
                    nonNegativeIndex++;
                }
            }
        }

        return res;
    }
};
