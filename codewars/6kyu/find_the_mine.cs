using System;

public class Kata
{
  public static Tuple<int, int> MineLocation(int[,] field)
  {
      var rows = field.GetLength(0);
      var cols = field.GetLength(1);

      for (int i = 0; i < rows; ++i)
      {
          for (int j = 0; j < cols; ++j)
          {
              if (field[i, j] == 1)
              {
                  return new Tuple<int, int>(i, j);
              }
          }
      }

      return null;
  }
}
