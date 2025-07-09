#include <cmath>
#include <vector>

int FindOutlier(std::vector<int> arr)
{
    for (int i = 0, j = 1, k = 2; k < arr.size(); i++, j++, k++) {
        if (abs(arr[i]) % 2 == abs(arr[j]) % 2 && abs(arr[i]) % 2 != abs(arr[k]) % 2) {
            return arr[k];
        }
        if (abs(arr[i]) % 2 == abs(arr[k]) % 2 && abs(arr[i]) % 2 != abs(arr[j]) % 2) {
            return arr[j];
        }
        if (abs(arr[k]) % 2 == abs(arr[j]) % 2 && abs(arr[i]) % 2 != abs(arr[k]) % 2) {
            return arr[i];
        }
    }
}
