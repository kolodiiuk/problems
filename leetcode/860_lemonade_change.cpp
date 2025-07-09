#include <vector>

using namespace std;

class Solution {
public:
    bool lemonadeChange(vector<int>& bills) {
        int c[2];
        for (int i = 0; i < 2; i++) c[i] = 0;
        for (int i = 0; i < bills.size(); i++){
            if (bills[i] == 5) {
                c[0]++;
            }
            else if (bills[i] == 10) {
                if (c[0] == 0) {
                    return false;
                }
                c[1]++;
                c[0]--;
            }
            else {
                if (c[0] == 0 || c[1] == 0 && c[0] == 0 || c[0] < 3 && c[1] == 0) {
                    return false;
                }
                if (c[1] != 0 && c[0] != 0) {
                    c[0]--;
                    c[1]--;
                }
                else if (c[0] >= 3) {
                    c[0] -=3;
                }
            }
        }

        return true;
    }
};