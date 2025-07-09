class Solution {
public:
    int countPrimeSetBits(int left, int right) {
        int count = 0;
        while (left != right + 1) {
            int set = 0, n = left;
            while (n != 0) {
                if (n & 1) {
                    set++;
                }
                n >>= 1;
            }
            if (isPrime(set)) {
                count++;;
            }
            left++;
        }

        return count;
    }

    bool isPrime(int n) {
        if (n <= 1) {
            return false;
        }
        if (n == 2) {
            return true;
        }
        if (n % 2 == 0) {
            return false;
        }
        for (int i = 3; i * i <= n; i += 2) {
            if (n % i == 0) {
                return false;
            }
        }
        
        return true;
    }
};
