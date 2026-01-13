public class Solution
{
    public int DiagonalSum(int[][] mat)
    {
        int sum = 0;
        int len = mat.GetLength(0);
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++)
            {
                if ((i == j || i + j == len - 1))
                {
                    sum += mat[i][j];
                }
            }
        }

        return sum;
    }
}
