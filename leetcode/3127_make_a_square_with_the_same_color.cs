public class Solution {
    public bool CanMakeSquare(char[][] grid) {
        var ul = grid[0][0] + grid[0][1] + grid[1][0] + grid[1][1];
        var ur = grid[0][1] + grid[0][2] + grid[1][1] + grid[1][2];
        var ll = grid[1][0] + grid[1][1] + grid[2][0] + grid[2][1];
        var lr = grid[1][1] + grid[1][2] + grid[2][1] + grid[2][2];

        return IsDoable(ul) || IsDoable(ur) || IsDoable(ll) || IsDoable(lr);

        bool IsDoable(int sum) {
            return sum switch {
                306 => false,
                _ => true
            };
        }
    }
}
