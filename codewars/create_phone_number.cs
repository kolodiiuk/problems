using System.Text;

public class Kata
{
    public static string CreatePhoneNumber(int [] numbers)
    {
        var res = new StringBuilder("(");


        for (int i = 0; i <= 2; ++i)
        {
            res.Append(numbers[i]);
        }

        res.Append(") ");

        for (int i = 3; i <= 5; ++i)
        {
            res.Append(numbers[i]);
        }

        res.Append("-");

        for (int i = 6; i < numbers.Length; ++i)
        {
            res.Append(numbers[i]);
        }

        return res.ToString();
    }
}
