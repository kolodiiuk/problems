#include <vector>
#include <cmath>
using namespace std;

class DigPow {
public:
    static int digPow(int n, int p);
private:
    static vector<int> parse(int n);
};

int DigPow::digPow(int n, int p) {
    vector<int> digits = parse(n);
    int sum = 0;
    for (int i = digits.size() - 1, pow = p; i >= 0; i--, pow++) {
        sum += static_cast<int>(std::pow(static_cast<double>(digits[i]), static_cast<double>(pow)));
    }

    if (sum % n == 0) {
        return sum / n;
    }

    return -1;
}

vector<int> DigPow::parse(int n) {
    vector<int> v;
    while (n != 0) {
        v.emplace_back(n % 10);
        n /= 10;
    }
    return v;
}