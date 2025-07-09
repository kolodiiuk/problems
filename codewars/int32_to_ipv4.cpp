#include <string>
#include <vector>

using namespace std;

std::string uint32_to_ip(uint32_t ip)
{
    int mask = 0, n = 8;
    while (n != 0) {
        mask |= 1;
        n--;
        if (n != 0) {
            mask <<= 1;
        }
    }
    vector<int> octets;
    for (int i = 0; i <= 4; i++) {
        int octet = (ip & mask) >> (i << 3);
        octets.push_back(octet);
        mask <<= 8;
    }
    std::string res;
    for (int i = 3; i >= 0; --i) {
        res += std::to_string(octets[i]);
        if (i != 0) {
            res += ".";
        }
    }

    return res;
}