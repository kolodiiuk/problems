#include <iostream>
#include <string>
using namespace std;

class SolutionFindDifference {
public:
    char findTheDifference(std::string s, std::string t) {
        char result = 0;

        for (char c : s) {
            result ^= c;
        }

        for (char c : t) {
            result ^= c;
        }

        return result;
    }
};

int main() {
    SolutionFindDifference solution;

    // Test cases
    std::string s1 = "abcd";
    std::string t1 = "abcde";
    std::cout << "Test 1: '" << s1 << "' and '" << t1 << "' -> '"
        << solution.findTheDifference(s1, t1) << "'" << std::endl;

    std::string s2 = "abc";
    std::string t2 = "abcd";
    std::cout << "Test 2: '" << s2 << "' and '" << t2 << "' -> '"
        << solution.findTheDifference(s2, t2) << "'" << std::endl;

    std::string s3 = "";
    std::string t3 = "a";
    std::cout << "Test 3: '" << s3 << "' and '" << t3 << "' -> '"
        << solution.findTheDifference(s3, t3) << "'" << std::endl;

    std::string s4 = "ae";
    std::string t4 = "aea";
    std::cout << "Test 4: '" << s4 << "' and '" << t4 << "' -> '"
        << solution.findTheDifference(s4, t4) << "'" << std::endl;

    return 0;
}