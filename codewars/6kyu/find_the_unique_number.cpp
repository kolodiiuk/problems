#include <vector>

float find_uniq(const std::vector<float> &v)
{
    for (int i = 0, j = 1, k = 2; k < v.size(); i++, j++, k++) {
        if (v[i] == v[j] && v[i] != v[k]) {
            return v[k];
        }
        if (v[i] == v[k] && v[i] != v[j]) {
            return v[j];
        }
        if (v[j] == v[k] && v[i] != v[j]) {
            return v[i];
        }
    }
}
