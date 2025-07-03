#include <utility>
#include <string>
#include <vector>

std::pair<bool, std::vector<char>> caseSensitive(const std::string& str) {
    bool b = 1;
    std::vector<char> upperCase;
    for (const char c : str) {
        if (c >= 65 && c <= 90) {
            b = 0;
            upperCase.emplace_back(c);
        }
    }

    return { b, upperCase };
}