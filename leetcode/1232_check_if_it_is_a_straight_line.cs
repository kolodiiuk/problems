public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        if (coordinates.GetLength(0) == 2) return true;

        int x1 = coordinates[0][0];
        int x2 = coordinates[1][0];
        int y1 = coordinates[0][1];
        int y2 = coordinates[1][1];

        var cond = new Func<int, int, int>((x, y) => ((y2 - y1)*(x - x1) - (x2 - x1)*(y - y1)));

        int rows = coordinates.GetLength(0);
        for (int i = 0; i < rows; ++i) {
            if (cond(coordinates[i][0], coordinates[i][1]) != 0) {
                return false;
            }
        }

        return true;
    }
}
