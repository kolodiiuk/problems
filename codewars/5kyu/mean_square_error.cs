public class Kata
{
  public static double Solution(int[] firstArray, int[] secondArray)
  {
      double mean = default;

      for (int i = 0; i < firstArray.Length; ++i)
      {
          mean += firstArray[i] > secondArray[i]
            ? (firstArray[i] - secondArray[i]) * (firstArray[i] - secondArray[i])
            : (secondArray[i] - firstArray[i]) * (secondArray[i] - firstArray[i]);
      }

      return mean / firstArray.Length;
  }
}
