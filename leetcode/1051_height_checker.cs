public class Solution {
    public int HeightChecker(int[] heights) {
        var arr = new int[101];
        for (int i = 0; i < heights.Length; ++i) {
            arr[heights[i]]++;
        }

        int res = 0;
        int hIndex = 0;
        int arrIndex = 0;

        while (hIndex < heights.Length && arrIndex < arr.Length) {
            if (arr[arrIndex] == 0) {
                arrIndex++;
                continue;
            }

            if (heights[hIndex] != arrIndex) {
                res++;
            }

            arr[arrIndex]--;
            hIndex++;
        }

        return res;
    }
}
