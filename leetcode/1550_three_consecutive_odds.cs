public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        if (arr.Length < 3) return false;
        int n = arr.Length;
        for (int i = 0; i < n; ++i) {
            if (i + 2 < n && IsDiv3(arr[i]) && IsDiv3(arr[i + 1]) && IsDiv3(arr[i + 2])) {
                return true;
            }
        }

        for (int i = 1; i < n; ++i) {
            if (i + 2 < n && IsDiv3(arr[i]) && IsDiv3(arr[i + 1]) && IsDiv3(arr[i + 2])) {
                return true;
            }
        }

        for (int i = 2; i < n; ++i) {
            if (i + 2 < n && IsDiv3(arr[i]) && IsDiv3(arr[i + 1]) && IsDiv3(arr[i + 2])) {
                return true;
            }
        }

        return false;

        bool IsDiv3(int n) => n % 2 != 0;
    }
}
