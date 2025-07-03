#include <string>
#include <set>

bool is_pangram(const std::string& s) {
    std::set<char> set;
    for (int i = 97; i <= 122; i++) {
        set.insert(static_cast<char>(i));
    }
  
    for (char c : s) {
        if (c >= 65 && c <= 90) {
            c += 32;
        }
        if (set.find(c) != set.end()) {
            set.erase(c);
        }
    }
    
    return set.empty();
}