#include <iostream>
#include <set>
#include <vector>
using namespace std;

class FinsDisappearedNumbersSolution {
public:
    vector<int> findDisappearedNumbers(vector<int>& nums) {
        set<int> set;
        for (int i = 1; i <= nums.size(); i++) {
            set.emplace(i);
        }

        for (auto it = nums.begin(); it != nums.end(); ++it) {
            if (set.contains(*it)) {
                set.erase(*it);
            }
        }

        vector<int> resultVector;
        for (int num : set) {
            resultVector.push_back(num);
        }
        return resultVector;
    }
};
