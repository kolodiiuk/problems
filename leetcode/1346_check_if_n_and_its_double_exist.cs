public class Solution {
    public bool CheckIfExist(int[] arr) {
        for (int i = 0; i < arr.Length; ++i) {
            if ((arr[i] | 1) == arr[i]) 
                continue;
            for (int j = 0; j < arr.Length; ++j) {
                if (arr[i] == 2 * arr[j] && i != j) {
                    return true;
                }
            }
        }

        return false;
    }
}

