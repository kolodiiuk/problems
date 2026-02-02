public class Solution {
    public IList<string> FizzBuzz(int n) {
        var res = new string[n];
        for (int i = 1; i <= n; i++) {
            res[i - 1] = i.ToString();
        }

        for (int i = 3; i <= n; i += 3) {
            res[i - 1] = "Fizz";
        }

        for (int i = 5; i <= n; i += 5) {
            res[i - 1] = "Buzz";
        }

        for (int i = 15; i <= n; i += 15) {
            res[i - 1] = "FizzBuzz";
        }

        return res.ToList();
    }
}
